using System;
namespace Substring
{
    class Substring
    {
        public static void Main(String[] args)
        {
            string name = "Daniel Zacharin";
            int charPos = name.IndexOf("Z");
            string lastname = name.Substring(charPos);

            Console.WriteLine(lastname);
        }
    }
}