using System;
using System.Globalization;
using System.Net.Sockets;
namespace program
{
    class Two_D_Array
    {
        public static void Main(String[] args)
        {
            int[,] table = {{3, 23, 34, 342, 34},{99,24,532,634,3}};
            foreach(double num in table)
            {
                Console.WriteLine(num);
            }
            
        }

        
    }    
}
