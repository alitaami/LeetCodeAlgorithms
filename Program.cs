using System.Collections.Generic;
using System.Linq;
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
        var res12 = RansomeNote2("a", "b");
        var res13 = IsValid("(){}[]");
        var res14 = ReverseInteger(123);
        var res15 = FirstMissingPositive(new int[] { 1, 2, 0 });
        var res16 = MySqrt(8);
        var res17 = MySqrt2(8);
        var res18 = SingleNumber(new int[] { 4, 1, 2, 1, 2 });
        var res19 = SingleNumber2(new int[] { 4, 1, 2, 1, 2 });
        var res20 = MyAtoi("-42");
        var res21 = Divide(10, 3);
        var res22 = WordPattern("abab", "dog dog dog dog");
        var res23 = ReverseString(new char[] { 'h', 'e', 'l', 'l', 'o' });
        var res24 = AddStrings("11", "123");
        var res25 = ValidIPAddress("172.16.254.1");
        var res26 = LargestNumber(new int[] { 10, 2 });
        var res27 = ContainsDuplicate(new int[] { 1, 2, 3, 1 });
        var res28 = Merge(new int[] { 1, 2, 3, 0, 0, 0 }, 3 , new int[] { 2, 5, 6 }, 3);

        // SQL
        var sqlProblem = CombineTwoTable();
        var sqlProblem1 = DuplicateEmails();
        var sqlProblem2 = BigCountries();
        var sqlProblem3 = SecondHighestSalary();
        var sqlProblem4 = RankScores();

        Console.WriteLine(res28);
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

    public static bool RansomeNote(string ransomNote, string magazine)
    {
        var dic = new Dictionary<char, int>();

        foreach (char c in magazine)
        {
            if (dic.ContainsKey(c))
                dic[c]++;
            else
                dic[c] = 1;
        }

        foreach (char c in ransomNote)
        {
            if (!dic.TryGetValue(c, out int value) || value is 0)
            {
                return false;
            }

            dic[c]--;
        }

        return true;
    }

    public static bool RansomeNote2(string ransomNote, string magazine)
    {
        foreach (char c in ransomNote.Distinct())
        {
            if (magazine.Count(m => m == c) < ransomNote.Count(r => r == c))
                return false;
        }

        return true;
    }

    public static bool IsValid(string s)
    {
        if (s.Length % 2 != 0)
            return false;

        Stack<char> stack = new Stack<char>();

        foreach (char c in s)
        {
            if (c == '(' || c == '{' || c == '[')
            {
                stack.Push(c);
            }
            else if (!stack.Any())
            {
                return false;
            }
            else if (c == '}')
            {
                if (stack.Pop() != '{')
                    return false;
            }
            else if (c == ']')
            {
                if (stack.Pop() != '[')
                    return false;
            }
            else if (c == ')')
            {
                if (stack.Peek() != '(')
                {
                    return false;
                }

                stack.Pop();
            }
        }

        return stack.Count() == 0;
    }

    public static int ReverseInteger(int x)
    {
        bool isNeagtive = x < 0;

        var num = isNeagtive ? x.ToString().TrimStart('-') : x.ToString();

        var array = num.ToCharArray();

        Array.Reverse(array);

        string res = string.Join("", array);

        int.TryParse(res, out int result);

        return isNeagtive ? (-1) * result : result;
    }

    public static int FirstMissingPositive(int[] nums)
    {
        var numbers = new HashSet<int>(nums);
        int output = 1;

        while (numbers.Contains(output))
        {
            output++;
        }

        return output;
    }
    public static int MySqrt(int x)
    {
        return (int)Math.Sqrt(x);
    }
    public static int MySqrt2(int x)
    {
        if (x == 1 || x == 2)
            return 1;

        for (long i = 0; i < x; i++)
        {
            if (i * i > x)
            {
                return (int)i - 1;
            }
            else if (i * i == x)
            {
                return (int)i;
            }
        }

        return 0;
    }
    public static int SingleNumber(int[] nums)
    {
        int res = 0;
        var dic = new Dictionary<int, int>();

        foreach (var num in nums)
        {
            if (!dic.ContainsKey(num))
            {
                dic[num] = 1;
            }
            else
            {
                dic[num]++;
            }
        }

        foreach (var kvp in dic)
        {
            if (kvp.Value == 1)
                res = kvp.Key;
        }

        return res;
    }
    public static int SingleNumber2(int[] nums)
    {
        var result = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            result ^= nums[i];
        }
        return result;
    }

    public static int MyAtoi(string s)
    {
        s = s.Trim();

        if (string.IsNullOrEmpty(s))
            return 0;

        StringBuilder sb = new StringBuilder();

        int sign = 1;
        if (s[0] == '-' || s[0] == '+')
        {
            sign = s[0] == '-' ? -1 : 1;
            s = s[1..];
        }

        foreach (char c in s)
        {
            if (char.IsDigit(c))
            {
                sb.Append(c.ToString());
            }

            else
                break;
        }

        s = sb.ToString();

        if (BigInteger.TryParse(s, out BigInteger bigInt))
        {
            bigInt = bigInt * (sign);

            if (bigInt >= int.MaxValue)
            {
                sign = 1;
                return int.MaxValue;
            }
            else if (bigInt <= int.MinValue)
            {
                sign = -1;
                return int.MinValue;
            }
        }

        int.TryParse(s, out int result);

        return result * sign;
    }

    public static int Divide(int dividend, int divisor)
    {
        long division = (long)dividend / divisor;

        if (division >= int.MaxValue)
            return int.MaxValue;
        else if (division <= int.MinValue)
            return int.MinValue;

        return (int)division;
    }

    public static bool WordPattern(string pattern, string s)
    {
        var ss = s.Trim().Split(' ');

        if (ss.Length != pattern.Length)
            return false;

        Dictionary<char, string> dict = new Dictionary<char, string>();

        for (int i = 0; i < pattern.Length; i++)
        {
            if (dict.TryGetValue(pattern[i], out string str))
            {
                if (str != ss[i])
                    return false;

                else
                    continue;
            }

            if (dict.ContainsValue(ss[i]))
                return false;

            else
                dict[pattern[i]] = ss[i];
        }

        return true;
    }

    public static string ReverseString(char[] s)
    {
        int left = 0;
        int right = s.Length - 1;

        while (left < right)
        {
            char t = s[left];
            s[left] = s[right];
            s[right] = t;
            left++;
            right--;
        }

        return "";
    }

    public static string AddStrings(string num1, string num2)
    {
        BigInteger.TryParse(num1, out BigInteger number1);
        BigInteger.TryParse(num2, out BigInteger number2);

        return (number1 + number2).ToString();
    }

    public static string ValidIPAddress(string queryIP)
    {
        string neither = "Neither";

        if (string.IsNullOrEmpty(queryIP))
            return neither;

        char splitChar = queryIP.Contains(':') ? ':' : '.';

        if (splitChar == '.')
        {
            var parts = queryIP.Split(splitChar);

            if (parts.Length != 4)
                return neither;

            foreach (var part in parts)
            {
                if (part.Length == 0 || part.Length > 3)
                    return neither;

                if (part.Length > 1 && part.StartsWith('0'))
                    return neither;

                if (!int.TryParse(part, out int num) || num < 0 || num > 255)
                    return neither;
            }

            return "IPv4";
        }
        else if (splitChar == ':')
        {
            var parts = queryIP.Split(splitChar);

            if (parts.Length != 8)
                return neither;

            foreach (var part in parts)
            {
                if (part.Length == 0 || part.Length > 4)
                    return neither;

                // Check if each part is a valid hexadecimal number
                foreach (char c in part)
                {
                    bool isHex = (char.IsDigit(c)) || (c >= 'a' && c <= 'f') || (c >= 'A' && c <= 'F');

                    if (!isHex)
                        return neither;
                }
            }

            return "IPv6";
        }

        return neither;
    }

    public static string LargestNumber(int[] nums)
    {
        if (nums.All(n => n == 0))
            return "0";

        var strNums = nums.Select(n => n.ToString()).ToArray();

        //If b + a (where b comes before a) is larger, then b should appear before a in the final arrangement.
        Array.Sort(strNums, (a, b) => (b + a).CompareTo(a + b));

        return string.Concat(strNums);
    }

    public static bool ContainsDuplicate(int[] nums)
    {
        var set = new HashSet<int>();

        foreach (var n in nums)
        {
            if (set.Contains(n))
            {
                return true;
            }
            else
            {
                set.Add(n);
            }
        }

        return false;
    }

    public static int[] Merge(int[] nums1, int m, int[] nums2, int n)
    {
        for (int i = 0; i < n; i++)
        {
            nums1[m + i] = nums2[i];
        }
        Array.Sort(nums1);

        return nums1;
    }

    #region SQL
    public static string CombineTwoTable()
    {
        string query = @"
                       Select 
                       p.firstName ,
                       p.lastName ,
                       a.city ,
                       a.state  
                       from  Person p 
                       left join 
                       Address a 
                       on p.personId = a.personId
                       ";
        return query;
    }
    public static string DuplicateEmails()
    {
        string query = @"SELECT distinct p.Email
                         FROM Person p
                         WHERE (SELECT COUNT(*) FROM Person pp WHERE p.Email = pp.Email) > 1;
                         ";
        return query;
    }
    public static string BigCountries()
    {
        string query = @"select 
                         w.name,
                         w.population,
                         w.area
                         from World w 
                         where w.area >= 3000000 or w.population >= 25000000 
                         ";
        return query;
    }

    public static string SecondHighestSalary()
    {
        string query = @"SELECT MAX(e.salary) AS SecondHighestSalary
                         FROM Employee e
                         WHERE e.salary < (SELECT MAX(ee.salary) FROM Employee ee);
                         ";
        return query;
    }

    public static string RankScores()
    {
        string query = @"Select 
                         s.score,
                         Dense_Rank() over (Order By s.score Desc) as Rank
                         from Scores s";
        return query;
    }
    #endregion
}