using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualTill
{
    class CashDeck
    {
        private int _fifties; // all cashdecks have money in them!
        private int _hundreds;
        private int _twenties;
        private int _tens;
        private int _fives;
        private int _coins; //not sure how i'll implement this. Might have coins as it's own class.?

        public CashDeck(int hundreds, int fifties, int twenties, int tens, int fives)
        {
            int _fifties = fifties;
            int _hundreds = hundreds;
            int _twenties = twenties;
            int _tens = tens;
            int _fives = fives;
        }
        public int count() //counts the money in the cashdeck and returns the exact $ amount.
        {
            return (_hundreds * 100) + (_fifties * 50) + (_twenties * 20) + (_tens * 10) + (_fives * 5);
        }
    }
}
