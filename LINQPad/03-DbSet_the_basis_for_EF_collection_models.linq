<Query Kind="Statements" />

var context = new NorthwindEntities();

//DbSet and DbQuery implement IQueryable
//DbSet represents the EF model for a database table

//Region table in EF ORM is mapped to the DbContext.Regions property
//public virtual DbSet<Region> {get; set;}
//a row in the Regions table is mapped to the Region class

context.Regions.Dump();
var regionRow = context.Regions.First();
regionRow.Dump();