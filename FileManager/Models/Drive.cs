using System;

namespace FileManager.Models
{
    [Serializable]
    public class Drive : Base
    {
        public string Label { get; set; }
        public long Size { get; set; }
    }
}
