<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddCssForm.aspx.cs" Inherits="NewTest.AddCssForm" %>

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
                url: "WebServices.aspx/readLanguageDropdown",
                contentType: "application/json;charset=utf-8",
                dataType: "json",
                success: function (response) {
                    $.each(response.d, function (i, item) {
                        var optionRow = "<option value=" + item._Fld_Sitestyle_Language_Id + ">" + item._Fld_Sitestyle_Language_Text + "</option>";
                        $(optionRow).appendTo('#DropdownLanguage');
                    });
                },
                failure: function () {
                    alert("there is a error!");
                }
            });

        });

        function submitdata() {
            var text = $('#txtText').val();
            var lang = $("#DropdownLanguage").val();
            var obj =
            {
                "_Fld_Sitestyle_Css_Id": "0",
                "_Fld_Sitestyle_Css_Name": text,
                "_Fld_Sitestyle_Css_LanguageId": lang
            };

            $.ajax({
                type: "POST",
                url: "WebServices.aspx/createCss",
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
                        <label class="bg-dark w-100 text-white">افزودن CSS</label>
                    </div>
                    <div class="form-group form-inline ">
                        <label class="labels" for="txtText">متن</label>
                        <input type="text" id="txtText" name="txtText" data-msg-required="متن نباید خالی باشد" class="form-control w-100 usertext" placeholder="مثال : " />
                    </div>
                    <div class="form-group form-inline">
                        <label class="labels" for="DropdownLanguage">زبان</label>
                        <select name="DropdownLanguage" id="DropdownLanguage" class="w-100">
                        </select>
                    </div>
                    <input type="button" name="submitbtn" id="submitbtn" class="btn btn-primary w-100" value="ثبت" onclick="submitdata()" />
                    <input type="button" name="cancelbtn" id="cancelbtn" class="btn btn-outline-primary w-100 mt-2" value="انصراف" onclick="cancel()" />
                </form>
            </div>
        </div>
    </div>

</body>
</html>