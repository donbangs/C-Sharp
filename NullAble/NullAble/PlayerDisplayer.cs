using System;
using System.Collections.Generic;
using System.Text;

namespace NullAble
{
    class PlayerDisplayer
    {
        public static void Write(PlayerCharacter player)
        {
            if (string.IsNullOrWhiteSpace(player.Name))
            {
                Console.WriteLine("Player is null or all whitespace");
            }
            else
            {
                Console.WriteLine(player.Name);
            }
            //int _get = player.DaysSinceLastLogin.GetValueOrDefault(-1);

            //int _get = player.DaysSinceLastLogin.HasValue ? player.DaysSinceLastLogin.Value : -1;

            int _get = player.DaysSinceLastLogin ?? -1;

            Console.WriteLine($"{_get} days since of login");
            //if (player.DaysSinceLastLogin.HasValue)
            //{
            //    Console.WriteLine(player.DaysSinceLastLogin.Value);
            //}
            //else {
            //    Console.WriteLine("No value for DaysSinceLastLogin"); 
            //}

            if (player.DateOfBirth == null) { 
                Console.WriteLine("No date of birth specifed");
            }
            else {
                Console.WriteLine(player.DateOfBirth);
            }

            if (player.IsNoob == null)
            {
                Console.WriteLine("Player newbie status is unkown");
            }
            else if (player.IsNoob == true)
            {
                Console.WriteLine("Player newbie status is unkown");
            }
        }
    }
}
