using System;
using System.Collections.Generic;
using System.Text;

namespace Data
{
    public class Application
    {
        public DateTime ChangedDate { get; set; }
        public int AnnouncedNumber { get; set; }
        public int TechnicalNumber { get; set; }
        public int TrainID { get; set; }
        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }
        public string DepartureDays { get; set; }
        public string Replacement { get; set; }
        public string UppcommingIntermission { get; set; }
        //borde inte vara string utan en user?
        public string ChangedBy { get; set; }
        public DateTime DepatureTime { get; set; }
        public DateTime ArrivalTime { get; set; }
        public bool Released { get; set; }
        public bool ChangedAfterRelease { get; set; }
        public TrainType TrainType { get; set; }
        public ChangeType ChangeType { get; set; }
        public virtual ICollection<Status> Statuses { get; set; }
        public Location ToLocation { get; set; }
        public Location FromLocation { get; set; }
        public Route Route { get; set; }
        public Cause Cause { get; set; }
        public Case Case { get; set; }
    }
}
