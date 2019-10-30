CREATE TABLE Cohort (
    Id INTEGER NOT NULL PRIMARY KEY IDENTITY,
    CohortName VARCHAR(50) NOT NULL,
);
CREATE TABLE Student (
    Id INTEGER NOT NULL PRIMARY KEY IDENTITY,
    FirstName VARCHAR(15) NOT NULL,
	LastName VARCHAR(20) NOT NULL,
	SlackHandle VARCHAR(25) NOT NULL,
	CohortId INTEGER NOT NULL,
	CONSTRAINT FK_Student_Cohort FOREIGN KEY(CohortId) REFERENCES Cohort(Id)
);
CREATE TABLE Instructor (
    Id INTEGER NOT NULL PRIMARY KEY IDENTITY,
    FirstName VARCHAR(15) NOT NULL,
	LastName VARCHAR(20) NOT NULL,
	SlackHandle VARCHAR(25) NOT NULL,
	Speciality VARCHAR(25) NOT NULL,
	CohortId INTEGER NOT NULL,
	CONSTRAINT FK_Instructor_Cohort FOREIGN KEY(CohortId) REFERENCES Cohort(Id)
);
CREATE TABLE Exercise (
    Id INTEGER NOT NULL PRIMARY KEY IDENTITY,
	ExerciseName VARCHAR(20) NOT NULL,
	ExerciseLanguage VARCHAR(20) NOT NULL
);
----join table
CREATE TABLE StudentExercise (
    Id INTEGER NOT NULL PRIMARY KEY IDENTITY,
	StudentId INTEGER NOT NULL,
    ExerciseId INTEGER NOT NULL,
	CONSTRAINT FK_StudentExercise_Student FOREIGN KEY(StudentId) REFERENCES Student(Id),
	CONSTRAINT FK_StudentExercise_Exercise FOREIGN KEY(ExerciseId) REFERENCES Exercise(Id),
);
----Populate each table with data. You should have 2-3 cohorts, 5-10 students, 4-8 instructors, 2-5 exercises and each
--Cohorts
INSERT INTO Cohort (CohortName) VALUES ('Cohort33');
INSERT INTO Cohort (CohortName)VALUES ('Cohort34');
INSERT INTO Cohort (CohortName)VALUES ('Cohort35');
--Student
INSERT INTO Student (FirstName,LastName,SlackHandle, CohortId) VALUES ('Amber','Gooch', 'CodeDr', 1);
INSERT INTO Student (FirstName,LastName,SlackHandle, CohortId) VALUES ('Allie','Patton', 'ApMod', 2);
INSERT INTO Student (FirstName,LastName,SlackHandle, CohortId) VALUES ('Mike','Stiles', 'MovieBuff', 2);
INSERT INTO Student (FirstName,LastName,SlackHandle, CohortId) VALUES ('Quin','Smith', 'TallDev', 3);
INSERT INTO Student (FirstName,LastName,SlackHandle, CohortId) VALUES ('Rob','Smith', 'LDev', 3);
INSERT INTO Student (FirstName,LastName,SlackHandle, CohortId) VALUES ('Joe','Snyder', 'JoeSnyds', 2);
INSERT INTO Student (FirstName,LastName,SlackHandle, CohortId) VALUES ('Bryan','Wilson', 'BYAND', 1);
--Instructor
INSERT INTO Instructor (FirstName,LastName,SlackHandle, Speciality, CohortId) VALUES ('Jenna','Solis', 'SolisOne', 'Game of Thrones', 2);
INSERT INTO Instructor (FirstName,LastName,SlackHandle, Speciality, CohortId) VALUES ('Steve','Brownlee', 'Coach', 'Google it', 1);
INSERT INTO Instructor (FirstName,LastName,SlackHandle, Speciality, CohortId) VALUES ('Brenda','Duarte', 'TopDesigner', 'CSS', 3);
INSERT INTO Instructor (FirstName,LastName,SlackHandle, Speciality, CohortId) VALUES ('Andy','Collins', 'CaptainAndy','The Pointer', 2);
INSERT INTO Instructor (FirstName,LastName,SlackHandle, Speciality, CohortId) VALUES ('Brian','Wilson', 'BWill', 'Basketball is life', 3);
--Exercise
INSERT INTO Exercise (ExerciseName, ExerciseLanguage) VALUES ('Welcome To Nashville','JavaScript');
INSERT INTO Exercise (ExerciseName, ExerciseLanguage)VALUES ('Kennel','React');
INSERT INTO Exercise (ExerciseName, ExerciseLanguage)VALUES ('Nutshell','React');
INSERT INTO Exercise (ExerciseName, ExerciseLanguage)VALUES ('Plan Heist','C#');
--StudentExercise
INSERT INTO StudentExercise (StudentId, ExerciseId)VALUES (1,4);
INSERT INTO StudentExercise (StudentId, ExerciseId)VALUES (1,2);
INSERT INTO StudentExercise (StudentId, ExerciseId)VALUES (2,1);
INSERT INTO StudentExercise (StudentId, ExerciseId)VALUES (2,3);
INSERT INTO StudentExercise (StudentId, ExerciseId)VALUES (3,1);
INSERT INTO StudentExercise (StudentId, ExerciseId)VALUES (3,2);
INSERT INTO StudentExercise (StudentId, ExerciseId)VALUES (3,4);
INSERT INTO StudentExercise (StudentId, ExerciseId)VALUES (4,1);
INSERT INTO StudentExercise (StudentId, ExerciseId)VALUES (4,4);
INSERT INTO StudentExercise (StudentId, ExerciseId)VALUES (5,1);
INSERT INTO StudentExercise (StudentId, ExerciseId)VALUES (6,3);
INSERT INTO StudentExercise (StudentId, ExerciseId)VALUES (7,2);

