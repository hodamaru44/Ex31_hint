using System;
using System.Collections.Generic;
using System.Text;

namespace Ex31_hint
{
    class Tank : Character
    {
        public int bullet = 0;
        public Tank(string name, float hp, float power, float resistance) : base(name, hp, power, resistance) { }
        public override void Attack(Character destination)
        {
            if (bullet > 0)
            {
                bullet--;
                Console.WriteLine($"{this.name}は{destination.name}に向け大砲を発射！");
                Console.WriteLine($"{destination.name}はうしろに吹っ飛んだ！");
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
                Console.WriteLine($"{base.name}は弾切れです！");
            }
        }
    }
}