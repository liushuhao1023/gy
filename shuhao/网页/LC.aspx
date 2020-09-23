<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LC.aspx.cs" Inherits="part4.LC" %>

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
                    <td>库存管理界面</td>
                    <td>当前安全生产值为：<asp:Label ID="Label1" runat="server"></asp:Label>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>
                        <asp:GridView ID="GridView1" runat="server" Caption="物料表" HorizontalAlign="Center" AutoGenerateColumns="False" DataKeyNames="id" DataSourceID="SqlDataSource1">
                            <Columns>
                                <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
                                <asp:BoundField DataField="id" HeaderText="id" ReadOnly="True" SortExpression="id" />
                                <asp:BoundField DataField="mid" HeaderText="物料编号" SortExpression="mid" />
                                <asp:BoundField DataField="color" HeaderText="颜色" SortExpression="color" />
                                <asp:BoundField DataField="num" HeaderText="数量" SortExpression="num" />
                            </Columns>
                        </asp:GridView>
                        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConflictDetection="CompareAllValues" ConnectionString="<%$ ConnectionStrings:part1ConnectionString %>" DeleteCommand="DELETE FROM [wl] WHERE [id] = @original_id AND (([mid] = @original_mid) OR ([mid] IS NULL AND @original_mid IS NULL)) AND (([color] = @original_color) OR ([color] IS NULL AND @original_color IS NULL))" InsertCommand="INSERT INTO [wl] ([id], [mid], [color]) VALUES (@id, @mid, @color)" OldValuesParameterFormatString="original_{0}" SelectCommand="SELECT * FROM [wl]" UpdateCommand="UPDATE [wl] SET [mid] = @mid, [color] = @color WHERE [id] = @original_id AND (([mid] = @original_mid) OR ([mid] IS NULL AND @original_mid IS NULL)) AND (([color] = @original_color) OR ([color] IS NULL AND @original_color IS NULL))">
                            <DeleteParameters>
                                <asp:Parameter Name="original_id" Type="String" />
                                <asp:Parameter Name="original_mid" Type="String" />
                                <asp:Parameter Name="original_color" Type="String" />
                            </DeleteParameters>
                            <InsertParameters>
                                <asp:Parameter Name="id" Type="String" />
                                <asp:Parameter Name="mid" Type="String" />
                                <asp:Parameter Name="color" Type="String" />
                            </InsertParameters>
                            <UpdateParameters>
                                <asp:Parameter Name="mid" Type="String" />
                                <asp:Parameter Name="color" Type="String" />
                                <asp:Parameter Name="original_id" Type="String" />
                                <asp:Parameter Name="original_mid" Type="String" />
                                <asp:Parameter Name="original_color" Type="String" />
                            </UpdateParameters>
                        </asp:SqlDataSource>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>安全生产值<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>
                        <asp:Button ID="Button1" runat="server" Text="配置" OnClick="Button1_Click" />
                    </td>
                    <td>
                        <asp:Button ID="Button2" runat="server" PostBackUrl="~/Admin_Main.aspx" Text="返回" />
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
