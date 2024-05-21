using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperMarket
{
     public class SuperMarket
    {
        private List<Employee> Employees;
        private List<Product> Products;
        private List<Transaction> Transactions;

        public SuperMarket()
        {
            Employees = new List<Employee>();
            Products = new List<Product>();
            Transactions = new List<Transaction>();
        }
        public void AddEmployee(Employee employee)
        {
            Employees.Add(employee);
        }
        public void AddProduct(Product product)
        {
            Products.Add(product);
        }
        public void AddTransaction(Transaction transaction)
        {
            Transactions.Add(transaction);
        }

        public void Print()
        {
            Console.WriteLine("----------Employee----------");
            foreach (Employee employee in Employees)
            {
                Console.WriteLine($"Employee ID: {employee.EmployeeID}, Name: {employee.Name}");
            }
            Console.WriteLine("----------Product----------");
            foreach (Product product in Products)
            {
                Console.WriteLine($"Product: {product.Name}, Price: {product.Price}");
            }
            Console.WriteLine("----------Transaction----------");
            foreach (Transaction transaction in Transactions)
            {
                Console.WriteLine($"Transaction ID: {transaction.TransactionsID}, Total: {transaction.TotalAmount}");
            }
        }
    }
}
