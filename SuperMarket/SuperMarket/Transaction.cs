using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperMarket
{
    public class Transaction
    {
        public int TransactionsID { get; private set; }
        public List<Product> ProductsList { get; private set; }
        public double TotalAmount { get; private set; }
        
        public Transaction(int transaction)
        {
            TransactionsID = transaction;
            ProductsList = new List<Product>();
        }
        //Workout Total Cost
        public void AddProduct(Product product)
        {
            ProductsList.Add(product);
            TotalAmount += product.Price;
        }
    }
}
