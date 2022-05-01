
using HomeworkClass01;

//Create interfaces called IAnimal, IDog, ICat
//IAnimal : Contains method PrintAnimal
//IDog - Contains method Bark
//ICat - Contains method Eat that gets parameter food of type string
//Create an abstract class Animal (you choose the properties) that implements IAnimal, with abstract method PrintAnimal
//Create class Dog that implements IDog and inherits from Animal. Implement PrintAnimal but also Bark.
//Create class Cat that implements ICat and inherits from Animal. Implement PrintAnimal but also Eat.
//Create several objects and test the method calls
//** Bonus

//Create a list of Animal and add members that are of type Cat and Dog.
//Iterate the list, use GetType for each member to see the type of animal. If it is a dog call its bark method, if it is a cat call the Eat method.

Dog dog = new Dog("Perky",6,"labrador");
Dog dog2 = new Dog("Hubi", 3, "Boxer");
Dog dog3 = new Dog("Luna", 8, "Pomerian");
dog.PrintAnimal();
dog.Bark();
dog2.PrintAnimal();
dog2.Bark();
dog3.PrintAnimal();
dog3.Bark();

Cat cat = new Cat("Mona",5, "Siamese cat");
Cat cat2 = new Cat("Bella", 5, "Siberian cat");
Cat cat3 = new Cat("Leo", 5, "Bengal cat");
cat.PrintAnimal();
cat.Eat("fish");
cat2.PrintAnimal();
cat2.Eat("fish");
cat3.PrintAnimal();
cat3.Eat("fish");

List<string> AnimalType = new List<string>();
AnimalType.Add("Dog");
AnimalType.Add("Cat");
AnimalType.Add("Dog");
AnimalType.Add("Dog");
AnimalType.Add("Dog");
AnimalType.Add("Cat");
AnimalType.Add("Cat");

foreach (string type in AnimalType)
{
    Console.WriteLine(type);
    if (type == "Dog")
    {
        dog.Bark();
    }
    else if(type == "Cat")
    {
        cat.Eat("fish");
    }
    else
    {
        Console.WriteLine("Wrong Answer!Only two options:Cat or Dog");
    }  
};

Console.ReadLine();
