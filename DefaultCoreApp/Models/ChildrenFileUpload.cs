using System;
using System.Collections.Generic;

namespace DefaultCoreApp.Models
{
    public partial class ChildrenFileUpload
    {
        public int Id { get; set; }
        public string FileName { get; set; }
        public DateTime UploadDate { get; set; }
        public byte[] FileContent { get; set; }
    }
}
