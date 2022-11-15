namespace FindMaximumNumber
{
    public class FindMaxNumber
    {
        public int FindMaxInteger(int a, int b, int c)
        {
            if (a > b && a > c)
                return a;
            else if (b > a && b > a)
                return b;
            else
                return c;
        }
        public float FindMaxFloat(float a, float b, float c)
        {
            if (a > b && a > c)
                return a;
            else if (b > a && b > a)
                return b;
            else
                return c;
        }
        public string FindMaxString(string a, string b, string c)
        {
            if (a.CompareTo(b) > 0 && a.CompareTo(c) > 0)
                return a;
            else if (b.CompareTo(a) > 0 && b.CompareTo(c) > 0)
                return b;
            else
                return c;
        }
    }
}