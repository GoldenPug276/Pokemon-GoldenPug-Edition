using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon_GoldenPug_Edition
{
    class Pokemon
    {
        string Name;
        int HP;
        int Attack;
        int Defense;
        int SpAttack;
        int SpDefense;
        int Speed;
        int Level;
        string Type1;
        string Type2;
        Image Sprite;
        Image AssPic;
        Move Move1;
        Move Move2;
        Move Move3;
        Move Move4;
        int Thickness;
        public Pokemon(string name, int health, int attack, int defense, int spAttack, int spDefense, int speed, int level, string type, string t2, Image sprite, Image assPic, Move move1, Move move2, Move move3, Move move4, int size)
        {
            Name = name;
            HP = health;
            Attack = attack;
            Defense = defense;
            SpAttack = spAttack;
            SpDefense = spDefense;
            Speed = speed;
            Level = level;
            Type1 = type;
            Type2 = t2;
            Sprite = sprite;
            AssPic = assPic;
            Move1 = move1;
            Move2 = move2;
            Move3 = move3;
            Move4 = move4;
            Thickness = size;
        }
        public string GetName()
        {
            return Name;
        }
        public int GetHealth()
        {
            return HP;
        }
        public int GetAttack()
        {
            return Attack;
        }
        public int GetDefense()
        {
            return Defense;
        }
        public int GetSpecialAttack()
        {
            return SpAttack;
        }
        public int GetSpecialDefense()
        {
            return SpDefense;
        }
        public int GetSpeed()
        {
            return Speed;
        }
        public int GetLevel()
        {
            return Level;
        }
        public string GetPokemonType1()
        {
            return Type1;
        }
        public string GetPokemonType2()
        {
            return Type2;
        }
        public Image GetSprite()
        {
            return Sprite;
        }
        public Image GetAssPic()
        {
            return AssPic;
        }
        public Move GetFirstMove()
        {
            return Move1;
        }
        public Move GetSecondMove()
        {
            return Move2;
        }
        public Move GetThirdMove()
        {
            return Move3;
        }
        public Move GetFourthMove()
        {
            return Move4;
        }
        public int GetAssSize()
        {
            return Thickness;
        }
    }
}
