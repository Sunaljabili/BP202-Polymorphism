using System;
using Models;

namespace ProductApp
{
    class Program
    {
        static void Main(string[] args)
        {

            Book book = new Book();
            book.Name = "Qaranliq";
            book.Author = "Hikmet";
            book.Genre = "Elmi";
            book.Price = 19.90;


            Book book2 = new Book();
            book2.Name = "1994";
            book2.Author = "Zakir";
            book2.Genre = "Fantastic";
            book2.Price = 29.90;


            Library library = new Library();
            library.AddProduct(book);
            library.AddProduct(book2);
            //foreach (var item in library.GetProductByName("Qaranliq"))
            //{
            //     item.GetInfo();
            //}
            foreach (var item in library.GetProductsByPrice(20, 50))
            {
                item.GetInfo();
            }


            //book.GetInfo();
        }
    }
}
