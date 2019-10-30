--Write a query to return all student first and last names with their cohort's name.
Select FirstName, LastName, c.CohortName from Student s LEFT JOIN Cohort c on CohortId = C.Id;

--Write a query to return student first and last names with their cohort's name only for a single cohort.
Select FirstName, LastName, c.CohortName from Student s LEFT JOIN Cohort c on CohortId = C.Id 
WHERE CohortName = 'Cohort34';

--Write a query to return all instructors ordered by their last name.
Select * from Instructor ORDER BY LastName ASC;

--Write a query to return a list of unique instructor specialties.
Select DISTINCT Speciality from Instructor;

--Write a query to return a list of all student names along with the names of the exercises 
--they have been assigned. If an exercise has not been assigned, it should not be in the result.
Select FirstName, LastName, e.ExerciseName from Student s LEFT JOIN StudentExercise se on se.StudentId = s.Id 
LEFT JOIN Exercise e on se.ExerciseId = e.Id;

--Return a list of student names along with the count of exercises assigned to each student.
Select FirstName, LastName, COUNT(*)as 'Exercisenumber' from StudentExercise se LEFT JOIN Student s on se.StudentId = s.Id
Group By se.StudentId, s.FirstName, s.LastName;