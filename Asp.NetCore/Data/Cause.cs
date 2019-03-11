using System;
using System.Collections.Generic;
using System.Text;

namespace Data
{
    public class Cause
    {
        public Guid CauseID { get; set; }
        public string TypeName { get; set; }
        public ICollection<Application> Applications { get; set; }
        public ICollection<Information> Information { get; set; }
    }
}
