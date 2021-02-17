using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class Product
    {
        internal string productName;

        public int Id { get; set; }//ıd si

        public int CategoryId { get; set; }//hangi kategoriye dahil
        public string ProductName { get; set; }//ürün ismi
        public double UnitPrice { get; set; }//ürünün birim fiyatı
        public int UnitsInStock { get; set; }//ürünün stok adedi

    }
}
