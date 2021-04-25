<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ReadMenuForm.aspx.cs" Inherits="NewTest.ReadMenuForm" %>

<!DOCTYPE html>
<html>
<head>
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Home Page - My ASP.NET Application</title>

    <link href="/css/bootstrap.css" rel="stylesheet" />
    <link rel="stylesheet" href="css/fa/css/font-awesome.min.css">

    <script src="/Scripts/jquery-3.3.1.js"></script>
    <script src="/Scripts/bootstrap.js"></script>

    <%--<noscript><meta HTTP-EQUIV="refresh" content=0;url ="noscript.html"></noscript>--%>

    <style>
        #background {
            background: rgba(54, 54, 54, .8);
        }
    </style>

    <script>
        $(document).ready(function () {
            $.ajax({
                type: "POST",
                url: "WebServices.aspx/readMenu",
                contentType: "application/json;charset=utf-8",
                dataType: "json",
                success: function (response) {
                    $.each(response.d, function (i, item) {
                        $('<tr>').html("<td>" + item._Fld_Sitestyle_Menu_Text + "</td><td>" + item._Fld_Sitestyle_Menu_Hotkey + "</td><td>" + item._Fld_Sitestyle_Menu_FontIcon + "</td><td>" + item._Fld_Sitestyle_Menu_ImageIcon + "</td><td>" + item._Fld_Sitestyle_Menu_AccessId + "</td>").appendTo('#table'); 
                    });
                },
                failure: function () {
                    alert("there is a error!");
                }
            });
        });
    </script>

</head>
<body id="background" dir="rtl">
    <div class="container">
        <h2>لیست زبان ها</h2>
        <table class="table table-dark table-hover table-striped" id="table">
            <thead>
                <tr>
                    <th>متن</th>
                    <th>کلید میانبر</th>
                    <th>آیکون فونت</th>
                    <th>آیکون تصویر</th>
                    <th>دسترسی</th>
                </tr>
            </thead>
            <tbody>
            </tbody>
        </table>
    </div>
</body>
</html>



