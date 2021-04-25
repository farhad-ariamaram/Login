<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DeleteAlertTypesForm.aspx.cs" Inherits="NewTest.DeleteAlertTypesForm" %>

<!DOCTYPE html>
<html>
<head>
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Home Page - My ASP.NET Application</title>
    <link href="/css/bootstrap.css" rel="stylesheet" />
    <link rel="stylesheet" href="css/fa/css/font-awesome.min.css">

    <script src="/Scripts/modernizr-2.8.3.js"></script>
    <script src="/Scripts/jquery-3.3.1.js"></script>

    <script src="/Scripts/jquery.validate.js"></script>
    <script src="/Scripts/jquery.validate.unobtrusive.js"></script>

    <script src="/Scripts/bootstrap.js"></script>

    <%--<noscript><meta HTTP-EQUIV="refresh" content=0;url ="noscript.html"></noscript>--%>

    <style>
        .centered {
            position: fixed;
            top: 50%;
            left: 50%;
            transform: translate(-50%, -50%);
        }

        .error {
            color: red;
            font-weight: bold;
            text-shadow: 3px 3px 15px #ffffff;
        }

        #Form {
            background: rgba(54, 54, 54, .9);
        }

        .labels {
            color: #ffffff;
            font-weight: bold;
        }

        #background {
            background: rgba(54, 54, 54, .8);
        }

    </style>

    <script>

        var getUrlParameter = function getUrlParameter(sParam) {
            var sPageURL = window.location.search.substring(1),
                sURLVariables = sPageURL.split('&'),
                sParameterName,
                i;

            for (i = 0; i < sURLVariables.length; i++) {
                sParameterName = sURLVariables[i].split('=');

                if (sParameterName[0] === sParam) {
                    return typeof sParameterName[1] === undefined ? true : decodeURIComponent(sParameterName[1]);
                }
            }
            return false;
        };

        function submitdata() {
            var id = getUrlParameter('id');
            var data = {};
            data.id = id;
            $.ajax({
                type: "POST",
                url: "WebServices.aspx/deleteAlerttype",
                contentType: "application/json;charset=utf-8",
                dataType: "json",
                data: JSON.stringify(data),
                success: function (response) {
                    alert('success');
                },
                failure: function () {
                    alert('failure');
                }
            });
        }

    </script>

</head>

<body id="background">
    <div class="container" dir="rtl">
        <div class="modal" style="display: block;" role="dialog">
            <div class="modal-dialog" role="document">
                <div class="modal-content">
                    <div class="modal-header">
                        <h5 class="modal-title">حذف</h5>
                    </div>
                    <div class="modal-body">
                        <p> برای حذف عنصر مطمئن هستید؟</p>
                    </div>
                    <div class="modal-footer">
                        <input type="button" class="btn btn-danger" value="حذف" onclick="submitdata()" />
                        <input type="button" class="btn btn-secondary" value="انصراف" onclick="cancel()" />
                    </div>
                </div>
            </div>
        </div>
    </div>
</body>
</html>

