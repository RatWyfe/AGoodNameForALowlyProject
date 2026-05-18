using System;
using System.IO;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using RataTat;

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
            char[] split;
            for (int i = 0; i < filecontents.Length; i++)
            {
                if (filecontents[i].StartsWith("-"))
                {
                    StringManipulation Counter = new StringManipulation();
                    split = (Counter.Substring(filecontents[i], 1, filecontents[i].Length - 1).ToCharArray());
                    if (Convert.ToInt32(split) == index)
                    {
                        return (i);
                    }
                }
            }
            return -1;
        }
    }
    public class FileWriter
    {
        internal void FileWrite(string filename, string[] content)
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
                    FileTools TemporaryObject2 = new FileTools();
                    int position = TemporaryObject2.Fileindexfind(filecontents, index);
                    if (position != -1)
                    {
                        StreamReader reader = new StreamReader(filename);
                        string reWrite;
                        for (int i = 0; i < position + 4; i++)
                        {
                            reWrite = reader.ReadLine();
                            if (i >= position)
                            {
                                foundindex[i - position] = reWrite;
                            }
                        }
                    }
                    return foundindex;
                }
                else
                {
                    File.Create(filename).Close();
                }
            }
            return foundindex;
        }
    }
}
