<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="KB.aspx.cs" Inherits="part4.KB" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 20px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <table style="width: 100%; text-align: center;">
            <tr>
                <td>看板界面</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>
                    <asp:GridView ID="GridView1" runat="server" Caption="监控" HorizontalAlign="Center" AutoGenerateColumns="False" DataKeyNames="id" DataSourceID="SqlDataSource1">
                        <Columns>
                            <asp:BoundField DataField="id" HeaderText="id" ReadOnly="True" SortExpression="id" />
                            <asp:BoundField DataField="name" HeaderText="设备名" SortExpression="name" />
                            <asp:BoundField DataField="status" HeaderText="状态" SortExpression="status" />
                        </Columns>
                    </asp:GridView>
                    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConflictDetection="CompareAllValues" ConnectionString="<%$ ConnectionStrings:part1ConnectionString %>" DeleteCommand="DELETE FROM [sb] WHERE [id] = @original_id AND (([name] = @original_name) OR ([name] IS NULL AND @original_name IS NULL)) AND (([status] = @original_status) OR ([status] IS NULL AND @original_status IS NULL))" InsertCommand="INSERT INTO [sb] ([id], [name], [status]) VALUES (@id, @name, @status)" OldValuesParameterFormatString="original_{0}" SelectCommand="SELECT * FROM [sb]" UpdateCommand="UPDATE [sb] SET [name] = @name, [status] = @status WHERE [id] = @original_id AND (([name] = @original_name) OR ([name] IS NULL AND @original_name IS NULL)) AND (([status] = @original_status) OR ([status] IS NULL AND @original_status IS NULL))">
                        <DeleteParameters>
                            <asp:Parameter Name="original_id" Type="String" />
                            <asp:Parameter Name="original_name" Type="String" />
                            <asp:Parameter Name="original_status" Type="String" />
                        </DeleteParameters>
                        <InsertParameters>
                            <asp:Parameter Name="id" Type="String" />
                            <asp:Parameter Name="name" Type="String" />
                            <asp:Parameter Name="status" Type="String" />
                        </InsertParameters>
                        <UpdateParameters>
                            <asp:Parameter Name="name" Type="String" />
                            <asp:Parameter Name="status" Type="String" />
                            <asp:Parameter Name="original_id" Type="String" />
                            <asp:Parameter Name="original_name" Type="String" />
                            <asp:Parameter Name="original_status" Type="String" />
                        </UpdateParameters>
                    </asp:SqlDataSource>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1"></td>
                <td class="auto-style1">
                    <asp:Button ID="Button1" runat="server" Text="监控" />
                </td>
                <td class="auto-style1"></td>
            </tr>
            <tr>
                <td class="auto-style1">&nbsp;</td>
                <td class="auto-style1">&nbsp;</td>
                <td class="auto-style1">
                    <asp:Button ID="Button2" runat="server" Text="返回" OnClick="Button2_Click" style="height: 21px; width: 40px" />
                </td>
            </tr>
        </table>
        <div>
        </div>
    </form>
</body>
</html>
