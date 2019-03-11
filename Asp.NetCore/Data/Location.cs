using System;
using System.Collections.Generic;
using System.Text;

namespace Data
{
    public class Location
    {
        public Guid LocationID { get; set; }
        public int LocationCode { get; set; }
        public string Fullname { get; set; }
        public ICollection<Application>  Applications { get; set; }
    }
}
