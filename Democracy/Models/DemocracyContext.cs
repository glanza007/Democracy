﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Democracy.Models
{
    public class DemocracyContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public DemocracyContext() : base("name=DemocracyContext")
        {
        }

        public DbSet<Data.Entities.State> States { get; set; }

        public System.Data.Entity.DbSet<Democracy.Data.Entities.Group> Groups { get; set; }

        public System.Data.Entity.DbSet<Democracy.Data.Entities.Voting> Votings { get; set; }
    }
}
