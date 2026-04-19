using System;
namespace Switch_Statment{
    class program
    {
        static void Main(String[] args)
        {
        string orderStatus = "Shipped";

        string customerMessage = orderStatus switch
        {
            "Received" => "Your order has been received.",
            "Processing" => "We are currently packing your items",
            "Shipped" => "The package has been handed over to the carrier.",
            "Delivered" => "The package was delivered successfuly",
            _ => "Unknow status. Please contact our support team."
        };

        Console.WriteLine($"Customer Info: {customerMessage}");
        }
    }
}