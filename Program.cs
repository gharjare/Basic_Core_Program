namespace BasicCoreProgram
{
    class program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to basic core program");
            int divident = 50, divisor = 8;
            int quotient = divident / divisor;
            int remainder = divident % divisor;
            Console.WriteLine("Divident : {0} Divisor : {1}", divident, divisor);
            Console.WriteLine("Quotient :" + quotient);
            Console.WriteLine("Remainder : " + remainder);

        }
    }
    
}
