using MusicLibrary.BL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace MusicLibrary.BL.Controller
{
    public class CatalogController
    {
        public List<Catalog>  Catalogs { get; }
        public Catalog CurrentCatalog { get; set; }
        
        public CatalogController(string catalogName)
        {
            Catalogs = GetDataFromXml();
            CurrentCatalog = Catalogs.SingleOrDefault();
            // проверка по имени каталога 

            if(CurrentCatalog == null)
            {
                // создание нового каталога 
                SaveDataInXml();
            }
        }
        private void SaveDataInXml()
        {
            XDocument xml = new XDocument(new XElement("Library",
                new XElement("catalog",
                    new XAttribute("name", $"{CurrentCatalog.CatalogName}"),
                    new XElement("author", $"{CurrentCatalog.Author}"),
                    new XElement("albom name", $"{CurrentCatalog.AlbomName}"),
                    new XElement("genre", $"{CurrentCatalog.Genre}"),
                    new XElement("country", $"{CurrentCatalog.Country}"))));
            xml.Save("library.xml");
        }
        private static List<Catalog> GetDataFromXml()
        {
           
            return new List<Catalog>();
        }
        public void SetNewCatalog(string catalogName, string author, string albomName, DateTime date, string country, DateTime releaseDate)
        {
            CurrentCatalog = new Catalog(catalogName, author, albomName, date, country, releaseDate);
            CurrentCatalog.CatalogName = catalogName;
            CurrentCatalog.Author = author;
            CurrentCatalog.AlbomName = albomName;
            CurrentCatalog.Date = date;
            CurrentCatalog.Country = country;
            CurrentCatalog.ReleaseDate = releaseDate;
        }
    }
}
