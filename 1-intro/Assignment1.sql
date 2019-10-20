--Basic Exercises

SELECT 
	FirstName, LastName, CustomerId, Country
FROM
	Customer
WHERE
	Country != 'USA'
	-- Exercise 2
SELECT
	FirstName, LastName
FROM
	Customer
WHERE 
	Country = 'brazil';

	-- Exercise 3
SELECT
	*
FROM
	Employee
WHERE 
	Title LIKE '%Sales%Agent%';

	--Exercise 4 
-- 4. show a list of all countries in billing addresses on invoices.

SELECT DISTINCT
	BillingCountry
FROM
	Invoice

-- Exercise 5

SELECT COUNT(BillingCountry), SUM(Total)
FROM
	Invoice
WHERE
	'2009-12-30' > InvoiceDate AND InvoiceDate > '2009-01-01'
--SELET
	--SUM(Total) AS TotalAmount, COUNT(InvoiceID) AS InvoicesIn2019
--FROM
	--Invoice
--WHERE InvoiceData BETWEEN 2009 AND 2010
	
-- Exercise 6 how many line items were there for invoice #37?

SELECT
	*
FROM 
	Invoice
WHERE
	InvoiceId = 37

-- Exercise 7 how many invoices per country?

SELECT 
	BillingCountry,COUNT(BillingCountry) as '# of invoices'
FROM 
	Invoice
GROUP BY
	BillingCountry

-- Exercis 8 show total sales per country, ordered by highest sales first.
 select i.billingcountry, sum(total) as 'TotalSales'
from invoice as i
group by billingcountry
order by totalsales desc

SELECT Invoice.BillingCountry,SUM(Total) AS 'Total Sales'
FROM Invoice
GROUP BY BillingCountry
ORDER BY 'Total Sales' DESC
