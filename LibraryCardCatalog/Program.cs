using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace LibraryCardCatalog
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello. Please enter a file name.");

            Books b1 = new Books("Dictionary", "Oxford", "Education", "0001");

            List<Books> booksList = new List<Books>();

            CardCatalogMethod();

            void CardCatalogMethod()
            {
                bool exit = false;
                while (exit == false)
                {
                    string selectionPrompt = "Type '1' to list all books." +
                    Environment.NewLine + "Type '2' to add a book." +
                    Environment.NewLine + "Type '3' to save and exit.";

                    Console.WriteLine(selectionPrompt);
                    string userSelection = Console.ReadLine();

                    if (userSelection == "1")
                    {
                        Console.WriteLine("Here are the books!");
                        //use serialization here
                    }

                    if (userSelection == "2")
                    {
                        AddBook();
                    }

                    if (userSelection == "3")
                    {
                        exit = true;
                        Console.WriteLine("exiting program...");
                        Console.ReadLine();
                    }
                }
            }

            void AddBook()
            {
                Console.WriteLine("Enter Book ISBN");
                string isbnEntry = Console.ReadLine();

                Console.WriteLine("Enter Title");
                string titleEntry = Console.ReadLine();

                Console.WriteLine("Enter Author");
                string authorEntry = Console.ReadLine();

                Console.WriteLine("Enter Genre");
                string genreEntry = Console.ReadLine();

                booksList.Add(new Books(titleEntry, authorEntry, genreEntry, isbnEntry));

                Console.WriteLine();
                foreach (var book in booksList)
                {
                    Console.WriteLine("Title: {0} | Author: {1}", book.Title, book.Author);
                }
                Console.ReadLine();
            }
            //My changes
        }
    }
}