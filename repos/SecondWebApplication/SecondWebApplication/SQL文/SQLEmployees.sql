﻿DELETE FROM Employees;

INSERT INTO Employees
Values(1, N'土井', 1, '19781025 12:30:50', 5200000, '03-0000-0000' ,1),
      (2, N'中村', 1, '19750203 12:30:50', 7000000, '042-0000-0000',1),
      (3, N'川口', 2, '19800412 13:40:30', 6000000, '06-0000-0000' ,0),
      (4, N'田中', 2, '19640408 13:40:30', 12000000,'03-0000-0000' ,1),
      (5, N'石川', 2, '19650504 17:40:30', 5000000, '050-0000-0000',1),
      (6, N'関根', 2, '19581005 15:42:30', 8000000, '080-0000-0000',0)
      
      ;

SELECT * FROM Employees;