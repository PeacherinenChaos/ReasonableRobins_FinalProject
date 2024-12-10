// Name: Connor Thomas
// Email: thoma5cg @mail.uc.edu
// Assignment Number: Final Project
// Due Date: 12 / 10 / 24
// Course #/Section: IS3050/001
// Semester/Year: 1st / 4th
// Brief Description of the assignment: In this assignment, we are working with a group on 3 separate hard problems from LeetCode.In the problem I chose, I am finding out which bucket is filled with poisonous liquid using pig lives.
// Citations: ChatGPT, LeetCode
// Anything else that's relevant:
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
namespace ReasonableRobins_FinalProject
{
    public partial class PoorPigs : System.Web.UI.Page
    {
        protected void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                // Retrieve input values from textboxes
                int buckets = Convert.ToInt32(this.buckets.Text);
                int minutesToDie = Convert.ToInt32(this.minutesToDie.Text);
                int minutesToTest = Convert.ToInt32(this.minutesToTest.Text);
                // Call the PoorPigs method to calculate the minimum number of pigs
                int minPigs = PoorPigsSolution.PoorPigs(buckets, minutesToDie, minutesToTest);
                // Display the result
                lblResult.Text = "Minimum number of pigs needed: " + minPigs;
            }
            catch (Exception ex)
            {
                // Handle potential errors gracefully
                lblResult.Text = "Error: " + ex.Message;
            }
        }
        public class PoorPigsSolution
        {
            public static int PoorPigs(int buckets, int minutesToDie, int minutesToTest)
            {
                int statesPerPig = 1 + (minutesToTest / minutesToDie);
                int pigs = 0;
                while (Math.Pow(statesPerPig, pigs) < buckets)
                {
                    pigs++;
                }
                return pigs;
            }
            public static void Main(string[] args)
            {
                int buckets = 1000; // Number of buckets
                int minutesToDie = 15; // Time it takes for a pig to die after drinking
                int minutesToTest = 60; // Time frame for testing
                int minPigs = PoorPigs(buckets, minutesToDie, minutesToTest);
                Console.WriteLine("Minimum number of pigs needed: " + minPigs);
            }
        }
    }
}