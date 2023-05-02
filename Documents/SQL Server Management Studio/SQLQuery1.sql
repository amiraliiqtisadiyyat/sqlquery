CREATE DATABASE Course
USE Course

CREATE TABLE Groups 
(
     Id INT PRIMARY KEY IDENTITY,
	 NO NVARCHAR(5)

	 )


CREATE TABLE Students
(    
     Id INT PRIMARY KEY ,
	 FullName NVARCHAR (30),
	 Point TINYINT CHECK (Point<=100),
	 GroupId INT FOREIGN KEY REFERENCES Groups (Id)

	
	)



CREATE TABLE Exams
(
      Id INT PRIMARY KEY ,
	  SubjectName NVARCHAR (11),
	  StartDate DATETIME ,
	  EndDate DATETIME
	  )

	 CREATE TABLE StudentExams
	 (    StudentId INT PRIMARY KEY,
	      ExamId INT ,
		  ResultPoint INT 
		  )

		  
		  INSERT INTO Students 
		  VALUES
		  (1,'Nahid Hesenov',98,1),
		  (2,'Mahir Muradov',51,2),
		  (3,'Natiq Qasimov',86,3),
		  (4,'Ilham Agayev',40,4),
		  (5,'Kerem Eliyev',92,5),
		  (6,'Ayxan Abdullayev',65,6)
		 
		 ALTER TABLE Students
		 DROP COLUMN FullName
