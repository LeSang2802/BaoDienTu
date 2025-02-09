﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace BTL_BaoDienTu
{
    public partial class HeaderNavFooter : System.Web.UI.MasterPage
    {
        private string inputSearch;
        protected void Page_Load(object sender, EventArgs e)
        {




            if (Request.Form["inputSearch"] != null)
            {
                inputSearch = Request.Form["inputSearch"];
                List<News> dsBao = Application["newslist"] as List<News>;

                int count = 0;
                string sHTML = "";
                for (int i = 0; i < dsBao.Count; i++)
                {
                    if (dsBao[i].Title.ToLower().Contains(inputSearch.ToLower()) == true || dsBao[i].Content.ToLower().Contains(inputSearch.ToLower()) == true)
                    {
                        count++;
                        sHTML += "<section class='item'>" +
                        "<a href='trangconchitiet.aspx?id=" + dsBao[i].Id + "'>" +
                        "<img src='" + dsBao[i].Image + "' />" +
                        "<p class='title'>" + dsBao[i].Title + "</p>" +
                        "<section class='description'>" +
                        "<p class='time'>" + dsBao[i].Time + "  • </p>" +
                        "<p class='category'>" + dsBao[i].Category + "</p>" +
                        "</section>" +
                        "</a>" +
                        "</section>";
                    }
                }
                if (count == 0)
                {
                    sHTML += "<h2 style='font-size: 44px'>Không tìm thấy bài báo nào với từ khóa: '" + inputSearch + "'</h2>";
                    //Response.Write("<script>alert('Không tìm thấy bài báo nào với từ khóa: " + inputSearch + "')</script>");
                    //Response.Redirect("trangchu.aspx");
                }
                else
                {
                    sHTML = "<h2 style='font-size: 44px'>Có tổng cộng " + count + " bài báo chứa từ khóa: '" + inputSearch + "'</h2>" + sHTML;
                    //Response.Write("<script>alert('Có tổng cộng " + count + " bài báo')</script>");
                }
                Session["renderNewsList"] = sHTML;
            }
            //int userCount = (int)Application["session_counter"];
            //if (Request.Cookies.Count > 1)
            //{
            //    if (Request.Cookies["userCookie"].Value != null)
            //    {
            //        userCount++;
            //        Application["session_counter"] = userCount;

            //    }
            //}
            //Response.Write(Application["session_counter"]);


        }
    }
}