using System;
using System.Threading;

namespace RataTat
{
    public class StringManipulation
    {
        public string Substring(string input, byte begin, byte length)// this is supposed to be in the newer versions so I might aswell make myself
        {
            
            if (begin < 0)
            {
                throw new ArgumentException("End index must be greater than or equal to begin index.");
            }
            char[] converthold = new char[length];
            for (int i = 0; i < input.Length; i++)
            {
                
            }
            return "";
        }
    }
    public class ConversionValidation
    {
        public int StringToInt(string input)
        {
            try
            {
                return Convert.ToInt32(input);
            }
            catch (FormatException)
            {
                throw new ArgumentException("Input string is not in a correct format.");
            }
            catch (OverflowException)
            {
                throw new ArgumentException("Input string represents a number less than MinValue or greater than MaxValue.");
            }
        }
    }
}