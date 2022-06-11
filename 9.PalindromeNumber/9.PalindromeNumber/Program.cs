namespace _9.PalindromeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            solution.IsPalindrome(141);
        }
    }
    public class Solution
    {
        public bool IsPalindrome(int x)
        {
            string c = x.ToString();
            int a = c.Length - 1, b = 0;
            while (b < a)
            {
                if (c[a] != c[b])
                    return false;
                b++;
                a--;
            }
            return true;
        }
    }
}