
using System;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;

namespace WPF.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<WPF.TestDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }
    } 
}