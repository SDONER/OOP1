using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    //CRUD Create - Read - Update - Delete 
    //int,double,bool... değer tip
    //diziler.class,abstract class,interface .... referans tip
    class ProductManager
    {
        public void Add(Product product)
        {
            Console.WriteLine(product.ProductName + "Eklendi.");
        }

        public void Update(Product product)
        {
          Console.WriteLine(product.ProductName+ "Güncellendi."); 
        }

    
    }  
}
