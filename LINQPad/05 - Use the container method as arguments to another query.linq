<Query Kind="Statements">
  <Connection>
    <ID>0ea8a6ee-d4c6-411d-9b6d-cb8dc2e97176</ID>
    <Persist>true</Persist>
    <Driver>EntityFrameworkDbContext</Driver>
    <CustomAssemblyPath>C:\Users\Sean\Source\Repos\LinkedIn_dotNetEssenttialsLINQforDatabases\ConsoleForEF\bin\Debug\ConsoleForEF.exe</CustomAssemblyPath>
    <CustomTypeName>ConsoleForEF.NorthwindEntities</CustomTypeName>
    <AppConfigPath>C:\Users\Sean\Source\Repos\LinkedIn_dotNetEssenttialsLINQforDatabases\ConsoleForEF\App.config</AppConfigPath>
  </Connection>
</Query>

// user results of a query as arguments to another query

var q1 = from p in Products
		where p.UnitPrice > 90
		select p.ProductID;
		
q1.Dump();

Order_Details.Take(10).Dump();

var productIds = q1.ToList();
// User productIds in the next query
var q2 = from o in Order_Details
		 where productIds.Contains(o.Product.ProductID)
		 select o;
		 
q2.Dump();