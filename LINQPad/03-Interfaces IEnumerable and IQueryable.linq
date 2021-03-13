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

var context = new NorthwindEntities();

// Product is DbSet
//context.Products.GetType().Name.Dump("Products property is DbSet");

context.Products.GetType().GetInterfaces().Dump("Products property is DbSet");
// this query is DbQuery
var q = from p in Products
		select p;
		
q.GetType().Name.Dump("The query is DbQuery");

Products.Select(p => p).GetType().Name.Dump("DbQuery from Extention Method");
