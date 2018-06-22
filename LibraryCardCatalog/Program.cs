using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace LibraryCardCatalog
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello. Please enter a file name.");

            string fileName = Console.ReadLine();

            File.Create(c:\LibraryCatalog\fileName.txt);

            //Books b1 = new Books("Dictionary", "Oxford", "Education", "0001");

            List<Books> booksList = new List<Books>(); // create list to store books in

            CardCatalog cc = new CardCatalog();
            cc.CardCatalogMethod();

        }
    }
}