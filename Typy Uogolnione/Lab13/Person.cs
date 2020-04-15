using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13
{
    class Person : IComparable
    {
        public string Name { get; set; }
        public string Surname { get; set; }

        public Person(string name,string surname)
        {
            Name = name;
            Surname = surname;
        }

        public override string ToString()
        {
            return Name + " " + Surname;
        }

        public int CompareTo(object obj)
        {
            if (obj == null) return 1;
            Person p = obj as Person;
            switch(Name.CompareTo(p.Name))
            {
                case -1: return -1;                    
                case 0:
                    switch (Surname.CompareTo(p.Surname))
                    {
                        case -1:
                            return -1;
                        case 0:
                            return 0;
                        case 1:
                            return 1;
                    }
                    break;
                case 1: return 1;                    
            }
            throw new NotImplementedException();
        }
    }
}
