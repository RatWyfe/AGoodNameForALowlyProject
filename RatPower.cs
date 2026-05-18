using System;
using System.Threading;

namespace RataTat
{
    public class StringManipulation
    {
        public string Substring(string input, int begin, int length)
        {
            // st/ring- 6 length 5 begin 2
            if (input.Length - begin - length < 0)
            {
                throw new IndexOutOfRangeException();
            }
            else
            {
                char[] converthold = new char[length];
                for (int i = 0; i < length; i++)
                { // String "string" 0 then start at s if 1 start at t
                    converthold[i] = input[begin + i];
                }
                return new string(converthold);
            }
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