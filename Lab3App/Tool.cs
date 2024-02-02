using System;
using System.Collections.Generic;

namespace Lab3App
{
    public abstract class Tool : Collectable
    {
        public Tool(string Description) : base(Description)
        {
        }
        public abstract void doAction();

        public override void AddMe(List<Collectable> myList)
        {
            base.AddMe(myList);
            doAction();
        }
    }
}