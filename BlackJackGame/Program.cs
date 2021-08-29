using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackGame
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Game> games = new List<Game>();
            TwentyOneGame game = new TwentyOneGame();
            games.Add(game);
            
            Deck deck = new Deck();
            deck.Shuffle(3);

            foreach (Card card in deck.Cards)
            {
                Console.WriteLine(card.Face + " of " + card.Suit);
            }
            Console.WriteLine(deck.Cards.Count);
            Console.ReadLine();
        }

        

    //    public static Deck Shuffle(Deck deck, int times)
    //    {
    //        for (int i =0; i < times; i++)
    //        {
    //            deck = Shuffle(deck);
    //        }
    //        return deck;
       }
    }

