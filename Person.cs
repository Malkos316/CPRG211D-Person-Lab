using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPRG211DPersonLab
{
    internal class Person
    {
        //fields
        private int     id;
        private string  firstName;
        private string  lastName;
        private int     age;
        private string  favoriteColor;
        private bool    isWorking;

        //properties
        public int      Id              {get => id; set => id = value; }
        public string   FirstName       { get => firstName; set => firstName = value; }
        public string   LastName        { get => lastName; set => lastName = value; }
        public int      Age             { get => age; set => age = value; }
        public string   FavoriteColor   { get => favoriteColor; set => favoriteColor = value; }
        public bool     IsWorking       { get => isWorking; set => isWorking = value; }

        public Person(int id, string firstName, string lastName, int age, string favoriteColor, bool isWorking)
        {
            Id =            id;
            FirstName =     firstName;
            LastName =      lastName;
            Age =           age;
            FavoriteColor = favoriteColor;
            IsWorking =     isWorking;
        }

        public override string ToString()
        {
            string formatted = "";

            formatted += "ID: " + id + "\n";
            formatted += "First name: " + firstName + "\n";
            formatted += "Last name: " + lastName + "\n";
            formatted += "FavoriteColor: " + favoriteColor + "\n";
            formatted += "Age: " + age + "\n";
            formatted += "IsWorking: " + isWorking + "\n";

            return formatted;
        }

        public string GetAgeInTenYears()
        {
            string tenYears = firstName + " " + lastName + " " + "age in 10 years is: " + (age + 10);

            return tenYears;
        }

        public string ChangeFavoriteColor()
        {
            string newFavoriteColor = (favoriteColor = "White");

            return newFavoriteColor;
        }

        public string DisplayPersonInfo()
        {
            string info = id + ": " + firstName  + " " + lastName + "'s  favorite color is " + favoriteColor+ "\n";

            return info;
        }
    }
}
