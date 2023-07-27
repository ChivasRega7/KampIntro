using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{   
    //snippet
    class Product //Entity
    {
        public int Id { get; set; }
        
        public int CategoryId { get; set; }
        //Ürün Adı
        public string ProductName { get; set; }
        //Adet Fiyatı
        public double UnitPrice { get; set; }
        //Stok Adedi
        public int UnitsInStock { get; set; }

     // INFO --> CRUD (Create,Read,Update,Delete)
    }
}
