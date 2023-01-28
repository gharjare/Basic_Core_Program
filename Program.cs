namespace BasicCoreProgram
{
    class program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to basic core program");

            Console.WriteLine("Enter the proper year");
            int year = Convert.ToInt32(Console.ReadLine());
            if(year%4==0) 
            {
                Console.WriteLine("Year is leap");
            }
            else
            {
                Console.WriteLine("Not leap Year");
            }
        }
    }
    
}
