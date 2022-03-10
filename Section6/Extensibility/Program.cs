var dbMigrator = new DbMigrator(new ConsoleLogger());

dbMigrator.Migrate();

var anotherMigrator = new DbMigrator(new FileLogger("/Users/matildamared/Documents/programming/c#/CSharpIntermediate/section6/Extensibility/log.txt"));
anotherMigrator.Migrate();