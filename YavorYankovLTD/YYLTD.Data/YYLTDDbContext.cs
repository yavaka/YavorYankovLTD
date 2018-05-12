namespace YYLTD.Data
{
    using Tracker;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class YYLTDDbContext : DbContext
    {
        
        public YYLTDDbContext()
            : base("name=YYLTDDbContext")
        {
        }

        public virtual DbSet<Tracker> MyEntities { get; set; }
    }
}