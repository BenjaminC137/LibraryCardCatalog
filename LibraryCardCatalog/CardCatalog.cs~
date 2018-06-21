using System;
using System.Xml.Serialization;

//serialization instructions: https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/serialization/how-to-write-object-data-to-an-xml-file

namespace LibraryCardCatalog
{
    public class CardCatalog
    {
        public CardCatalog()
        {
            bool exit = false;
            while (exit == false)
            {
                string selectionPrompt = "Type '1' to list all books." +
                Environment.NewLine + "Type '2' to add a book." +
                Environment.NewLine + "Type '3' to save and exit.";
                
                Console.WriteLine(selectionPrompt);
                string userSelection = Console.ReadLine();

                if (userSelection == "3")
                {
                    exit = true;
                    Console.WriteLine("exiting program...");
                    Console.ReadLine();
                }
                if (userSelection == "1")
                {
                    Console.WriteLine("");

                    {
                        if(userSelection == "2"){
                            Console.WriteLine("Enter Book ISBN");
                            string isbnEntry = Console.ReadLine();

                            Console.WriteLine("Enter Title");
                            string titleEntry = Console.ReadLine();

                            Console.WriteLine("Enter Author");
                            string authorEntry = Console.ReadLine();

                            Console.WriteLine("Enter Genre");
                            string genreEntry = Console.ReadLine();


                        }

                    }
                }
            }
        }
