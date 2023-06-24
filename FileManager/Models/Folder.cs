using System;

namespace FileManager.Models
{
    [Serializable]
    public class Folder : Base
    {
        public int FatherId { get; set; }
    }
}
