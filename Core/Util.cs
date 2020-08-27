namespace IPA.Core
{
    public class Util
    {
        public static int Clamp(int val, int min, int max)
        {
            // função básica de clamp
            if (val < min) return min;
            else if (val > max) return max;
            else return val;
        }
    }
}
