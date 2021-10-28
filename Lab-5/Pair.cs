using System;
using System.Collections.Generic;
using System.Text;

namespace PairNumber
{
    class Pair
    {
        public Pair(int initFirst, int initSecond)
        {
            _first = initFirst;
            _second = initSecond;
        }

        public double _first;
        public double _second;

        public double First
        {
            get
            {
                return _first;
            }
            set
            {
                _first = value;
            }
        }
        public double Second
        {
            get
            {
                return _second;
            }
            set
            {
                _second = value;
            }
        }
        public bool Compare(Pair value)
        {
            if (First > value.First || (First == value.First && Second > value.Second)) return true;
            else return false;
        }
        public bool Compare(int firstNumber, int secondNumber)
        {
            if (First > firstNumber || (First == firstNumber && Second > secondNumber)) return true;
            else return false;
        }
    }
}
