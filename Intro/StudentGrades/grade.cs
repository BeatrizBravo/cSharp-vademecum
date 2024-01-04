using System;

namespace Intro
{
    class Grades
    {
        public static void Grade()
        {
            // Step 1: Declare variables and assign values
            string studentName = "Sophia Johnson";
            string course1Name = "English 101";
            string course2Name = "Algebra 101";
            string course3Name = "Biology 101";
            string course4Name = "Computer Science I";
            string course5Name = "Psychology 101";

            int course1Credit = 3;
            int course2Credit = 3;
            int course3Credit = 4;
            int course4Credit = 4;
            int course5Credit = 3;

            // Step 2: Calculate the GPA
            double totalCredits = course1Credit + course2Credit + course3Credit + course4Credit + course5Credit;

            double course1Grade = 4;
            double course2Grade = 3;
            double course3Grade = 3;
            double course4Grade = 3;
            double course5Grade = 4;

            double course1Gpa = course1Grade * course1Credit;
            double course2Gpa = course2Grade * course2Credit;
            double course3Gpa = course3Grade * course3Credit;
            double course4Gpa = course4Grade * course4Credit;
            double course5Gpa = course5Grade * course5Credit;

            double totalGpa = (course1Gpa + course2Gpa + course3Gpa + course4Gpa + course5Gpa) / totalCredits;

            // Step 3: Display the results
            Console.WriteLine("Student Name: " + studentName);
            Console.WriteLine("Course 1: " + course1Name + " (Credit: " + course1Credit + ", Grade: " + course1Grade + ")");
            Console.WriteLine("Course 2: " + course2Name + " (Credit: " + course2Credit + ", Grade: " + course2Grade + ")");
            Console.WriteLine("Course 3: " + course3Name + " (Credit: " + course3Credit + ", Grade: " + course3Grade + ")");
            Console.WriteLine("Course 4: " + course4Name + " (Credit: " + course4Credit + ", Grade: " + course4Grade + ")");
            Console.WriteLine("Course 5: " + course5Name + " (Credit: " + course5Credit + ", Grade: " + course5Grade + ")");
            Console.WriteLine("Final GPA: " + totalGpa);
        }
    }
}
