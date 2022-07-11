using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Pratice_Exam
{
    public class Mainn
    {
        public static void Main(string[] args)
        {
            Product pd = new Product();
            while (true)
            {
            Console.WriteLine("\nChoose the function you want");
            Console.WriteLine("1. Add product records");
            Console.WriteLine("2. Display product records");
            Console.WriteLine("3. Delete product by Id");
            Console.WriteLine("4. Exit");
            int x = Convert.ToInt32(Console.ReadLine());    
                switch (x)
                {
                    case 1:
                        {
                            Console.WriteLine("Add product records");
                            pd.addpd();
                            Console.WriteLine("Add successfully");
                            break;
                        }
                    case 2:
                        {

                            Console.WriteLine("Display product records");
                            pd.displaypd(pd.getProduct());
                            break;
                        }
                    case 3:
                        {
                            string id;
                            Console.WriteLine("Delete product by Id");            
                            Console.Write("\nNhap ID: ");
                            id = Console.ReadLine();
                            if (pd.deletebyid(id))
                            {
                                Console.WriteLine("Delete successfully",id);
                            }
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("Exit");
                            return;
                        }
                    default:
                        break;
                }
            }
        }
    }
}
