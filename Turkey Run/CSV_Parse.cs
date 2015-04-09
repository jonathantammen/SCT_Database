using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Turkey_Run
{
    class CSV_Parse
    {
        Stream filename;

        public CSV_Parse(Stream file)
        {
            this.filename = file;
        }

        public String[] read()
        {
            StreamReader sr = new StreamReader(filename);
            String[] timesList;
            timesList = new String[1024];
            int i = 0;
            while (sr.Peek() != -1)
            {
                String line = sr.ReadLine();
                if (line.Contains("Position"))
                {
                    continue;
                }
                String[] words = line.Split();
                timesList[i] = words[1].TrimEnd(',');
                i++;
            }
            return timesList;
        }
    }
}
