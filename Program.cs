﻿namespace BasicCoreProgram
{
    class program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to basic core program");
            int a = 10, b = 20, temp;
            Console.WriteLine("Before swapping value of a={0},b={1}", a, b);
            temp = a;
            a = b;
            b = temp;
            Console.WriteLine("After the swapping value of a={0},b={1}", a, b);
        }
    }
    
    
}
