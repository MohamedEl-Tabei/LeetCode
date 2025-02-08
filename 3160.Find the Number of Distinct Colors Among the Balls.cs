public class Solution {
    public int[] QueryResults(int limit, int[][] queries) {
        Dictionary < int, int > balls=new Dictionary < int, int > ();
        Dictionary < int, int > colors=new Dictionary < int, int > ();
        List < int > result=new List < int > ();
        int count = 0;
        int ball;
        int color;
        int oldColor = -1;
        for (int i = 0; i < queries.Length; i++)
        {
            ball = queries[i][0];
            color = queries[i][1];
            if (balls.ContainsKey(ball)) {
                oldColor = balls[ball];
                balls[ball] = color;
            }
            else {
                balls.Add(ball, color);
            }
            if (colors.ContainsKey(color)) {
                colors[color] += 1;
            }
            else {
                colors[color] = 1;
            }
            if (oldColor > -1 && colors.ContainsKey(oldColor)) {
                colors[oldColor] -= 1;
            }
            if (oldColor > -1 && colors[oldColor] < 1) colors.Remove(oldColor);
            result.Add(colors.Count);
            oldColor = -1;
        }
        return result.ToArray();
    }
}