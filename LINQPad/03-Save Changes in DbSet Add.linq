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

//DbSet instance is a in memory collection
// filled from the database

//changes to items in the DbSet are not commited to the DB, unless .SaveChanges is callled

var nwRegion = new Region{ RegionID = 44, RegionDescription="NorthWest"};

context.Regions.Dump("Before Add");
context.Regions.Add(nwRegion);
// context.SaveChanges();
context.Regions.Dump("After Add");

