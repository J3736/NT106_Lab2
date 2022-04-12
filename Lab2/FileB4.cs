using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace Lab2
{
    public class SaveFileB4
    {
        public static bool Save(List<SinhVien> dssv, string path)
        {
            try
            {
                FileStream fs = new FileStream(path, FileMode.Create);
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fs, dssv);
                fs.Flush();
                fs.Close();
                fs.Dispose();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static List<SinhVien> Read(string path)
        {
            List<SinhVien> dssv = new List<SinhVien>();
            FileStream fs = new FileStream(path,FileMode.Open);
            BinaryFormatter bf = new BinaryFormatter();
            object data = bf.Deserialize(fs);
            dssv = data as List<SinhVien>;
            fs.Flush();
            fs.Close();
            fs.Dispose();
            return dssv;
        }
        
    }
}
