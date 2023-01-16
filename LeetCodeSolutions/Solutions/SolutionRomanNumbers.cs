using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions.Solutions
{
    /*
     https://leetcode.com/problems/roman-to-integer/
     
     */

    public class SolutionRomanNumbers
    {   

        public int RomanToInt(string s)
        {
            char[] numbers = s.ToCharArray();
            int finalNumber = 0;

            for(int i = 0; i < numbers.Length;i++)
            {
                int digit = ConvertRomanToArabic(numbers[i]);
                finalNumber += digit;
            }

            return finalNumber;
        }



        private int RomanNumeralsSubtractions(char romanNumeral)
        {
            return 0;
        }


        private int ConvertRomanToArabic(char romanNumeral)
        {
            switch (romanNumeral)
            {
                case 'I':
                    return 1;
                case 'V':
                    return 5;
                case 'X':
                    return 10;
                case 'L':
                    return 50;
                case 'C':
                    return 100;
                case 'D':
                    return 500;
                case 'M':
                    return 1000;
                default:
                    return 0;
            }
        }
    }
}
