using System;
using System.Collections.Generic;
using System.Text;

namespace Data
{
    public class Information
    {
        public Guid Id { get; set; }
        public string DatePeriod { get; set; }
        public string TimePeriod { get; set; }
        public string ProblemDescription { get; set; }
        public string ChangeDescription { get; set; }
        public Case Case { get; set; }
        public ICollection<File> Files { get; set; }
        public Cause Cause { get; set; }
        public Route Route { get; set; }
    }
}
