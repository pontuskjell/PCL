using System;
using System.Collections.Generic;
using System.Text;

namespace Data
{
   public class Case
    {
        public Guid Id { get; set; }
        public string CaseNumber { get; set; }
        public string ReleaseMonth { get; set; }
        public string TRVNumber { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ChangedDate { get; set; }
    }
}
