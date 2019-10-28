using System;
using System.Collections.Generic;

namespace StudentExercises
{
    public class CreateInstructor : NSSPerson
    {
        // properties field 
        // public string FirstName { get; set; }
        // public string LastName { get; set; }
        // public string SlackHandle { get; set; }
        public CreateCohort InstructorCohort { get; set; }
        public string InstructorSpecialty { get; set; }

        public void AssignExercise(CreateExercise exercise, CreateStudent student)
        {
            student.AddExercise(exercise);
        }

        // constructor
        public CreateInstructor(string _firstName, string _lastName, string _slackHandle, CreateCohort Cohort, string _instructorSpecialty)
        {
            FirstName = _firstName;
            LastName = _lastName;
            SlackHandle = _slackHandle;
            InstructorCohort = Cohort;
            InstructorSpecialty = _instructorSpecialty;
        }
    }
}