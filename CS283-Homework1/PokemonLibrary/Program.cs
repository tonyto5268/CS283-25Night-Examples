using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pokemon;


namespace PokemonLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            PokemonOwner atony = new PokemonOwner();
            atony.name = "妙娃種子";
            atony.hp = 60;
           
            atony.weight = 5.94f;
            atony.typeKind= new string[] {"草","毒"};
            atony.hight = 0.67f;
           
            atony.powerupNeedStardust = 3000;
            atony.powerupNeedCandy = 3;
            atony.eveolevNeedCandy = 25;
           
          
            Console.WriteLine
            ("{0}\n{1}\n{2}\n{3}\n{4}\n{5}\n{6}\n{7}",
            atony.name,
            atony.hp,
            
            atony.weight,
            atony.typeKind[0]+"/"+atony.typeKind[1],
            atony.hight,
           
            atony.powerupNeedStardust,
            atony.powerupNeedCandy,
            atony.eveolevNeedCandy
            
            );



        }
            
    }
}
