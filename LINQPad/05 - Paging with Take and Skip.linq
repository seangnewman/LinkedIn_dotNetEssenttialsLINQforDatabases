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

// Use Take/Skip to get less rows without a where clause
// Take : Returns contiguous elements from the start of a sequence
// Skip bypasses elements in a sequence and then returns the remaining elements

var q1 = from p in Products
         orderby p.ProductID
		 select new {p.ProductID, p.ProductName, p.UnitPrice};
var count = q1.Count();

count.Dump("Product Count");

var pageSize = 25;
q1.Take(pageSize).Dump("First Page");
q1.Skip(pageSize).Take(pageSize).Dump("Next page");