using System;

namespace ExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dt = new DateTime(2020, 5, 16, 4, 40, 59);
            Console.WriteLine(dt.ElapsedTime());

            Console.WriteLine();
            string s1 = "Bom dia queridos estudantes!";
            Console.WriteLine(s1.Cut(10));
        }
    }
}
