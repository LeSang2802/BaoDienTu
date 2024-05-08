using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace BTL_BaoDienTu
{
    public partial class login_register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            List<User> users = (List<User>)Application["Users"];
            int registeredUsersCount = users.Count;

            // Truy xuất đến phần tử li chứa số lượng người dùng và hiển thị số lượng
            var registeredUsersLi = (HtmlGenericControl)Master.FindControl("registeredUsers");
            if (registeredUsersLi != null)
            {
                registeredUsersLi.InnerHtml = $"<h4>Đã có {registeredUsersCount} người dùng</h4>";
            }

            //Page.Title = "Đăng ký, đăng nhập";

            //List<User> users = (List<User>)Application["Users"];
            //string tkdk = Request.Form["inputTKDK"];
            //string mkdk = Request.Form["inputMKDK"];
            //string mkdkcheck = Request.Form["inputMKCheckDK"];
            //string tkdn = Request.Form["inputTK"];
            //string mkdn = Request.Form["inputMK"];

            //if (tkdn != null && mkdn != null)
            //{
            //    int checkdn = 0;
            //    int index = 0;
            //    for (int i = 0; i < users.Count; i++)
            //    {
            //        if (String.Compare(users[i].Taikhoan, tkdn.ToString(), false) == 0 && String.Compare(users[i].Matkhau, mkdn.ToString(), false) == 0)
            //        {
            //            index = i;
            //            checkdn++;
            //            //Response.Redirect("trangchu");
            //        }
            //    }
            //    if (checkdn > 0)
            //    {
            //        HttpCookie mycookieDN = new HttpCookie("userCookie");
            //        mycookieDN.Value = "" + tkdn;
            //        mycookieDN.Expires = DateTime.Now.AddMinutes(10);
            //        HttpContext.Current.Response.Cookies.Add(mycookieDN);

            //        Response.Redirect("trangchu.aspx");
            //    }
            //    else
            //    {
            //        Response.Write("<script>alert('Sai tài khoản hoặc mật khẩu')</script>");
            //    }
            //}

            //else if (tkdk != null && mkdk != null && mkdkcheck != null)
            //{
            //    int check = 0;
            //    for (int i = 0; i < users.Count; i++)
            //    {
            //        if (String.Compare(users[i].Taikhoan, tkdk.ToString(), false) == 0)
            //        {
            //            check++;
            //        }
            //    }
            //    if (check == 0)
            //    {
            //        users.Add(new User(users.Count + 1, tkdk, mkdk, "user"));
            //        HttpCookie mycookie = new HttpCookie("userCookie");
            //        mycookie.Value = "" + tkdk;
            //        mycookie.Expires = DateTime.Now.AddMinutes(10);
            //        HttpContext.Current.Response.Cookies.Add(mycookie);

            //        Response.Write("<script>alert('Đăng kí thành công')</script>");
            //        System.Threading.Thread.Sleep(2000);
            //    }
            //    else
            //    {
            //        Response.Write("<script>alert('Tài khoản đã tồn tại, vui lòng nhập tài khoản khác!')</script>");
            //    }
            //    //}
            //}




            Page.Title = "Đăng ký, đăng nhập";

            List<User> users = (List<User>)Application["Users"];




            //string tkdk = Request.Form["inputTKDK"];
            //string mkdk = Request.Form["inputMKDK"];
            //string mkdkcheck = Request.Form["inputMKCheckDK"];
            //string tkdn = Request.Form["inputTK"];
            //string mkdn = Request.Form["inputMK"]


            //// Xử lý đăng nhập
            //if (!string.IsNullOrEmpty(tkdn) && !string.IsNullOrEmpty(mkdn))
            //{
            //    var user = users.FirstOrDefault(u => string.Equals(u.Taikhoan, tkdn, StringComparison.OrdinalIgnoreCase) && string.Equals(u.Matkhau, mkdn, StringComparison.OrdinalIgnoreCase));

            //    if (user != null)
            //    {
            //        // Tạo cookie và chuyển hướng đến trang chủ
            //        HttpCookie mycookieDN = new HttpCookie("userCookie");
            //        mycookieDN.Value = tkdn;
            //        mycookieDN.Expires = DateTime.Now.AddMinutes(10);
            //        HttpContext.Current.Response.Cookies.Add(mycookieDN);

            //        Response.Redirect("trangchu.aspx");
            //    }
            //    else
            //    {
            //        Response.Write("<script>alert('Sai tài khoản hoặc mật khẩu')</script>");
            //    }
            //}

            //// Xử lý đăng ký
            //else if (!string.IsNullOrEmpty(tkdk) && !string.IsNullOrEmpty(mkdk) && !string.IsNullOrEmpty(mkdkcheck))
            //{
            //    var existingUser = users.FirstOrDefault(u => string.Equals(u.Taikhoan, tkdk, StringComparison.OrdinalIgnoreCase));

            //    if (existingUser == null)
            //    {
            //        users.Add(new User(users.Count + 1, tkdk, mkdk, "user"));

            //        // Tạo cookie và thông báo đăng ký thành công
            //        HttpCookie mycookie = new HttpCookie("userCookie");     
            //        mycookie.Value = tkdk;
            //        mycookie.Expires = DateTime.Now.AddMinutes(10);
            //        HttpContext.Current.Response.Cookies.Add(mycookie);

            //        Response.Write("<script>alert('Đăng kí thành công')</script>");
            //    }
            //    else
            //    {
            //        Response.Write("<script>alert('Tài khoản đã tồn tại, vui lòng nhập tài khoản khác!')</script>");
            //    }
            //}

            string tkdk = Request.Form["inputTKDK"];
            string mkdk = Request.Form["inputMKDK"];
            string mkdkcheck = Request.Form["inputMKCheckDK"];
            string tkdn = Request.Form["inputTK"];
            string mkdn = Request.Form["inputMK"];
            string cccd = Request.Form["inputCCCD"];

// Xử lý đăng ký
else if (!string.IsNullOrEmpty(tkdk) && !string.IsNullOrEmpty(mkdk) && !string.IsNullOrEmpty(mkdkcheck) && !string.IsNullOrEmpty(cccd))
            {
                var existingUser = users.FirstOrDefault(u => string.Equals(u.Taikhoan, tkdk, StringComparison.OrdinalIgnoreCase));

                if (existingUser == null)
                {
                    // Kiểm tra số căn cước công dân
                    var regexCCCD = new System.Text.RegularExpressions.Regex(@"^[a-z]\d{7}$");
                    if (!regexCCCD.IsMatch(cccd))
                    {
                        Response.Write("<script>alert('Số căn cước công dân không hợp lệ')</script>");
                        return;
                    }

                    users.Add(new User(users.Count + 1, tkdk, mkdk, cccd, "user"));

                    // Tạo cookie và thông báo đăng ký thành công
                    HttpCookie mycookie = new HttpCookie("userCookie");
                    mycookie.Value = tkdk;
                    mycookie.Expires = DateTime.Now.AddMinutes(10);
                    HttpContext.Current.Response.Cookies.Add(mycookie);

                    Response.Write("<script>alert('Đăng kí thành công')</script>");
                }
                else
                {
                    Response.Write("<script>alert('Tài khoản đã tồn tại, vui lòng nhập tài khoản khác!')</script>");
                }
            }

        }
    }
}