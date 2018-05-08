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
            Dog dog1 = new Dog("Dalmation", 17);
            Dog dog2 = new Dog("Doberman", 8);
            Dog dog3 = new Dog("Husky", 9);
 
            List<object> listOfDogs = new List<object> {dog1, dog2, dog3};

            //add to dogs
            listOfDogs.Add("Spaniel, 10");
            listOfDogs.Add("Beagle, 7");
            listOfDogs.Add("American Staffordshire, 3");


            //print dogs
            dog1.printDog(dog1.name, dog1.age);
            dog1.printDog(dog2.name, dog2.age);
            dog3.printDog(dog3.name, dog3.age);

            //print dogs
            for (int i = 3; i < 6; i++)
            {
                Console.WriteLine(listOfDogs[i] + "\n");
            }//end for

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
