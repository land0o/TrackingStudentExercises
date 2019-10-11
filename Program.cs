using System;
using System.Collections.Generic;

namespace StudentExercises
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Create 4, or more, exercises.
            CreateExercise ApiIntro = new CreateExercise("Welcome To Nashville", "Javascript");
            CreateExercise ReactIntro = new CreateExercise("Kennel", "React");
            CreateExercise ReactProject = new CreateExercise("Nutshell", "React");
            CreateExercise CsharpIntro = new CreateExercise("Plan Heist", "C#");

            // Create 3, or more, cohorts. 
            CreateCohort Cohort33 = new CreateCohort("Cohort 33");
            CreateCohort Cohort34 = new CreateCohort("Cohort 34");
            CreateCohort Cohort35 = new CreateCohort("Cohort 35");

            //Create 4, or more, students and assign them to one of the cohorts.
            CreateStudent Amber = new CreateStudent("Amber", "Gooch", "CodeDr", Cohort33);
            CreateStudent Allie = new CreateStudent("Allie", "Patton", "ApMod", Cohort34);
            CreateStudent Mike = new CreateStudent("Mike", "Stiles", "MovieBuff", Cohort34);
            CreateStudent Quin = new CreateStudent("Quin", "Smith", "TallDev", Cohort35);

            //Create 3, or more, instructors and assign them to one of the cohorts. 
            CreateInstructor Jenna = new CreateInstructor("Jenna", "Solis", "SolisOne", Cohort34, "Game of Thrones");
            CreateInstructor Steve = new CreateInstructor("Steve", "Smith", "Coach", Cohort33, "Depends");
            CreateInstructor Brenda = new CreateInstructor("Brenda", "Duarte", "TopDesigner", Cohort35, "CSS");

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
            // CreateCohort.Student.Add(Amber);
        }
    }
}
