using System.Collections.Generic;

namespace lab4
{
    public class lobject
    {
        public int city;
        public int cost;
        public int[,] matrix;
        public int[] remainingcity;
        public int city_left_to_expand;
        public Stack<int> st;
        public lobject(int number)
        {
            matrix = new int[number, number];
            st = new Stack<int>();
        }
    }
}
