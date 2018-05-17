namespace YYLTD.Data
{
    using YYLTD.Models;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class YYLTDDbContext : DbContext
    {
        
        public YYLTDDbContext()
            : base("name=YYLTDDbContext")
        {
        }

        public virtual DbSet<Tracker> Trackers { get; set; }
    }
}