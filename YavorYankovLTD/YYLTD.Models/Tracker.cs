using System;

namespace ClassLibrary1
{
    public class Tracker
    {
        public int Id { get; set; }

        public DateTime Date { get; set; }

        public short Route { get; set; }

        public short Miles { get; set; }

        public DateTime StartIn { get; set; }

        public DateTime EndIn { get; set; }

        public short StopsToDeliver { get; set; }

        public bool IsWork { get; set; }
    }
}