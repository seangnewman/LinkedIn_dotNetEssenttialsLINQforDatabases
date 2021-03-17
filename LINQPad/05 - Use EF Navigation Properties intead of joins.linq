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

// DB joins are defined in the EF mapping
// In the entity classes thay are represented as Navigation properties
//Navigation properties provide a way to navigate an associateion between two entity types
// They allow you to navigate and manage relationships in both directions

//This simplifies common LINQ queries

var q2 = from o in Order_Details
          where o.Order.CustomerID == "ISLAT"
		  select o;
		  
q2.Dump();

// The DB joins are defined in the EF mapping
// this simplifies common queries
var q2_1 = from o in Order_Details
          where o.Order.CustomerID == "ISLAT"
		  select new{o.Order.Customer.CompanyName, o.Order.OrderDate, o.Product.ProductName, Employee=o.Order.Employee.FirstName + " " + o.Order.Employee.LastName};
		  
q2_1.Dump();
