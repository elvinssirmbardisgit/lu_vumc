using ArraysLession3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysLession3
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
}


namespace LU_VUMC_Project
{
    class Lesson_6
    {
        public void Lesson_6_Method()
        {
            List<int> nums = new List<int>
            {
                95
            };

            nums.Add(14);
            nums.Add(14);
            nums.Add(25);

            foreach (var item in nums)
            {
                Console.WriteLine($"My numbers {item}");
            }

            //================================================================================

            List<Person> persons = new List<Person>();

            Person artisPerson = new Person()
            {
                Name = "Artis",
                Age = 45
            };

            persons.Add(artisPerson);
            persons.Add(artisPerson);
            persons.Add(artisPerson);

            persons.Remove(artisPerson);
            persons.RemoveAt(1);

            foreach (var item in persons)
            {
                Console.WriteLine($"Name: {item.Name} Age: {item.Age}");
            }

            //================================================================================

            var passwords = new Dictionary<string, Person>();

            passwords.Add("a", artisPerson);

            Person emilsPerson = new Person
            {
                Name = "Emils",
                Age = 46
            };

            passwords.Add("e", emilsPerson);

            foreach (KeyValuePair<string, Person> item in passwords)
            {
                Console.WriteLine($"Key: {item.Key} Name: {item.Value.Name}");
            }

            foreach (string key in passwords.Keys)
            {
                Person item = passwords[key];
                Console.WriteLine($"Second loop Key: {key} Value: {item.Name}");
            }


        }
    }
}
