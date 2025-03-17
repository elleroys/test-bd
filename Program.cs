using System;
using System.Collections.Generic;
using Animalpedia;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.InputEncoding = System.Text.Encoding.UTF8;

        List<Animal> animals = new List<Animal> // Polymorphism dyn
            {
                new Dog("1","Собака свійський", "Ссавці", "Псові", "Культигенна тварина, одомашнена форма вовка", "вівчарка."),
                new Cat("2", "Кіт свійський", "Ссавці", "Котові", "Кіт свійський, або кішка свійська — невеликий ссавець ряду хижих родини котових", "шотландська кішка."),
                new Bird("3", "Курка свійська", "Птахи", "Фазанові", "Кури свійські або домашня курка — свійські птахи, найпоширеніші птахи планети", "курка кучерява."),
            };

        foreach (var animal in animals)
        {
            animal.MakeSound();

            AnimalInfoPrinter.PrintInfo(animal);
        }
    }

    static class AnimalInfoPrinter
    {
        public static void PrintInfo(Animal animal)
        {
            string extraInfo = animal switch // pattern matching
            {
                Dog d => $"на малюнку зображена {d.Breed}",
                Cat c => $"на малюнку зображена {c.Breed}",
                Bird b => $"на малюнку зображена {b.Breed}",
                _ => "додаткової інформації немає"
            };

            Console.WriteLine($"Унікальний айді:{animal.Id}, назва {animal.Name}, вид {animal.Type}, родина {animal.Family}; Опис: {animal.Info}, {extraInfo}");
        }
    }
}