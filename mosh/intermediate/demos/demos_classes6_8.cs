// Intermediate - Classes Demo file - Lectures 6-8

// Customer.cs file
using System.Collections.Generic;

namespace IntermediateMosh
{
    public class Customer
    {
        // Classes

        public int Id;
        public string Name;
        public List<Order> Orders;

        // Constructors
        public Customer()
        {
            Orders = new List<Order>();
        }

        public Customer(int id)
            : this()
        {
            this.Id = id;
        }

        public Customer(int id, string name)
            : this(id)
        {
            this.Name = name;
        }
    }

}

// Program.cs file

using System;

namespace IntermediateMosh
{
    class Program
    {
        static void Main(string[] args)
        {
            var customer = new Customer();
            customer.Id = 1;
            customer.Name = "John";

            var order = new Order();
            customer.Orders.Add(order);

            Console.WriteLine(customer.Id);
            Console.WriteLine(customer.Name);
        }
    }

}