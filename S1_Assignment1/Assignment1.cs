using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session1
{
    public class Assignement1
    {
        public class StudentProfessorTest
        {
            public static void Main(string[] args)
            {
                // Create a new Person and make them say hello
                Person person = new Person();
                person.Greet();

                // Create a new Student, set an age, say hello, and display her age
                Student student = new Student();
                student.SetAge(20);
                student.Greet();
                student.ShowAge();

                // Create a new Teacher, set an age, say hello, and start the explanation
                Teacher teacher = new Teacher();
                teacher.SetAge(35);
                teacher.Greet();
                teacher.Explain();
            }
        }



        public class Person
        {
            public int Age { get; set; }
            public void Greet()
            {
                Console.WriteLine("Hi");
            }
            public void SetAge(int age)
            {
                this.Age = age;
            }
        }

        public class Student : Person
        {
            public void Study()
            {
                Console.WriteLine("I'm studying");
            }
            public void ShowAge()
            {
                Console.WriteLine($"My age is {this.Age} years old");
            }
        }

        public class Teacher : Person
        {
            public void Explain()
            {
                Console.WriteLine("I'm Explaining");
            }
        }

    }
}
