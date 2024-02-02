using System;
using System.Collections.Generic;

namespace Lab3App
{
    internal class Coin : Treasure
    {
        public int Value;

        public Coin(string description, int score, int value):base(description, score) 
        {
            this.Value = value;
        }   
        public override void Display()
        {
            Console.WriteLine("Coin " + Description + " is displayed");
        }

        public void updateTotalValue()
        {
            Board.TotalValue += Value;
            Console.WriteLine("Total Value is updated to: " + Board.TotalValue);
        }

        public override void AddMe(List<Collectable> myList)
        {
            base.AddMe(myList);
            updateTotalValue();
        }
    }
}