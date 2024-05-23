using System;
using static System.Math;

namespace RectangleArea
{
    public class Solution
    {
        public int computeArea(int RectA_x1, int RectA_y1, int RectA_x2, int RectA_y2,  int RectB_x1, int RectB_y1, int RectB_x2, int RectB_y2)
        {
            // Calculate the area of each rectangle
            int area_A = Math.Abs(RectA_x2 - RectA_x1) * Math.Abs(RectA_y2 - RectA_y1);
            int area_B = Math.Abs(RectB_x2 - RectB_x1) * Math.Abs(RectB_y2 - RectB_y1);

            int inter_x1 = Math.Max(RectA_x1, RectB_x1);
            int inter_y1 = Math.Max(RectA_y1, RectB_y1);
            int inter_x2 = Math.Min(RectA_x2, RectB_x2);
            int inter_y2 = Math.Min(RectA_y2, RectB_y2);
            
            int inter_area;
            if(inter_x1 < inter_x2 && inter_y1 < inter_y2)
            {
                inter_area = Math.Abs(inter_x2 - inter_x1) * Math.Abs(inter_y2 - inter_y1);
            }
            else
            {
                inter_area = 0;
            }

            int total_area = area_A + area_B - inter_area;

            return total_area;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            int result = solution.computeArea(-3, 0, 3, 4, 0, -1, 9, 2);
            Console.WriteLine($"The area is: {result}");

        }
    }
}


