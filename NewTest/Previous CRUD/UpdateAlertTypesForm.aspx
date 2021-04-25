﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UpdateAlertTypesForm.aspx.cs" Inherits="NewTest.UpdateAlertTypesForm" %>

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

        $(document).ready(function () {

            $.ajax({
                type: "POST",
                url: "WebServices.aspx/readAlertTypeDropdown",
                contentType: "application/json;charset=utf-8",
                dataType: "json",
                success: function (response) {
                    $.each(response.d, function (i, item) {
                        var optionRow = "<option value=" + item._Fld_Sitestyle_Alerttype_Id + ">" + item._Fld_Sitestyle_Alerttype_Name + "</option>";
                        $(optionRow).appendTo('#DropdownAlertType');
                    });
                },
                failure: function () {
                    alert("there is a error!");
                }
            });

            var id = getUrlParameter('id');
            var data = {};
            data.id = id;
            $.ajax({
                type: "POST",
                url: "WebServices.aspx/readAlerttypeById",
                contentType: "application/json;charset=utf-8",
                dataType: "json",
                data: JSON.stringify(data),
                success: function (response) {
                    $.each(response.d, function (i, item) {
                        $('#txtName').val(item._Fld_Sitestyle_Alerttype_Name);
                        $('#txtIcon').val(item._Fld_Sitestyle_Alerttype_Icon);
                    });
                },
                failure: function () {
                    alert("there is a error!");
                }
            });

        });

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
            var name = $('#txtName').val();
            var icon = $('#txtIcon').val();
            var obj =
            {
                "_Fld_Sitestyle_Alerttype_Id": id,
                "_Fld_Sitestyle_Alerttype_Name": name,
                "_Fld_Sitestyle_Alerttype_Icon": icon,
            };

            $.ajax({
                type: "POST",
                url: "WebServices.aspx/updateAlertType",
                contentType: "application/json",
                data: JSON.stringify({ obj: obj }),
                success: function (data) {
                    alert('success');
                },
                error: function (errordata) {
                    alert('failure');
                }
            });
        }

    </script>

    <%--    <script>

        $(document).ready(function () {

            $('#myform').validate({
                error: function (label) {
                    $(this).addClass("error");
                }, rules: {
                    txtUserName: "required",
                    txtPassword: "required",
                    code: "required"
                }
            });

        });
    </script>--%>
</head>
<body id="background">

    <div class="container">
        <div class="row">
            <div id="Form" dir="rtl" class="col-lg-4 col-md-6 col-sm-12 col-12 text-center centered">
                <form class="form-group" action="#" method="post" id="myform">
                    <div class="form-group">
                        <label class="bg-dark w-100 text-white">افزودن نوع اعلان جدید</label>
                    </div>
                    <div class="form-group form-inline ">
                        <label class="labels" for="txtName">نام</label>
                        <input type="text" id="txtName" name="txtName" data-msg-required="نام نباید خالی باشد" class="form-control w-100 usertext" placeholder="مثال : " />
                    </div>
                    <div class="form-group form-inline ">
                        <label class="labels" for="txtIcon">آیکون</label>
                        <input type="text" id="txtIcon" name="txtIcon" data-msg-required="آیکون نباید خالی باشد" class="form-control w-100 usertext" placeholder="مثال : " />
                    </div>
                    <input type="button" name="submitbtn" id="submitbtn" class="btn btn-primary w-100" value="ثبت" onclick="submitdata()" />
                    <input type="button" name="cancelbtn" id="cancelbtn" class="btn btn-outline-primary w-100 mt-2" value="انصراف" onclick="cancel()" />
                </form>
            </div>
        </div>
    </div>

</body>
</html>


