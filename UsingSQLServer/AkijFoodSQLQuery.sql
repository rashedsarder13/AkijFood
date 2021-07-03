/****** Script for SelectTopNRows command from SSMS  ******/
SELECT TOP (1000) [intColdDrinksId]
      ,[strColdDrinksName]
      ,[numQuantity]
      ,[numUnitPrice]
  FROM [dbAkijFood].[dbo].[tblColdDrinks]
  INSERT INTO tblColdDrinks(strColdDrinksName,numQuantity,numUnitPrice)VALUES('Clemon',450,20);
  INSERT INTO tblColdDrinks(strColdDrinksName,numQuantity,numUnitPrice)VALUES('Frutika',500,25);
  INSERT INTO tblColdDrinks(strColdDrinksName,numQuantity,numUnitPrice)VALUES('Speed',600,30);

  --API 01
  INSERT INTO tblColdDrinks(strColdDrinksName,numQuantity,numUnitPrice)VALUES('Mojo',575,15);
  --API 02
  UPDATE tblColdDrinks SET numUnitPrice=35 WHERE strColdDrinksName='Frutika';
  --API 03
  DELETE FROM tblColdDrinks WHERE strColdDrinksName='Speed';
  --API-04
  SELECT strColdDrinksName FROM tblColdDrinks;
  --API 05
  DELETE FROM tblColdDrinks WHERE numQuantity<500;
  --API 06
  SELECT SUM(numQuantity * numUnitPrice) AS Total_of_Products FROM tblColdDrinks;