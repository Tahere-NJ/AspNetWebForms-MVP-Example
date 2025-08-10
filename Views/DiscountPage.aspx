<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DiscountPage.aspx.cs" Inherits="DiscountCalculatorWebApp.Views.DiscountPage" %>

<!DOCTYPE html>
<html>
<head>
    <title>Discount Calculator (MVP)</title>
</head>
<body>
    <h1>Discount Calculator</h1>
    <asp:TextBox ID="txtPrice" runat="server" />
    <asp:Button ID="btnCalculate" runat="server" Text="Calculate" OnClick="btnCalculate_Click" />
    <asp:Label ID="lblResult" runat="server" />
    <asp:Label ID="lblError" runat="server" ForeColor="Red" />
</body>
</html>