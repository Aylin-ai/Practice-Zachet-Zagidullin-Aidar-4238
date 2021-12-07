using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_1_4238
{
    class Person
    {
        public string fullName;
        public int age;
        public void move() 
        {
            Console.WriteLine("Такой-то {0} идёт", fullName);
        }
        public void talk() 
        {
            Console.WriteLine("Такой-то {0} говорит", fullName);
        }
        public Person() { }
        public Person(string fullName, int age)
        {
            this.fullName = fullName;
            this.age = age;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person();
            person1.fullName = "Дэвид";
            person1.age = 33;
            Person person2 = new Person("Том", 22);

            person1.move();
            person1.talk();

            Console.WriteLine();

            person2.move();
            person2.talk();
            Console.ReadKey();
        }
    }
}
