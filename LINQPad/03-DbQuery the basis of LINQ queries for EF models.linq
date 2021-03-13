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

// DbSet and DbQuery implements IQueryable
// DbQuery represents a non-generic LINQ to Entities query against a DbContext (EF 6.x)
// EF Core 2.1, useful to represent non-updateable database Views
// EF Core 3, removed from EF

// EF 6

context.Regions.Dump();

var q1 = from r in context.Regions
 		           where r.RegionID == 2
				   select r;
				   
q1.Dump();
