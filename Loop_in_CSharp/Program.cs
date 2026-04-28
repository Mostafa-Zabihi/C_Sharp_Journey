using System;
using System.Security.Cryptography.X509Certificates;
namespace Loop_in_CSharp
{
    public class Car
    {
        public string[] BrandList = {"BMW", "Porsche", "Toyota", "Honda"};
    }

  public class Program
    {
          public static void Main(String[] args)
        {
           Car myCars = new Car();
           foreach(string i in myCars.BrandList)
            {
                Console.WriteLine(i);
            }
        }
    }
}