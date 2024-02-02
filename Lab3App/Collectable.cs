
using System;
using System.Collections.Generic;

namespace Lab3App
{
    public abstract class Collectable : Displayable
    {
        public string Description;
        public CollectionBoard Board;

        public Collectable(string description)
        {
            Description = description;
        }

        public virtual void AddMe(List<Collectable> myList)
        {
            myList.Add(this);
            Console.WriteLine(Description + " Collected, Congrats!!!!");

        }

        public abstract void Display();
    }
}