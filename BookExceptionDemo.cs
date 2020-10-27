using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookExceptionProject
{
    class BookExceptionDemo
    {
        static void Main(string[] args)
        {
            //add a try catch block
            try
            {
                //create an object for Book class and set the values using properties
                Book book1 = new Book();
                book1.Title = "Goognight Moon";
                book1.Author = "Margaret Wise Brown";
                book1.Price = 12.99;
                book1.NumberOfPages = 25;
                //validate if the ratio is valid
                validateBook(book1);
            }
            //catch if any exception is raised and print the message
            catch (BookException ex)
            {
                Console.WriteLine(ex.Message);
            }
            //add a try catch block
            try
            {
                //create an object for Book class and set the values using properties
                Book book2 = new Book();
                book2.Title = "Origins of Love";
                book2.Author = "Kishwar Desai";
                book2.Price = 30.99;
                book2.NumberOfPages = 500;
                //validate if the ratio is valid
                validateBook(book2);
            }
            //catch if any exception is raised and print the message
            catch (BookException ex)
            {
                Console.WriteLine(ex.Message);
            }
            //add a try catch block
            try
            {
                //create an object for Book class and set the values using properties
                Book book3 = new Book();
                book3.Title = "Go Set a Watchman";
                book3.Author = "Harper Lee";
                book3.Price = 10.99;
                book3.NumberOfPages = 250;
                //validate if the ratio is valid
                validateBook(book3);
            }
            //catch if any exception is raised and print the message
            catch (BookException ex)
            {
                Console.WriteLine(ex.Message);
            }
            //add a try catch block
            try
            {
                //create an object for Book class and set the values using properties
                Book book4 = new Book();
                book4.Title = "The Grapes of Math";
                book4.Author = "Alex Bellos";
                book4.Price = 30.99;
                book4.NumberOfPages = 300;
                //validate if the ratio is valid
                validateBook(book4);
            }
            //catch if any exception is raised and print the message
            catch (BookException ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.Write("\nPress any key to continue. . .");
            Console.ReadKey();
        }

        //method that validates the book
        private static void validateBook(Book bookObj)
        {
            //calculate the price per page
            double pricePerPage = (bookObj.Price * 100) / bookObj.NumberOfPages;
            //throw an exception if price per page is more than 10 cents
            if (pricePerPage > 10)
                throw new BookException(bookObj.Title, bookObj.Price, bookObj.NumberOfPages);
        }
    }
}