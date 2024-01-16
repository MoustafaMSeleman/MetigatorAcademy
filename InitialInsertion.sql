use MetigatorAcademy;
GO

 -- Inserting data for Courses
    INSERT INTO Courses (CourseName, Price) VALUES ('Mathematics', 1000.00);
    INSERT INTO Courses (CourseName, Price) VALUES ('Physics', 2000.00);
    INSERT INTO Courses (CourseName, Price) VALUES ('Chemistry', 1500.00);
    INSERT INTO Courses (CourseName, Price) VALUES ('Biology', 1200.00);
    INSERT INTO Courses (CourseName, Price) VALUES ('Computer Science', 3000.00);

	  -- Inserting data for Offices
    INSERT INTO Office (OfficeName, Location) VALUES ('Off_05', 'building A');
    INSERT INTO Office (OfficeName, Location) VALUES ('Off_12', 'building B');
    INSERT INTO Office (OfficeName, Location) VALUES ('Off_32', 'Adminstration');
    INSERT INTO Office (OfficeName, Location) VALUES ('Off_44', 'IT Department');
    INSERT INTO Office (OfficeName, Location) VALUES ('Off_43', 'IT Department');

	-- Inserting data for Instructors
    INSERT INTO Instructors (Name, Location) VALUES ('Ahmed Abdullah', 1);
    INSERT INTO Instructors (Name, Location) VALUES ('Yasmeen Mohammed', 2);
    INSERT INTO Instructors (Name, Location) VALUES ('Khalid Hassan', 3);
    INSERT INTO Instructors (Name, Location) VALUES ('Nadia Ali', 4);
    INSERT INTO Instructors (Name, Location) VALUES ('Omar Ibrahim', 5);

	INSERT INTO Sections (SectionName, CourseId, InstructorId) VALUES ('S_MA1', 1, 1);
    INSERT INTO Sections (SectionName, CourseId, InstructorId) VALUES ('S_MA2', 1, 2);
    INSERT INTO Sections (SectionName, CourseId, InstructorId) VALUES ('S_PH1', 2, 1);
    INSERT INTO Sections (SectionName, CourseId, InstructorId) VALUES ('S_PH2', 2, 3);
    INSERT INTO Sections (SectionName, CourseId, InstructorId) VALUES ('S_CH1', 3, 2);
    INSERT INTO Sections (SectionName, CourseId, InstructorId) VALUES ('S_CH2', 3, 3);
    INSERT INTO Sections (SectionName, CourseId, InstructorId) VALUES ('S_BI1', 4, 4);
    INSERT INTO Sections (SectionName, CourseId, InstructorId) VALUES ('S_BI2', 4, 5);
    INSERT INTO Sections (SectionName, CourseId, InstructorId) VALUES ('S_CS1', 5, 4);
    INSERT INTO Sections (SectionName, CourseId, InstructorId) VALUES ('S_CS2', 5, 5);
    INSERT INTO Sections (SectionName, CourseId, InstructorId) VALUES ('S_CS3', 5, 4);


	-- Inserting data for Schedules
    INSERT INTO Schedules (Title, SUN, MON, TUE, WED, THU, FRI, SAT) VALUES ('Daily', 1, 1, 1, 1, 1, 0, 0);
    INSERT INTO Schedules (Title, SUN, MON, TUE, WED, THU, FRI, SAT) VALUES ('DayAfterDay', 1, 0, 1, 0, 1, 0, 0);
    INSERT INTO Schedules (Title, SUN, MON, TUE, WED, THU, FRI, SAT) VALUES ('Twice-a-Week', 0, 1, 0, 1, 0, 0, 0);
    INSERT INTO Schedules (Title, SUN, MON, TUE, WED, THU, FRI, SAT) VALUES ('Weekend', 0, 0, 0, 0, 0, 1, 1);
    INSERT INTO Schedules (Title, SUN, MON, TUE, WED, THU, FRI, SAT) VALUES ('Compact', 1, 1, 1, 1, 1, 1, 1);

	 -- Inserting data for SectionSchedules
    INSERT INTO SectionSchedules (SectionId, ScheduleId, StartTime, EndTime) VALUES (1, 1, '08:00:00', '10:00:00');
    INSERT INTO SectionSchedules (SectionId, ScheduleId, StartTime, EndTime) VALUES (2, 3, '14:00:00', '18:00:00');
    INSERT INTO SectionSchedules (SectionId, ScheduleId, StartTime, EndTime) VALUES (3, 4, '10:00:00', '15:00:00');
    INSERT INTO SectionSchedules (SectionId, ScheduleId, StartTime, EndTime) VALUES (4, 1, '10:00:00', '12:00:00');
    INSERT INTO SectionSchedules (SectionId, ScheduleId, StartTime, EndTime) VALUES (5, 1, '16:00:00', '18:00:00');
    INSERT INTO SectionSchedules (SectionId, ScheduleId, StartTime, EndTime) VALUES (6, 2, '08:00:00', '10:00:00');
    INSERT INTO SectionSchedules (SectionId, ScheduleId, StartTime, EndTime) VALUES (7, 3, '11:00:00', '14:00:00');
    INSERT INTO SectionSchedules (SectionId, ScheduleId, StartTime, EndTime) VALUES (8, 4, '10:00:00', '14:00:00');
    INSERT INTO SectionSchedules (SectionId, ScheduleId, StartTime, EndTime) VALUES (9, 4, '16:00:00', '18:00:00');
    INSERT INTO SectionSchedules (SectionId, ScheduleId, StartTime, EndTime) VALUES (10, 3, '12:00:00', '15:00:00');
    INSERT INTO SectionSchedules (SectionId, ScheduleId, StartTime, EndTime) VALUES (11, 5, '09:00:00', '11:00:00');


	-- Inserting data for Students
    INSERT INTO Students (Name) VALUES ('Fatima Ali');
    INSERT INTO Students (Name) VALUES ('Noor Saleh');
    INSERT INTO Students (Name) VALUES ('Omar Youssef');
    INSERT INTO Students (Name) VALUES ('Huda Ahmed');
    INSERT INTO Students (Name) VALUES ('Amira Tariq');
    INSERT INTO Students (Name) VALUES ('Zainab Ismail');
    INSERT INTO Students (Name) VALUES ('Yousef Farid');
    INSERT INTO Students (Name) VALUES ('Layla Mustafa');
    INSERT INTO Students (Name) VALUES ('Mohammed Adel');
    INSERT INTO Students (Name) VALUES ('Samira Nabil');

	-- Inserting data for Enrollments
    INSERT INTO Enrollments (StudentId, SectionId) VALUES (1, 6);
    INSERT INTO Enrollments (StudentId, SectionId) VALUES (2, 6);
    INSERT INTO Enrollments (StudentId, SectionId) VALUES (3, 7);
    INSERT INTO Enrollments (StudentId, SectionId) VALUES (4, 7);
    INSERT INTO Enrollments (StudentId, SectionId) VALUES (5, 8);
    INSERT INTO Enrollments (StudentId, SectionId) VALUES (6, 8);
    INSERT INTO Enrollments (StudentId, SectionId) VALUES (7, 9);
    INSERT INTO Enrollments (StudentId, SectionId) VALUES (8, 9);
    INSERT INTO Enrollments (StudentId, SectionId) VALUES (9, 10);
    INSERT INTO Enrollments (StudentId, SectionId) VALUES (10, 10);
