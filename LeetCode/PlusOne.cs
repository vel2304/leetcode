using System;
using System.Collections.Generic;

namespace LeetCode
{
    class PlusOne
    {
        public static void Test1()
        {
            int[] numbers = { 9, 8, 7, 6, 5, 4, 3, 2, 1, 0 };
            Solution1(numbers);
        }
        public static void Test2()
        {
            int[] numbers = { 9, 9 };
            Solution2(numbers);
        }
        public static void Test3()
        {
            int[] numbers = { 9, 9 };
            Solution3(numbers);
        }
        static int[] Solution1(int[] numbers)
        {
            long newNumber = 0;
            long multi = 1;

            for (int i = numbers.Length - 1; i >= 0; i--)
            {
                newNumber += numbers[i] * multi;
                multi *= 10;
            }

            newNumber += 1;

            long divident = newNumber;
            long divisor = 10;
            long remaider = 0;
            long res;

            List<int> result = new List<int>();

            do
            {
                res = Math.DivRem(divident, divisor, out remaider);
                result.Insert(0, (int)remaider);
                divident = res;
            } while (res != 0);

            return result.ToArray();
        }

        static int[] Solution2(int[] numbers)
        {
            int indexLastOne = numbers.Length - 1;
            int[] oneBefore = { 1 };

            if (numbers[indexLastOne] != 9)
            {
                numbers[indexLastOne] += 1;
                return numbers;
            }
            else //if (numbers[indexLastOne] == 9)
            {
                for (int i = numbers.Length - 1; i >= 0; i--)
                {
                    numbers[i] = 0;
                    int previousIndex = i - 1;

                    if (previousIndex == -1)
                    {
                        List<int> termsList = new List<int>();

                        termsList.AddRange(oneBefore);
                        termsList.AddRange(numbers);

                        return termsList.ToArray();
                    }

                    if (numbers[previousIndex] != 9)
                    {
                        numbers[previousIndex] += 1;
                        return numbers;
                    }
                }

                return numbers; //
            }
        }

        static int[] Solution3(int[] numbers)
        {
            for (int i = numbers.Length - 1; i >= 0; i--)
            {
                int result = numbers[i] + 1;
                if (result == 10)
                {
                    numbers[i] = 0;
                }
                else
                {
                    numbers[i] = result;
                    return numbers;
                }
            }

            // add 1 to the beginning of the array
            int[] newNums = new int[numbers.Length + 1];
            newNums[0] = 1;
            numbers.CopyTo(newNums, 1);
            return newNums;
        }
    }
}