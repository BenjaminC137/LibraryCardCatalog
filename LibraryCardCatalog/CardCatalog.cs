using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.IO;
using System.Threading;

//serialization instructions: https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/serialization/how-to-write-object-data-to-an-xml-file

namespace LibraryCardCatalog
{
    public class CardCatalog
    {
        //List<Books> booksList = new List<Books>();

        private string pathString = "";
        private Books catalog = null;
        public List<Books> booksList = new List<Books>();

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
                Console.WriteLine("\nNew file created: {0}\nPress 'Return' to view options", pathString);
                Console.ReadLine();
            }
            else
            {
                LoadCatalog();
                Console.WriteLine("\nExisting file found: {0}\nPress 'Return' to view options", pathString);
                Console.ReadLine();
                //Console.WriteLine("Filename: {0} already exists.", pathString);
                //Console.ReadLine();
            }

            //Console.WriteLine("Path to my file: {0}\nPress 'Return' to view options", pathString);
            //Console.ReadLine();


            bool exit = false;
            while (exit == false)
            {
                string selectionPrompt = "Type '1' to list all books. \n" +
                    "Type '2' to add a book. \n" +
                    "Type '3' to save and exit.";

                Console.WriteLine(selectionPrompt);
                string userSelection = Console.ReadLine();

                if (userSelection == "1")
                {
                    Console.WriteLine();
                    //Console.WriteLine("Here are the books!");
                    ReadCatalog();

                    Console.WriteLine();
                    //Console.WriteLine("ISBN: {3} Title: {0}: Author: {1} Genre: {2}", catalog.Title, catalog.Author, catalog.Genre, catalog.ISBN);
                }

                if (userSelection == "2")
                {
                    Console.WriteLine();
                    AddBook();
                    Console.WriteLine();
                }

                if (userSelection == "3")
                {
                    Console.WriteLine();
                    exit = true;
                    Console.WriteLine("exiting program...");
                    Thread.Sleep(1000);
                    //Console.ReadLine();
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

            //catalog = new Books
            //{
            //    Title = titleEntry,
            //    Author = authorEntry,
            //    Genre = genreEntry,
            //    ISBN = isbnEntry
            //};
            //booksList.Add(catalog);

            //booksList.Add()

            booksList.Add(new Books(titleEntry, authorEntry, genreEntry, isbnEntry));

            //Console.WriteLine();
            //foreach (var book in booksList)
            //{
            //    Console.WriteLine("Title: {0} | Author: {1}", book.Title, book.Author);
            //}
            //Console.ReadLine();


            XmlSerializer writer =
            new XmlSerializer(typeof(List<Books>));

            FileStream fileStream = File.Open(this.pathString, FileMode.OpenOrCreate);


            writer.Serialize(fileStream, booksList);
            fileStream.Close();
            fileStream.Dispose();

        }

        public void ReadCatalog()
        {
            XmlSerializer reader = new XmlSerializer(typeof(List<Books>));
            StreamReader file = new StreamReader(pathString);
            booksList = (List<Books>)reader.Deserialize(file);

            file.Close();
            file.Dispose();

            foreach (var book in booksList)
            {
                Console.WriteLine("ISBN: {0}, Title: {1}, Author: {2}, Genre: {3}", 
                                  book.ISBN, book.Title, book.Author, book.Genre);
            }
        }

        public void LoadCatalog()
        {
            XmlSerializer reader = new XmlSerializer(typeof(List<Books>));
            StreamReader file = new StreamReader(pathString);
            booksList = (List<Books>)reader.Deserialize(file);

            file.Close();
            file.Dispose();
        }


    }
}