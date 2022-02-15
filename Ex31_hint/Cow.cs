﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Ex31_hint
{
    class Cow: Character
    {
        public Cow(string name, float hp, float power, float resistance) : base(name, hp, power, resistance) { }

        public override void Attack(Character destination)
        {
            if (this.hp>=5)
            {
                Console.WriteLine($"{this.name}は{destination.name}に角でついた");
                Console.WriteLine($"{destination.name}は{this.power}のダメージ");
                destination.hp -= this.power;
                if (destination.hp <= 0)
                {
                    Console.WriteLine($"{destination.name}は死にました");
                }
                else
                {
                    Console.WriteLine($"{destination.name}の残りのHPは{destination.hp}");
                }
            }
            else
            {
                Console.WriteLine($"{this.name}は瀕死です。");
            }
        }
    }
}
