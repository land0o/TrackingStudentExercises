using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentExercises
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Create 4, or more, exercises.
            CreateExercise ApiIntro = new CreateExercise("Welcome To Nashville", "JavaScript");
            CreateExercise ReactIntro = new CreateExercise("Kennel", "React");
            CreateExercise ReactProject = new CreateExercise("Nutshell", "React");
            CreateExercise CsharpIntro = new CreateExercise("Plan Heist", "C#");

            // Create 3, or more, cohorts. 
            CreateCohort Cohort33 = new CreateCohort("Cohort 33");
            CreateCohort Cohort34 = new CreateCohort("Cohort 34");
            CreateCohort Cohort35 = new CreateCohort("Cohort 35");
            List<CreateCohort> cohorts = new List<CreateCohort>(){
                Cohort33,
                Cohort34,
                Cohort35
            };

            //Create 4, or more, students and assign them to one of the cohorts.
            CreateStudent Amber = new CreateStudent("Amber", "Gooch", "CodeDr", Cohort33);
            CreateStudent Allie = new CreateStudent("Allie", "Patton", "ApMod", Cohort34);
            CreateStudent Mike = new CreateStudent("Mike", "Stiles", "MovieBuff", Cohort34);
            CreateStudent Quin = new CreateStudent("Quin", "Smith", "TallDev", Cohort35);
            CreateStudent Rob = new CreateStudent("Rob", "Smith", "LDev", Cohort35);
                
            //Create 3, or more, instructors and assign them to one of the cohorts. 
            CreateInstructor Jenna = new CreateInstructor("Jenna", "Solis", "SolisOne", Cohort34, "Game of Thrones");
            CreateInstructor Steve = new CreateInstructor("Steve", "Smith", "Coach", Cohort33, "Depends");
            CreateInstructor Brenda = new CreateInstructor("Brenda", "Duarte", "TopDesigner", Cohort35, "CSS");

            List<CreateInstructor> instructors = new List<CreateInstructor>(){
                Jenna,
                Steve,
                Brenda
            };

            //Have each instructor assign 2 exercises to each of the students.
            Jenna.AssignExercise(CsharpIntro, Amber);
            Jenna.AssignExercise(ReactIntro, Amber);
            Steve.AssignExercise(ApiIntro, Allie);
            Steve.AssignExercise(ReactProject, Allie);
            Brenda.AssignExercise(CsharpIntro, Mike);
            Brenda.AssignExercise(ReactProject, Mike);
            Jenna.AssignExercise(ApiIntro, Quin);
            Jenna.AssignExercise(CsharpIntro, Quin);

            //Create a list of students. Add all of the student instances to it.
            Cohort33.Student.Add(Amber);
            Cohort34.Student.Add(Allie);
            Cohort34.Student.Add(Mike);
            Cohort35.Student.Add(Quin);
            List<CreateStudent> Students = new List<CreateStudent>(){
                Amber,
                Allie,
                Mike,
                Quin
            };


            //Create a list of exercises. Add all of the exercise instances to it.
            List<CreateExercise> Exercises = new List<CreateExercise>();
            Exercises.Add(ApiIntro);
            Exercises.Add(ReactIntro);
            Exercises.Add(ReactProject);
            Exercises.Add(CsharpIntro);

            //Generate a report that displays which students are working on which exercises.
            foreach (var Student in Students)
            {
                int i = 0;
                Console.WriteLine($"{Student.FirstName} is working on {Exercises[i].ExerciseName}");
            }

            //List exercises for the JavaScript language by using the Where() LINQ method.
            List<CreateExercise> JavaScriptExercises = Exercises.Where(Exercise => Exercise.LanguageOfExercise == "JavaScript").ToList();

            foreach (CreateExercise ex in JavaScriptExercises)
            {
                System.Console.WriteLine($"{ex.ExerciseName}");
            }
            //List students in a particular cohort by using the Where() LINQ method.
            List<CreateStudent> studentsInCohort33 = Students.Where(Student => Student.StudentCohort.CohortName == "Cohort 33").ToList();
            foreach (CreateStudent student33 in studentsInCohort33)
            {
                Console.WriteLine($"{student33.FirstName} is in cohort 33");
            }
            //List instructors in a particular cohort by using the Where() LINQ method.
            List<CreateInstructor> instructorOf33 = instructors.Where(instructor => instructor.InstructorCohort.CohortName == "Cohort 33").ToList();
            foreach (CreateInstructor teach33 in instructorOf33)
            {
                Console.WriteLine($"{teach33.FirstName} is the teacher of cohort 33");
            }
            //Sort the students by their last name.
            List<CreateStudent> studentsABC = Students.OrderBy(Student => Student.LastName).ToList();
            foreach (var l in studentsABC)
            {
                Console.WriteLine(l.LastName);
            }
            //Display any students that aren't working on any exercises (Make sure one of your student instances don't have any exercises. Create a new student if you need to.)
            List<CreateStudent> studentsWithNoWork = Students.Where(Student => Student.StudentCurrentExercise.Count == 0).ToList();
            foreach (var zeroWork in studentsWithNoWork)
            {
                Console.WriteLine(zeroWork);
            }
            //Which student is working on the most exercises? Make sure one of your students has more exercises than the others.

            //How many students in each cohort?
            Console.WriteLine($"{Cohort33.Student.Count}");
            Console.WriteLine($"{Cohort34.Student.Count}");
            Console.WriteLine($"{Cohort35.Student.Count}");

        }
    }
}
