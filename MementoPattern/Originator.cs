using System;
namespace MementoPattern
{
    public class Originator
    {
        private string _description;
        private string _title;
        private string _author;
        private DateTime _lastEdit;


        public Originator(string title, string author, string dsc, DateTime time)
        {
            _title = title;
            _author = author;
            _description = dsc;
            _lastEdit = time;
        }

        public string Description
        {
            get { return _description; }
            set
            {
                _description = value;
                UpdateLasEdit();
            }
        }

        public string Title
        {
            get { return _title; }
            set
            {
                _title = value;
                UpdateLasEdit();
            }
        }

        public string Author
        {
            get { return _author; }
            set
            {
                _author = value;
                UpdateLasEdit();
            }
        }

        private void UpdateLasEdit()
        {
            _lastEdit = DateTime.UtcNow;
        }

        public void RestoreFromMemento(Memento m)
        {
            _title = m.GetSavedTitle();
            _author = m.GetSavedAuthor();
            _description = m.GetSavedDescription();
            _lastEdit = m.GetSavedLastEdit();
        }

        public Memento SaveToMemento()
        {
            return new Memento(_title, _author, _description, _lastEdit);
        }

        public void PrintState()
        {
            Console.WriteLine("{0} - '{1}'   by {2}, edited {3}.\n", _title, _description, _author, _lastEdit);
        }
    }
}
