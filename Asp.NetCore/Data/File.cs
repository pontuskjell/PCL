using System;
using System.Collections.Generic;
using System.Text;

namespace Data
{
    public class File
    {
        public Guid FileID { get; set; }
        public string FileName { get; set; }
        public byte[] FileData { get; set; }
        public Information Information { get; set; }
    }
}
