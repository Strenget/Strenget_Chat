using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chat
{
    public class Person
    {
        // обьявляем переменные
        public string Name;
        private int Age;
        private string Country;
        private string City;
        private string Aducation;
        private string Language;

        // создаем конструктор
        public Person(string name, int age, string coutry, string city, string aducation, string language)
        {
            Name = name;
            Age = age;
            Country = coutry;
            City = city;
            Aducation = aducation;
            Language = language;
        }
    }
}
