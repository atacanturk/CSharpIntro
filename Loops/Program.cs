using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            string course1 = "Mathematic";
            string course2 = "Physics";
            string course3 = "Chemistry";
            string course4 = "Biology";

            //array

            string[] courses = new string[] { course1, course2, course3, course4 };

            for (int i = 0; i < courses.Length; i++)
            {
                Console.WriteLine(courses[i]);
            }

            Console.WriteLine("---------");

            foreach (var course in courses)
            {
                Console.WriteLine(course);
            }
        }
    }
}
