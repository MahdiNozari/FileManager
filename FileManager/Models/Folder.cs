using System;

namespace FileManager.Models
{
    [Serializable]
    public class Folder : Base
    {
        public int FatherId { get; set; }

        public override int GetFatherId()
        {
            return FatherId;
        }

        public override long GetSize()
        {
            return 0;
        }
    }
}
