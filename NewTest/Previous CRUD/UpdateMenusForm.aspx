<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UpdateMenusForm.aspx.cs" Inherits="NewTest.UpdateMenusForm" %>

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
            var id = getUrlParameter('id');
            var data = {};
            data.id = id;
            $.ajax({
                type: "POST",
                url: "WebServices.aspx/readMenuById",
                contentType: "application/json;charset=utf-8",
                dataType: "json",
                data: JSON.stringify(data),
                success: function (response) {
                    $.each(response.d, function (i, item) {
                        $('#txtText').val(item._Fld_Sitestyle_Menu_Text);
                        $('#txtHotkey').val(item._Fld_Sitestyle_Menu_Hotkey);
                        $('#txtFontIcon').val(item._Fld_Sitestyle_Menu_FontIcon);
                        $('#txtImageIcon').val(item._Fld_Sitestyle_Menu_ImageIcon);
                        $('#txtAccess').val(item._Fld_Sitestyle_Menu_AccessId);
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
            var text = $('#txtText').val();
            var hotkey = $('#txtHotkey').val();
            var fonticon = $('#txtFontIcon').val();
            var imageicon = $('#txtImageIcon').val();
            var access = $('#txtAccess').val();
            var obj =
            {
                "_Fld_Sitestyle_Menu_Id": id,
                "_Fld_Sitestyle_Menu_Text": text,
                "_Fld_Sitestyle_Menu_Hotkey": hotkey,
                "_Fld_Sitestyle_Menu_FontIcon": fonticon,
                "_Fld_Sitestyle_Menu_ImageIcon": imageicon,
                "_Fld_Sitestyle_Menu_AccessId": "0",
            };

            $.ajax({
                type: "POST",
                url: "WebServices.aspx/updateMenu",
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
                        <label class="bg-dark w-100 text-white">افزودن منو جدید</label>
                    </div>
                    <div class="form-group form-inline ">
                        <label class="labels" for="txtText">نام</label>
                        <input type="text" id="txtText" name="txtText" data-msg-required="نام نباید خالی باشد" class="form-control w-100 usertext" placeholder="مثال : " />
                    </div>
                    <div class="form-group form-inline ">
                        <label class="labels" for="txtHotkey">کلید میانبر</label>
                        <input type="text" id="txtHotkey" name="txtHotkey" data-msg-required="آیکون نباید خالی باشد" class="form-control w-100 usertext" placeholder="مثال : " />
                    </div>
                    <div class="form-group form-inline ">
                        <label class="labels" for="txtFontIcon">آیکون فونت</label>
                        <input type="text" id="txtFontIcon" name="txtFontIcon" data-msg-required="آیکون نباید خالی باشد" class="form-control w-100 usertext" placeholder="مثال : " />
                    </div>
                    <div class="form-group form-inline ">
                        <label class="labels" for="txtImageIcon">آیکون عکس</label>
                        <input type="text" id="txtImageIcon" name="txtImageIcon" data-msg-required="آیکون نباید خالی باشد" class="form-control w-100 usertext" placeholder="مثال : " />
                    </div>
                    <div class="form-group form-inline ">
                        <label class="labels" for="txtAccess">دسترسی</label>
                        <input type="text" id="txtAccess" name="txtAccess" data-msg-required="آیکون نباید خالی باشد" class="form-control w-100 usertext" placeholder="مثال : " />
                    </div>
                    <input type="button" name="submitbtn" id="submitbtn" class="btn btn-primary w-100" value="ثبت" onclick="submitdata()" />
                    <input type="button" name="cancelbtn" id="cancelbtn" class="btn btn-outline-primary w-100 mt-2" value="انصراف" onclick="cancel()" />
                </form>
            </div>
        </div>
    </div>

</body>
</html>

