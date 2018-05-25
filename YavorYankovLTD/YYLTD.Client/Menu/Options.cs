using System;
using YYLTD.Data;
using YYLTD.Models;

namespace YYLTD.Client
{
    public class Options
    {
        #region AddJourney
        public static void AddJourney()
        {
            Console.Clear();

            using (var db = new YYLTDDbContext())
            {
                Tracker journey = NewJourney();

                db.Trackers.Add(journey);
                db.SaveChanges();
            }
        }

        private static Tracker NewJourney()
        {
            var journey = new Tracker();
            //Current date
            journey.Date = DateTime.Now.Date;
            Console.WriteLine(journey.Date);

            //Is working on that day?
            Console.Write("Do you work on that day? Y/N : ");
            var isWork = Console.ReadLine();

            if (isWork.ToLower() == "y")
            {
                journey.IsWork = true;
                
                Console.Write("Route : ");
                journey.Route = short.Parse(Console.ReadLine());

                Console.Write("Miles : ");
                journey.Miles = short.Parse(Console.ReadLine());

                Console.Write("Stops : ");
                journey.StopsToDeliver = short.Parse(Console.ReadLine());
            }
            else
            {
                journey.IsWork = false;
            }
            return journey;
        }
        #endregion

        #region Calendar
        public static void Calendar()
        {
            using (var db = new YYLTDDbContext())
            {
            
            }
        }
        #endregion

        public static void Exit()
        {
            Console.Clear();
        }
    }
}
