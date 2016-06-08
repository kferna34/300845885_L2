using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _300845885_L2
{
    /// <summary>
    /// This class creates an object that represents a playing  card
    /// </summary>
    /// @class card
    public class Card
    {


        //public prop +++++++++++++++++++++++++++++++++++++++++++
        public int Face { get; set; }
        public string Suit { get; set; }

        /// <summary>
        /// this constructor takes 2 param: face & suit to instantiate a card object
        /// </summary>
        /// @constructor Card
        /// @param {string} face
        /// @param{string} suit
        public Card(int face, string suit)
        {
            this.Face = face;
            this.Suit = suit;

        }

    }
}
