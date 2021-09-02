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


            

            Deck deck = new Deck();



            List<Card> newList = deck.Cards.Where(x => x.Face == Face.King).ToList();
            //int count = deck.Cards.Count(x => x.Face == Face.Ace);

            //deck.Cards.
            
            //int counter = 0;
            //foreach (Card card in deck.Cards)
            //{
            //    if (card.Face == Face.Ace)
            //    {
            //        counter++;
            //    }
            //}
            //deck.Shuffle(3);

            //foreach (Card card in deck.Cards)
            //{
            //    Console.WriteLine(card.Face + " of " + card.Suit);
            //}
            //Console.WriteLine(deck.Cards.Count);
            Console.ReadLine();
        }
   
       }
    }

