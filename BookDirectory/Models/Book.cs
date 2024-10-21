using System;

namespace BookDirectory.Models
{
    public class Book
    {
        private static int nextId = 1; // Statische Variable zur Generierung der ID
        private int _id; 
        private string _author; 
        private string _title; 
        private int _releaseYear; 

        // Konstruktor
        public Book(string title, string author, int releaseYear)
        {
            _id = nextId++; // Generiere die ID und erhöhe nextId
            Title = title; // Verwende Setter, um Validierung durchzuführen
            Author = author; 
            ReleaseYear = releaseYear; 
        }

        // Öffentliche Eigenschaften
        public int Id
        {
            get => _id; 
        }

        public string Title
        {
            get => _title; 
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentNullException(nameof(value), "Titel darf nicht leer sein.");
                _title = value; 
            }
        }

        public string Author
        {
            get => _author; 
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentNullException(nameof(value), "Autor darf nicht leer sein.");
                _author = value; 
            }
        }

        public int ReleaseYear
        {
            get => _releaseYear; 
            private set
            {
                if (value < 1000 || value > DateTime.Now.Year)
                    throw new ArgumentOutOfRangeException(nameof(value), "Das Veröffentlichungsjahr muss zwischen 1000 und dem aktuellen Jahr liegen.");
                _releaseYear = value; 
            }
        }
    }
}
