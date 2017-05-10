using System;
using System.Collections.Generic;
using System.Threading;

namespace MementoPattern
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Caretaker caretaker = new Caretaker();

            Originator org = new Originator("Memento Pattern", "Gruppe 0", "This is just a test", DateTime.UtcNow);

            org.PrintState();

            caretaker.Save(org.SaveToMemento());

            Thread.Sleep(3000);

            org.Description = "The pattern can be used for many things like this.";
            org.Author = "Gruppe 25";

            caretaker.Save(org.SaveToMemento());

            org.PrintState();

            Thread.Sleep(2000);

            org.Description = "The pattern can be used for many thi...";
            org.Author = "Gruppe 26";


            org.PrintState();

            caretaker.Save(org.SaveToMemento());

            Thread.Sleep(1000);

            org.Description = "The pattern can be used for am back to ear....";

            org.PrintState();

            Thread.Sleep(1000);

            Console.WriteLine("\n\nRolling back two changes -> result:\n ");

            org.RestoreFromMemento(caretaker.Restore(1));

            org.PrintState();
        }






    }
}

