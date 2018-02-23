using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_8_StringToInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "-1.5";
            Solution s1 = new Solution();
            Console.Write(s1.MyAtoi(input));
            Console.WriteLine();
            Console.Write(Int32.MaxValue);
            Console.WriteLine();
            Console.Write(Int32.MinValue);
            var a = Console.ReadKey();
        }
    }
    public class Solution
    {
        public int MyAtoi(string str)
        {
            int sign = 1;
            int result = 0; 
            string input = str.TrimStart();
            for ( int i = 0; i < input.Length; i++ )
            {
                int temp = SingleChar(input[i]);
                if ( i == 0 )
                {
                    if (temp == 11)
                    {
                        sign = -1;
                    }
                    else if (temp < 0)
                    {
                        return result;
                    }
                    else if (temp < 10)
                    {
                        result = temp;
                    }
                }
                else
                {
                    if (temp < 10 && temp >=0 )
                    {
                        try
                        {
                            result = checked(result * 10 + temp* sign);
                        }
                        catch(OverflowException)
                        {
                            if (sign > 0 )
                            {
                                return Int32.MaxValue;
                            }
                            else
                            {
                                return Int32.MinValue;
                            }
                        }
                    }
                    else
                    {
                        break;
                    }
                }
            }
            return result;
        }
        public int SingleChar(char s)
        {
            switch (s)
            {
                case '1':
                    return 1;
                case '2':
                    return 2;
                case '3':
                    return 3;
                case '4':
                    return 4;
                case '5':
                    return 5;
                case '6':
                    return 6;
                case '7':
                    return 7;
                case '8':
                    return 8;
                case '9':
                    return 9;
                case '0':
                    return 0;
                case '+':
                    return 10;
                case '-':
                    return 11;
                default:
                    return -1;
            }
        }
    }
}
