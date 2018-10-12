using System;

namespace WeightConvertLibrary
{
    public static class WeightConverter
    {
         
        private const double measureConstant = 28.349523125; 

        public static double OzToGrams(double oz)
        {
            return oz * measureConstant;
        }

        public static double GramsToOz(double grams)
        {
            return grams / measureConstant;
        }
        
    }
}
