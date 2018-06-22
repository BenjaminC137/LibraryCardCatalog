using System;
using System.Collections.Generic;
using System.Xml.Serialization;

//serialization instructions: https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/serialization/how-to-write-object-data-to-an-xml-file

namespace LibraryCardCatalog
{
    public class CardCatalog
    {
        List<Books> booksList = new List<Books>();

        public void CardCatalogMethod()
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
          

            foreach (var book in booksList)
            {
                Console.WriteLine(book.Title);
            }

        }

        private string _filename;
    }
}