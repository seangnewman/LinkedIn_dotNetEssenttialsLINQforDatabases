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

// SelectMany flattens a one-many relationship
// or saying it another way, it can ungroup nested sequences

Regions.Dump();

var q1 = from r in Regions
         select r.Territories;
		 
q1.Dump("4 hashset collections in result");

// Flatten and remove hashsets
var q2 = Regions.SelectMany(r => r.Territories);

q2.Dump("Flattened to a single DbQuery");
