using System;

namespace MoshIntDemos

{
    class MainClass
    {
        static void Main(string[] args)
        {
            var dbMigator = new DbMigrator(new Logger());

            var logger = new Logger();
            var installer = new Installer(logger);

            dbMigator.Migrate();

            installer.Install();
        }
    }
}
