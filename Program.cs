namespace BasicCoreProgram
{
    class program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to basic core program");
            double sum = 0.0;
            Console.WriteLine("\n\n");
            Console.WriteLine("Calculate the sum of harmonic series");
            Console.WriteLine("Enter the value of n");
            int num = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < num; i++)
            {
                Console.WriteLine("1/{0}+", i);
                sum += 1 / (float)i;
            }
            Console.WriteLine("\nsum of series of {0} terms: {1} \n", num, sum);


        }
    }
    
}
