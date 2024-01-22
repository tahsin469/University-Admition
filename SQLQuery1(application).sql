Create Database application_db

Use application_db

Create Table student_tbl
(
id Int Identity(1,1) Primary Key,
studentName Varchar(50),
fatherName Varchar(50),
fatherOccupation Varchar(50),
motherName Varchar(50),
motherOccupation Varchar(50),
dateOfBirth Varchar(50),
presentAddress Varchar(50),
permanentAddresses Varchar(50),
fatherMobileNumber BigInt,
motherMobileNumber BigInt,
legalGuardianName Varchar(50),
legalGuardianRelation Varchar(50),
legalGuardianOccupation Varchar(50),
legalGuardianMobileNumber BigInt,
nameOfTheUniversityPreviousStudied Varchar(50),
NOCnumber BigInt,
NOCdate Varchar(50),
theClassThatWantsToBeAdmitted Varchar(50),
admitionDate Varchar(50)
)

SELECT TOP (1000) [id]
      ,[studentName]
      ,[fatherName]
      ,[fatherOccupation]
      ,[motherName]
      ,[motherOccupation]
      ,[dateOfBirth]
      ,[presentAddress]
      ,[permanentAddresses]
      ,[fatherMobileNumber]
      ,[motherMobileNumber]
      ,[legalGuardianName]
      ,[legalGuardianRelation]
      ,[legalGuardianOccupation]
      ,[legalGuardianMobileNumber]
      ,[nameOfTheUniversityPreviousStudied]
      ,[NOCnumber]
      ,[NOCdate]
      ,[theClassThatWantsToBeAdmitted]
      ,[admitionDate]
  FROM [application_db].[dbo].[student_tbl]

INSERT INTO student_tbl (studentName, fatherName, fatherOccupation, motherName, motherOccupation, dateOfBirth, presentAddress, permanentAddresses, fatherMobileNumber, motherMobileNumber, legalGuardianName, legalGuardianRelation, legalGuardianOccupation, legalGuardianMobileNumber, nameOfTheUniversityPreviousStudied, NOCnumber, NOCdate, theClassThatWantsToBeAdmitted, admitionDate)
VALUES
('John Doe', 'Robert Doe', 'Engineer', 'Jane Doe', 'Teacher', '2000-01-01', '123 Main St', '456 Elm St', '1234567890', '0987654321', 'Alice Smith', 'Aunt', 'Doctor', '1122334455', 'State University', '1234', '2023-01-01', 'Grade 10', '2024-01-20'),
('Emily Clark', 'Michael Clark', 'Architect', 'Sarah Clark', 'Nurse', '2002-05-12', '789 Pine St', '321 Oak St', '2345678901', '1098765432', 'Brandon Miller', 'Uncle', 'Businessman', '2233445566', 'Tech College', '5678', '2023-02-10', 'Grade 12', '2024-01-22'),
('Sarah Johnson', 'Dave Johnson', 'Lawyer', 'Anna Johnson', 'Accountant', '2003-08-19', '654 Willow St', '987 Birch St', '3456789012', '2109876543', 'Emma Wilson', 'Family Friend', 'Teacher', '3344556677', 'Liberal Arts College', '9101', '2023-03-15', 'Grade 11', '2024-01-25'),
('Oliver Smith', 'Aaron Smith', 'Chef', 'Linda Smith', 'Writer', '2001-03-22', '234 Oak Lane', '890 Maple Rd', '4567890123', '3210987654', 'Gary Adams', 'Grandfather', 'Retired', '4455667788', 'Historical College', '2345', '2023-04-11', 'Grade 10', '2024-02-01'),
('Lucas Brown', 'George Brown', 'Photographer', 'Emily Brown', 'Designer', '2002-07-30', '567 Pine Circle', '123 Ash Blvd', '5678901234', '4321098765', 'Susan Clark', 'Godmother', 'Engineer', '5566778899', 'Science Academy', '3456', '2023-05-20', 'Grade 12', '2024-02-05'),
('Mia Turner', 'William Turner', 'Musician', 'Grace Turner', 'Librarian', '2004-04-15', '321 Cedar Ave', '654 Spruce St', '6789012345', '5432109876', 'Nora Davis', 'Sister', 'Artist', '6677889900', 'Fine Arts Institute', '7890', '2023-06-18', 'Grade 9', '2024-02-10'),
('Isaac Martin', 'Oscar Martin', 'Scientist', 'Ruby Martin', 'Doctor', '2001-11-20', '123 Birch Lane', '987 Cedar Rd', '7890123456', '6543210987', 'Leah Wilson', 'Cousin', 'Lawyer', '7788990011', 'Science & Tech High', '8912', '2023-07-22', 'Grade 10', '2024-02-15'),
('Sophia Davis', 'Ethan Davis', 'Pilot', 'Ava Davis', 'Journalist', '2002-02-28', '890 Maple St', '321 Pine Ave', '8901234567', '7654321098', 'Jack Taylor', 'Brother', 'Actor', '8899001122', 'Performing Arts School', '3457', '2023-08-30', 'Grade 12', '2024-02-20'),
('Benjamin Lee', 'Jacob Lee', 'Entrepreneur', 'Emma Lee', 'Chef', '2003-06-03', '456 Elm Street', '123 Oak Street', '9012345678', '8765432109', 'Olivia Kim', 'Aunt', 'Dentist', '9900112233', 'Business Academy', '4568', '2023-09-15', 'Grade 11', '2024-02-25'),
('Charlotte Wilson', 'Logan Wilson', 'Engineer', 'Sophie Wilson', 'Teacher', '2004-09-10', '789 Pine Road', '456 Elm Avenue', '1234567890', '0987654321', 'Luke Brown', 'Uncle', 'Architect', '1122334455', 'Technical High School', '5679', '2023-10-05', 'Grade 9', '2024-03-01');

Select * From student_tbl;

CREATE PROCEDURE spGetStudents
AS
BEGIN
  Select * From student_tbl
END

EXECUTE spGetStudents;

-- Create Stored Procedure for Inserting Data
CREATE PROCEDURE spAddStudent
	@studentName Varchar(50),
	@fatherName Varchar(50),
	@fatherOccupation Varchar(50),
	@motherName Varchar(50),
	@motherOccupation Varchar(50),
	@dateOfBirth Varchar(50),
	@presentAddress Varchar(50),
	@permanentAddresses Varchar(50),
	@fatherMobileNumber BigInt,
	@motherMobileNumber BigInt,
	@legalGuardianName Varchar(50),
	@legalGuardianRelation Varchar(50),
	@legalGuardianOccupation Varchar(50),
	@legalGuardianMobileNumber BigInt,
	@nameOfTheUniversityPreviousStudied Varchar(50),
	@NOCnumber BigInt,
	@NOCdate Varchar(50),
	@theClassThatWantsToBeAdmitted Varchar(50),
	@admitionDate Varchar(50)
AS
BEGIN
    INSERT INTO student_tbl (studentName, fatherName, fatherOccupation, motherName, motherOccupation, dateOfBirth, presentAddress, permanentAddresses, fatherMobileNumber, motherMobileNumber, legalGuardianName, legalGuardianRelation, legalGuardianOccupation, legalGuardianMobileNumber, nameOfTheUniversityPreviousStudied, NOCnumber, NOCdate, theClassThatWantsToBeAdmitted, admitionDate)
    VALUES (@studentName, @fatherName, @fatherOccupation, @motherName, @motherOccupation, @dateOfBirth, @presentAddress, @permanentAddresses, @fatherMobileNumber, @motherMobileNumber, @legalGuardianName, @legalGuardianRelation, @legalGuardianOccupation, @legalGuardianMobileNumber, @nameOfTheUniversityPreviousStudied, @NOCnumber, @NOCdate, @theClassThatWantsToBeAdmitted, @admitionDate);
END;

EXEC spAddStudent 'Charlotte Wilson2', 'Logan Wilson', 'Engineer', 'Sophie Wilson', 'Teacher', '2004-09-10', '789 Pine Road', '456 Elm Avenue', '1234567890', '0987654321', 'Luke Brown', 'Uncle', 'Architect', '1122334455', 'Technical High School', '5679', '2023-10-05', 'Grade 9', '2024-03-01';


-- Create Stored Procedure for Update Data
CREATE PROCEDURE spUpdateStudent(
    @id int,
	@studentName Varchar(50),
	@fatherName Varchar(50),
	@fatherOccupation Varchar(50),
	@motherName Varchar(50),
	@motherOccupation Varchar(50),
	@dateOfBirth Varchar(50),
	@presentAddress Varchar(50),
	@permanentAddresses Varchar(50),
	@fatherMobileNumber BigInt,
	@motherMobileNumber BigInt,
	@legalGuardianName Varchar(50),
	@legalGuardianRelation Varchar(50),
	@legalGuardianOccupation Varchar(50),
	@legalGuardianMobileNumber BigInt,
	@nameOfTheUniversityPreviousStudied Varchar(50),
	@NOCnumber BigInt,
	@NOCdate Varchar(50),
	@theClassThatWantsToBeAdmitted Varchar(50),
	@admitionDate Varchar(50)
	)
AS
BEGIN
       UPDATE student_tbl
    SET
        studentName = @studentName,
        fatherName = @fatherName,
        fatherOccupation = @fatherOccupation,
        motherName = @motherName,
        motherOccupation = @motherOccupation,
        dateOfBirth = @dateOfBirth,
        presentAddress = @presentAddress,
        permanentAddresses = @permanentAddresses,
        fatherMobileNumber = @fatherMobileNumber,
        motherMobileNumber = @motherMobileNumber,
        legalGuardianName = @legalGuardianName,
        legalGuardianRelation = @legalGuardianRelation,
        legalGuardianOccupation = @legalGuardianOccupation,
        legalGuardianMobileNumber = @legalGuardianMobileNumber,
        nameOfTheUniversityPreviousStudied = @nameOfTheUniversityPreviousStudied,
        NOCnumber = @NOCnumber,
        NOCdate = @NOCdate,
        theClassThatWantsToBeAdmitted = @theClassThatWantsToBeAdmitted,
        admitionDate = @admitionDate
    WHERE
        id = @id
END;

EXEC spUpdateStudent 1,'John Doe new', 'Robert Doe', 'Engineer', 'Jane Doe', 'Teacher', '2000-01-01', '123 Main St', '456 Elm St', '1234567890', '0987654321', 'Alice Smith', 'Aunt', 'Doctor', '1122334455', 'State University', '1234', '2023-01-01', 'Grade 10', '2024-01-20'


-- Create Stored Procedure for deleting Data
CREATE PROCEDURE spDeleteStudent
    @id INT
AS
BEGIN
    DELETE FROM Student_tbl WHERE id = @id;
END;

EXEC spDeleteStudent 14