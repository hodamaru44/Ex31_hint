using System;
using System.Collections.Generic;
using System.Text;

namespace Ex31_hint
{
    
    class Hornet:Character
    {/// <summary>
    /// 
    /// </summary>
    /// <param name="name"></param>名前
    /// <param name="hp"></param>体力
    /// <param name="power"></param>攻撃力
    /// <param name="resistance"></param>耐性
        public Honet(string name, float hp, float power, float resistance) : base(name, hp, power, resistance) { }

        public override void Attack(Character destination)
        {
                Console.WriteLine($"{this.name}は{destination.name}に毒針を刺した");
                if (destination.resistance == 0)
                {
                    Console.WriteLine($"{destination.name}は死にました");
                }
                else
                {
                    Console.WriteLine($"{destination.name}には効かなかった");
                }
            
        }
        
    }
}
