<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CS.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script type="text/javascript" src="http://ajax.googleapis.com/ajax/libs/jquery/1/jquery.min.js"></script>
    <script type = "text/javascript">
        $("#demo").live("click", function () {
            $.ajax({
                type: "POST",
                url: "CS.aspx/LoadUserControl",
                data: "{message: '" + $("#message").val() + "'}",
                contentType: "application/json; charset=utf-8",
                dataType: "json",
                success: function (r) {
                    $("#Content").append(r.d);
                }
            });
        });
    </script>
</head>
<body>
    <form id="form1" runat="server">
    <input type = "text" id = "message" />
    <input type = "button" id = "demo" value = "Load" />
    <div id  = "Content">
    Hello
    </div>
    </form>
</body>
</html>
