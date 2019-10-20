-- basics of SQL

-- SQL is declarative - we say what we want, not how to implement it

SELECT 1;
SELECT 1;

SELECT 2 + 3;

SELECT 'str1' + ' ' + CONVERT(VARCHAR, 2 + 3);

SELECT *
FROM Employee;

SELECT FirstName, LastName
FROM Employee;

SELECT *
FROM Employee
WHERE LEN(FirstName) <= 5;

SELECT *
FROM Employee
WHERE FirstName = 'Steve' AND LastName = 'Johnson';

SELECT 
	FirstName + ' ' + LastName AS [Full Name],
	LEN(FirstName + ' ' + LastName) AS [Length]
FROM Employee;





