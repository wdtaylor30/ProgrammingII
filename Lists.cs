using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/* William Daniel Taylor
 * 5.8.18
 * Assignment on Lists */

namespace DogList
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog dog1 = new Dog("Fred", 17);
            Dog dog2 = new Dog("Mark", 8);
            Dog dog3 = new Dog("Josanne", 9);
 
            List<Dog> listOfDogs = new List<Dog> {dog1, dog2, dog3};

            //print dogs
            dog1.printDog(dog1.name, dog1.age);
            dog1.printDog(dog2.name, dog2.age);
            dog3.printDog(dog3.name, dog3.age);

            Console.ReadLine();
        }//end main
    }//end class

    class Dog
    {
        public string name;
        public int age;

        public Dog(string n, int a)
        {
            name = n;
            age = a;
        }//end constructor

        public void printDog(string name, int age)
        {
            Console.WriteLine(name + ", " + Convert.ToString(age) + "\n");
        }//end method
    }//end class
}

