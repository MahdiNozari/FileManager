using System;

namespace FileManager.Models
{
    [Serializable]
    public class File : Base
    {
        public int FatherId { get; set; }
        public long Size { get; set; }

        public override int GetFatherId()
        {
            return FatherId;
        }

        public override long GetSize()
        {
            return Size;
        }
    }
}
