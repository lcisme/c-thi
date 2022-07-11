using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Pratice_Exam
{
    class Product
    {
        private List<Product> list = null;
        
        public Product()
        {
            list = new List<Product>();
        }
        public string id { get; set; }
        public string productname { get; set; }
        public string price { get; set; }

        public void addpd()
        {
            Product add = new Product();
            Console.WriteLine("Id");
            add.id = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Product Name");
            add.productname = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Price");
            add.price = Convert.ToString(Console.ReadLine());

            list.Add(add);
        }
        public void displaypd(List<Product> listpd)
        {
            Console.WriteLine("{0, -30} {1, -30} {2, -30}",
                            "Product ID", "Product Name", "Price");
            if (listpd != null && listpd.Count > 0)
            {
                foreach (Product pd in listpd)
                {
                    Console.WriteLine("{0, -30} {1, -30} {2, -30}",
                                      pd.id, pd.productname, pd.price);
                }
            }
            Console.WriteLine();
        }
        public List<Product> getProduct()
        {
            return list;
        }

        public bool deletepd()
        {
            Console.WriteLine("Id");
        }
    }
}
