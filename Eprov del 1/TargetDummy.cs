using System;

namespace Eprov_del_1
{
    public class TargetDummy: Hero
    {
        //arv av hero
        int targetHp = 1000; 
        int targetDmg = 20;
     public TargetDummy() //konstruktor 
     {
         name = "Target Dummy";
         
         hp =  targetHp;

         dmg = targetDmg;

         armored = false;
     }   
    }
}
