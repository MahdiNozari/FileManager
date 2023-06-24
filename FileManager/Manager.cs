using BehComponents;
using FileManager.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace FileManager
{
    public class Manager
    {
        private List<Base> myPc;

        public Manager()
        {
            myPc = new List<Base>();
        }

        public void Add(Base @base)
        {
            myPc.Add(@base);
        }

        public bool ReadFile(string path)
        {
            try
            {
                using (Stream stream = System.IO.File.Open(path, FileMode.Open))
                {
                    var bformatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();

                    myPc = (List<Base>)bformatter.Deserialize(stream);
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBoxFarsi.Show(ex.Message, "خطا", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Error);
                return false;
            }
        }

        public bool WriteFile(string path)
        {
            try
            {
                if (System.IO.File.Exists(path))
                {
                    System.IO.File.Delete(path);
                }
                using (Stream stream = System.IO.File.Open(path, FileMode.Create))
                {
                    var bformatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();

                    bformatter.Serialize(stream, myPc);
                }
                return true;
            }
            catch(Exception ex)
            {
                MessageBoxFarsi.Show(ex.Message, "خطا", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Error);
                return false;
            }
        }

        public List<Base> GetDrives()
        {
            return myPc.Where(x => x.GetFatherId() == 1).ToList();
        }
    }
}
