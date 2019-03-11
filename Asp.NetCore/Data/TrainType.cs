using System;
using System.Collections.Generic;
using System.Text;

namespace Data
{
   public class TrainType
    {
        public Guid TypeID { get; set; }
        public string TypeName { get; set; }
        public virtual ICollection<Application> Applications { get; set; }
    }
}
