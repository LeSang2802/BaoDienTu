﻿<%@ Page Title="" Language="C#" MasterPageFile="~/HeaderNavFooter.Master" AutoEventWireup="true" CodeBehind="trangconchitiet.aspx.cs" Inherits="BTL_BaoDienTu.trangconchitiet" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!DOCTYPE html>
    <html xmlns="http://www.w3.org/1999/xhtml">
    <head>
        <title>Trang con chi tiết</title>
        <link rel="stylesheet" href="asset/css/trangconchitiet_style.css">
    </head>
    <body>
        <div class="container1" style="width: 100%;">
        </div>
    </body>
    <script>
        var container = document.querySelector(".container1")

        container.innerHTML = "<%= Session["renderTrangconchitiet"] %>"

    </script>
    </html>
</asp:Content>
