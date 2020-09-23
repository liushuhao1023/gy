<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Admin_Wl.aspx.cs" Inherits="part4.Admin_Wl" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 172px;
        }
        .auto-style2 {
            height: 25px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table style="width: 100%; text-align: center;">
                <tr>
                    <td>物料入库界面</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style1"></td>
                    <td class="auto-style1">
                        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" Caption="料仓表" DataKeyNames="id" DataSourceID="SqlDataSource1" HorizontalAlign="Center">
                            <Columns>
                                <asp:BoundField DataField="id" HeaderText="料仓号" ReadOnly="True" SortExpression="id" />
                                <asp:BoundField DataField="mid" HeaderText="物料编号" SortExpression="mid" />
                                <asp:BoundField DataField="num" HeaderText="数量" SortExpression="num" />
                            </Columns>
                        </asp:GridView>
                        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConflictDetection="CompareAllValues" ConnectionString="<%$ ConnectionStrings:part1ConnectionString %>" DeleteCommand="DELETE FROM [lc] WHERE [id] = @original_id AND (([mid] = @original_mid) OR ([mid] IS NULL AND @original_mid IS NULL)) AND (([num] = @original_num) OR ([num] IS NULL AND @original_num IS NULL))" InsertCommand="INSERT INTO [lc] ([id], [mid], [num]) VALUES (@id, @mid, @num)" OldValuesParameterFormatString="original_{0}" SelectCommand="SELECT * FROM [lc]" UpdateCommand="UPDATE [lc] SET [mid] = @mid, [num] = @num WHERE [id] = @original_id AND (([mid] = @original_mid) OR ([mid] IS NULL AND @original_mid IS NULL)) AND (([num] = @original_num) OR ([num] IS NULL AND @original_num IS NULL))">
                            <DeleteParameters>
                                <asp:Parameter Name="original_id" Type="String" />
                                <asp:Parameter Name="original_mid" Type="String" />
                                <asp:Parameter Name="original_num" Type="String" />
                            </DeleteParameters>
                            <InsertParameters>
                                <asp:Parameter Name="id" Type="String" />
                                <asp:Parameter Name="mid" Type="String" />
                                <asp:Parameter Name="num" Type="String" />
                            </InsertParameters>
                            <UpdateParameters>
                                <asp:Parameter Name="mid" Type="String" />
                                <asp:Parameter Name="num" Type="String" />
                                <asp:Parameter Name="original_id" Type="String" />
                                <asp:Parameter Name="original_mid" Type="String" />
                                <asp:Parameter Name="original_num" Type="String" />
                            </UpdateParameters>
                        </asp:SqlDataSource>
                    </td>
                    <td class="auto-style1"></td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>料仓<asp:DropDownList ID="DropDownList1" runat="server">
                        <asp:ListItem>1</asp:ListItem>
                        <asp:ListItem>2</asp:ListItem>
                        <asp:ListItem>3</asp:ListItem>
                        <asp:ListItem>4</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2"></td>
                    <td class="auto-style2">物料<asp:DropDownList ID="DropDownList2" runat="server">
                        <asp:ListItem>A101</asp:ListItem>
                        <asp:ListItem>A102</asp:ListItem>
                        <asp:ListItem>B101</asp:ListItem>
                        <asp:ListItem>B102</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                    <td class="auto-style2"></td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>数量<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>
                        <asp:Button ID="Button1" runat="server" Text="配置" OnClick="Button1_Click" />
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>
                        <asp:Button ID="Button2" runat="server" Text="返回" OnClick="Button2_Click" />
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
