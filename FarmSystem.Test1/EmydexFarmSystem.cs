using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace FarmSystem.Test1
{
    public class EmydexFarmSystem
    {
        readonly Collection<object> farmAnimals = new Collection<object>();

        public delegate void FarmEmpty();
        public event FarmEmpty farm_empty;

        //TEST 1
        public void Enter(object animal)
        {
            //TODO Modify the code so that we can display the type of animal (cow, sheep etc) 
            //Hold all the animals so it is available for future activities
            Console.WriteLine(animal.GetType().Name +  " has entered the Emydex farm");
            farmAnimals.Add(animal);
        }
     
        //TEST 2
        public void MakeNoise()
        {
            //Test 2 : Modify this method to make the animals talk
            foreach(object animal in farmAnimals)
            {
                animal.GetType().GetMethod("Talk").Invoke(animal, null);
            }

        }

        //TEST 3
        public void MilkAnimals()
        {
            foreach (object animal in farmAnimals)
            {
                if(animal.GetType().GetMethod("ProduceMilk")!= null)
                { 
                    Console.WriteLine(animal.GetType().Name + " was milked!");
                }
            }
        }

        //TEST 4
        public void ReleaseAllAnimals()
        {
            foreach (object animal in farmAnimals)
            {
                Console.WriteLine(animal.GetType().Name + " has left the farm");
            }
            
            farm_empty();
        }
    }
}