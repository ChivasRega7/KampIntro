using System;

namespace OOP1
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "Masa"; //Gerçekte Kullanıcı verisi almak için => product1.ProductName = tbxProductName.Text
            product1.UnitPrice = 500;
            product1.UnitsInStock = 3;

            Product product2 = new Product { Id = 2, CategoryId = 5, UnitsInStock = 5, ProductName = "Kalem", UnitPrice = 35 };
            
           //PascalCase    //camelCase
           //case sensitive
            ProductManager productManager = new ProductManager();
            productManager.Add(product1);
            Console.WriteLine("Id : " + product1.Id + " \nCategory Id : " + product1.CategoryId + " \nProduct Name : " + product1.ProductName + "\nPrice : " + product1.UnitPrice + "\nStock : " + product1.UnitsInStock);

            int sayi = 100;
            productManager.BiseyYap(sayi);
            Console.WriteLine(sayi);
            //=100 ->It doesn't change because we are giving 


            //int,double,bool ... değer tip
            //arrays , class , abstract calass , Interface... referans tip
        }
    }
}