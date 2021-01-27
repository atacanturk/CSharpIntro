using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMethodDemo
{
    class CustomerManager
    {
        public void Add(Customer customer)
        {
            Console.WriteLine(customer.Name+" "+customer.Surname+" added.");
        }
        public void Update(Customer customer)
        {
            Console.WriteLine(customer.Name + " " + customer.Surname + " who have "+customer.Id+" ID Number is updated.");
        }
        public void Delete(Customer customer)
        {
            Console.WriteLine(customer.Name + " " + customer.Surname + " deleted.");
        }
    }
}
