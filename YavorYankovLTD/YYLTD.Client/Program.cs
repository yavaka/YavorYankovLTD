using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YYLTD.Data;

namespace YYLTD.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new YYLTDDbContext)
            {
                db.Database.Initialize(true);
            }
        }
    }
}
