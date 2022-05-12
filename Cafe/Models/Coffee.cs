namespace Cafe.Models
{
    public class Coffee
    {
        public double Price;
        public double Discount;
        public int Quantity;

        public Coffee(int quantity)
        {
            Price = 5;
            Discount = 0.5;
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
                    coffeeTotal += Price * Discount;
                }
                else 
                {
                    coffeeTotal += Price;
                }
            }
            return coffeeTotal;
        }
    }
}