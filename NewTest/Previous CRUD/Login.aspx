<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="NewTest.Login" %>

<!DOCTYPE html>
<html>
<head>
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Home Page - My ASP.NET Application</title>
    <link href="/css/bootstrap.css" rel="stylesheet" />

    <script src="/Scripts/modernizr-2.8.3.js"></script>
    <script src="/Scripts/jquery-3.3.1.js"></script>

    <script src="/Scripts/jquery.validate.js"></script>
    <script src="/Scripts/jquery.validate.unobtrusive.js"></script>

    <script src="/Scripts/bootstrap.js"></script>
    <script src="/Scripts/rotate.js"></script>

    <script src="/Scripts/db.js"></script>

    <noscript><meta HTTP-EQUIV="refresh" content=0;url ="noscript.html"></noscript>

    <style>
        @font-face {
            font-family: Yekan;
            src: url(font/Yekan.woff);
        }

        body {
            font-family: Yekan;
        }

        .centered {
            position: fixed;
            top: 50%;
            left: 50%;
            transform: translate(-50%, -50%);
        }

        img {
            max-width: 100%;
            height: auto;
        }



        @media screen and (min-width: 576px) {

            .mobile {
                display: none !important;
            }
        }

        .mobile {
            display: block;
        }

        .error {
            color: red;
            font-weight: bold;
            text-shadow: 3px 3px 15px #ffffff;
        }

        #login {
            display: none;
            background: rgba(54, 54, 54, .7);
        }

        #labels {
            color: rgb(255,165,0);
            font-weight: bold;
            display: block;
        }

        .title {
            display: block;
            height: 40px;
            clear: both;
        }
    </style>

    <script>

        $(document).ready(function () {

            $('#refresh').click(function () {
                $(this).rotate();
            }).click();

            var win = $(this);
            if (win.width() >= 576) {
                $('.usertext').attr("placeholder", "نام کاربری");
                $('.passtext').attr("placeholder", "کلمه عبور");
            } else {
                $('.usertext').removeAttr('placeholder');
                $('.passtext').removeAttr('placeholder');
            }
            $(window).on('resize', function () {
                var win = $(this);
                if (win.width() >= 576) {
                    $('.usertext').attr("placeholder", "نام کاربری");
                    $('.passtext').attr("placeholder", "کلمه عبور");
                } else {
                    $('.usertext').removeAttr('placeholder');
                    $('.passtext').removeAttr('placeholder');
                }
            });

            $('#myform').validate({
                error: function (label) {
                    $(this).addClass("error");
                }, rules: {
                    txtUserName: "required",
                    txtPassword: "required",
                    code: "required"
                }
            });

            var images = ['1.jpeg', '2.jpeg', '3.jpeg', '4.jpeg', '5.jpeg', '6.jpeg', '8.jpeg', '9.jpeg'];
            $('#background').css({ 'background-image': 'url(image/' + images[Math.floor(Math.random() * images.length)] + ')' });
            $('#background').css({ 'background-size': 'cover' });
            $('#background').css({ 'background-repeat': 'no-repeat' });
            $('#background').css({ 'background-attachment': 'fixed' });


            $("#login").fadeIn()
                .css({ top: 1000, position: 'absolute' })
                .animate({ top: 275 }, 800, function () {
                });

        });
    </script>

</head>
<body id="background">

    <div class="container">
        <div class="row">
            <div id="login" dir="rtl" class="col-lg-4 col-md-6 col-sm-12 col-12 text-center centered">
                <form class="form-group" action="#" method="post" id="myform" runat="server">
                    <div class="form-group">
                        <label class="bg-dark w-100 text-white">ورود به سامانه</label>
                    </div>
                    <div class="form-group form-inline ">
                        <label class="mobile" id="labels" for="txtUserName">نام کاربری</label>
                        <asp:TextBox ID="txtUserName" runat="server" data-msg-required="نام کاربری نمی‌تواند خالی باشد" type="text" Class="form-control w-100 usertext" name="txtUserName" placeholder="نام کاربری" />
                    </div>
                    <div class="form-group form-inline ">
                        <label class="mobile" id="labels" for="txtPassWord">رمز ورود</label>
                        <asp:TextBox ID="txtPassword" runat="server" data-msg-required="کلمه عبور نمی‌تواند خالی باشد" type="password" Class="form-control w-100 passtext" name="txtPassword" placeholder="کلمه عبور" />
                    </div>

                    <div class="form-group form-inline title" style="list-style-type: none;">
                        <span style="float: right">
                            <label style="display: inline-block;" id="labels" for="remember">
                                12 ساعت
                                <input style="display: inline-block;" type="checkbox" name="remember">
                            </label>
                        </span>
                        <span style="float: left">
                            <img style="display: inline-block;" id="imgCaptcha" src="foo.png">
                            <img style="display: inline-block;" id="refresh" src="image/refreshs.png" height="20" width="20">
                        </span>
                    </div>

                    <div class="form-group">
                        <input data-msg-required="کد امنیتی نمی‌تواند خالی باشد" type="text" class="form-control" name="code" placeholder="تصویر امنیتی">
                    </div>
                    <br />
                    <asp:Button ID="loginbtn" class="btn btn-primary w-100" runat="server" Text="ورود به سیستم" OnClick="btnSubmit_Click" />
                </form>
            </div>
        </div>
    </div>

</body>
</html>

