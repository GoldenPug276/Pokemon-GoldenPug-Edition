using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon_GoldenPug_Edition
{
    class Move
    {
        string Name;
        string Type;
        string Category;
        int Power;
        int Accuracy;
        int PP;
        int MaxPP;
        Image ButtonImage;
        int MoveNumber;
        
        public Move(string name, string type, string cat, int power, int accuracy, int pp, int mpp, Image moveb, int number)
        {
            Name = name;
            Type = type;
            Category = cat;
            Power = power;
            Accuracy = accuracy;
            PP = pp;
            MaxPP = mpp;
            ButtonImage = moveb;
            MoveNumber = number;
        }
        public string GetName()
        {
            return Name;
        }
        public string GetMoveType()
        {
            return Type;
        }
        public string GetCategory()
        {
            return Category;
        }
        public int GetPower()
        {
            return Power;
        }
        public int GetAccuracy()
        {
            return Accuracy;
        }
        public int GetDatPP()
        {
            return MaxPP;
        }
        public Image GetButtonImage()
        {
            return ButtonImage;
        }
        public int GetMoveNumber()
        {
            return MoveNumber;
        }
        public void PPModifier()
        {
            PP-=1;
        }
        public int GetCurrentPP()
        {
            return PP;
        }
    }
}
