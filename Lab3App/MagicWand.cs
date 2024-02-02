﻿using System;
namespace Lab3App
{
    public class MagicWand : Tool
    {
        public MagicWand(string description) : base(description)
        {
        }
        public override void Display()
        {
            Console.WriteLine("MagicWand " + Description + " is displayed");
        }

        public override void doAction()
        {
            Console.WriteLine("MagicWand is used");
        }

    }
}