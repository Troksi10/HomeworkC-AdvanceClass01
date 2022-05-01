using HomeworkClass01.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkClass01
{
    abstract class Animal : IAnimal
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Type { get; set; }

        public abstract void PrintAnimal();

        public List<string> AnimalTypes { get; set; } = new List<string>();

        public Animal (string name,int age,string type)
        {
            Name = name;
            Age = age;
            Type = type;

        }
    }
}
