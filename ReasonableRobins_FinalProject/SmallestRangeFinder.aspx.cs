// Name: Shantele King
// email: King4sl@mail.uc.edu 
// Assignment Title: Final Project
// Due Date: 11/19/2024
// Course: IS 3050
// Semester/Year: Fall 2024
// Brief Description: Solution to problem from Leetcode
// Citations: Gemini ChatGPT
// Anything else that's relevant: N/A
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ReasonableRobins_FinalProject
{
    public partial class SmallestRangeFinder : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Problem1611_Click(object sender, EventArgs e)
        {
            {
                SmallestRangeFinder solver = new SmallestRangeFinder();

                // put desired input in ()
                int result = solver.MinOperations(6);

                lblResult.Text = $"Solution: {result}";
            }


        }

    }
}