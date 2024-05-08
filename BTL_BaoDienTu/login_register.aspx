<%@ Page Title="" Language="C#" MasterPageFile="~/HeaderNavFooter.Master" AutoEventWireup="true" CodeBehind="login_register.aspx.cs" Inherits="BTL_BaoDienTu.login_register" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!DOCTYPE html>
    <%-- Đẩy r đấy --%>

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <title>Đăng nhập Đăng ký</title>
        <link rel="stylesheet" href="asset/css/login_register_style.css">
</head>
<body>
    <div class ="bodyTCCT">
    <table>
        <tr>
            <td class ="tableTCCT">
                <div class="formdn">
                <h1 style = "width: 100%; font-size: 26px">Đăng nhập</h1>
<%--                <p>Nếu bạn đã có tài khoản thì hãy đăng nhập để đăng báo</p>--%>
                <form id="formdn" method ="post" action="#">
                    <label>Tài khoản: </label> 
                    <input type ="text" class ="taikhoan" name="inputTK" /><br />
                    <label>Mật khẩu: </label> 
                    <input type ="password" class ="matkhau" name="inputMK" /><br />
                    <label>    </label> 
                    <input style="visibility:hidden;" type ="password" class ="check123" name="inputMKCheckDK" /><br />
                    <button type="submit" id="btnDangNhap">ĐĂNG NHẬP</button>
                </form>
                </div>
            </td>

            <td class ="tableTCCT">
                <div class="formdky">
                <h1 style = "width: 100%; font-size: 26px">Đăng ký</h1>
<%--                <p>Nếu chưa có tài khoản, đăng ký ngay!</p>--%>
                <form id="form2" method ="post" action="#">
                    <label>Tài khoản: </label> 
                    <input type ="text" class ="taikhoan1" name="inputTKDK" /><br />
                    


                    <label>CCCD: </label> 
                    <input type ="text" class ="cancuoc" name="inputCCCD" /><br />




                    <label>Mật khẩu: </label> 
                    <input type ="password" class ="matkhau1" name="inputMKDK" /><br />
                    <label>Nhập lại mật khẩu: </label> 
                    <input type ="password" class ="check" name="inputMKCheckDK" /><br />
                    <button class ="dangky" type ="submit"> ĐĂNG KÝ</button>
                </form>
                </div>
            </td>
         </tr>
    </table>
    </div>
</body>
    <script>
        //const tkDN = document.querySelector(".taikhoan");
        //const mkDN = document.querySelector(".matkhau");
        //const tkDK = document.querySelector(".taikhoan1");
        //const mkDK = document.querySelector(".matkhau1");
        //const checkDK = document.querySelector(".check");
        //var btnDN = document.querySelector('#btnDangNhap')
        //var btnDK = document.querySelector('button[class="dangky"]')
        //const formDK = document.querySelector('#form2')
        //const formDN = document.querySelector('#formdn')

        //mkDK.addEventListener("change", () => {
        //    //var regexp = /(?=.*[A-Z])/;
        //    var regexp = /(?=.*[0-9])/;
        //     //var regexp = /(?=.*[!@#$%^&*])/;
        //    console.log(mkDK.value);
        //    console.log(regexp.test(mkDK.value.trim()));
        //    console.log(mkDK.value.trim().match(regexp));
        //    //dùng match để tìm kiếm
        //})

        ////---------------------------------------------------------------------
        ////mkDK.addEventListener("change", () => {
        ////    var regexp = /(?=.*[0-9])(?=.*[!@#$%^&*])(?=.*[A-Z])(?=.*[a-z])/; // Ít nhất 1 số, 1 kí tự đặc biệt, 1 chữ in hoa và 1 chữ in thường
        ////    console.log(mkDK.value);
        ////    console.log(regexp.test(mkDK.value.trim()));
        ////    if (!regexp.test(mkDK.value.trim())) {
        ////        alert("Mật khẩu phải chứa ít nhất 1 số và 1 kí tự đặc biệt, 1 chữ in hoa và 1 chữ in thường !");
        ////    }
        ////})
        ////---------------------------------------------------------------------

        //btnDN.addEventListener('click', function (e) {
        //    e.preventDefault();
        //    if (tkDN.value.trim() === "") {
        //        alert("Tài khoản không được trống");
        //    }
        //    else if (mkDN.value.trim() === "") {
        //        alert("Mật khẩu không được trống");
        //    } else {
        //        formDN.submit();
        //    }
        //})

        //btnDK.addEventListener('click', function (e) {
        //    e.preventDefault();
        //    if (tkDK.value.trim() === "") {
        //        alert("Tài khoản không được trống");
        //    }
        //    else if (mkDK.value.trim() === "") {
        //        alert("Mật khẩu không được trống");
        //    }
        //    else if (checkDK.value.trim() != mkDK.value.trim()) {
        //        alert("Mật khẩu không trùng khớp");
        //        checkDK.focus();
        //    } else {
        //        formDK.submit();
        //    }
        //})

        const tkDN = document.querySelector(".taikhoan");
        const mkDN = document.querySelector(".matkhau");
        const tkDK = document.querySelector(".taikhoan1");
        const mkDK = document.querySelector(".matkhau1");
        const checkDK = document.querySelector(".check");
        const cccdDK = document.querySelector(".cancuoc"); 

        var btnDN = document.querySelector('#btnDangNhap');
        var btnDK = document.querySelector('button[class="dangky"]');
        const formDK = document.querySelector('#form2');
        const formDN = document.querySelector('#formdn');

        mkDK.addEventListener("change", () => {
            var regexp = /(?=.*[0-9])/;
            console.log(mkDK.value);
            console.log(regexp.test(mkDK.value.trim()));
            console.log(mkDK.value.trim().match(regexp));
        })

        btnDN.addEventListener('click', function (e) {
            e.preventDefault();
            if (tkDN.value.trim() === "") {
                tkDN.classList.add('input-invalid');  
                alert("Tài khoản không được trống");
            }
            else if (mkDN.value.trim() === "") {
                mkDN.classList.add('input-invalid'); 
                alert("Mật khẩu không được trống");
            } else {
                formDN.submit();
            }
        })

        btnDK.addEventListener('click', function (e) {
            e.preventDefault();
            if (tkDK.value.trim() === "") {
                tkDK.classList.add('input-invalid');  
                alert("Tài khoản không được trống");
            }
            else if (mkDK.value.trim() === "") {
                mkDK.classList.add('input-invalid'); 
                alert("Mật khẩu không được trống");
            }
            else if (checkDK.value.trim() != mkDK.value.trim()) {
                checkDK.classList.add('input-invalid');  
                alert("Mật khẩu không trùng khớp");
                checkDK.focus();
            }
            else if (!/^[a-z]\d{7}$/.test(cccdDK.value.trim())) {  
                cccdDK.classList.add('input-invalid');  
                alert("Số CCCD phải bắt đầu bằng 1 chữ cái thường và tiếp theo là 7 chữ số !");
            } else {
                formDK.submit();
            }
        })


    </script>
</html>
</asp:Content>
