using System;
using System.Collections.Generic;
using System.Text;

namespace NullAble
{
    class PlayerCharacter
    {
        public readonly ISpecialDefence specialDefence;
        public string Name { get; set; }
        public int? DaysSinceLastLogin { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public bool?  IsNoob{get;set;}
        public int Health { get; set; } = 100;

        public PlayerCharacter(ISpecialDefence specialDefence)
        {
            this.specialDefence = specialDefence;
        }

        public void Hit(int demage)
        {
            int demageReduciton = specialDefence.CalcluateDamageReduciton(demage);

            int totalDemage = demage - demageReduciton;

            Health -= totalDemage;

            Console.WriteLine($"{Name}'s health has been reduced by {totalDemage} to {Health} ");
        
        }

      
    }
}
