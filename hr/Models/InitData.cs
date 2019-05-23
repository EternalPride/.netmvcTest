using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace hr.Models
{
    public class InitData
    {
        public IEnumerable<Class> AcXH { get; set; }
        public IEnumerable<Achievement> ID { get; set; }
        public InitData()
        {
            OTSEntities db = new OTSEntities();
            AcXH = db.Class.ToList();
            ID = db.Achievement.ToList();

        }
    }
}