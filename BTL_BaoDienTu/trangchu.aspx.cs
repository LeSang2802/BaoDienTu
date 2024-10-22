﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BTL_BaoDienTu
{
    public partial class trangchu : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Page.Title = "F News";
            Session["renderNewsList"] = renderNewsList();

            List<News> dsBao = Application["newslist"] as List<News>;
        }
        private string renderNewsList()
        {
            string sHTML = "";
            List<News> dsBao = Application["newslist"] as List<News>;
            //dsBao.Sort((x, y) => y.Time.CompareTo(x.Time));
            for (int i = 0; i < dsBao.Count; i++)
            {
                sHTML += "<section class='item' id=" + dsBao[i].Id + ">" +
                    "<a href='trangconchitiet.aspx?id=" + dsBao[i].Id + "'>" +
                    "<img src='" + dsBao[i].Image + "' />" +
                    "<p class='title'>" + dsBao[i].Title + "</p>" +
                    "<p class='sub_title'>" + dsBao[i].Content + "</p>" +
                    "<section class='description'>" +
                    "<p class='time'>" + dsBao[i].Time + "  • </p>" +
                    "<p class='category'>" + dsBao[i].Category + "</p>" +
                    "</section>" +
                    "<button><a href='trangconchitiet.aspx?id=" + dsBao[i].Id + "'>Chi tiết</a></button>" +
                    "</a>" +
                    "</section>";
            }

            return sHTML;
        }
    }
}