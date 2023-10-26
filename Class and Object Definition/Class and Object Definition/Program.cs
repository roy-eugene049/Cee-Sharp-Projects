using System;
namespace ClassDemo
{
    class Sum
    {
        private int x;
        private int y;
        public void setVal(int val1, int val2)
        {
            x = val1;
            y = val2;
        }
        public int getSum()
        {
            return x + y;
        }
    }
    class Test
    {
        static void Main(string[] args)
        {
            Sum s = new Sum();
            s.setVal(3, 14);
            Console.WriteLine("Sum of 3 and 14 is: {0}", s.getSum());
        }
    }
}