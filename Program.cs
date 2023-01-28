namespace BasicCoreProgram
{
    class program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to basic core program");
            Console.WriteLine("Enter the any character");
            char ch = Convert.ToChar(Console.ReadLine());
            if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u' || ch == 'A' || ch == 'E' || ch == 'I' || ch == 'O' || ch == 'U')
            {
                Console.WriteLine(ch + "is vowel");
            }
            else
            {
                Console.WriteLine(ch + "is consonant ");
            }
        }
    }
    
    
}
