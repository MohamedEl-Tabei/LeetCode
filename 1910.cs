public class Solution
{
    public string RemoveOccurrences(string s, string part)
    {
        Stack<char> stack = new Stack<char>();
        string temp = "";
        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == part[part.Length - 1])
            {
                temp = $"{s[i]}";
                for (int j = 0; j < part.Length - 1; j++)
                {
                    if (stack.Count == 0) break;
                    temp = $"{stack.Pop()}{temp}";
                }
                if (temp != part)
                {
                    for (int j = 0; j < temp.Length; j++)
                    {
                        stack.Push(temp[j]);
                    }
                }
            }
            else
            {
                stack.Push(s[i]);
            }
        }
        temp = "";
        while (stack.Count() > 0)
        {
            temp = $"{stack.Pop()}{temp}";
        }
        return temp;
    }
}