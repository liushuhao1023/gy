<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Admin_Main.aspx.cs" Inherits="part4.Admin_Main" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table style="width: 100%; text-align: center;">
                <tr>
                    <td>管理员主界面</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>
                        <asp:Button ID="Button1" runat="server" PostBackUrl="~/Admin_OrderSearch.aspx" Text="订单查询" />
                    </td>
                    <td>
                        <asp:Button ID="Button2" runat="server" PostBackUrl="~/Admin_User.aspx" Text="用户管理" />
                    </td>
                    <td>
                        <asp:Button ID="Button3" runat="server" PostBackUrl="~/KB.aspx" Text="看板界面" />
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>
                        <asp:Button ID="Button4" runat="server" PostBackUrl="~/Admin_Wl.aspx" Text="物料入库" />
                    </td>
                    <td>
                        <asp:Button ID="Button5" runat="server" PostBackUrl="~/LC.aspx" Text="库存管理" />
                    </td>
                    <td>
                        <asp:Button ID="Button7" runat="server" PostBackUrl="~/Admin_CsSet.aspx" Text="参数设置" />
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>
                        <asp:Button ID="Button6" runat="server" PostBackUrl="~/Login.aspx" Text="返回" />
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
