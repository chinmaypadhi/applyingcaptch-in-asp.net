using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace applyingcaptch_in_asp.net
{
    public partial class captcha : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            captcha1.ValidateCaptcha(TextBox1.Text.Trim());
            if (captcha1.UserValidated)
            {
                Label1.ForeColor = System.Drawing.Color.Green;
                Label1.Text = "Your Captcha Text Has Been Verified Successfully. You Have Entered Valid Captcha";
            }
            else
            {
                Label1.ForeColor = System.Drawing.Color.Red;
                Label1.Text = "Your Captcha Text Verification is UnSuccessfully. You Have Entered Invalid Captcha";
            }

        }
    }
}