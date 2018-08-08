using System;

namespace Test
{
    public class PepsiMax
    {
        //Measurements of liquids
        public int Millilitre;
        protected int Litres;
        //Ingredients
        protected double Salt, Protein, Fat;

        public double GetIngredients(double salt, double protein, double fat)
        {
            Salt = salt;
            Protein = protein;
            Fat = fat;
            return salt+protein+fat;
        }

        public int GetSize(int ml, int litres)
        {
            Litres = litres;
            ml = Millilitre;
            Millilitre = 330;
            if (Millilitre == 1000)
            {
                Millilitre = Litres;
                Litres++;
            }
            return Millilitre + litres;
        }
    }

    public class DietPepsi : PepsiMax
    {

    }

    public class MainClass
    {
        static void Main(string[] forwards)
        {
            PepsiMax test = new PepsiMax();

        }
    }
}