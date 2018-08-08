using System;
using System.Collections.Generic;

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

        public virtual void SaltAmount()
        {
            double result = Salt - 1;
            Console.WriteLine(result);
        }

        public virtual void ProteinAmount()
        {
            double result = Protein - 1;
            Console.WriteLine(result);
        }

        public virtual void FatAmount()
        {
            double result = Fat - 1;
            Console.WriteLine(result);
        }
    }

    public class DietPepsi : PepsiMax
    {

        public override void SaltAmount()
        {
            double result = Salt - 2;
            Console.WriteLine(result);
        }

        public override void ProteinAmount()
        {
            double result = Protein - 2;
            Console.WriteLine(result);
        }

        public override void FatAmount()
        {
            double result = Fat - 2;
            Console.WriteLine(result);
        }
    }

    public class MainClass
    {
        static void Main(string[] forwards)
        {
            PepsiMax test = new PepsiMax();

            test.GetIngredients(5,6,7);
            Console.Write("Salt: ");
            test.SaltAmount();
            Console.Write("Protein: ");
            test.ProteinAmount();
            Console.Write("Fat: ");
            test.FatAmount();

            Console.WriteLine("----------");

            DietPepsi test2 = new DietPepsi();

            test2.GetIngredients(10, 9, 8);
            Console.Write("Salt: ");
            test2.SaltAmount();
            Console.Write("Protein: ");
            test2.ProteinAmount();
            Console.Write("Fat: ");
            test2.FatAmount();
        }
    }
}