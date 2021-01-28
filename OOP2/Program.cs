using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Behzat Amir
            Individual customer1 = new Individual();
            customer1.Id = 06;
            customer1.CustomerId = "12345";
            customer1.FirstName = "Behzat";
            customer1.LastName = "Amir";
            customer1.TcNo = "15478518565";

            //Ercüment Çözer Ltd.Şti
            Corporate customer2 = new Corporate();
            customer2.Id = 34;
            customer2.CustomerId = "54321";
            customer2.TaxNumber = "1234567890";
            customer2.CompanyName = "Ercüment Çözer Ltd.Şti";

            Customer customer3 = new Individual();//Customer   Indıvudal ve Corporate'ın ref. no'sunu tutabilmekte.
            Customer customer4 = new Corporate();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Add(customer2);
            customerManager.Add(customer3);
            customerManager.Add(customer4);


        }
    }
}
