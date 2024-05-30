using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblems
{
    public class LongestSubstring
    {
        public int LengthOfLongestSubstring(string s)
        {

            int result = 0;
            int left = 0, right = 0;
            int stringlength = s.Count();

            if (stringlength == 1) return 1;
            if (stringlength == 0) return 0;

            StringBuilder sb = new StringBuilder();
            //SortedSet<char> tracker = [];
            sb = sb.Append(s);

            var tracker = new Dictionary<char, int>();

            while (right < stringlength)
            {
                //If we find a character that is already in the dictionary, we need to move the left pointer to the right of the last occurence of that character
                if (tracker.ContainsKey(sb[right]))
                {
                    left = Math.Max(left, tracker[sb[right]] + 1);
                }

                //Use the dictionary to keep track of the furthest right index of a particular character
                tracker[sb[right]] = right;

                result = Math.Max(result, right - left + 1);

                right++;
            }

            return result;
        }
    }
}