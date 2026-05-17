using System;
using System.IO;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CarlasTextFileToolUwU
{
    public class FileTools
    {
        internal (string[], bool) FileReader(string filename)
        {
            if (FileCheck(filename) == true)
            {
                return (File.ReadAllLines(filename), true);
            }
            else
            {
                return (new string[] { "" }, false);
            }
        }
        private bool FileCheck(string filename)
        {
            if (File.Exists(filename))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        internal int Fileindexfind(string[] filecontents, int index)
        {
            char[] split = { '-', '1' };
            for (int i = 0; i < filecontents.Length; i++)
            {
                // read files
                if (filecontents[i].StartsWith("-"))
                {
                    if (filecontents[i].Length > 1)
                    {
                        split = new char[filecontents[i].Length - 1];
                    }
                    // looks for -
                    // splits into character array
                    for (int j = 0; j + 1 < filecontents[j].Length; j++)
                    {   // now we just ignore the first character aka the "-" and looking whats after it
                        split[j] = Convert.ToChar(filecontents[j + 1]);
                    }
                }
            }
            return Convert.ToInt32(Convert.ToString(split));
        }
    }
    public class FileWriter
    {
        public void FileWrite(string filename, string[] content)
        {
            File.WriteAllLines(filename, content);
        }
    }
    public class UserFileTools
    {
        public string[] GetIndex(int index, string filename)
        {
            FileTools TemporaryObject = new FileTools();
            var (filecontents, check) = TemporaryObject.FileReader(filename);
            string[] foundindex = new string[4];
            if (filecontents != null)
            {
                if (check == true)
                {

                    return foundindex;
                }
            }
            return foundindex;
        }
    }
}
