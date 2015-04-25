<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="JSONPClient.aspx.cs" Inherits="WebApplication1.JSONPClient" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script>
        function makeCall() {
            var proxy = new JsonAjaxService.IService1();
            proxy.set_enableJsonp(true);
            proxy.GetCustomer(onSuccess, onFail,null);
        }
        function onSuccess(result) {
            document.getElementById("name").value = result.Name;
            document.getElementById("address").value = result.Address;
        }
        function onFail() {
            document.getElementById("name").value = "Error";
            document.getElementById("address").value = "Error";
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <asp:ScriptManager runat="server" >
            <Services>
                <asp:ServiceReference Path="http://localhost:58025/Service1.svc" />
            </Services>
        </asp:ScriptManager>
        <h1>
            name : <input type="text" id="name" />
            address: <input type="text" id="address" />
        </h1>
        <script type="text/javascript" defer="defer">makeCall();</script>
    </form>
</body>
</html>
