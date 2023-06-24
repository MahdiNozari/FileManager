using System;

namespace FileManager.Models
{
    [Serializable]
    public class File : Base
    {
        public int FatherId { get; set; }
        public long Size { get; set; }
        public string SystemPath { get; set; }
    }
}
