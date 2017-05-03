using System;
namespace MementoPattern
{
    public class Memento
    {
        private readonly string _description;
        private readonly string _title;
        private readonly string _author;
        private readonly DateTime _lastEdit;


        public Memento(string title, string author, string dsc, DateTime time)
        {
            _title = title;
            _author = author;
            _description = dsc;
            _lastEdit = time;
        }

        public string GetSavedDescription()
        {
            return _description;
        }

        public string GetSavedTitle()
        {
            return _title;
        }

        public DateTime GetSavedLastEdit()
        {
            return _lastEdit;
        }

        public string GetSavedAuthor()
        {
            return _author;
        }
    }
}
