<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Menu.aspx.cs" Inherits="NewTest.Menu" %>

<!DOCTYPE html>
<html>
<head>
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Home Page - My ASP.NET Application</title>

    <script src="/Scripts/jquery-3.3.1.js"></script>
    <script src="/Scripts/bootstrap.js"></script>
    <script src="/Scripts/db.js"></script>
    <script src="/Scripts/mousetrap/mousetrap.min.js"></script>
    <link href="/css/bootstrap.css" rel="stylesheet" />
    <link href="/css/menu.css" rel="stylesheet">
    <link rel="stylesheet" href="css/fa/css/font-awesome.min.css">

    <%--<noscript><meta HTTP-EQUIV="refresh" content=0;url ="noscript.html"></noscript>--%>

    <%
        Response.Write(
            "<style>" + Environment.NewLine +
        "@font-face {" + Environment.NewLine +
            "font-family: " + GetFont() + ";" + Environment.NewLine +
            "src: url(font/" + GetFont() + ".woff);" + Environment.NewLine +
        "}" + Environment.NewLine +
        "</style>"
            );

    %>
</head>
<body dir="rtl" <% Response.Write("style=font-family:'" + GetFont() + "'"); %>>

    <nav class="navbar navbar-icon-top navbar-expand-sm navbar-dark bg-dark">
        <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarSupportedContent" aria-controls="navbarSupportedContent" aria-expanded="false" aria-label="Toggle navigation">
            <span class="navbar-toggler-icon"></span>
        </button>

        <div class="collapse navbar-collapse" id="navbarSupportedContent">
            <ul class="navbar-nav mr-auto">
                <% 
                    foreach (var item in GetItems())
                    {
                %>
                <li class="nav-item <% if (item.Text.Equals("home")) { Response.Write("active"); } %>">
                    <a class="nav-link" href="#" <% if (item.Text.Equals("exit")) { Response.Write("onclick='logout();'"); } %>>
                        <i class="<%=item.FontIcon %>"></i>
                        <%=item.Title %>
                    </a>
                </li>
                <%
                    }
                %>
            </ul>
        </div>
    </nav>

    <nav class="navbar navbar-dark bg-dark w-100 bottomNav">
        <ul class="text-light lead">
            <li class="nav-item badge bg-success">شرکت:
            </li>
            <li class="nav-item badge bg-info">سال مالی:
            </li>
            <li class="nav-item badge bg-danger">کاربر:
                <script>document.write(localStorage.getItem("username") + '(' + localStorage.getItem("id") + ')');</script>
            </li>
            <li class="nav-item badge bg-primary">پرسنلی: فرهاد آریامرام
            </li>
            <li class="nav-item badge bg-warning">تاریخ: <%= DateTime.Now.ToShortDateString() %>
            </li>
        </ul>
    </nav>
    <script>
        <% 
        foreach (var item in GetItems())
        {
        %>
        Mousetrap.bind('<%= item.Hotkey %>', function () { hotkeyDo('<%= item.Text %>'); });
        <% 
        }
        %>

        function hotkeyDo(pcode) {

            window.location.href = 'foo.html?p=' + pcode;
        }
    </script>
</body>
</html>



