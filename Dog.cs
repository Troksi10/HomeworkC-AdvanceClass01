using HomeworkClass01.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkClass01
{
     class Dog : Animal,IDog
    {
        public void Bark()
        {
            Console.WriteLine("Bark Bark!");
        }

        public override void PrintAnimal()
        {
            Console.WriteLine($"The dog {Name} have {Age} years old.");
        }

        public Dog(string name,int age,string type) : base(name, age, type)
        {

        }
    }
}
