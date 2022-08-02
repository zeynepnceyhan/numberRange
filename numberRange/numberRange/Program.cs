namespace methods
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int number1;
            Console.WriteLine("Please enter a number: ");
            number1 = Convert.ToInt32(Console.ReadLine());


            if (number1 <= 100 && number1 >= 0)
            {
                Console.WriteLine("NUMBER IS IN THE RANGE 0-100...");
            }

            else if (number1 < 0)
            {
                Console.WriteLine("NUMBER IS LESS THAN 0, NOT INCLUDED IN THE RANGE...");
            }
            else
            {
                Console.WriteLine("NUMBER IS GREATER THAN 100, NOT INCLUDED IN THE RANGE...");
            }

        }

    }

}