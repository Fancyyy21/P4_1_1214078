using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_1_1214078
{
    internal class ProductTest_1214078
    {
        static void Main(string[] args)
        {
            /*Product_1214078 myProduct = new Product_1214078();

            myProduct.MyType = "DVD";

            Console.WriteLine(myProduct.MyType);*/

            Book_1214078 product1 = new Book_1214078("Book", "C# Object Oriented Solution", "300");

            DVD_1214078 product2 = new DVD_1214078("She's Hulk", "110");

            Console.WriteLine("Ini dari Class Book");  
            Console.WriteLine("Product 1 is a {0} called \"{1}\" and has {2} pages", product1.MyType, product1.MyTitle, product1.PageCount);

            Console.WriteLine("");

            Console.WriteLine("Ini dari Clas DVD!!!");
            Console.WriteLine("Product 2 is a {0} called \"{1}\" and has {2} minutes duration", product2.MyType, product2.MyTitle, product2.Duration);

            Console.ReadKey();

            /*Book_1214078 product1 = new Book_1214078("Book", "C# Object Oriented Solution", "300");

            Console.WriteLine("\" the book {0} has {1} pages\"", myBook.MyTitle, myBook.PageCount);
            Console.WriteLine("");

            DVD_1214078 product2 = new DVD_1214078("DVD", "C# Object Oriented Solution", "300");
            Console.WriteLine("\" the DVD {0} has {1} pages\"", product2.MyTitle, product2.Duration);*/


            //BELAJAR INHERITANCE, PROPERTY, COSTRUCTOR, METHOD, DLL
        }
    }
}
