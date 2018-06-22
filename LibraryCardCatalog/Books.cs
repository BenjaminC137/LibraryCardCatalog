using System;
using System.Xml.Serialization;

namespace LibraryCardCatalog
{
    public class Books
    {
            public string Title { get; set; }
            public string Author { get; set; }
            public string Genre { get; set; }
            public string ISBN { get; set; }
    }
}