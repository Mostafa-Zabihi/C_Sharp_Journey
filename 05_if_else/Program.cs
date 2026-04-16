using System;
using System.Security.Cryptography;
using System.Threading.Tasks.Dataflow;
namespace _05_if_else;
class Program
{
    public static void Main(String[] args)
    {
        int age = 18;
        int grade = 2;

        string result = (age >= 18) ? "The user is 18 years old and legally an adult." 
                                        : "The user is under 18 and therefore a minor";
        String grades = (grade == 1) ? "Excellent grade!":
                        (grade == 2) ? "Good grade":
                        (grade == 3) ? "The gradee is sufficient.":
                        "Invalid Grade";

        Console.WriteLine(result + "\n" + grades);
    }
}