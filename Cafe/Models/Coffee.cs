using System;

namespace Cafe.Models
{
    public class Coffee
    {
        private static double _Price = 5;
        private double _Discount;
        public int Quantity { get; set; }

        public static double Price
        {
            get { return _Price; }
            set { _Price = value; }
        }

        public Coffee(int quantity)
        {
            _Price = Price;
            _Discount = 0.5;
            Quantity = quantity;
        }

        public double CoffeeCost()
        {
            double coffeeTotal = 0;
            for (int index = 0; index <= Quantity; index++)
            {
                if (index == 0)
                {
                    coffeeTotal += 0;
                } 
                else if (index % 3 == 0) 
                {
                    coffeeTotal += _Price * _Discount;
                }
                else 
                {
                    coffeeTotal += _Price;
                }
            }
            return coffeeTotal;
        }
    }
}