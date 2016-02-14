using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CardLib10;

namespace CardLibClient
{
    class Game
    {
        private int currentCard;
        private Deck playDeck;
        private Player[] players;
        private Cards discardedCards;

        public Game()
        {
            currentCard = 0;
            playDeck = new Deck(true);
            playDeck.LastCardDrawn += new LastCardDrawnHandler(Reshuffle);
            playDeck.Shuffle();
            discardedCards = new Cards();
        }

        public void Reshuffle(Deck currentDeck)
        {
            Console.WriteLine("Отброшеные карты перетасованы и переданы в колоду.");
            currentDeck.Shuffle();
            discardedCards.Clear();
            currentCard = 0;
        }

        public void SetPlayers(Player[] newPlayers)
        {
            if (newPlayers.Length > 7)
                throw new ArgumentException("В эту игру могут играть не более 7 человек!");
            if (newPlayers.Length < 2)
                throw new ArgumentException("В эту игру могут играть не менее 2 человек!");
            players = newPlayers;
        }

        public void DealHands()
        {
            for(int p = 0; p < players.Length; p++)
            {
                for(int c = 0; c < 7; c++)
                {
                    players[p].PlayHand.Add(playDeck.GetCard(currentCard++));
                }
            }
        }

        public int PlayGame()
        {
            // проводить игру только если есть игроки
            if (players == null)
                return -1;

            //выполнение раздач карт на руки игрокам
            DealHands();

            /*инициализация причастных к игре переменных вместе с переменной представляющую первую карту,
            которая должна выкладываться на стол,то есть с переменной playCard
            */

            bool GameWon = false;
            int currentPlayer;
            Card playCard = playDeck.GetCard(currentCard++);
            discardedCards.Add(playCard);

            // главный цикл игры,который должен выполняться до тех пор, пока не будет соблюдено условие GameWon == true

            do
            {
                //проход по игракам в каждом раунде игры
                for(currentPlayer = 0; currentPlayer < players.Length; currentPlayer++)
                {
                    Console.WriteLine("{0} ходит.", players[currentPlayer].Name);
                    Console.WriteLine("Текущие карты: ");
                    foreach(Card card in players[currentPlayer].PlayHand)
                    {
                        Console.WriteLine(card);
                    }
                    Console.WriteLine("Карта в игре: {0}", playCard);

                    //приглашение игроку взять карту или вытащить новую
                    bool inputOk = false;
                    do
                    {
                        Console.WriteLine("Нажмите T, чтобы взять разыгранную карту, или D, чтобы взять новую:");
                        string input = Console.ReadLine();
                        if(input.ToLower() == "t")
                        {
                            //добавление карты со стола на руки пользователя
                            Console.WriteLine("Вытащена карта {0}.", playCard);

                            if (discardedCards.Contains(playCard))
                            {
                                discardedCards.Remove(playCard);
                            }
                            players[currentCard].PlayHand.Add(playCard);
                        }
                        if(input.ToLower() == "d")
                        {
                            //добавление новой карты на руки пользователя из колоды
                            Card newCard;

                            bool cardIsAvailable;
                            do
                            {
                                newCard = playDeck.GetCard(currentCard++);
                                cardIsAvailable = !discardedCards.Contains(newCard);
                                if (cardIsAvailable)
                                {
                                    foreach(Player testPlayer in players)
                                    {
                                        if (testPlayer.PlayHand.Contains(newCard))
                                        {
                                            cardIsAvailable = false;
                                            break;
                                        }
                                    }
                                }

                            } while (cardIsAvailable);

                            //выдача вытащенной карты на руки игроку
                            Console.WriteLine("Вытащена карта {0}", newCard);
                            players[currentPlayer].PlayHand.Add(newCard);
                            inputOk = true;

                        }
                         
                    } while (inputOk == false);

                    //Отображение новой раскладки на руках игрока с нумерацией карт
                    Console.WriteLine("Новые карты: ");
                    for(int i = 0; i < players[currentPlayer].PlayHand.Count; i++)
                    {
                        Console.WriteLine("{0} : {1}", i + 1, players[currentPlayer].PlayHand[i]);
                    }

                    //Предложение игроку отбросить какую-нибудь карту
                    inputOk = false;
                    int choice = -1;
                    do
                    {
                        Console.WriteLine("Выберете карту для отбрасывания!");
                        string input = Console.ReadLine();
                        try
                        {
                            choice = Convert.ToInt32(input);
                            if ((choice > 0) && (choice <= 8))
                                inputOk = true;
                        }
                        catch
                        {

                        }

                    } while (inputOk == false);

                    playCard = players[currentPlayer].PlayHand[choice - 1];
                    players[currentPlayer].PlayHand.RemoveAt(choice - 1);
                    discardedCards.Add(playCard);
                    Console.WriteLine("Отбрасывание карты {0}.", playCard);
                    Console.WriteLine();

                    //проверка выиграл ли игрок
                    GameWon = players[currentPlayer].HasWon();
                    if (GameWon == true)
                        break;
                }

            } while (GameWon == false);

            //завершение игры с указанием выигрывшего игрока
            return currentPlayer;
        }
    }
}
