using System;

namespace Ex31_hint
{
    class Program
    {
        static void Main(string[] args)
        {
            Character character1 = new Character("しむら人", 500, 2,0);
            Character character2 = new Character("ささっき", 1000, 25,0);
            Tank tank1 = new Tank("Tiger",500000,250,0);
            tank1.bullet = 10;
            Tank tank2 = new Tank("がんタンク",10000,125,1);
            tank2.bullet = 5;
            Cat cat = new Cat("チェシャー猫",200,96,0);
            Cow cow = new Cow("赤べこ",2000,100,0);
            Hornet honet = new Hornet("ライトニングホーネット",100,10,0);
            Character[] characters = { character1, character2, tank1, tank2,cat,cow,honet};
            for(var i = 1; i < characters.Length; i++)
            {
                characters[i].Attack(character1);
            }
        }
    }
}
