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
                int result = solver.MinOperations(91);

                lblResult.Text = $"Solution: {result}";
            }


        }

    }
}