﻿                <%@ Page Title="" Language="C#" MasterPageFile="~/HeaderNavFooter.Master" AutoEventWireup="true" CodeBehind="trangchu.aspx.cs" Inherits="BTL_BaoDienTu.trangchu" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!DOCTYPE html>
<html>
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="stylesheet" href="asset/css/trangchu_style.css" />
    <title>News</title>
</head>
<body>
    <style>
        #activehome{
            background-color :lightgray;
        }
    </style>
    <section class="content">

    </section> 
    <script>
        const renderNewsList = document.querySelector(".content");

        renderNewsList.innerHTML = "<%= Session["renderNewsList"] %>";
    </script>
</body>
</html>
</asp:Content>
