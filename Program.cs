using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml;

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
        ReverseString(new char[] { 'h', 'e', 'l', 'l', 'o' });
        var res24 = AddStrings("11", "123");
        var res25 = ValidIPAddress("172.16.254.1");
        var res26 = LargestNumber(new int[] { 10, 2 });
        var res27 = ContainsDuplicate(new int[] { 1, 2, 3, 1 });
        var res28 = Merge(new int[] { 1, 2, 3, 0, 0, 0 }, 3, new int[] { 2, 5, 6 }, 3);
        var res29 = StrStr("sasbutsad", "sad");
        var res30 = IsPalindrome("AbBa");
        var res31 = MaxProfit(new int[] { 7, 1, 5, 3, 6, 4 });
        var res32 = IsPalindrome(-121);
        var res33 = LongestCommonPrefix(new string[] { "flower", "flow", "flight" });
        var res34 = PlusOne(new int[] { 1, 2, 3 });
        var res35 = PlusOne2(new int[] { 1, 2, 3 });
        var res36 = Multiply("123456789", "987654321");

        var input = CreateList(new int[] { 1, 1, 2, 3, 3 });
        var res37 = DeleteDuplicates(input);

        var res38 = IsSymmetric(new TreeNode(1, new TreeNode(2), new TreeNode(2)));
        var res39 = HammingWeight(3);
        MoveZeroes(new int[] { 0, 0, 0, 3, 12 });

        var res40 = MissingNumber(new int[] { 2, 1 });
        var res41 = FindTheDifference("abcd", "abcde");
        var res42 = IsSubsequence("acb", "ahbgdc");
        var res43 = FindMaxConsecutiveOnes(new int[] { 1, 1, 0, 1, 1, 1 });
        var res44 = IsPerfectSquare(16);
        var res45 = WordBreak("carsanddog", new List<string> { "car", "cars", "and", "dog", "code" });
        var res46 = AddDigits(38);
        var res47 = IsUgly(6);
        var res48 = ReverseVowels("A man, a plan, a canal -- Panama");
        var res49 = FirstUniqChar("leetcode");
        var res50 = CountSegments("Hello, my name is John");
        var res51 = LongestPalindrome("abccccdd");
        var res52 = ThirdMax(new int[] { 1, 2 });
        var res53 = NumberOfArithmeticSlices(new int[] { 1, 3, 5, 7 });
        var res54 = ArrangeCoins(8);
        var res55 = FindComplement(5);
        var res56 = CheckPerfectNumber(28);
        var res57 = DetectCapitalUse("FLaG");
        var res58 = FindLUSlength("aaa", "bbb");
        var res59 = ReverseStr_2("abcdefg", 2);
        var res60 = IntegerReplacement(8);
        var res61 = FindNthDigit(11);
        var res62 = FindTargetSumWays(new int[] { 1, 1, 1, 1, 1 }, 3);
        var res63 = FindRelativeRanks(new int[] { 10, 3, 8, 9, 4 });
        var res64 = ArrayPairSum(new int[] { 1, 4, 3, 2 });
        SortColors(new int[] { 1, 1, 2, 3, 2, 0, 0 });
        var res65 = new MyHashSet();
        res65.Add(10);

        var res66 = new MyHashMap();
        res66.Put(1, 1);
        res66.Get(1);
        res66.Put(1, 2);
        res66.Remove(1);

        var res67 = ToLowerCase("HeLLO");
        var res68 = IsOneBitCharacter(new int[] { 1, 1, 1, 0 });
        var res69 = SelfDividingNumbers(1, 22);
        var res70 = FindErrorNums(new int[] { 1, 2, 2, 4 });
        var res71 = LetterCombinations("23");
        var res72 = CountDigitOne(13);
        var res73 = CompareVersion("1.01", "1.001");
        var res74 = RepeatedSubstringPattern("ab");
        var res75 = CheckRecord("PPALLP");
        var res76 = IsIsomorphic("egg", "add");
        var res77 = FindDisappearedNumbers(new int[] { 4, 3, 2, 7, 8, 2, 3, 1 });
        var res78 = IsHappy(19);
        var res79 = ReplaceWords(new string[] { "cat", "bat", "rat" }, "the cattle was rattled by the battery\"\r\nOutput: \"the cat was rat by the bat");
        var res80 = PowerfulIntegers(2, 3, 10);
        var res81 = MajorityElement(new int[] { 3, 2, 3 });
        var res82 = FindWords(new string[] { "Hello", "Alaska", "Dad", "Peace" });
        var res83 = MostCommonWord("Bob. hIt, baLl", new string[] { "hit", "bob" });
        var res84 = MajorityElement_medium(new int[] { 3, 2, 3 });
        var res85 = CanConstruct("aab", "baa");

        // SQL
        var sqlProblem = CombineTwoTable();
        var sqlProblem1 = DuplicateEmails();
        var sqlProblem2 = BigCountries();
        var sqlProblem3 = SecondHighestSalary();
        var sqlProblem4 = RankScores();
        var sqlProblem5 = FindCustomerReferee();
        var sqlProblem6 = GroupSoldProductsByTheDate();
        var sqlProblem7 = TopTravellers();
        var sqlProblem8 = ReplaceEmployeeIDWithTheUniqueIdentifier();
        var sqlProblem9 = AverageSellingPrice();
        var sqlProblem10 = PatientsWithACondition();

        Console.WriteLine(res48);
    }

    #region C#

    public static int SearchInsert(int[] nums, int target)
    {
        Array.Sort(nums);
        int? left = 0;
        int? right = 0;
        int length = nums.Length;

        for (int i = 0; i < length; i++)
        {
            left = nums[i];
            right = i + 1 == length ? null : nums[i + 1];

            if (right != null)
            {
                if (left == target)
                    return i;
                else if (right == target)
                    return i + 1;
                else if (left < target && target < right)
                {
                    return i + 1;
                }
            }
            else
            {
                if (target > left)
                    return i + 1;
            }
        }
        return 0;

    }
    public static int RemoveDuplicates(int[] nums)
    {
        int index = 1;
        if (nums.Length == 0)
            return 0;

        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i] != nums[i - 1])
            {
                nums[index] = nums[i];
                index++;
            }
        }

        return index;
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
            {
                nums[j] = nums[i];
                j++;
            }
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
            if (c == '{' || c == '(' || c == '[')
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
                if (stack.Pop() != '(')
                    return false;
            }
        }
        return stack.Count() == 0;
    }

    // Easy and Tricky :)
    public bool IsValid2(string s)
    {
        while (s.Contains("()") || s.Contains("[]") || s.Contains("{}"))
        {
            s = s.Replace("()", "").Replace("[]", "").Replace("{}", "");
        }

        return s.Length == 0;
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

    public static int SingleNumber3(int[] nums)
    {
        return nums.GroupBy(n => n)
                   .Where(g => g.Count() == 1)
                   .Select(g => g.Key)
                   .FirstOrDefault();
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

    public static bool WordPattern2(string pattern, string s)
    {
        var ss = s.Trim().Split(" ");

        if (pattern.Length != ss.Length)
            return false;

        var map = new Dictionary<char, string>();
        char P;
        string S = string.Empty;

        for (int i = 0; i < pattern.Length; i++)
        {
            P = pattern[i];
            S = ss[i];

            if (map.ContainsKey(P))
            {
                if (map[P] != S)
                    return false;
            }
            else
            {
                if (map.ContainsValue(S))
                    return false;

                map[P] = S;
            }
        }

        return true;
    }

    public static void ReverseString(char[] s)
    {
        int left = 0;
        int right = s.Length - 1;
        char temp = ' ';

        while (left < right)
        {
            temp = s[left];
            s[left] = s[right];
            s[right] = temp;

            left++;
            right--;
        }
    }

    public static string AddStrings(string num1, string num2)
    {
        BigInteger.TryParse(num1, out BigInteger number1);
        BigInteger.TryParse(num2, out BigInteger number2);

        return (number1 + number2).ToString();
    }
    public static string AddStrings2(string num1, string num2)
    {
        int i = num1.Length - 1;
        int j = num2.Length - 1;
        int carry = 0;
        var result = new StringBuilder();

        while (i >= 0 || j >= 0 || carry > 0)
        {
            int digit1 = i >= 0 ? num1[i] - '0' : 0;
            int digit2 = j >= 0 ? num2[j] - '0' : 0;

            int sum = digit1 + digit2 + carry;
            result.Append(sum % 10);
            carry = sum / 10;

            i--;
            j--;
        }

        char temp = ' ';
        int left = 0;
        int right = result.Length - 1;

        while (left < right)
        {
            temp = result[left];
            result[left] = result[right];
            result[right] = temp;
            left++;
            right--;
        }

        return result.ToString();
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

    public static bool ContainsDuplicate2(int[] nums)
    {
        var set = new HashSet<int>(nums);

        return set.Count() != nums.Length;
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

    public static int StrStr(string haystack, string needle)
    {
        for (int i = 0; i <= haystack.Length - needle.Length; i++)
        {
            if (haystack.Substring(i, needle.Length) == needle)
                return i;
        }

        return -1;
    }

    public static bool IsPalindrome(string s)
    {
        s = s.ToLower().Trim();
        StringBuilder sb = new StringBuilder();

        foreach (char c in s)
        {
            if (char.IsLetterOrDigit(c))
                sb.Append(c);
        }

        string cleanedString = sb.ToString();
        int left = 0, right = cleanedString.Length - 1;

        while (left < right)
        {
            if (cleanedString[left] != cleanedString[right])
                return false;

            left++;
            right--;
        }

        return true;
    }

    public static int MaxProfit(int[] prices)
    {
        // Dumb Way 

        //int maxProfit = 0;

        //for (int i = 0; i < prices.Length; i++)
        //{
        //    for (int j = i + 1; j < prices.Length; j++)
        //    {
        //        if (prices[j] - prices[i] > maxProfit)
        //            maxProfit = prices[j] - prices[i];
        //    }
        //}
        //return maxProfit;

        // -------------

        int maxProfit = 0;
        int minPrice = int.MaxValue;

        foreach (int price in prices)
        {
            if (price < minPrice)
            {
                minPrice = price;
            }
            else
            {
                maxProfit = Math.Max(maxProfit, price - minPrice);
            }
        }

        return maxProfit;
    }

    public static bool IsPalindrome(int x)
    {
        // -- Slow way -- 
        //var y = x.ToString().ToCharArray();
        //Array.Reverse(y); //Reverses char array.
        //return x.ToString() == new string(y);


        // -- Fast way --

        if (x < 0)
            return false;

        var number = x.ToString();

        int left = 0, right = number.Length - 1;

        while (left < right)
        {
            if (number[left] != number[right])
                return false;

            left++;
            right--;
        }

        return true;
    }

    public static string LongestCommonPrefix(string[] strs)
    {
        HashSet<string> words = new HashSet<string>(strs);
        var shortestWord = strs.MinBy(c => c.Length);

        string startsWithString = string.Empty;
        string prefix = string.Empty;

        for (int i = 0; i < shortestWord.Length; i++)
        {
            startsWithString = prefix + shortestWord[i];

            if (!words.All(c => c.StartsWith(startsWithString)))
                break;
            else
                prefix += shortestWord[i];
        }

        return prefix;
    }

    public static int[] PlusOne(int[] digits)
    {
        BigInteger number = 0;
        var stringNumber = string.Concat(digits);
        BigInteger.TryParse(stringNumber, out number);

        number += 1;

        return number.ToString()
            .Select(c => int.Parse(c.ToString()))
            .ToArray();
    }

    public static int[] PlusOne2(int[] digits)
    {
        if (digits.Last() is 9)
        {
            int carry = 1;

            for (int i = digits.Length - 1; i >= 0; i--)
            {
                digits[i] += carry;

                if (digits[i] is 10)
                {
                    digits[i] = 0;
                    carry = 1;
                }
                else
                {
                    carry = 0;
                    break;
                }
            }

            if (carry is 1)
            {
                int[] newDigits = new int[digits.Length + 1];
                newDigits[0] = 1;

                Array.Copy(digits, 0, newDigits, 1, digits.Length);

                return newDigits;
            }
        }
        else
            digits[digits.Length - 1]++;

        return digits;

    }

    public static string Multiply(string num1, string num2)
    {
        List<BigInteger> number1 = new List<BigInteger>();
        List<BigInteger> number2 = new List<BigInteger>();

        foreach (var n in num1)
            number1.Add(CharToDigit(n));

        foreach (var n in num2)
            number2.Add(CharToDigit(n));

        BigInteger combined1 = CombineDigits(number1);
        BigInteger combined2 = CombineDigits(number2);

        return (combined1 * combined2).ToString();

        int CharToDigit(char n)
        {
            switch (n)
            {
                case '0': return 0;
                case '1': return 1;
                case '2': return 2;
                case '3': return 3;
                case '4': return 4;
                case '5': return 5;
                case '6': return 6;
                case '7': return 7;
                case '8': return 8;
                case '9': return 9;
                default: throw new ArgumentException("Invalid character: " + n);
            }
        }

        BigInteger CombineDigits(List<BigInteger> digits)
        {
            BigInteger result = 0;
            foreach (var digit in digits)
                result = result * 10 + digit;
            return result;
        }
    }

    public static string Multiply2(string num1, string num2)
    {
        List<BigInteger> number1 = new List<BigInteger>();
        List<BigInteger> number2 = new List<BigInteger>();

        foreach (var n in num1)
        {
            // for example n is 5 and 53 in ASCII and 0 is 48 in ASCII  so 53-48 = 5
            if (n < '0' || n > '9')
                throw new Exception("Argument error");
            number1.Add(n - '0');
        }

        foreach (var n in num2)
        {
            if (n < '0' || n > '9')
                throw new Exception("Argument error");
            number2.Add(n - '0');
        }

        BigInteger combined1 = CombineDigits(number1);
        BigInteger combined2 = CombineDigits(number2);

        return (combined1 * combined2).ToString();

        BigInteger CombineDigits(List<BigInteger> digits)
        {
            BigInteger result = 0;
            foreach (var digit in digits)
            {
                result = result * 10 + digit;
            }
            return result;
        }
    }

    #region DeleteDuplicates
    public static ListNode DeleteDuplicates(ListNode head)
    {
        ListNode current = head;
        var uniqueNumbers = new HashSet<int>();

        while (current != null)
        {
            uniqueNumbers.Add(current.val);

            current = current.next;
        }

        ListNode result = new ListNode(0);
        ListNode resultCurrent = result;

        foreach (int val in uniqueNumbers)
        {
            resultCurrent.next = new ListNode(val);
            resultCurrent = resultCurrent.next;
        }

        return result.next;
    }

    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }
    public static ListNode CreateList(int[] values)
    {
        if (values == null || values.Length == 0) return null;

        ListNode head = new ListNode(values[0]);
        ListNode current = head;
        for (int i = 1; i < values.Length; i++)
        {
            current.next = new ListNode(values[i]);
            current = current.next;
        }
        return head;
    }

    public static List<int> ToList(ListNode head)
    {
        List<int> result = new List<int>();
        while (head != null)
        {
            result.Add(head.val);
            head = head.next;
        }
        return result;
    }
    #endregion

    #region IsSymmetric
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }

    public static bool IsSymmetric(TreeNode root)
    {
        return CheckSymmetric(root.left, root.right);

        bool CheckSymmetric(TreeNode left, TreeNode right)
        {
            if (right is null || left is null)
                return left == right;

            return (left.val == right.val) && CheckSymmetric(left.left, right.right) && CheckSymmetric(left.right, right.left);
        }
    }
    #endregion

    public static int HammingWeight(int n)
    {
        string binary = Convert.ToString(n, 2);

        return binary.Count(b => b == '1');
    }

    public static void MoveZeroes(int[] nums)
    {
        int index = 0;

        // Move non-zero elements to the front
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] != 0)
            {
                nums[index] = nums[i];
                index++;
            }
        }

        // Fill the rest with zeros
        while (index < nums.Length)
        {
            nums[index] = 0;
            index++;
        }
    }

    public static int MissingNumber(int[] nums)
    {
        Array.Sort(nums);

        if (nums[0] != 0)
            return 0;

        for (int i = 1; i < nums.Length; ++i)
        {
            if (nums[i] - nums[i - 1] > 1)
                return nums[i - 1] + 1;
        }

        return nums.Last() + 1;
    }

    public static int MissingNumber2(int[] nums)
    {
        int n = nums.Length;
        int expectedSum = n * (n + 1) / 2;
        int actualSum = nums.Sum();

        return expectedSum - actualSum;
    }

    public static char FindTheDifference(string s, string t)
    {
        var dict = new Dictionary<char, int>();

        foreach (char c in s)
            dict[c] = dict.ContainsKey(c) ? dict[c] + 1 : 1;

        foreach (char c in t)
        {
            if (!dict.ContainsKey(c) || dict[c] == 0)
                return c;

            dict[c]--;
        }

        return ' ';
    }

    public static char FindTheDifference2(string s, string t)
    {
        int sum_S = s.Sum(s => s);
        int sum_T = t.Sum(t => t);

        return (char)(sum_T - sum_S);
    }

    public char FindTheDifference3(string s, string t)
    {
        int sumS = 0, sumT = 0;

        foreach (char c in s)
            sumS += c;

        foreach (char c in t)
            sumT += c;

        return (char)(sumT - sumS);
    }

    public static bool IsSubsequence(string s, string t)
    {
        int i = 0;
        foreach (char c in t)
        {
            if (i >= s.Length)
                break;

            if (c == s[i])
            {
                i++;
            }
        }

        return i == s.Length;
    }

    public static int FindMaxConsecutiveOnes(int[] nums)
    {
        int max = 0;
        int temp = 0;

        foreach (int x in nums)
        {
            if (x is 1)
            {
                temp++;

                max = Math.Max(max, temp);
            }
            else
                temp = 0;
        }

        return max;
    }

    public static int FindMaxConsecutiveOnes2(int[] nums)
    {
        int max = 0;
        HashSet<int> maxSet = new HashSet<int>();

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] == 1)
            {
                max++;

                if (nums.Length - 1 == i)
                {
                    maxSet.Add(max);
                }
            }
            else
            {
                maxSet.Add(max);
                max = 0;
            }
        }

        return maxSet.Max();
    }

    public static bool IsPerfectSquare(int num)
    {
        if (num is 1)
            return true;

        for (int i = 1; i <= num / 2; i++)
        {
            if (i * i == num)
                return true;
        }
        return false;
    }

    public static void SortColors(int[] nums)
    {
        int index = 0, count0 = 0, count1 = 0, count2 = 0;

        foreach (int num in nums)
        {
            if (num is 0)
                count0++;
            else if (num is 1)
                count1++;
            else
                count2++;
        }

        for (int i = 0; i < count0; i++) { nums[index++] = 0; }
        for (int i = 0; i < count1; i++) { nums[index++] = 1; }
        for (int i = 0; i < count2; i++) { nums[index++] = 2; }
    }

    public static bool WordBreak(string s, IList<string> wordDict)
    {
        // it is ok for most of case 
        // TODO: finish it`s implementation

        int index = 0;

        for (int i = index; i < wordDict.Count(); i++)
        {
            if (s.Contains(wordDict[i]))
            {
                s = s.Replace(wordDict[i], string.Empty);
                index++;
            }
        }

        return s.Length == 0;
    }

    public static int AddDigits(int num)
    {
        var number = num.ToString();
        int sum = 0;

        while (number.Length > 1)
        {
            sum = 0;
            foreach (var n in number)
            {
                sum += int.Parse(n.ToString());
            }

            number = sum.ToString();
        }

        return int.Parse(number);
    }
    public static bool IsUgly(long n)
    {
        if (n <= 0) return false;

        foreach (var divisor in new[] { 2, 3, 5 })
        {
            while (n % divisor == 0)
            {
                n /= divisor;
            }
        }

        return n == 1;
    }

    public static string ReverseVowels(string s)
    {
        var text = s.ToCharArray();
        var existVowels = new List<char> { };
        var vowels = new HashSet<char> { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };

        for (int i = 0; i < text.Length; i++)
        {
            if (vowels.Contains(text[i]))
            {
                existVowels.Add(text[i]);
                text[i] = '*';
            }
        }

        int left = 0, right = existVowels.Count - 1;
        char temp = ' ';

        while (left < right)
        {
            temp = existVowels[left];
            existVowels[left] = existVowels[right];
            existVowels[right] = temp;

            left++;
            right--;
        }

        int index = 0;
        for (int j = 0; j < text.Length; j++)
        {
            if (text[j] == '*')
            {
                text[j] = existVowels[index++];
            }
        }
        return new string(text);
    }

    public static int FirstUniqChar(string s)
    {
        int minIndex = int.MaxValue;
        var dic = new Dictionary<char, int>();

        foreach (char c in s)
        {
            if (dic.ContainsKey(c))
                dic[c]++;
            else
                dic[c] = 1;
        }

        foreach (var kvp in dic.Where(d => d.Value == 1))
        {
            minIndex = Math.Min(s.IndexOf(kvp.Key), minIndex);
        }

        return minIndex == int.MaxValue ? -1 : minIndex;
    }
    public static int FirstUniqChar2(string s)
    {
        int minIndex = int.MaxValue;
        var dic = new Dictionary<char, (int count, int index)>();

        for (int i = 0; i < s.Length; i++)
        {
            if (dic.ContainsKey(s[i]))
            {
                dic[s[i]] = (dic[s[i]].count + 1, dic[s[i]].index);
            }
            else
                dic[s[i]] = (1, i);
        }

        foreach (var kvp in dic)
        {
            if (kvp.Value.count == 1)
                minIndex = Math.Min(kvp.Value.index, minIndex);
        }

        return minIndex is int.MaxValue ? -1 : minIndex;
    }

    public static int CountSegments(string s)
    {
        if (string.IsNullOrWhiteSpace(s))
            return 0;

        var text = s.Trim().Split(' ');

        return text.Count(s => s != "");
    }
    public static int CountSegments2(string s)
    {
        if (string.IsNullOrWhiteSpace(s))
            return 0;

        return s.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Length;
    }

    public static int LongestPalindrome(string s)
    {
        var set = new HashSet<char>();
        var maxLength = 0;

        foreach (var c in s)
        {
            if (set.Contains(c))
            {
                set.Remove(c);
                maxLength += 2;
            }
            else
                set.Add(c);
        }

        return set.Count > 0 ? maxLength + 1 : maxLength;
    }

    public static int ThirdMax(int[] nums)
    {
        nums = nums
                   .Select(n => n)
                   .Distinct()
                   .OrderByDescending(n => n)
                   .ToArray();

        return
            nums.Length >= 3 ? nums[2] :
            nums.Length > 0 ? nums[0] :
            0;
    }
    public static int ThirdMax2(int[] nums)
    {
        HashSet<int> set = new HashSet<int>();
        foreach (int num in nums)
        {
            set.Add(num);

            if (set.Count > 3)
                set.Remove(set.Min());
        }

        if (set.Count < 3)
            return set.Max();

        return set.Min();
    }

    public static int NumberOfArithmeticSlices(int[] nums)
    {
        int count = 0, total = 0;

        for (int i = 0; i < nums.Length - 2; i++)
        {
            if (nums[i + 1] - nums[i] == nums[i + 2] - nums[i + 1])
            {
                count++;
                total += count;
            }
            else
                count = 0;
        }

        return total;
    }

    public static int ArrangeCoins(int n)
    {
        int row = 0;
        while (n > row)
        {
            row++;
            n -= row;
        }

        return row;
    }

    public static int FindComplement(int num)
    {
        var binary = Convert.ToString(num, 2).ToCharArray();

        for (int i = 0; i < binary.Length; i++)
        {
            binary[i] = (binary[i] == '1' ? '0' : '1');
        }

        string number = new string(binary);

        return Convert.ToInt32(number, 2);
    }

    public static bool CheckPerfectNumber(int num)
    {
        if (num <= 1)
            return false;

        // The first proper divisor of every number is 1
        int sum = 1;

        // So we start from 2
        for (int i = 2; i <= num / 2; i++)
        {
            if (num % i == 0)
                sum += i;
        }

        return sum == num;
    }

    public static bool DetectCapitalUse(string word)
    {
        return word.All(c => char.IsUpper(c)) ||
               word.All(c => char.IsLower(c)) ||
               char.IsUpper(word[0]) && word.Substring(1).All(c => char.IsLower(c));
    }
    public bool DetectCapitalUse2(string word)
    {
        if (word.Length <= 1)
            return true;

        bool isFirstUpper = char.IsUpper(word[0]);
        bool isSecondUpper = char.IsUpper(word[1]);

        // Case 1: All letters must be uppercase
        if (isFirstUpper && isSecondUpper)
        {
            for (int i = 2; i < word.Length; i++)
            {
                if (!char.IsUpper(word[i]))
                    return false;
            }
            return true;
        }

        // Case 2: All letters except the first must be lowercase
        for (int i = 1; i < word.Length; i++)
        {
            if (!char.IsLower(word[i]))
                return false;
        }

        return true;
    }

    public static int FindLUSlength(string a, string b)
    {
        if (string.Equals(a, b))
            return -1;

        return Math.Max(a.Length, b.Length);
    }

    public static string ReverseStr_2(string s, int k)
    {
        if (s.Length < k)
        {
            var res = s.ToCharArray();
            Array.Reverse(res);
            return new string(res);
        }

        var sb1 = new List<char>();
        var sb2 = new List<char>();
        var sb3 = new List<char>();
        var sb4 = new List<char>();

        // Reverse first k characters
        for (int i = k - 1; i >= 0; i--)
        {
            sb1.Add(s[i]);
        }

        // If 2k ≤ s.Length
        if (s.Length >= 2 * k)
        {
            // Next k characters remain the same
            for (int i = k; i < 2 * k; i++)
            {
                sb2.Add(s[i]);
            }

            // Remaining characters: reverse every first k in 2k block
            for (int i = 2 * k; i < s.Length; i += 2 * k)
            {
                int end = Math.Min(i + k, s.Length);

                // Reverse first k characters
                for (int j = end - 1; j >= i; j--)
                {
                    sb3.Add(s[j]);
                }

                // Append next k as-is
                for (int j = end; j < Math.Min(i + 2 * k, s.Length); j++)
                {
                    sb3.Add(s[j]);
                }
            }
        }
        // If remaining < 2k but ≥ k
        else if (s.Length < 2 * k && s.Length >= k)
        {
            // Add remaining after first k in same order
            for (int i = k; i < s.Length; i++)
            {
                sb3.Add(s[i]);
            }
        }

        return new string(sb1.ToArray()) + new string(sb2.ToArray()) + new string(sb3.ToArray()) + new string(sb4.ToArray());
    }

    public static int IntegerReplacement(int n)
    {
        int counter = 0;

        if (n == int.MaxValue)
            return 32;

        while (n > 1)
        {
            if (n % 2 == 0)
            {
                n /= 2;
            }
            // 9 → 10 → 5 → 4 → 2 → 1 (4steps)❌  ,  9 → 8 → 4 → 2 → 1 (3steps)✅ 
            // 3 -> 4 -> 2 -> 1 → ❌ 3 steps  ,  3 -> 2 -> 1 → ✅ 2 steps
            else if (n == 3 || (n & 2) == 0)
            {
                n--;
            }
            else
            {
                n++;
            }

            counter++;
        }

        return counter;
    }

    public static int FindNthDigit1(int n)
    {
        List<int> digits = new List<int>();
        string number = string.Empty;

        for (int i = 1; i <= n; i++)
        {
            number = i.ToString();
            if (i > 9)
            {
                foreach (char d in number)
                {
                    if (d == '0')
                        digits.Add(int.Parse("0"));
                    else
                        digits.Add(d - '0');
                }
            }
            else
            {
                digits.Add(i);
            }
        }

        return digits[n - 1];
    }
    public static int FindNthDigit(int n)
    {
        int i = 1, counter = 0;
        string number = string.Empty;

        while (i <= n)
        {
            if (i > 9)
            {
                number = i.ToString();

                if (counter + number.Length >= n)
                {
                    return int.Parse(number[n - counter - 1].ToString());
                }
                else
                    counter += number.Length;
            }
            else
                counter++;

            i++;
        }

        return counter;

    }

    public static int FindTargetSumWays(int[] nums, int target)
    {
        int count = 0;
        int n = nums.Length;
        int totalCombinations = (int)Math.Pow(2, n);

        for (int mask = 0; mask < totalCombinations; mask++)
        {
            int sum = 0;
            List<int> combination = new List<int>();

            for (int i = 0; i < n; i++)
            {
                if (((mask >> i) & 1) == 1)
                {
                    sum += nums[i];
                    combination.Add(nums[i]);
                }
                else
                {
                    sum -= nums[i];
                    combination.Add(-nums[i]);
                }
            }

            if (sum == target)
                count++;
        }

        return count;
    }
    public static string[] FindRelativeRanks(int[] score)
    {
        var scores = score.Select(c => c.ToString()).ToArray();
        Array.Sort(score, (a, b) => b.CompareTo(a));
        var dic = new Dictionary<int, string>();

        for (int i = 0; i < score.Length; i++)
        {
            dic[score[i]] = i switch
            {
                0 => "Gold Medal",
                1 => "Silver Medal",
                2 => "Bronze Medal",
                _ => (i + 1).ToString()
            };
        }

        for (int i = 0; i < scores.Length; i++)
        {
            scores[i] = dic[(int.Parse(scores[i]))];
        }

        return scores;
    }
    // Faster and less memory usage
    public static string[] FindRelativeRanks2(int[] score)
    {
        int len = score.Length;
        var result = new string[len];
        var sortedScores = new List<int>(score).ToArray();

        Array.Sort(sortedScores, (a, b) => b.CompareTo(a));

        var dic = new Dictionary<int, string>();

        for (int i = 0; i < len; i++)
        {
            dic[sortedScores[i]] = i switch
            {
                0 => "Gold Medal",
                1 => "Silver Medal",
                2 => "Bronze Medal",
                _ => (i + 1).ToString()
            };
        }

        for (int i = 0; i < len; i++)
        {
            result[i] = dic[score[i]];
        }

        return result;
    }

    public static int ArrayPairSum(int[] nums)
    {
        Array.Sort(nums);

        int sum = 0;

        // Add every alternate number (first of each pair)
        for (int i = 0; i < nums.Length; i += 2)
        {
            sum += nums[i];
        }

        return sum;
    }

    #region Design HashSet
    // The fastest and most memory efficient solution
    public class MyHashSet
    {
        // I assigned 1000001 because the Max value in testcases is 1000000 to start BitArray from 0 to 1000000
        private BitArray array = new(1000001);

        public void Add(int key)
        => array[key] = true;

        public void Remove(int key)
        => array[key] = false;

        public bool Contains(int key)
        => array[key];
    }
    public class MyHashSet2
    {
        // I assigned 1000001 because the Max value in testcases is 1000000 to start BitArray from 0 to 1000000
        bool[] array = new bool[1000001];

        public void Add(int key)
        => array[key] = true;

        public void Remove(int key)
        => array[key] = false;

        public bool Contains(int key)
        => array[key];
    }

    public class MyHashSet3
    {
        private List<int> list = new List<int>();

        public void Add(int key)
        {
            if (!list.Contains(key))
                list.Add(key);
        }

        public void Remove(int key)
        => list.Remove(key);

        public bool Contains(int key)
        => list.Contains(key);
    }

    #endregion

    #region Design HashMap
    public class MyHashMap
    {
        (int? key, int? value)[] map = new (int?, int?)[3400]; // Max possible index according to test cases

        public void Put(int key, int value)
        {
            for (int i = 0; i < map.Length; i++)
            {
                if (map[i].key == key)
                {
                    map[i].value = value;
                    return;
                }
            }

            for (int i = 0; i < map.Length; i++)
            {
                if (map[i].key == null)
                {
                    map[i] = (key, value);
                    return;
                }
            }
        }

        public int Get(int key)
            => map.FirstOrDefault(m => m.key == key).value ?? -1;

        public void Remove(int key)
        {
            for (int i = 0; i < map.Length; i++)
            {
                if (map[i].key == key)
                {
                    map[i].value = null;
                }
            }
        }
    }

    public class MyHashMap2
    {
        int?[] map;

        public MyHashMap2()
        {
            map = new int?[1000001]; // Max number that exists in testcases
        }

        public void Put(int key, int value)
        {
            map[key] = value;
        }

        public int Get(int key)
        => map[key] ?? -1;

        public void Remove(int key)
        {
            map[key] = null;
        }
    }
    public class MyHashMap3
    {
        int[] map = new int[1000001];

        public MyHashMap3()
        {
            Array.Fill<int>(map, -1);
        }

        public void Put(int key, int value)
        {
            map[key] = value;
        }

        public int Get(int key)
        => map[key];

        public void Remove(int key)
        {
            map[key] = -1;
        }
    }

    #endregion

    public static string ToLowerCase(string s)
    => s.ToLower();

    // Fastest and most memory efficient solution
    public string ToLowerCase2(string s)
    {
        // explanation => 'a' is 97 in ASCII and 'A' is 65 in ASCII and there is a 32 digits gap between upper and lower cases
        int diff = 'a' - 'A';
        StringBuilder sb = new StringBuilder(s);

        for (int i = 0; i < sb.Length; i++)
        {
            if (char.IsUpper(sb[i]))
                sb[i] = (char)(sb[i] + diff);
        }

        return sb.ToString();
    }

    public static bool IsOneBitCharacter(int[] bits)
    {
        int i = 0;
        while (i < bits.Length - 1)
        {
            if (bits[i] == 1)
                i += 2;  // 2-bit character
            else
                i += 1;  // 1-bit character
        }
        // True if the last char is a 1-bit
        return i == bits.Length - 1;
    }

    public static IList<int> SelfDividingNumbers(int left, int right)
    {
        var list = new List<int>();
        string temp = string.Empty;

        while (left <= right)
        {
            temp = left.ToString();

            if (left < 10)
                list.Add(left);
            else if (!temp.Contains('0'))
            {
                bool flag = true;
                foreach (var n in temp)
                {
                    if (n != '0')
                        if (left % (n - '0') != 0)
                        {
                            flag = false;
                            break;
                        }
                }

                if (flag)
                    list.Add(left);
            }

            left++;
        }

        return list;
    }
    public static IList<int> SelfDividingNumbers2(int left, int right)
    {
        var list = new List<int>();
        string temp = string.Empty;

        for (int i = left; i <= right; i++)
        {
            temp = i.ToString();

            for (int j = 0; j < temp.Length; j++)
            {
                if (temp[j] == '0')
                    break;
                if (i % (temp[j] - '0') != 0)
                    break;
                if (j == temp.Length - 1)
                {
                    list.Add(i);
                }
            }
        }

        return list;
    }

    public static int[] FindErrorNums(int[] nums)
    {

        var set = new HashSet<int>();
        int duplicate = 0;

        foreach (int i in nums)
        {
            if (!set.Contains(i))
            {
                set.Add(i);
            }
            else
            {
                duplicate = i;
                break;
            }
        }

        int actualSum = nums.Sum();
        int expectedSum = nums.Length * (nums.Length + 1) / 2;

        int missing = expectedSum + duplicate - actualSum;

        return new int[] { duplicate, missing };
    }
    public static int[] FindErrorNums2(int[] nums)
    {
        int[] result = new int[2];
        int[] array = new int[nums.Length + 1];
        int duplicate = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            array[nums[i]]++;

            // If the count of the number is greater than 1, it is a duplicate
            if (array[nums[i]] > 1)
            {
                duplicate = nums[i];
            }
        }

        result[0] = duplicate;

        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] == 0)
            {
                result[1] = i;

                break;
            }
        }

        return result;
    }

    public static IList<string> LetterCombinations(string digits)
    {
        if (string.IsNullOrEmpty(digits))
            return new List<string>();

        Dictionary<char, string> map = new Dictionary<char, string>
        {
            {'2', "abc"}, {'3', "def"}, {'4', "ghi"}, {'5', "jkl"},
            {'6', "mno"}, {'7', "pqrs"}, {'8', "tuv"}, {'9', "wxyz"}
        };

        var result = new List<string>();

        if (digits.Length == 1)
        {
            foreach (char c in map[digits[0]])
                result.Add($"{c}");
        }
        else if (digits.Length == 2)
        {
            foreach (char c1 in map[digits[0]])
                foreach (char c2 in map[digits[1]])
                    result.Add($"{c1}{c2}");
        }
        else if (digits.Length == 3)
        {
            foreach (char c1 in map[digits[0]])
                foreach (char c2 in map[digits[1]])
                    foreach (char c3 in map[digits[2]])
                        result.Add($"{c1}{c2}{c3}");
        }
        else if (digits.Length == 4)
        {
            foreach (char c1 in map[digits[0]])
                foreach (char c2 in map[digits[1]])
                    foreach (char c3 in map[digits[2]])
                        foreach (char c4 in map[digits[3]])
                            result.Add($"{c1}{c2}{c3}{c4}");
        }

        return result;
    }
    public static IList<string> LetterCombinations2(string digits)
    {
        if (string.IsNullOrEmpty(digits))
            return new List<string>();

        Dictionary<char, string> map = new Dictionary<char, string>
        {
            {'2', "abc"}, {'3', "def"}, {'4', "ghi"}, {'5', "jkl"},
            {'6', "mno"}, {'7', "pqrs"}, {'8', "tuv"}, {'9', "wxyz"}
        };

        var result = new List<string>() { "" };

        for (int i = 0; i < digits.Length; i++)
        {
            var temp = new List<string>();

            foreach (string prefix in result)
            {
                foreach (char c in map[digits[i]])
                {
                    temp.Add(prefix + c);
                }
            }

            result = temp;
        }

        return result;
    }

    public static int CountDigitOne(int n)
    {
        int count = 0;
        string temp = string.Empty;

        for (int i = 1; i <= n; i++)
        {
            count += temp.Count(c => c == '1');
        }

        return count;
    }

    public static int CompareVersion(string version1, string version2)
    {
        var parts1 = version1.Split('.');
        var parts2 = version2.Split('.');

        int length = Math.Max(parts1.Length, parts2.Length);

        for (int i = 0; i < length; i++)
        {
            int v1 = i < parts1.Length ? int.Parse(parts1[i]) : 0;
            int v2 = i < parts2.Length ? int.Parse(parts2[i]) : 0;

            if (v1 < v2) return -1;
            if (v1 > v2) return 1;
        }

        return 0;
    }

    public static bool RepeatedSubstringPattern(string s)
    {
        string doubleS = s + s; // "abab" + "abab" = "abababab"
        string trimmed = doubleS.Substring(1, doubleS.Length - 2); // "bababa"
        return trimmed.Contains(s); // Check if original "abab" exists in "bababa"
    }

    public static bool CheckRecord(string s)
    {
        int temp = 0, late = 0, absent = 0;

        foreach (var c in s)
        {
            if (c == 'L')
            {
                temp++;
                late = Math.Max(late, temp);
            }
            else
            {
                temp = 0;

                if (c == 'A')
                    absent++;
            }
        }

        return late < 3 && absent < 2;
    }

    public static bool IsIsomorphic(string s, string t)
    {
        return GetPattern(s) == GetPattern(t);

        string GetPattern(string word)
        {
            var dic = new Dictionary<char, int>();
            StringBuilder pattern = new StringBuilder();
            int index = 0;

            foreach (var w in word)
            {
                if (!dic.ContainsKey(w))
                    dic[w] = index++;

                pattern.Append(dic[w] + ',');
            }

            return pattern.ToString();
        }
    }
    public static bool IsIsomorphic2(string S, string T)
    {
        if (S.Length != T.Length) return false;

        var mapS = new Dictionary<char, char>();
        var mapT = new Dictionary<char, char>();

        char s;
        char t;

        for (int i = 0; i < S.Length; i++)
        {
            s = S[i];
            t = T[i];

            if (mapS.ContainsKey(s))
            {
                if (mapS[s] != t)
                    return false;
            }
            else
            {
                if (mapT.ContainsKey(t))
                {
                    if (mapT[t] != s)
                        return false;
                }

                mapT[t] = s;
                mapS[s] = t;
            }
        }

        return true;
    }

    public static bool IsIsomorphic3(string S, string T)
    {
        if (S.Length != T.Length) return false;

        var map = new Dictionary<char, char>();

        char s;
        char t;

        for (int i = 0; i < S.Length; i++)
        {
            s = S[i];
            t = T[i];

            if (map.ContainsKey(s))
            {
                if (map[s] != t)
                    return false;
            }
            else
            {
                if (map.ContainsValue(t))
                {
                    if (map[t] != s)
                        return false;
                }

                map[s] = t;
            }
        }

        return true;
    }

    public static IEnumerable<int> FindDisappearedNumbers(int[] nums)
    {
        var bitArray = new BitArray(nums.Length + 1); // index 0 unused
        var res = new List<int>();

        foreach (int num in nums)
        {
            bitArray[num] = true;
        }

        for (int i = 1; i <= nums.Length; i++)
        {
            if (!bitArray[i])
                res.Add(i);
        }

        return res;
    }

    public static IList<int> FindDisappearedNumbers2(int[] nums)
    {
        return Enumerable.Range(1, nums.Length).Except(nums).ToList();
    }

    public static IList<int> FindDisappearedNumbers3(int[] nums)
    {
        var set = new HashSet<int>(nums);
        var res = new List<int>();

        for (int i = 1; i <= nums.Length; i++)
        {
            if (!set.Contains(i))
                res.Add(i);
        }

        return res;
    }

    public static bool IsHappy(int n)
    {
        var list = new List<int>();
        int sum = 0;

        while (sum != 1)
        {
            sum = 0;

            while (n > 0)
            {
                sum += (n % 10) * (n % 10);

                n /= 10;
            }

            n = sum;

            if (list.Contains(sum))
                return false;
            else
                list.Add(sum);
        }

        return true;
    }

    public static bool IsHappy2(int n)
    {
        var seen = new HashSet<int>();

        while (n != 1 && !seen.Contains(n))
        {
            seen.Add(n);
            n = GetSumOfSquares(n);
        }

        return n == 1;
    }

    private static int GetSumOfSquares(int n)
    {
        int sum = 0;
        while (n > 0)
        {
            int digit = n % 10;
            sum += digit * digit;
            n /= 10;
        }
        return sum;
    }

    public static string ReplaceWords(IList<string> dictionary, string sentence)
    {
        var set = new HashSet<string>(dictionary);
        var res = new List<string>();
        var words = sentence.Split(' ');
        string replacement = string.Empty;
        string prefix = string.Empty;

        foreach (var word in words)
        {
            replacement = word;

            for (int i = 1; i < word.Length; i++)
            {
                prefix = word.Substring(0, i);

                if (set.Contains(prefix))
                {
                    replacement = prefix;
                    break;
                }
            }

            res.Add(replacement);
        }

        return string.Join(" ", res);
    }

    public static IList<int> PowerfulIntegers(int x, int y, int bound)
    {
        var result = new HashSet<int>();
        int sum = 0;

        for (int i = 0; Math.Pow(x, i) <= bound; i++)
        {
            for (int j = 0; Math.Pow(y, j) <= bound; j++)
            {
                sum = (int)(Math.Pow(x, i) + Math.Pow(y, j));

                if (sum <= bound)
                    result.Add(sum);

                if (y == 1)
                    break;
            }

            if (x == 1)
                break;
        }

        return result.ToList();
    }

    public static int MajorityElement(int[] nums)
    {
        int n = nums.Length / 2;
        var dic = new Dictionary<int, int>();

        foreach (int num in nums)
        {
            if (dic.ContainsKey(num))
            {
                dic[num]++;
                if (dic[num] > n)
                    return num;
            }
            else
                dic[num] = 1;
        }

        return nums.SingleOrDefault();
    }

    public static int MajorityElement2(int[] nums)
    {
        int n = nums.Length / 2;

        return nums.GroupBy(c => c)
                   .Select(g => new { Key = g.Key, Count = g.Count() })
                   .Where(c => c.Count > n)
                   .Select(c => c.Key)
                   .FirstOrDefault();
    }

    public static IList<int> MajorityElement_medium(int[] nums)
    {
        int n = nums.Length / 3;

        return nums.GroupBy(c => c)
                   .Select(g => new { Key = g.Key, Count = g.Count() })
                   .Where(c => c.Count > n)
                   .Select(c => c.Key)
                   .ToList();
    }

    public static IList<int> MajorityElement_medium2(int[] nums)
    {
        Dictionary<int, int> dict = new Dictionary<int, int>();
        foreach (int i in nums)
        {
            if (dict.ContainsKey(i))
            {
                dict[i]++;
            }
            else
            {
                dict[i] = 1;
            }
        }

        List<int> res = new List<int>();
        int compare = nums.Length / 3;
        foreach (var pair in dict)
        {
            if (pair.Value > compare)
            {
                res.Add(pair.Key);
            }
        }

        return res;
    }

    public static string[] FindWords(string[] words)
    {
        HashSet<char> row1 = new HashSet<char>("qwertyuiopQWERTYUIOP");
        HashSet<char> row2 = new HashSet<char>("asdfghjklASDFGHJKL");
        HashSet<char> row3 = new HashSet<char>("zxcvbnmZXCVBNM");

        int x = 0;
        int y = 0;
        int z = 0;

        List<string> result = new List<string>();

        foreach (var word in words)
        {
            x = 0;
            y = 0;
            z = 0;

            foreach (var w in word)
            {
                if (row1.Contains(w))
                    x = 1;
                else if (row2.Contains(w))
                    y = 1;
                else if (row3.Contains(w))
                    z = 1;
            }

            if (x + y + z == 1)
                result.Add(word);
        }

        return result.ToArray();
    }

    #region Print in Order
    public class Foo
    {
        TaskCompletionSource<bool> firstTaskDone = new TaskCompletionSource<bool>();
        TaskCompletionSource<bool> secondTaskDone = new TaskCompletionSource<bool>();

        public Foo()
        {

        }

        public void First(Action printFirst)
        {
            printFirst();
            firstTaskDone.SetResult(true);
        }

        public void Second(Action printSecond)
        {
            firstTaskDone.Task.Wait();
            printSecond();
            secondTaskDone.SetResult(true);
        }

        public void Third(Action printThird)
        {
            secondTaskDone.Task.Wait();
            printThird();
        }
    }
    #endregion

    public static string MostCommonWord(string paragraph, string[] banned)
    {
        var bannedSet = new HashSet<string>(banned);
        var cleaned = Regex.Replace(paragraph.ToLower(), "[^a-z]", " ");
        var words = cleaned.Split(' ', StringSplitOptions.RemoveEmptyEntries);

        var dic = new Dictionary<string, int>();

        foreach (var word in words)
        {
            if (!bannedSet.Contains(word))
            {
                if (dic.ContainsKey(word))
                    dic[word]++;
                else
                    dic[word] = 1;
            }
        }
        return dic.MaxBy(kvp => kvp.Value).Key;
    }

    // Fast and efficient
    public string MostCommonWord2(string paragraph, string[] banned)
    {
        var separators = new char[] { ' ', '!', '?', ',', ';', '.', '"', '\'' };

        return paragraph
         .ToLower()
         .Split(separators)
         .Where(word => word != string.Empty)
         .GroupBy(word => word)
         .ExceptBy(banned, gr => gr.Key)
         .MaxBy(gr => gr.Count()).Key;
    }

    public static bool CanConstruct(string ransomNote, string magazine)
    {
        Dictionary<char, int> letters = new Dictionary<char, int>();
        foreach (char letter in magazine)
        {
            if (letters.ContainsKey(letter))
                letters[letter]++;
            else
                letters[letter] = 1;
        }

        foreach (char c in ransomNote)
        {
            if (letters.ContainsKey(c) && letters[c] > 0)
                letters[c]--;
            else
                return false;
        }
        return true;
    }

    public class ParkingSystem
    {
        int small = 0, medium = 0, big = 0;

        public ParkingSystem(int big, int medium, int small)
        {
            this.big = big;
            this.medium = medium;
            this.small = small;
        }

        public bool AddCar(int carType)
        {
            switch (carType)
            {
                case (int)ParkType.big:
                    if (big > 0)
                    {
                        big--;
                        return true;
                    }
                    break;

                case (int)ParkType.medium:
                    if (medium > 0)
                    {
                        medium--;
                        return true;
                    }
                    break;

                case (int)ParkType.small:
                    if (small > 0)
                    {
                        small--;
                        return true;
                    }
                    break;
            }
            return false;
        }
        public enum ParkType
        {
            big = 1,
            medium = 2,
            small = 3
        }
    }
    #endregion

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

    public static string FindCustomerReferee()
    {
        string query = @"
                        Select c.name from 
                        Customer c 
                        where c.referee_id <> 2 or c.referee_id is null";
        return query;
    }

    public static string GroupSoldProductsByTheDate()
    {
        string query = @" SELECT
                              a.sell_date,
                              COUNT(a.product) AS num_sold,
                              STRING_AGG(a.product, ',') AS products
                          FROM  
  	                      (SELECT DISTINCT * FROM Activities ) a 
                          GROUP BY 
                              a.sell_date
                       ";
        return query;
    }

    public static string TopTravellers()
    {
        string query = @"SELECT 
                         u.name,
                         SUM(Case 
                         When r.distance Is Null
                         Then 0
                         Else
                          r.distance 
                         End ) AS travelled_distance 
                     FROM
                        Users u
                      left join
                          Rides r ON r.user_id = u.id
                     GROUP BY 
                         u.id,
                         u.name 
                     ORDER BY 
                         travelled_distance DESC 
                     ";
        return query;
    }

    public static string ReplaceEmployeeIDWithTheUniqueIdentifier()
    {
        string query = @"SELECT en.unique_id, e.name
                         FROM Employees AS e
                         LEFT JOIN EmployeeUNI AS en
                         ON e.id = en.id
                                              ";
        return query;
    }
    public static string AverageSellingPrice()
    {
        string query = @"Select 
                         p.product_id ,
                         COALESCE(ROUND(CAST(SUM(p.price * us.units) AS FLOAT) / SUM(us.units),2),0) as average_price 
                         from 
                         Prices p 
                         left join 
                         UnitsSold us
                         on p.product_id  = us.product_id  
                         AND purchase_date >= start_date and purchase_date <= end_date
                         Group By p.product_id ";
        return query;
    }

    public static string PatientsWithACondition
    ()
    {
        string query = @"SELECT *
                         FROM Patients 
                         WHERE EXISTS (
                             SELECT 1
                             FROM STRING_SPLIT(conditions, ' ') AS splittedConditions
                             WHERE splittedConditions.value LIKE N'DIAB1%'
                         );
                          ";
        return query;
    }

    #endregion

}