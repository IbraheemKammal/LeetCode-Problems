using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Problems
{
    internal class TwoSum
    {
        public int[] Do(int[] nums, int target)
        {
            int[] result = new int[2];
            int firstIndex = 0, secondIndex;
            for (; firstIndex < nums.Length; firstIndex++)
            {
                int current = nums[firstIndex];
                int currentTargetReminder;
                currentTargetReminder = target - current;

                secondIndex = Array.IndexOf(nums, currentTargetReminder);
                if (secondIndex != -1 && firstIndex != secondIndex)
                {
                    result = new int[] { firstIndex, secondIndex };
                    break;
                }
            }
            return result;

        }
    }
}
