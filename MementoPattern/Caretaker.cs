using System;
using System.Collections.Generic;

namespace MementoPattern
{
    public class Caretaker
    {
        public List<Memento> savedStates { get; set; }

        public Caretaker()
        {
            savedStates = new List<Memento>();
        }

        public Memento Restore(int numOfSetBacks)
        {

            if (numOfSetBacks <= savedStates.Count)
                return savedStates[numOfSetBacks];
            else
                throw new ArgumentOutOfRangeException();

        }

        public void Save(Memento m)
        {
            savedStates.Add(m);
        }

    }
}
