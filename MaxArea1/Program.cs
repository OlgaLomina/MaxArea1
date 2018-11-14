using System;
/*Container With Most Water

Given n non-negative integers a1, a2, ..., an , where each represents a point at coordinate (i, ai). 
n vertical lines are drawn such that the two endpoints of line i is at (i, ai) and (i, 0). 
Find two lines, which together with x-axis forms a container, such that the container contains the most water.

Note: You may not slant the container and n is at least 2.
 * */
namespace MaxArea1
{
    class Program
    {
        public static int MaxArea(int[] height)
        {
            int l = 0, r = height.Length - 1;
            int area = 0;

            while (l < r)
            {
                area = Math.Max(area, (r - l) * Math.Min(height[l], height[r]));
                if (height[l] < height[r])
                {
                    l++;
                    while (height[l] < height[l - 1] && l < r)
                    {
                        l++;
                    }
                }
                else
                {
                    r--;
                    while (height[r] < height[r + 1] && l < r)
                    {
                        r--;
                    }
                }
            }
            return area;
        }

        public static void Main()
        {
            int[] array = new int[] { 1, 8, 6, 2, 5, 4, 8, 3, 7 };
            int area = MaxArea(array);
            Console.WriteLine(area);
        }
    }
}
