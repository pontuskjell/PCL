using System;
using System.Collections.Generic;
using System.Text;

namespace Data
{
    public class Route
    {
        public Guid RouteID { get; set; }
        public int AOMR { get; set; }
        public string Name { get; set; }
        public ICollection<Application> Applications { get; set; }
    }
}
