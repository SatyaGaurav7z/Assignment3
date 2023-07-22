using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Assign3json.Models
{
    public class Filehelper
    {
        public static string Read(string filePath)
        {
            if (File.Exists(filePath))
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    return reader.ReadToEnd();
                }
            }
            return string.Empty;
        }

        // WRITE FILE
        public static void Write(string filePath, string text, bool append = true)
        {
            using (StreamWriter writer = new StreamWriter(filePath, append: append))
            {
                writer.Write(text);
            }
        }
    }
}
