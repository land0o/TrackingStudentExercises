using System;
using System.Collections.Generic;

namespace StudentExercises
{
    public class CreateCohort
    {
        public string CohortName { get; set; }

        public List<CreateStudent> Student = new List<CreateStudent>();
        public List<CreateInstructor> Instructor = new List<CreateInstructor>();

        // constructor
        public CreateCohort(string name)
        {
            CohortName = name;
        }

    }
}