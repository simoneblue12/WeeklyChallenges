using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            string lowercaseAlphabet = "abcdefghijklmnopqrstuvwxyz";
            string uppercaseAlphabet = lowercaseAlphabet.ToUpper();

            if (lowercaseAlphabet.Contains(char.ToLower(c)))
            {
                return true;
            }
            else
            {
                return false;
            }

            if (uppercaseAlphabet.Contains(char.ToUpper(c)))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            if (vals.Length % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsNumberEven(int number)
        {
            if (number % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsNumberOdd(int num)
        {
            if (num % 2 != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            if (numbers == null)
            {
                return 0;
            }
            else
            {
                double min = double.MaxValue;
                double max = double.MinValue;
                foreach (double number in numbers)
                {
                    if (number < min)
                    {
                        min = number;
                    }
                    if (number > max)
                    {
                        max = number;
                    }
                }
                if (min == double.MaxValue && max == double.MinValue)
                {
                    return 0;
                }
                else
                {
                    return min + max;
                }
            }
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            if (str1.Length < str2.Length)
            {
                return str1.Length;
            }
            else
            {
                return str2.Length;
            }
        }

        public int Sum(int[] numbers)
        {
            if (numbers == null)
            {
                return 0;
            }
            else
            {
                int sum = 0;
                for (int i = 0; i < numbers.Length; i++)
                {
                    sum += numbers[i];
                }
                return sum;
            }
        }

        public int SumEvens(int[] numbers)
        {
            if (numbers == null)
            {
                return 0;
            }
            else
            {
                int sum = 0;
                for (int i = 0; i < numbers.Length; i++)
                {
                    if (numbers[i] % 2 == 0)
                    {
                        sum += numbers[i];
                    }
                }
                return sum;
            }
        }

        public bool IsSumOdd(List<int> numbers)
        {
            while (numbers == null)
            {
                return false;
            }
            if (numbers.Count == 0)
            {
                return false;
            }
            else
            {
                int sum = 0;
                for (int i = 0; i < numbers.Count; i++)
                {
                    sum += numbers[i];
                }
                if (sum % 2 != 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            return number < 0 ? 0 : number / 2;
            if (number < 0)
            {
                return 0;
            }
            else
            {
                int count = 0;
                for (int i = 0; i < number; i++)
                {
                    if (i % 2 != 0)
                    {
                        count++;
                    }
                }
                return count;
            }
        }
    }
}
