using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Sum;
namespace Calculator
{
    public partial class Calculator : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSum_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(txtNum1.Text);
          int num2 = int.Parse(txtNum2.Text);
            txtSum.Text = Class1.sum(num1, num2).ToString();
       
        }

    }
}