﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _300845885_L2
{
    /**
     * This class is the "driver" class for our Program
     * 
     * @class Program
     */
    public class Program
    {
        /**
         * the main method for our driver class Program
         * 
         * @method Main
         * @param {sting[]} args
         * @returns {void}
         */
        public static void Main(string[] args)
        {
            Deck deck = new Deck(); // creates a new set of deck
            deck.Display();
            deck.ShuffleDeck();
            deck.Display();
            Card cardDelt = deck.Deal();
            Console.WriteLine("Card Delt :{0} of {1}", cardDelt.Face, cardDelt.Suit);
            Console.WriteLine();
            deck.Deal();

        }

    }

}

