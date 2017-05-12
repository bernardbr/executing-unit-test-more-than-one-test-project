namespace model
{
    using System.Linq;

    using System;

    public static class Calc
    {
        public static int Sum(params int[] values)
        {
            return values.Sum();
        }
    }
}