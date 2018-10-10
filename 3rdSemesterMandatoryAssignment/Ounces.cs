using System;
using System.Collections.Generic;
using System.Text;

namespace ModelLibrary
{
    public class Ounces
    {
        private double _amount;

        public double Amount
        {
            get { return _amount; }
            set { _amount = value; }
        }
        public Ounces()
        {
        }

        public Ounces(double amount)
        {
            _amount = amount;
        }
        //Create a superClass for the following methods
        public double plus(Ounces ounces, double amount)
        {
            ounces.Amount = ounces.Amount + amount;
            return ounces.Amount;
        }

        public double minus(Ounces ounces, double amount)
        {
            ounces.Amount = ounces.Amount - amount;
            return ounces.Amount;
        }


        public double convertToGram(Ounces O)
        {
            return O.Amount * 28.3495231;
        }
    }
}
