using System;

namespace Eprov_del_1
{
    public class Hero
    {
        public string name;

        public int hp;

        public int dmg;

        public bool armored;

        public void Attack()
        {
           hp = hp - dmg;
        }
        public void Attacked()
        {
            if (!armored)
            {
          hp = hp - dmg; 
            }
            else{
               Console.WriteLine ("The target is armored, it will never take damage");
            }
        }
        public void showInfo()
        {
           if(!armored)
           {
           Console.WriteLine("This is the" + name + " ,They have " +hp +" Hp and is currently not armored..");

           }
           else 
           {
          Console.WriteLine("This is the" + name + " ,They have " +hp +" Hp and is currently armored");

           }
        }
    }
}
