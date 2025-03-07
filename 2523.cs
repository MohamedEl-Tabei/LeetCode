public class Solution
{
    public int[] ClosestPrimes(int left, int right)
    {
        int[] result = { -1, -1 };
        int sqr;
        bool isNotPrime = false;
        var primes = new List<int>();
        if (left < 2) left++;
        while (left <= right)
        {
            isNotPrime = false;
            for (int i = 2; i <= Math.Sqrt(left); i++)
            {
                if (left % i == 0)
                {
                    isNotPrime = true;
                    break;
                }
            }
            if (!isNotPrime) primes.Add(left);
            left++;
        }
        if (primes.Count >= 2)
        {
            result[0] = primes[0];
            result[1] = primes[1];
        }
        for (int i = 0; i < primes.Count - 1; i++)
        {
            if (result[1] - result[0] > primes[i + 1] - primes[i])
            {
                result[0] = primes[i];
                result[1] = primes[i + 1];
            }

        }

        return result;
        return primes.ToArray();
    }
}