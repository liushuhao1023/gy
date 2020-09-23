<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Admin_CsSet.aspx.cs" Inherits="part4.Admin_CsSet" %>

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
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>
                        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" Caption="产品表" DataKeyNames="lx" DataSourceID="SqlDataSource1" HorizontalAlign="Center">
                            <Columns>
                                <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
                                <asp:BoundField DataField="lx" HeaderText="lx" ReadOnly="True" SortExpression="lx" />
                                <asp:BoundField DataField="pm1" HeaderText="pm1" SortExpression="pm1" />
                                <asp:BoundField DataField="pm2" HeaderText="pm2" SortExpression="pm2" />
                                <asp:BoundField DataField="color" HeaderText="color" SortExpression="color" />
                            </Columns>
                        </asp:GridView>
                        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConflictDetection="CompareAllValues" ConnectionString="<%$ ConnectionStrings:part1ConnectionString %>" DeleteCommand="DELETE FROM [cp] WHERE [lx] = @original_lx AND (([pm1] = @original_pm1) OR ([pm1] IS NULL AND @original_pm1 IS NULL)) AND (([pm2] = @original_pm2) OR ([pm2] IS NULL AND @original_pm2 IS NULL)) AND (([color] = @original_color) OR ([color] IS NULL AND @original_color IS NULL))" InsertCommand="INSERT INTO [cp] ([lx], [pm1], [pm2], [color]) VALUES (@lx, @pm1, @pm2, @color)" OldValuesParameterFormatString="original_{0}" SelectCommand="SELECT * FROM [cp]" UpdateCommand="UPDATE [cp] SET [pm1] = @pm1, [pm2] = @pm2, [color] = @color WHERE [lx] = @original_lx AND (([pm1] = @original_pm1) OR ([pm1] IS NULL AND @original_pm1 IS NULL)) AND (([pm2] = @original_pm2) OR ([pm2] IS NULL AND @original_pm2 IS NULL)) AND (([color] = @original_color) OR ([color] IS NULL AND @original_color IS NULL))">
                            <DeleteParameters>
                                <asp:Parameter Name="original_lx" Type="String" />
                                <asp:Parameter Name="original_pm1" Type="String" />
                                <asp:Parameter Name="original_pm2" Type="String" />
                                <asp:Parameter Name="original_color" Type="String" />
                            </DeleteParameters>
                            <InsertParameters>
                                <asp:Parameter Name="lx" Type="String" />
                                <asp:Parameter Name="pm1" Type="String" />
                                <asp:Parameter Name="pm2" Type="String" />
                                <asp:Parameter Name="color" Type="String" />
                            </InsertParameters>
                            <UpdateParameters>
                                <asp:Parameter Name="pm1" Type="String" />
                                <asp:Parameter Name="pm2" Type="String" />
                                <asp:Parameter Name="color" Type="String" />
                                <asp:Parameter Name="original_lx" Type="String" />
                                <asp:Parameter Name="original_pm1" Type="String" />
                                <asp:Parameter Name="original_pm2" Type="String" />
                                <asp:Parameter Name="original_color" Type="String" />
                            </UpdateParameters>
                        </asp:SqlDataSource>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>产品类型<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>杯盖<asp:DropDownList ID="DropDownList1" runat="server">
                        <asp:ListItem>A101</asp:ListItem>
                        <asp:ListItem>A102</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>杯身<asp:DropDownList ID="DropDownList2" runat="server">
                        <asp:ListItem>B101</asp:ListItem>
                        <asp:ListItem>B102</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>颜色<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>
                        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="添加" />
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>
                        <asp:Button ID="Button2" runat="server" PostBackUrl="~/Admin_Main.aspx" Text="返回" />
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
