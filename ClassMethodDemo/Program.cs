using System;

namespace ClassMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.Id = 12;
            customer1.Name = "Engin";
            customer1.Surname = "Demir";
            customer1.IsRetired = false;

            Customer customer2 = new Customer();
            customer2.Id = 21;
            customer2.Name = "Berkay";
            customer2.Surname = "Bilgin";
            customer2.IsRetired = false;

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Add(customer2);
            customer1.Surname = "Demiroğ";
            customerManager.Update(customer1);
            customerManager.Delete(customer2);



          
            
        }
    }
}
