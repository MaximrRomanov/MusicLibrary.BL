using System;


namespace MusicLibrary.BL.Model
{
    public class Catalog
    {
        public string CatalogName { get; set; }
        public string Author { get; set; }
        public string AlbomName { get; set; }
        public string Genre { get; set; }
        public DateTime Date { get; set; }
        public string Country { get; set; }
        public DateTime ReleaseDate { get; set; }

        public Catalog(string catalogName, string author, string albomName, DateTime date, string country, DateTime releaseDate)
        {
            if (string.IsNullOrWhiteSpace(catalogName))
            {
                throw new ArgumentNullException("Имя каталога не может быть пустым или равно null!", nameof(catalogName));
            }
            
            if (string.IsNullOrWhiteSpace(author))
            {
                throw new ArgumentNullException("Имя автора не может быть пустым или равно null!", nameof(author));
            }
            if (string.IsNullOrWhiteSpace(albomName))
            {
                throw new ArgumentNullException("Название альбома не может быть пустым или равно null!", nameof(albomName));
            }
            if (string.IsNullOrWhiteSpace(country))
            {
                throw new ArgumentNullException("Название страны не может быть пустым или равно null!", nameof(country));
            }
            CatalogName = catalogName;
            Author = author;
            AlbomName = albomName;
            Country = country;
            Date = date;
            ReleaseDate = releaseDate;
        }
        public Catalog(string catalogName)
        {
            if (string.IsNullOrWhiteSpace(catalogName))
            {
                throw new ArgumentNullException("Имя каталога не может быть пустым или равно null!", nameof(catalogName));
            }
            CatalogName = catalogName;
        }
        public override string ToString()
        {
            return CatalogName;
        }
    }
}
