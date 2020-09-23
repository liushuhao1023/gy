<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Admin_OrderSearch.aspx.cs" Inherits="part4.Admin_OrderSearch" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 25px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div style="text-align: center">
            <table style="width:100%;">
                <tr>
                    <td>订单查询界面</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>
                        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" Caption="订单表" DataKeyNames="orderid" DataSourceID="SqlDataSource1" HorizontalAlign="Center">
                            <Columns>
                                <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
                                <asp:BoundField DataField="orderid" HeaderText="订单编号" InsertVisible="False" ReadOnly="True" SortExpression="orderid" />
                                <asp:BoundField DataField="userid" HeaderText="用户名" SortExpression="userid" />
                                <asp:BoundField DataField="address" HeaderText="分拣地址" SortExpression="address" />
                                <asp:BoundField DataField="lx" HeaderText="产品类型" SortExpression="lx" />
                                <asp:BoundField DataField="qty" HeaderText="下单数量" SortExpression="qty" />
                                <asp:BoundField DataField="fqty" HeaderText="完成数量" SortExpression="fqty" />
                                <asp:BoundField DataField="rqty" HeaderText="剩余数量" SortExpression="rqty" />
                                <asp:BoundField DataField="otime" HeaderText="下单时间" SortExpression="otime" />
                                <asp:BoundField DataField="status" HeaderText="订单状态" SortExpression="status" />
                            </Columns>
                        </asp:GridView>
                        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConflictDetection="CompareAllValues" ConnectionString="<%$ ConnectionStrings:part1ConnectionString %>" DeleteCommand="DELETE FROM [t_order] WHERE [orderid] = @original_orderid AND (([userid] = @original_userid) OR ([userid] IS NULL AND @original_userid IS NULL)) AND (([address] = @original_address) OR ([address] IS NULL AND @original_address IS NULL)) AND (([lx] = @original_lx) OR ([lx] IS NULL AND @original_lx IS NULL)) AND (([qty] = @original_qty) OR ([qty] IS NULL AND @original_qty IS NULL)) AND (([fqty] = @original_fqty) OR ([fqty] IS NULL AND @original_fqty IS NULL)) AND (([rqty] = @original_rqty) OR ([rqty] IS NULL AND @original_rqty IS NULL)) AND (([otime] = @original_otime) OR ([otime] IS NULL AND @original_otime IS NULL)) AND (([status] = @original_status) OR ([status] IS NULL AND @original_status IS NULL))" InsertCommand="INSERT INTO [t_order] ([userid], [address], [lx], [qty], [fqty], [rqty], [otime], [status]) VALUES (@userid, @address, @lx, @qty, @fqty, @rqty, @otime, @status)" OldValuesParameterFormatString="original_{0}" SelectCommand="SELECT * FROM [t_order]" UpdateCommand="UPDATE [t_order] SET [userid] = @userid, [address] = @address, [lx] = @lx, [qty] = @qty, [fqty] = @fqty, [rqty] = @rqty, [otime] = @otime, [status] = @status WHERE [orderid] = @original_orderid AND (([userid] = @original_userid) OR ([userid] IS NULL AND @original_userid IS NULL)) AND (([address] = @original_address) OR ([address] IS NULL AND @original_address IS NULL)) AND (([lx] = @original_lx) OR ([lx] IS NULL AND @original_lx IS NULL)) AND (([qty] = @original_qty) OR ([qty] IS NULL AND @original_qty IS NULL)) AND (([fqty] = @original_fqty) OR ([fqty] IS NULL AND @original_fqty IS NULL)) AND (([rqty] = @original_rqty) OR ([rqty] IS NULL AND @original_rqty IS NULL)) AND (([otime] = @original_otime) OR ([otime] IS NULL AND @original_otime IS NULL)) AND (([status] = @original_status) OR ([status] IS NULL AND @original_status IS NULL))">
                            <DeleteParameters>
                                <asp:Parameter Name="original_orderid" Type="Int32" />
                                <asp:Parameter Name="original_userid" Type="String" />
                                <asp:Parameter Name="original_address" Type="String" />
                                <asp:Parameter Name="original_lx" Type="String" />
                                <asp:Parameter Name="original_qty" Type="String" />
                                <asp:Parameter Name="original_fqty" Type="String" />
                                <asp:Parameter Name="original_rqty" Type="String" />
                                <asp:Parameter Name="original_otime" Type="DateTime" />
                                <asp:Parameter Name="original_status" Type="String" />
                            </DeleteParameters>
                            <InsertParameters>
                                <asp:Parameter Name="userid" Type="String" />
                                <asp:Parameter Name="address" Type="String" />
                                <asp:Parameter Name="lx" Type="String" />
                                <asp:Parameter Name="qty" Type="String" />
                                <asp:Parameter Name="fqty" Type="String" />
                                <asp:Parameter Name="rqty" Type="String" />
                                <asp:Parameter Name="otime" Type="DateTime" />
                                <asp:Parameter Name="status" Type="String" />
                            </InsertParameters>
                            <UpdateParameters>
                                <asp:Parameter Name="userid" Type="String" />
                                <asp:Parameter Name="address" Type="String" />
                                <asp:Parameter Name="lx" Type="String" />
                                <asp:Parameter Name="qty" Type="String" />
                                <asp:Parameter Name="fqty" Type="String" />
                                <asp:Parameter Name="rqty" Type="String" />
                                <asp:Parameter Name="otime" Type="DateTime" />
                                <asp:Parameter Name="status" Type="String" />
                                <asp:Parameter Name="original_orderid" Type="Int32" />
                                <asp:Parameter Name="original_userid" Type="String" />
                                <asp:Parameter Name="original_address" Type="String" />
                                <asp:Parameter Name="original_lx" Type="String" />
                                <asp:Parameter Name="original_qty" Type="String" />
                                <asp:Parameter Name="original_fqty" Type="String" />
                                <asp:Parameter Name="original_rqty" Type="String" />
                                <asp:Parameter Name="original_otime" Type="DateTime" />
                                <asp:Parameter Name="original_status" Type="String" />
                            </UpdateParameters>
                        </asp:SqlDataSource>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style1"></td>
                    <td class="auto-style1">
                        <asp:Button ID="Button1" runat="server" Text="监控" OnClick="Button1_Click" />
                    </td>
                    <td class="auto-style1"></td>
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
