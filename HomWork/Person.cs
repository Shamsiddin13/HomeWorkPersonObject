using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomWork
{
    internal class Person
    {
        public Person(string Name, bool IsParents, Person Jufti)
        {
            this.Name = Name;
            this.IsParents = IsParents;
            this.Jufti = Jufti;
        }

        public bool IsParents;
        
        public string Name;
        
        public Person Jufti;

        static public void Oila(Person person1, Person person2)
        {
            person1.IsParents = true;
            person2.IsParents = true;
        }

        public void OilaQurdirish(Person person)
        {
            Jufti = person;
            
        }

        public void Information()   
        {
            if (this.IsParents && IsParents) 
            {
                Console.WriteLine($"{this.Name} va {Jufti.Name} oila qurishdi");
            }
        }

    }
}
