var dbMigrator = new DbMigrator(new Logger());

var logger = new Logger();
var installer = new Installer(logger);

dbMigrator.Migrate();

installer.Install();