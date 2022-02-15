using System;
using System.Collections.Generic;
using System.Text;

namespace Ex31_hint
{
    class Cat : Character
    {/// <summary>
     /// 
     /// </summary>
     /// <param name="name"></param>名前
     /// <param name="hp"></param>体力
     /// <param name="power"></param>攻撃力
     /// <param name="resistance"></param>耐性
        public Cat(string name, float hp, float power,float resistance) : base(name, hp, power, resistance) { }
       
        public override void Attack(Character destination)
        {
            Console.WriteLine($"{this.name}は{destination.name}にひっかいた");
            Console.WriteLine($"{destination.name}は{this.power}のダメージ");
            destination.hp -= this.power;
            Console.WriteLine($"{destination.name}の残りのHPは{destination.hp}");
        }
    }
}
