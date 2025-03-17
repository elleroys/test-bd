using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Program;

namespace Animalpedia
{
    abstract class Mammal // Ссавці
    {

    }

    class Dog : Animal
    {
        public string Breed { get; private set; }

        public Dog(string id, string name, string type, string family, string info, string breed)
            : base(id, name, type, family, info)
        {
            Breed = breed;
        }

        public override void MakeSound()
        {
            Console.WriteLine($"Унікальний айді:{Id}, назва {Name}, вид {Type}, родина {Family} гавкає");
        }
    }
    class Cat : Animal
    {
        public string Breed { get; private set; }

        public Cat(string id, string name, string type, string family, string info, string breed)
            : base(id, name, type, family, info)
        {
            Breed = breed;
        }

        public override void MakeSound()
        {
            Console.WriteLine($"Унікальний айді:{Id}, назва {Name}, вид {Type}, родина {Family} мяукає");
        }
    }
}
