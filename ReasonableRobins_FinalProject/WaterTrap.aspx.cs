// Name: Annapoorna Nair
// email: nairap @mail.uc.edu
// Assignment Title: Reasonable Robins Final project
// Due Date: 12 / 07 / 24
// Course: IS 3050
// Semester/Year: Fall 2024
// Brief Description: Final project using the watertrap problem
// Citations: Leetcode for the actual problem itself
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ReasonableRobins_FinalProject
{
    public partial class WaterTrap : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        private static int TrapWater(int[] height)
        {
            int n = height.Length;
            if (n < 1 || n > 2 * 10000)
            {
                return 0;
            }

            // Validate height values
            for (int i = 0; i < n; i++)
            {
                if (height[i] < 0 || height[i] > 100000)
                {
                    return 0; // Return 0 for invalid height values
                }
            }

            int[] leftMax = new int[n];
            int[] rightMax = new int[n];

            // Calculate left maximum heights
            leftMax[0] = height[0];
            for (int i = 1; i < n; i++)
            {
                leftMax[i] = Math.Max(leftMax[i - 1], height[i]);
            }

            // Calculate right maximum heights
            rightMax[n - 1] = height[n - 1];
            for (int i = n - 2; i >= 0; i--)
            {
                rightMax[i] = Math.Max(rightMax[i + 1], height[i]);
            }

            int trappedWater = 0;
            for (int i = 0; i < n; i++)
            {
                // Ensure the subtraction doesn't lead to a negative value
                trappedWater += Math.Max(0, Math.Min(leftMax[i], rightMax[i]) - height[i]);
            }

            return trappedWater;
        }

        private void cmdAnswerClick_Click(object sender, EventArgs e)
        {
            int[] testInput = { 0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1 }; // Replace with user input if needed
            int waterTrapped = TrapWater(testInput);
            LblCalculateWater.Text = waterTrapped.ToString();
        }
    }
}
