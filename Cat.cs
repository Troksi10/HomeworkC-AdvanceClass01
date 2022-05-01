using HomeworkClass01.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkClass01
{
    class Cat : Animal, ICat
    {
        public void Eat(string food)
        {
            Console.WriteLine($"The cat is eating {food}.");
        }

         public override void PrintAnimal()
        {
            Console.WriteLine($"The cat {Name} have {Age} years old.");
        }

        public Cat(string name,int age,string type) : base(name,age,type)
        {
        }
    }
}
