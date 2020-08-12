using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualTill
{
    class Till
    {
        private CashDeck _cashDeck; //each till needs it's own cashdeck.
        private string _id; //each till needs a name.


        public Till(string name, int hundreds, int fifties, int twenties, int tens, int fives)
        {
            _id = name;
            _cashDeck = new CashDeck(hundreds, fifties, tens, tens, fifties);
        }


        public int processTransaction()
        {
            return 0;
        }

        public int countTill()
        {
            return _cashDeck.count();
        }
    }
}

