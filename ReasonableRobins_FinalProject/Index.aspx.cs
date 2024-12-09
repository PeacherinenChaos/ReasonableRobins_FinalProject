// Name: Reasonable Robins
// Email: thoma5cg@mail.uc.edu, nairap@mail.uc.edu, king4sl@mail.uc.edu
// Assignment Number: Final Project
// Due Date: 12/10/24
// Course #/Section: IS3050/001
// Semester/Year: 1st/4th
// Brief Description of the assignment: In this assignment, we are working with a group on 3 separate hard problems from LeetCode.
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
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }
        protected void cmdSmallestRangeFinder_Click(object sender, EventArgs e)
        {
            Response.Redirect("SmallestRangeFinder.aspx");
        }
        protected void cmdPoorPigs_Click(object sender, EventArgs e)
        {
            Response.Redirect("PoorPigs.aspx");
        }
    }
}