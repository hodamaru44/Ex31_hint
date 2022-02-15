using System;
using System.Collections.Generic;
using System.Text;

namespace Ex31_hint
{
    class Character
    {
       
        readonly public string name;
        public float hp;
        protected float power;
        public float resistance;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>名前
        /// <param name="hp"></param>体力
        /// <param name="power"></param>攻撃力
        /// <param name="resistance"></param>耐性
        public Character(string name,float hp,float power,float resistance)
        {
            this.name = name;
            this.hp = hp;
            this.power = power;
            this.resistance = resistance;
        }
        public virtual void Attack(Character destination)
        {
            Console.WriteLine($"{this.name}は{destination.name}をぶんなぐった！");
            Console.WriteLine($"{destination.name}は{this.power}のダメージ");
            destination.hp -= this.power;
            Console.WriteLine($"{destination.name}の残りのHPは{destination.hp}");
            Console.WriteLine($"{destination.resistance}");
            
        }
    }
}
