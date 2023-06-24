using System;

namespace FileManager.Models
{
    [Serializable]
    public class Pc : Base
    {
        public long Size { get; set; }
        public override int GetFatherId()
        {
            return 0;
        }

        public override long GetSize()
        {
            return Size;
        }
    }
}
