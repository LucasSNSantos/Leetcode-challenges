using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions.Solutions
{
    public class SolutionSumTwoNumbers
    {
        public int[] TwoSum(int[] nums, int target)
        {
            int choosenIndex = 0;
            int lenght = nums.Length;
            int[] answer = new int[2];
            bool hasAnswer = false;

            while (choosenIndex < lenght)
            {
                int index;
                for (index = 0; index < lenght; index++)
                {
                    if (choosenIndex != index)
                    {
                        if (nums[choosenIndex] + nums[index] == target)
                        {
                            answer[0] = choosenIndex;
                            answer[1] = index;
                            hasAnswer = true;
                            break;
                        }
                    }
                }
                index = 0;
                choosenIndex++;
                if (hasAnswer) { break; }
            }
            return answer;
        }
    }
}
