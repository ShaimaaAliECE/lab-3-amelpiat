using System;
using System.Collections.Generic;

namespace Lab3App
{
    public abstract class Treasure : Collectable
    {
        public int Score;

        public Treasure(string Description, int score) : base(Description)
        {
            this.Score = score;
        }

        public void updateTotalScore()
        {
            Board.TotalScore += Score;
            Console.WriteLine("Total Score is updated to: " + Board.TotalScore);
        }

        public override void AddMe(List<Collectable> myList)
        {
            base.AddMe(myList);
            updateTotalScore();
        }
    }
}
