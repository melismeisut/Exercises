namespace Vending_Machine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool started = true;
            bool finished = false;
            double totalSum = 0;
            double change = 0;

            while (started)
            {
                string input = Console.ReadLine();

                if (input == "Start")
                {
                    started = false;
                    finished = true;
                    break;
                }
                if (input == "0.1" || input == "0.2" || input == "0.5" || input == "1" || input == "2")
                {
                    double money = Convert.ToDouble(input);
                    totalSum += money;
                }
                else
                {
                    Console.WriteLine($"Cannot accept {input}");
                }
            }
            while (finished)
            {
                string product = Console.ReadLine();
                if (product == "End")
                {

                    finished = false;
                }
                else if (product == "Nuts")
                {
                    if (totalSum >= 2)
                    {
                        change = totalSum - 2;
                        Console.WriteLine("Product purchased");
                    }
                    else
                    {
                        Console.WriteLine("Not enough money");
                    }
                }
                else if (product == "Water")
                {
                    if (totalSum >= 0.7)
                    {
                        change = totalSum - 0.7;
                        Console.WriteLine("Product purchased");
                    }
                    else
                    {
                        Console.WriteLine("Not enough money");
                    }
                }
                else if (product == "Crisps")
                {
                    if (totalSum >= 1.5)
                    {
                        change = totalSum - 1.5;
                        Console.WriteLine("Product purchased");
                    }
                    else
                    {
                        Console.WriteLine("Not enough money");
                    }
                }
                else if (product == "Soda")
                {
                    if (totalSum >= 0.8)
                    {
                        change = totalSum - 0.8;
                        Console.WriteLine("Product purchased");
                    }
                    else
                    {
                        Console.WriteLine("Not enough money");
                    }
                }
                else if (product == "Coke")
                {
                    if (totalSum >= 1)
                    {
                        change = totalSum - 1;
                        Console.WriteLine("Product purchased");
                    }
                    else
                    {
                        Console.WriteLine("Not enough money");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid product");
                }


            }
            Console.WriteLine("{0:F2}", change);
        }
    }
}