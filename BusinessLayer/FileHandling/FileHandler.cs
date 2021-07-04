using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace BusinessLayer
{
    public class FileHandler
    {
        FileStream _file;

        public string Path { get; set; }

        //public FileHandler(string path)
        //{
        //    Path = path + @"\FileIO.csv";
        //}

        public void Write(Developer dev)
        {
            _file = new FileStream(Path, FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter writer = new StreamWriter(_file);
            writer.WriteLine($"Developer Name,TechStackCount");
            writer.WriteLine($"{dev.DeveloperName},{dev.TechStack.Count + Environment.NewLine}\n\r");
            writer.Close();
        }

        public string Read()
        {
            string fileOutput = string.Empty;
            if (File.Exists(Path))
            {
                _file = new FileStream(Path, FileMode.Open, FileAccess.Read);
                StreamReader reader = new StreamReader(_file);
                while(!reader.EndOfStream) fileOutput += reader.ReadLine() + Environment.NewLine;
                reader.Close();
            }
            return fileOutput;
        }

    }
}
