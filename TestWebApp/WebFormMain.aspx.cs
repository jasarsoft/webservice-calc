﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TestWebApp
{
    public partial class WebFormMain : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            CalculatorService.CalculatorWebServiceSoapClient client;

            client = new CalculatorService.CalculatorWebServiceSoapClient();

            int result = client.Add(Convert.ToInt32(txtFirstNumber.Text),
                            Convert.ToInt32(txtSecondNumber.Text));

            lblResult.Text = result.ToString();
        }
    }
}