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

// Query expression syntax
// a pass through querey, returns all rows and columns
// same as SELECT * FROM TABLE_NAME IN SQL

var q1 = from s in Shippers
		 select s;
		 
var q2 = from t in Territories
         select t;
		 
q1.Dump();
q2.Dump();

// Add mor clauses
var allProducts = from p in Products
                  select p;
				  
var filteredProducts = from p in Products 
  						where p.UnitsInStock == 0
						select p;
						
var orderedProducts = from p in Products
					  orderby p.UnitPrice
					  select p;
					  
allProducts.Dump();
filteredProducts.Dump();
orderedProducts.Dump();

// Instead of pipelining, add clauses to query expression
var manyClauses = from p in Products
					orderby p.UnitPrice
					where p.UnitsInStock == 0
					select p.ProductName;
					
manyClauses.Dump();


// Aggregation can only be used on extension methods
manyClauses.Count().Dump("Call count method");

// Where clause filters the number of rows returned
// Select clause (aka projection) filters the number of columns returned
Customers.Count().Dump("#rows in Customers");
var qx1 = from c in Customers
         where c.City.StartsWith("s")
		 select c;
		 
// Check the generated SQL, this gets all colums
qx1.Dump();

var qx2 = from c in Customers
			where c.City.StartsWith("S")
			select new {c.CompanyName, c.Address, c.City};
qx2.Dump();

// Extension Method Syntax
var qe1 = Customers.Where(c => c.City.StartsWith("S"));
qe1.Dump();

var qe2 = Customers.Where(c => c.City.StartsWith("S")).Select( c => new {c.CompanyName, c.Address, c.City});
qe2.Dump();


					
					
					