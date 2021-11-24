using System.Collections.Generic;
using System.IO;

namespace Task1
{
    public class Reader
    {                
        public List<string> TextReading(string path)
        {
            List<string> reReadText = new();

            using (StreamReader sr = new(path))
            {
                string rows;
                while ((rows = sr.ReadLine()) != null)
                {
                    reReadText.Add(rows);
                }               
            }
            return reReadText;
        }
    }
}

