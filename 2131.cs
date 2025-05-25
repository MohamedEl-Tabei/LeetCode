public class Solution
{
    public int LongestPalindrome(string[] words)
    {
        var d = new Dictionary<string, int>();
        int result = 0;
        int num = 0;
        bool onePalindrome = false;
        for (int i = 0; i < words.Length; i++)
        {
            if (!d.ContainsKey(words[i])) d.Add(words[i], 1);
            else d[words[i]]++;
        }
        foreach (string key in d.Keys)
        {
            string k = $"{key[1]}{key[0]}";
            if (d.ContainsKey(k) && key != k)
            {
                num = (d[k] > d[key] ? d[key] : d[k]) * 4;
                result = result + num;
                d.Remove(k);
            }

            if (key == k)
            {
                if (d[key] > 1)
                {
                    num = 0;
                    if (d[k] % 2 == 0)
                        num = d[k];
                    else if (!onePalindrome)
                    {
                        num = d[k];
                        onePalindrome = true;
                    }
                    else num = d[k] - 1;

                    result = result + num * 2;
                }
                else if (!onePalindrome)
                {
                    onePalindrome = true;
                    result = result + 2;
                }

            }

            d.Remove(key);
        }
        return result;
    }
}