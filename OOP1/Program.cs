﻿using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product(); //101
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "Table";
            product1.UnitPrice = 500;
            product1.UnitsInStock = 3;

            Product product2 = new Product {Id = 2, CategoryId = 5, 
                UnitsInStock = 5, ProductName = "Pencil", UnitPrice = 35};

            //PascalCase   //camelCase
            //case sensitive
            ProductManager productManager = new ProductManager();
            productManager.Add(product1);
            productManager.Add(product2);
            



            //int,double,bool... değer tip
            //diziler,class, abstract class, interface ... referans tip
            //ref out
        }
    }
}