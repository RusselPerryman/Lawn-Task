using System;

namespace Application
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input customer information
            Console.WriteLine("Enter customer's name: ");
            string customerName = Console.ReadLine();
            Console.WriteLine("Enter customer's address: ");
            string customerAddress = Console.ReadLine();
            Console.WriteLine("Enter customer's phone number: ");
            string customerPhoneNumber = Console.ReadLine();

            //Input the lawn details
            Console.WriteLine("Enter the width of the lawn (In Meters): ");
            double lawnWidth = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the length of the lawn (In Meters): ");
            double lawnLength = Convert.ToDouble(Console.ReadLine());

            //Input lawn care product details
            Console.WriteLine("Enter the quality of the lawn care product (Economy, Standard, Luxury):\n");
            string lawnCareQuality = Console.ReadLine();
            //Calculate the total area
            double totalArea = lawnWidth * lawnLength;
            //Calculate the cost of labour
            double labourCost = 0.50 * totalArea;
            //Cost of lawn calculation if requested
            double lawnCareCost = 0.0;
            if (!string.IsNullOrEmpty(lawnCareQuality))
            {
                switch (lawnCareQuality)
                {
                    case "Economy":
                        lawnCareCost = 0.45 * totalArea;
                        break;
                    case "Standard":
                        lawnCareCost = 0.45 * totalArea;
                        break;
                    case "Luxury":
                        lawnCareCost = 0.45 * totalArea;
                        break;
                }
            }
            //Calculate the cost excluding VAT
            double totalCostExcludingVAT = labourCost + lawnCareCost;
            //Calculate VAT
            double vatCost = 0.20 * totalCostExcludingVAT;
            //Calculate total cost including VAT
            double totalCostIncludingVAT = totalCostExcludingVAT + vatCost;

            //Output customer details and their bill
            Console.WriteLine("\nCustomer Details:");
            Console.WriteLine($"Name: {customerName}");
            Console.WriteLine($"Address: {customerAddress}");
            Console.WriteLine($"Phone Number: {customerPhoneNumber}");
            Console.WriteLine("\nYour Bill:");
            Console.WriteLine($"Total Area of the Lawn: {totalArea:F2} Meters Squared");
            Console.WriteLine($"Cost of Labour: £{labourCost:F2}");
            Console.WriteLine($"Cost of Lawn Care: £{lawnCareCost:F2}");
            Console.WriteLine($"Total Cost (Excluding VAT): £{totalCostExcludingVAT:F2}");
            Console.WriteLine($"VAT (20%): £{vatCost:F2} square meters");
            Console.WriteLine($"Total Cost (Including VAT): £{totalCostIncludingVAT:F2}");
        }
    }
}