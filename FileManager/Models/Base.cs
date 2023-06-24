using System;

namespace FileManager.Models
{
    [Serializable]
    public abstract class Base
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public abstract long GetSize();
        public abstract int GetFatherId();
    }
}
