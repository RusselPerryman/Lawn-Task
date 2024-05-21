using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperMarket
{
    class Program
    {
        static void Main(string[] args)
        {
            SuperMarket Tesco = new SuperMarket();
            Console.WriteLine("--------------------Tesco--------------------");
            //Add Employees
            Tesco.AddEmployee(new Employee("Jimmy", 1001));
            Tesco.AddEmployee(new Employee("Jeff", 1002));
            Tesco.AddEmployee(new Employee("Kelly", 1003));

            //Adding Products
            Product milk = (new Product("Milk", 1.99));
            Tesco.AddProduct(new Product("Bread", 1.25));
            Tesco.AddProduct(new Product("Cheese", 3.49));
            Product chocolate = (new Product("Chocolate", 4.99));

            Tesco.AddProduct(milk);
            Tesco.AddProduct(chocolate);

            //Transaction
            Transaction transaction1 = new Transaction(1001);
            transaction1.AddProduct(milk);
            transaction1.AddProduct(chocolate);
            Tesco.AddTransaction(transaction1);

            Transaction transaction2 = new Transaction(1002);
            transaction2.AddProduct(new Product("Cheese", 3.49));
            transaction2.AddProduct(new Product("Bread", 1.25));
            Tesco.AddTransaction(transaction2);

            Tesco.Print();

            SuperMarket Asda = new SuperMarket();
            Console.WriteLine("--------------------Asda--------------------");
            //Add Employees
            Asda.AddEmployee(new Employee("Jerry", 1001));
            Asda.AddEmployee(new Employee("Tom", 1002));
            Asda.AddEmployee(new Employee("Spike", 1003));

            Asda.AddProduct(new Product("Bread", 1.25));
            Asda.AddProduct(new Product("Cheese", 3.49));
            Product water = new Product("Water", 6.99);
            Product koppaburg = new Product("Koppaburg", 16.99);

            Transaction transaction3 = new Transaction(1003);
            transaction3.AddProduct(water);
            transaction3.AddProduct(chocolate);
            Asda.AddTransaction(transaction3);
            Asda.Print();
        }
    }
}
