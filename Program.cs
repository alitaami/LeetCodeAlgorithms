using System.Collections.Generic;
using System.Numerics;
using System.Text;

public class Solution
{
    public static void Main(string[] args)
    {
        var res1 = RemoveDuplicates(new int[] { 1, 1, 1, 2, 2, 3 });
        var res2 = CanJump(new int[] { 1, 2 });
        var res3 = LengthOfLastWord("  fly me   to   the moon  ");
        var res4 = TwoSum(new int[] { 2, 7, 11, 15 }, 9);
        var res5 = TwoSum2(new int[] { 3, 3 }, 6);
        var res6 = LengthOfLongestSubstring("dvdf");
        var res7 = FindMedianSortedArrays(new int[] { 1, 2, 3, 4, 5 }, new int[] { 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17 });
        var res8 = MaxArea(new int[] { 1, 8, 6, 2, 5, 4, 8, 3, 7 });
        var res9 = RemoveDuplicates2(new int[] { 1, 1, 2 });
        var res10 = RemoveElement(new int[] { 3, 2, 2, 3 }, 3);
        var res11 = SearchInsert(new int[] { 1, 3, 5 }, 3);

        Console.WriteLine(res10);
    }
    public static int SearchInsert(int[] nums, int target)
    {
        Array.Sort(nums);
        int result = 0;
        int length = nums.Length;
        int left = 0;
        int right = 0;

        if (nums.Any(n => n.Equals(target)))
        {
            result = nums.ToList().IndexOf(target);
        }
        else
        { 
            for (int i = 0; i < length; i++)
            {
                if (target < nums[i])
                {
                    return i;
                }
                else if (i + 1 >= length)
                {
                    return length;
                }
                else
                {
                    left = i;
                    right = i + 1;

                    if (nums[left] < target && target < nums[right])
                    {
                        return i + 1;
                    }

                    continue;
                }
            }
        }

        return result;
    }
    public static int RemoveDuplicates(int[] nums)
    {
        Array.Sort(nums);

        var dict = new Dictionary<int, int>();

        foreach (var item in nums)
        {
            if (dict.ContainsKey(item))
            {
                if (dict[item] < 2)
                {
                    dict[item] += 1;
                }
            }
            else
            {
                dict.Add(item, 1);
            }
        }

        return dict.Sum(d => d.Value);
    }

    public static int LengthOfLastWord(string s)
    {
        return s.Trim().Split(' ').Last().Length;
    }

    public static bool CanJump(int[] nums)
    {
        int length = nums.Length - 1;

        if (length is 0)
            return true;

        for (int i = 1; i <= length; i++)
        {
            if (nums[i] + i >= length)
                return true;

            else if (i == length - 1)
                return nums[i] + i == length;

            else
                if (nums[i] + i < length)
                i = nums[i] + i - 1;
        }

        return false;
    }

    public static int[] TwoSum(int[] nums, int target)
    {
        var result = new int[2];

        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = i + 1; j < nums.Length; j++)
            {
                if (nums[j] + nums[i] == target)
                    result = [i, j];

                continue;
            }
        }
        return result;
    }

    public static int[] TwoSum2(int[] nums, int target)
    {
        var dict = nums
        .Select((value, index) => new { value, index })
        .ToDictionary(x => x.index, x => x.value);

        foreach (var item in dict)
        {
            var neededDiff = target - item.Value;

            var temp = dict.Where(d => d.Key != item.Key).ToDictionary();

            if (temp.ContainsValue(neededDiff))
            {
                int first = temp.FirstOrDefault(d => d.Value.Equals(neededDiff)).Key;
                int second = item.Key;

                return [first, second];
            }
            else
                continue;
        }

        return [0, 0];
    }

    public static int LengthOfLongestSubstring(string s)
    {
        if (s.Length == 0)
            return 0;

        var set = new HashSet<char>();
        int maxLength = 0;
        int start = 0;

        for (int i = 0; i < s.Length; i++)
        {
            // If character is in set, remove from the start until it's unique
            while (set.Contains(s[i]))
            {
                set.Remove(s[start]);
                start++;
            }

            // Add the current character to the set
            set.Add(s[i]);

            // Calculate the current length of the substring and update maxLength
            maxLength = Math.Max(maxLength, i - start + 1);
        }

        return maxLength;
    }

    public static double FindMedianSortedArrays(int[] nums1, int[] nums2)
    {
        double result = 0;
        int medianIndex = 0;
        int[] nums = new int[nums1.Length + nums2.Length];
        Array.Copy(nums1, nums, nums1.Length);
        Array.Copy(nums2, 0, nums, nums1.Length, nums2.Length);
        Array.Sort(nums);

        int length = nums.Length;

        if (length % 2 == 0)
        {
            medianIndex = length / 2;
            result = (nums[medianIndex] + nums[medianIndex - 1]) / 2.0;
        }
        else
        {
            medianIndex = nums.Length is 1 ? length - 1 : (int)(length / 2.0);
            result = nums[medianIndex];
        }

        return result;
    }

    public static int MaxArea(int[] height)
    {
        int left = 0;
        int right = height.Length - 1;
        int maxArea = 0;

        while (left < right)
        {
            // Calculate the area between the two pointers
            int area = Math.Min(height[left], height[right]) * (right - left);
            maxArea = Math.Max(maxArea, area);

            if (height[left] < height[right])
            {
                left++;
            }
            else
            {
                right--;
            }
        }

        return maxArea;
    }

    public static int RemoveDuplicates2(int[] nums)
    {
        int[] distinctNums = nums.Distinct().ToArray();
        for (int i = 0; i < distinctNums.Length; i++)
        {
            nums[i] = distinctNums[i];
        }
        return distinctNums.Length;
    }

    public static int RemoveElement(int[] nums, int val)
    {
        int j = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            if (!nums[i].Equals(val))
                nums[j] = nums[i];
            j++;
        }
        return j;
    }

}