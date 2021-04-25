<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ReadLanguageForm.aspx.cs" Inherits="NewTest.ReadLanguageForm" %>

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
                url: "WebServices.aspx/readLanguage",
                contentType: "application/json;charset=utf-8",
                dataType: "json",
                success: function (response) {
                    $.each(response.d, function (i, item) {
                        $('<tr>').html("<td>" + item._Fld_Sitestyle_Language_Direction + "</td><td>" + item._Fld_Sitestyle_Language_Text + "</td><td>" + item._Fld_Sitestyle_Language_Iso639_1 + "</td><td>" + item._Fld_Sitestyle_Language_Iso639_2 + "</td><td>" + item._Fld_Sitestyle_Language_Iso639_3 + "</td>").appendTo('#table'); 
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
                    <th>چینش</th>
                    <th>نام</th>
                    <th>ISO639-1</th>
                    <th>ISO639-2</th>
                    <th>ISO639-3</th>
                </tr>
            </thead>
            <tbody>
            </tbody>
        </table>
    </div>
</body>
</html>


