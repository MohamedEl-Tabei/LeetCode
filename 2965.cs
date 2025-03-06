public class Solution
{
    public int[] FindMissingAndRepeatedValues(int[][] grid)
    {
        var dictionary = new Dictionary<int, int>();
        var list = new List<int>();
        int size = grid.Length * grid.Length;
        for (int i = 0; i < grid.Length; i++)
        {
            for (int j = 0; j < grid[i].Length; j++)
            {
                if (!dictionary.TryAdd(grid[i][j], 1)) dictionary[grid[i][j]]++;
                if (dictionary[grid[i][j]] == 2) list.Add(grid[i][j]);
            }
        }
        for (int i = 1; i < size + 1; i++)
        {
            if (!dictionary.ContainsKey(i)) list.Add(i);
        }
        return list.ToArray();
    }
}