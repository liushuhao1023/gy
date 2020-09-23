<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Admin_User.aspx.cs" Inherits="part4.Admin_User" %>

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
                    <td>用户管理界面</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>
                        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" Caption="用户表" DataKeyNames="userid" DataSourceID="SqlDataSource1" HorizontalAlign="Center">
                            <Columns>
                                <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
                                <asp:BoundField DataField="userid" HeaderText="账号" ReadOnly="True" SortExpression="userid" />
                                <asp:BoundField DataField="pwd" HeaderText="密码" SortExpression="pwd" />
                                <asp:BoundField DataField="address" HeaderText="地址" SortExpression="address" />
                                <asp:CheckBoxField DataField="suborder" HeaderText="提交订单权限" SortExpression="suborder" />
                                <asp:CheckBoxField DataField="searchorder" HeaderText="查询订单权限" SortExpression="searchorder" />
                                <asp:BoundField DataField="logintime" HeaderText="登陆时间" SortExpression="logintime" />
                            </Columns>
                        </asp:GridView>
                        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConflictDetection="CompareAllValues" ConnectionString="<%$ ConnectionStrings:part1ConnectionString %>" DeleteCommand="DELETE FROM [t_user] WHERE [userid] = @original_userid AND (([pwd] = @original_pwd) OR ([pwd] IS NULL AND @original_pwd IS NULL)) AND (([address] = @original_address) OR ([address] IS NULL AND @original_address IS NULL)) AND (([suborder] = @original_suborder) OR ([suborder] IS NULL AND @original_suborder IS NULL)) AND (([searchorder] = @original_searchorder) OR ([searchorder] IS NULL AND @original_searchorder IS NULL)) AND (([logintime] = @original_logintime) OR ([logintime] IS NULL AND @original_logintime IS NULL))" InsertCommand="INSERT INTO [t_user] ([userid], [pwd], [address], [suborder], [searchorder], [logintime]) VALUES (@userid, @pwd, @address, @suborder, @searchorder, @logintime)" OldValuesParameterFormatString="original_{0}" SelectCommand="SELECT * FROM [t_user]" UpdateCommand="UPDATE [t_user] SET [pwd] = @pwd, [address] = @address, [suborder] = @suborder, [searchorder] = @searchorder, [logintime] = @logintime WHERE [userid] = @original_userid AND (([pwd] = @original_pwd) OR ([pwd] IS NULL AND @original_pwd IS NULL)) AND (([address] = @original_address) OR ([address] IS NULL AND @original_address IS NULL)) AND (([suborder] = @original_suborder) OR ([suborder] IS NULL AND @original_suborder IS NULL)) AND (([searchorder] = @original_searchorder) OR ([searchorder] IS NULL AND @original_searchorder IS NULL)) AND (([logintime] = @original_logintime) OR ([logintime] IS NULL AND @original_logintime IS NULL))">
                            <DeleteParameters>
                                <asp:Parameter Name="original_userid" Type="String" />
                                <asp:Parameter Name="original_pwd" Type="String" />
                                <asp:Parameter Name="original_address" Type="String" />
                                <asp:Parameter Name="original_suborder" Type="Boolean" />
                                <asp:Parameter Name="original_searchorder" Type="Boolean" />
                                <asp:Parameter Name="original_logintime" Type="DateTime" />
                            </DeleteParameters>
                            <InsertParameters>
                                <asp:Parameter Name="userid" Type="String" />
                                <asp:Parameter Name="pwd" Type="String" />
                                <asp:Parameter Name="address" Type="String" />
                                <asp:Parameter Name="suborder" Type="Boolean" />
                                <asp:Parameter Name="searchorder" Type="Boolean" />
                                <asp:Parameter Name="logintime" Type="DateTime" />
                            </InsertParameters>
                            <UpdateParameters>
                                <asp:Parameter Name="pwd" Type="String" />
                                <asp:Parameter Name="address" Type="String" />
                                <asp:Parameter Name="suborder" Type="Boolean" />
                                <asp:Parameter Name="searchorder" Type="Boolean" />
                                <asp:Parameter Name="logintime" Type="DateTime" />
                                <asp:Parameter Name="original_userid" Type="String" />
                                <asp:Parameter Name="original_pwd" Type="String" />
                                <asp:Parameter Name="original_address" Type="String" />
                                <asp:Parameter Name="original_suborder" Type="Boolean" />
                                <asp:Parameter Name="original_searchorder" Type="Boolean" />
                                <asp:Parameter Name="original_logintime" Type="DateTime" />
                            </UpdateParameters>
                        </asp:SqlDataSource>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>
                        <asp:Button ID="Button1" runat="server" PostBackUrl="~/Admin_Main.aspx" Text="返回" />
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
