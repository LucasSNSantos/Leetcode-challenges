using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions.Solutions
{

    public static class Extensions
    {
        public static K FindFirstKeyByValue<K, V>(this Dictionary<K, V> dict, V val)
        {
            return dict.FirstOrDefault(entry =>
                EqualityComparer<V>.Default.Equals(entry.Value, val)).Key;
        }
    }

    public class SolutionCommonPrefix
    {

        public string LongestCommonPrefix(string[] strs)
        {
            Dictionary<string, int> dict = new Dictionary<string, int>();

            foreach(string str in strs)
            {
                string prefix = ExtractPrefix(str);

                if(dict.ContainsKey(prefix))
                {
                    int value = dict[prefix];
                    dict[prefix] = value + 1;
                }
                else
                {
                    dict.Add(prefix, 1);
                }
            }


            bool hasMaxValue = true;
            if(dict.Count > 1)
            {
                hasMaxValue = dict.Values.Distinct().Count() > 1;
            }

            if (hasMaxValue)
            {
                int maxValue = dict.Values.Max();
                string commomPrefix = dict.FindFirstKeyByValue(maxValue);
                return commomPrefix;
            }
            else
            {
                return "";
            }
        }


        private string ExtractPrefix(string str)
        {
            char[] chars = str.ToCharArray();

            if (str == "") return str;

            if(chars.Length > 1)
            {
                return str.Substring(0, 1);
            }
            else
            {
                return chars[0].ToString();
            }
        }

    }
}
