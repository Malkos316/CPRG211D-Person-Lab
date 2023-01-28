using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPRG211DPersonLab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person(1, "Ian", "Brooks", 30, "Red", true);
            Person person2 = new Person(2, "Gina", "James", 18, "Green", false);
            Person person3 = new Person(3, "Mike", "Briscoe", 45, "Blue", true);
            Person person4 = new Person(4, "Mary", "Beals", 28, "Yellow", true);

            Console.WriteLine(person2.DisplayFavoriteColor());
            Console.WriteLine(person3.DisplayPersonInfo());
            person1.ChangeFavoriteColor();
            Console.WriteLine(person1.DisplayFavoriteColor());
            Console.WriteLine(person4.GetAgeInTenYears());

            Relation relation1 = new Relation("Sister", person2, "Sister", person4);
            Console.WriteLine(relation1.Relationstring());
            Relation relation2 = new Relation("Brother", person1, "Brother", person3);
            Console.WriteLine(relation2.Relationstring());

            List<Person> people= new List<Person>();

            people.Add(person1);
            people.Add(person2);
            people.Add(person3);
            people.Add(person4);

            double sum = 0;

            foreach (Person person in people)
            {
                sum += person.Age;
            }

            double average = sum / people.Count;

            Console.WriteLine("Average age: " + average);

            Console.ReadLine();
        }
    }
}
