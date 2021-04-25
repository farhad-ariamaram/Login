<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MenuLanguageForm.aspx.cs" Inherits="NewTest.MenuLanguageForm" %>

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
            $("#addSection").hide();

            $("#addbtn").click(function () {
                $("#updatesubmitbtn").hide();
                $("#submitbtn").show();
                $("#addSection").show();
                $("#table").hide();
            });

            $("#cancelbtn").click(function () {
                $("#addSection").hide();
                $("#table").show();
            });

            $.ajax({
                type: "POST",
                url: "WebServices.aspx/readMenuDropdown",
                contentType: "application/json;charset=utf-8",
                dataType: "json",
                success: function (response) {
                    $.each(response.d, function (i, item) {
                        var optionRow = "<option value=" + item._Fld_Sitestyle_Menu_Id + ">" + item._Fld_Sitestyle_Menu_Text + "</option>";
                        $(optionRow).appendTo('#DropdownMenu');
                    });
                },
                failure: function () {
                    alert("there is a error!");
                }
            });

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

            refreshdata();
        });

        function submitdata() {
            $("#addSection").hide();
            $("#table").show();

            var title = $('#txtTitle').val();
            var tooltip = $('#txtTooltip').val();
            var menu = $("#DropdownMenu").val();
            var lang = $("#DropdownLanguage").val();
            var obj =
            {
                "_Fld_Sitestyle_MenuLanguage_Id": "0",
                "_Fld_Sitestyle_MenuLanguage_Title": title,
                "_Fld_Sitestyle_MenuLanguage_Tooltip": tooltip,
                "_Fld_Sitestyle_MenuLanguage_MenuId": menu,
                "_Fld_Sitestyle_MenuLanguage_LanguageId": lang
            };

            $.ajax({
                type: "POST",
                url: "WebServices.aspx/createMenuLanguage",
                contentType: "application/json",
                data: JSON.stringify({ obj: obj }),
                success: function (data) {
                    refreshdata();
                },
                error: function (errordata) {
                    alert('failure');
                }
            });
        }

        function deleteitem(idd) {
            var r = confirm("برای حذف مطمئن هستید؟")
            if (r == true) {
                var data = {};
                data.id = idd;
                $.ajax({
                    type: "POST",
                    url: "WebServices.aspx/deleteMenuLanguage",
                    contentType: "application/json;charset=utf-8",
                    dataType: "json",
                    data: JSON.stringify(data),
                    success: function (response) {
                        refreshdata();
                    },
                    failure: function () {
                        alert('failure');
                    }
                });
            }
        }

        var uid;

        function updateitem(idd) {
            uid = idd;
            $("#updatesubmitbtn").show();
            $("#submitbtn").hide();
            $("#addSection").show();
            $("#table").hide();
            var data = {};
            data.id = idd;
            $.ajax({
                type: "POST",
                url: "WebServices.aspx/readMenuLanguageById",
                contentType: "application/json;charset=utf-8",
                dataType: "json",
                data: JSON.stringify(data),
                success: function (response) {
                    $.each(response.d, function (i, item) {
                        $('#txtTitle').val(item._Fld_Sitestyle_MenuLanguage_Title);
                        $('#txtTooltip').val(item._Fld_Sitestyle_MenuLanguage_Tooltip);
                        $("#DropdownMenu").val(item._Fld_Sitestyle_MenuLanguage_MenuId);
                        $("#DropdownLanguage").val(item._Fld_Sitestyle_MenuLanguage_LanguageId);
                    });
                },
                failure: function () {
                    alert("there is a error!");
                }
            });
        }

        function refreshdata() {
            $("#tbodyid").empty();

            $.ajax({
                type: "POST",
                url: "WebServices.aspx/readMenuLanguage",
                contentType: "application/json;charset=utf-8",
                dataType: "json",
                success: function (response) {
                    $.each(response.d, function (i, item) {
                        $('<tr>').html("<td>" + item._Fld_Sitestyle_MenuLanguage_Title + "</td><td>" + item._Fld_Sitestyle_MenuLanguage_Tooltip + "</td><td>" + item._Fld_Sitestyle_MenuLanguage_Menu + "</td><td>" + item._Fld_Sitestyle_MenuLanguage_Language + "</td><td><a class='btn btn-primary' onclick='updateitem(" + item._Fld_Sitestyle_MenuLanguage_Id + ")'>ویرایش</a><a class='btn btn-danger' onclick='deleteitem(" + item._Fld_Sitestyle_MenuLanguage_Id + ")'>حذف</a></td>").appendTo('#table');
                    });
                },
                failure: function () {
                    alert("there is a error!");
                }
            });
        }

        function updatesubmitdata() {
            var id = uid;
            var title = $('#txtTitle').val();
            var tooltip = $('#txtTooltip').val();
            var menu = $("#DropdownMenu").val();
            var lang = $("#DropdownLanguage").val();
            var obj =
            {
                "_Fld_Sitestyle_MenuLanguage_Id": id,
                "_Fld_Sitestyle_MenuLanguage_Title": title,
                "_Fld_Sitestyle_MenuLanguage_Tooltip": tooltip,
                "_Fld_Sitestyle_MenuLanguage_MenuId": menu,
                "_Fld_Sitestyle_MenuLanguage_LanguageId": lang
            };

            $.ajax({
                type: "POST",
                url: "WebServices.aspx/updateMenuLanguage",
                contentType: "application/json",
                data: JSON.stringify({ obj: obj }),
                success: function (data) {
                    refreshdata();
                    $("#addSection").hide();
                    $("#table").show();
                },
                error: function (errordata) {
                    alert('failure');
                }
            });
        }
    </script>

</head>
<body>
    <div class="container">
        <h2>لیست اعلان ها</h2>
        <a id="addbtn" class="btn btn-success text-light">افزودن</a>
        <div id="addSection">
            <div class="row">
                <div id="Form" dir="rtl" class="col-lg-4 col-md-6 col-sm-12 col-12 text-center centered">
                    <form class="form-group" action="#" method="post" id="myform">
                        <div class="form-group">
                            <label class="bg-dark w-100 text-white">افزودن زبان منو</label>
                        </div>
                        <div class="form-group form-inline ">
                            <label class="labels" for="txtTitle">متن</label>
                            <input type="text" id="txtTitle" name="txtTitle" data-msg-required="متن نباید خالی باشد" class="form-control w-100 usertext" placeholder="مثال : " />
                        </div>
                        <div class="form-group form-inline ">
                            <label class="labels" for="txtTooltip">عنوان</label>
                            <input type="text" id="txtTooltip" name="txtTooltip" data-msg-required="عنوان نباید خالی باشد" class="form-control w-100 usertext" placeholder="مثال : " />
                        </div>
                        <div class="form-group form-inline">
                            <label class="labels" for="DropdownMenu">منو</label>
                            <select name="DropdownMenu" id="DropdownMenu" class="w-100">
                            </select>
                        </div>
                        <div class="form-group form-inline">
                            <label class="labels" for="DropdownLanguage">زبان</label>
                            <select name="DropdownLanguage" id="DropdownLanguage" class="w-100">
                            </select>
                        </div>
                        <input type="button" name="submitbtn" id="submitbtn" class="btn btn-primary w-100" value="ثبت" onclick="submitdata()" />
                        <input type="button" name="updatesubmitbtn" id="updatesubmitbtn" class="btn btn-primary w-100" value="ویرایش" onclick="updatesubmitdata()" />
                        <input type="button" name="cancelbtn" id="cancelbtn" class="btn btn-outline-primary w-100 mt-2" value="انصراف" onclick="cancel()" />
                    </form>
                </div>
            </div>
        </div>
        <table class="table table-dark table-hover table-striped" id="table">
            <thead>
                <tr>
                    <th>عنوان</th>
                    <th>Tooltip</th>
                    <th>منو</th>
                    <th>زبان</th>
                    <th></th>
                </tr>
            </thead>
            <tbody id="tbodyid">
            </tbody>
        </table>
    </div>
</body>
</html>
