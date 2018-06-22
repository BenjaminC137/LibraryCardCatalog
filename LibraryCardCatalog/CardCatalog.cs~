using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.IO;

//serialization instructions: https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/serialization/how-to-write-object-data-to-an-xml-file

namespace LibraryCardCatalog
{
    public class CardCatalog
    {
        List<Books> booksList = new List<Books>();

        private string pathString = "";

        public void CardCatalogMethod()
        {

            Console.WriteLine("Hello. Please enter a file name.");

            string fileName = Console.ReadLine();
            fileName += ".xml";

            //https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/file-system/how-to-create-a-file-or-folder

            //String path = String.Format(@"c:\LibraryCatalog\{0}.xml", fileName);
            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            Directory.CreateDirectory(path);
            //string fullName = Path.GetFileName(fileName);

            pathString = Path.Combine(path, fileName);

            if (!File.Exists(pathString))
            {
                FileStream stream = File.Create(pathString);  //create file   
                stream.Close();
                stream.Dispose();
            }
            else
            {
                Console.WriteLine("Filename: {0} already exists.", pathString);
                Console.ReadLine();
            }

            Console.WriteLine("Path to my file: {0}\n", pathString);
            Console.ReadLine();


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

        public void AddBook()
        {
            Console.WriteLine("Enter Book ISBN");
            string isbnEntry = Console.ReadLine();

            Console.WriteLine("Enter Title");
            string titleEntry = Console.ReadLine();

            Console.WriteLine("Enter Author");
            string authorEntry = Console.ReadLine();

            Console.WriteLine("Enter Genre");
            string genreEntry = Console.ReadLine();


            Books catalog = new Books
            {
                Title = titleEntry,
                Author = authorEntry,
                Genre = genreEntry,
                ISBN = isbnEntry
            };
            XmlSerializer writer =
            new XmlSerializer(typeof(Books));
            
            //var path = Program.p
            FileStream fileStream = File.Open(this.pathString, FileMode.OpenOrCreate);

            writer.Serialize(fileStream, catalog);
            fileStream.Close();
            fileStream.Dispose();

        }

        public static void WriteXML()
        {


        }

        //booksList.Add(new Books(titleEntry, authorEntry, genreEntry, isbnEntry));




        //foreach (var book in booksList)
        //{
        //    Console.WriteLine(book.Title);
        //}




        //private string _filename;
    }
}