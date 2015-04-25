<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="SimpleAjaxService.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script>
        function makeCall(operation) {
            var n1 = document.getElementById("num1").value;
            var n2 = document.getElementById("num2").value;
            if (n1 && n2) {
                var proxy = new SimpleAjexSample.ICalculator();
                switch (operation) {
                    case "Add":
                        proxy.Add(parseFloat(n1), parseFloat(n2), onSuccess, onFail, null);
                        break;
                    case "Sub":
                        proxy.Sub(parseFloat(n1), parseFloat(n2), onSuccess, onFail, null);
                        break;
                    case "Mul":
                        proxy.Mul(parseFloat(n1), parseFloat(n2), onSuccess, onFail, null);
                        break;
                    case "Div":
                        proxy.Div(parseFloat(n1), parseFloat(n2), onSuccess, onFail, null);
                        break;
                }
            }
        }

        function onSuccess(mathResult) {
            document.getElementById("result").value = mathResult;
        }

        function onFail() {
            document.getElementById("result").value = "Error";
        }
    </script>
</head>
<body>
    <div style="width:350px; border:1px solid #ea0000; padding:10px; font-family:sans-serif">
        <h3>Simple Ajax Service Client Page</h3>
        <p>First Num:<input type="text" id="num1" /></p>
        <p>Second Num:<input type="text" id="num2" /></p>
        <input type="button" value="Add" id="btnAdd" onclick="return makeCall('Add');" />
        <input type="button" value="Sub" id="btnSub" onclick="return makeCall('Sub');" />
        <input type="button" value="Mul" id="btnMul" onclick="return makeCall('Mul');" />
        <input type="button" value="Div" id="btnDiv" onclick="return makeCall('Div');" />
        <p>
            Result:
        <input type="text" id="result" />
        </p>
        <form id="mathForm" action="" runat="server">
            <asp:ScriptManager runat="server">
                <Services>
                    <asp:ServiceReference Path="http://localhost:58939/Service1.svc" />
                </Services>
            </asp:ScriptManager>
        </form>
    </div>
</body>
</html>
