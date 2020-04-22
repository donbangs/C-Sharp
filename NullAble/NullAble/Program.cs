using System;

namespace NullAble
{
    class Program
    {
        static void Main(string[] args)
        {
            //PlayerCharacter player = new PlayerCharacter();
            //PlayerCharacter[] players = new PlayerCharacter[3]
            //{
            //    new PlayerCharacter { Name = "Tom" },
            //    new PlayerCharacter(),
            //    null
            //};

            //player.Name="Tom";
            //PlayerDisplayer.Write(player);
            //int days = player.DaysSinceLastLogin.Value;
            //int days = player?.DaysSinceLastLogin ?? -1;

            //string p1 = players?[0]?.Name;
            //string p2 = players?[1]?.Name;
            //string p3 = players?[2]?.Name;
            //Console.WriteLine(days);


            PlayerCharacter p1 = new PlayerCharacter(new DiamondDefence()) 
            {
                Name = "Tom"
            };

            PlayerCharacter p2 = new PlayerCharacter(new IronDefence())
            {
                Name = "Andy"
            };

            PlayerCharacter p3 = new PlayerCharacter(new NullDefance())
            {
                Name = "Sarah"
            };


            p1.Hit(10);
            p2.Hit(10);
            p3.Hit(10);

#nullable enable
            string notNull = null;
#nullable disable
        }
    }
}
