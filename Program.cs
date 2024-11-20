namespace Assignment_3_2_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Assignment 3.2.4
             * Write a function that takes 4 numbers as input to calculate the total and average.
             * (Make use of params array to pass arguments and out parameters to return both total 
             * and average to main method).
             * Test Data:
             * Enter the First number: 10
             * Enter the Second number: 15
             * Enter the third number: 20
             * Enter the fourth number: 30
             */

            // params is not necessary if you use an array
            // I can store every number in a seperate variable and
            // use params to take in any amount of numbers

            const int numAmount = 4;
            double[] numbers = new double[numAmount];

            Console.WriteLine("Calculate Total and Average");
            Console.WriteLine($"\nEnter {numAmount} numbers one at a time: \n");

            for (int i = 0; i < numbers.Length; i++)
            {
                string place = "";
                switch (i)
                    {
                    case 0: place = "first"; break;
                    case 1: place = "second"; break;
                    case 2: place = "third"; break;
                    case 3: place = "fourth"; break;
                    }
                
                Console.Write($"Enter the {place} number: ");
                numbers[i] = Convert.ToDouble( Console.ReadLine() );
            }

            var (total, average) = CalculateTotalAndAverage(numbers);

            Console.WriteLine($"\nTotal: {total}\nAverage: {average}");
            Console.ReadLine();
        }

        static (double, double) CalculateTotalAndAverage(double[] Numbers_)
        {
            double total = 0;
            double average = 0;

            // Total
            foreach (double number in Numbers_)
            {
                total += number;
            }

            // Average
            average = total / Numbers_.Length;

            return (total, average);
        }
    }
}
