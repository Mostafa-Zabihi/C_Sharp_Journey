using System;
namespace arrayInCSharp
{
    class Program
    {
        public static void Main(String[] args)
        {
            string[] client = {"Daniel", "Musti", "Jashva", "Jamal", "Momo"};
            Array.Sort(client);
            foreach(string name in client)
            {
                Console.WriteLine(name);
            }
        }
    }
}