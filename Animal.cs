using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Program;

namespace Animalpedia
{
    abstract class Animal // Тварини
    {
        public string Id { get; protected set; }
        public string Name { get; protected set; }
        public string Type { get; protected set; }
        public string Family { get; protected set; }
        public string Info { get; protected set; }

        public Animal(string id, string name, string type, string family, string info)
        {
            Id = id;
            Name = name;
            Type = type;
            Family = family;
            Info = info;
        }

        public abstract void MakeSound(); // Polymorphism
    }
}
