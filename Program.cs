using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Spencer Finnegan
 * Group 1-6 Mooyah
 * DataStructures Project
 * This program creates a list of people who buy hamburgers from us and then updates it every time they buy another hamburger.
 * */

namespace ConsoleApplication8
{
    class Program
    {
        public static Random random = new Random(); //Create a random object. 

        public static string randomName()
        {
            string[] names = new string[8] { "Dan Morain", "Emily Bell", "Carol Roche", "Ann Rose", "John Miller", "Greg Anderson", "Arthur McKinney", "Joann Fisher" };
            int randomIndex = Convert.ToInt32(random.NextDouble() * 7);
            return names[randomIndex];
        } //Create a method called randomName() that generates a random name from a list of either names. 

        public static int randomNumberInRange() //Create another method that generates a random number. 
        {
            return Convert.ToInt32(random.NextDouble() * 20);
        }
        static void Main(string[] args)
        {
            Queue<string> qMyQueue  = new Queue<string>(); //Create a queue to load up the names of the people in line for burgers.

            Dictionary<string, int> dMyDictionary = new Dictionary<string, int>(); //Create the dictionary to save the name with how many burger they eat.

            for (int i = 0; i < 100; i++) //Create a loop to load up the queue with random people.
            {
                qMyQueue.Enqueue(randomName());
            }

            for (int i = 0; i < qMyQueue.Count; i++) 
            {
                string sRandomName = qMyQueue.Dequeue(); //Pull all the names from the queue list and store it to a temp variable.
                int iRandomNumber = randomNumberInRange(); //Generate a temp variable to hold a random number of hamburgers eaten.
                
                if (dMyDictionary.ContainsKey(sRandomName)) //Create an if to see if the person has eaten a hamburger. If they haven't, create a new record. If they have add more hamburgers to total. 
                {
                    dMyDictionary[sRandomName] += iRandomNumber;
                }
                else
                {
                    dMyDictionary.Add(sRandomName, iRandomNumber);
                }
            }

            foreach (KeyValuePair<string, int> entry in dMyDictionary) //For every entry in the dictionary publish the results.
            {
                Console.Write(entry.Key.PadRight(25));
                Console.WriteLine(entry.Value);
                

            }

            Console.ReadLine(); //Read the output. 


        }
    }
}
