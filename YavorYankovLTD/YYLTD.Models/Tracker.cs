using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YYLTD.Models
{
    public class Tracker
    {
        [Key]
        public int TrackerId { get; set; }

        public DateTime Date { get; set; }

        public short ?Route { get; set; }

        public short ?Miles { get; set; }

        public short ?StopsToDeliver { get; set; }

        public bool IsWork { get; set; }
    }
}
