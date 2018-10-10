using System;
using System.Collections.Generic;
using System.Text;

namespace ModelLibrary
{
    public class Gram
    {
        private double _amount;

        public double Amount
        {
            get { return _amount; }
            set { _amount = value; }
        }
        public Gram()
        {
        }

        public Gram(double amount)
        {
            _amount = amount;
        }

        //Create a superClass for the following methods
        public double plus(Gram gram, double amount)
        {
            gram.Amount = gram.Amount + amount;
            return gram.Amount;
        }

        public double minus(Gram gram, double amount)
        {
            gram.Amount = gram.Amount - amount;
            return gram.Amount;
        }

        public double convertToOunces(Gram G)
        {
            return G.Amount * 0.0352739619;
        }
    }
}
