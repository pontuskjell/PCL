using System;
using System.Collections.Generic;
using System.Text;

namespace Data
{
    public class Status
    {
        public Guid StatusID { get; set; }
        public string TypeName { get; set; }
        public ICollection<Application> Applications { get; set; }
    }
}
