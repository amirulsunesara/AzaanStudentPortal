﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
public partial class StudentMaster : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    public Label name
    {
        get
        {

            return fname;
        }

    }
    public LinkButton LogOutButton
    {
        get
        {
            return lbLogout;

        }


    }
    public HtmlAnchor LBtn
    {
        get
        {
            return msg;

        }


    }
    public HtmlAnchor Profilee
    {
        get
        {
            return pro;

        }


    }
    public void msg_Click(object sender, EventArgs e)
    {

        Response.Redirect("SMessage.aspx");
    }
    public void pro_Click(object sender, EventArgs e)
    {

        Response.Redirect("SProfile.aspx");
    }
}
