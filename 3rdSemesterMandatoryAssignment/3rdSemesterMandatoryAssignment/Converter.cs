using System;
using System.Collections.Generic;
using System.Text;

namespace ModelLibrary
{
    public class Converter
    {
        public Converter()
        {

        }
        public double ConvertToOunces(Gram G)
        {
            return G.Amount * 0.0352739619;
        }

        public double ConvertToGram(Ounces O)
        {
            return O.Amount * 28.3495231;
        }
    }
}
