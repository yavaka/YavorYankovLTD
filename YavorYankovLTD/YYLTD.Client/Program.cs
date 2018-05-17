
namespace YYLTD.Client
{
    using System;
    using YYLTD.Data;
    using YYLTD.Models;

    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new YYLTDDbContext())
            {
                var tracker = new Tracker();
                tracker.Date = DateTime.Now.Date;
                tracker.Miles = 80;
                tracker.Route = 50;
                tracker.StopsToDeliver = 97;
                tracker.IsWork = true;

                db.Trackers.Add(tracker);
                db.SaveChanges();

                var test = db.Trackers;
                foreach (var item in test)
                {
                    Console.WriteLine(item.Date.Date);
                }
            }
            
        }
    }
}
