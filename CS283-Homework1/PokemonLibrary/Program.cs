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
            atony.sex = "M";
            atony.weight = 5.94;
            atony.typeKind = "草/毒";
            atony.hight = 0.67;
            atony.stardust = 271484;
            atony.candy = 27;
            atony.powerupNeedStardust = 3000;
            atony.powerupNeedCandy = 3;
            atony.eveolevNeedCandy = 25;
            atony.quickAttackName = "藤鞭";
            atony.quickAttackLevel = 7;
            atony.digAttackName = "污泥炸彈";
            atony.digAttackNameLevel = 80;
            atony.gpsAddress = "台灣,新北市三重";
            atony.dateNow = DateTime.Now.ToShortDateString();
            Console.WriteLine
            ("{0}\n{1}\n{2}\n{3}\n{4}\n{5}\n{6}\n{7}\n{8}" +
            "\n{9}\n{10}\n{11}\n{12}\n{13}\n{14}\n{15}\n{16}",
            atony.name,
            atony.hp,
            atony.sex,
            atony.weight,
            atony.typeKind,
            atony.hight,
            atony.stardust,
            atony.candy,
            atony.powerupNeedStardust,
            atony.powerupNeedCandy,
            atony.eveolevNeedCandy,
            atony.quickAttackName,
            atony.quickAttackLevel,
            atony.digAttackName,
            atony.digAttackNameLevel,
            atony.gpsAddress,
            atony.dateNow
            );



        }
            
    }
}
