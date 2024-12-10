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
    public partial class WordCount : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }
        protected void Problem1255_Click(object sender, EventArgs e)
        {
            WordCount solver = new WordCount();
            // Assuming you have defined these arrays elsewhere
            string[] words = { "dog", "cat", "dad", "good" };
            char[] letters = { 'a', 'a', 'c', 'd', 'd', 'd', 'g', 'o', 'o' };
            int[] score = { 1, 0, 9, 5, 0, 0, 3, 0, 0, 0, 0, 0, 0, 0, 2, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            int result = solver.MaxScoreWords(words, letters, score);
            lblResult.Text = $"Solution: {result}";
        }
    }
}