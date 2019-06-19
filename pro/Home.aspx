<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="pro.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:dbconnect %>" SelectCommand="SELECT * FROM [VendorDetails]"></asp:SqlDataSource>
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CellPadding="3" DataSourceID="SqlDataSource1" ForeColor="Black" GridLines="Vertical" DataKeyNames="SI" BackColor="White" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px">
                <AlternatingRowStyle BackColor="#CCCCCC" />
                <Columns>
                    <asp:BoundField DataField="SI" HeaderText="SI" SortExpression="SI" ReadOnly="True" />
                    <asp:BoundField DataField="Page" HeaderText="Page" SortExpression="Page" />
                    <asp:BoundField DataField="VR" HeaderText="VR" SortExpression="VR" />
                    <asp:BoundField DataField="Particulars" HeaderText="Particulars" SortExpression="Particulars" />
                    <asp:BoundField DataField="Party_Name" HeaderText="Party_Name" SortExpression="Party_Name" />
                    <asp:BoundField DataField="Bill_No" HeaderText="Bill_No" SortExpression="Bill_No" />
                    <asp:BoundField DataField="Bill_Date" HeaderText="Bill_Date" SortExpression="Bill_Date" />
                    <asp:BoundField DataField="Qty" HeaderText="Qty" SortExpression="Qty" />
                    <asp:BoundField DataField="Original_Value " HeaderText="Original_Value " SortExpression="Original_Value " />
                    <asp:BoundField DataField="AdditionsDeletions_during_year" HeaderText="AdditionsDeletions_during_year" SortExpression="AdditionsDeletions_during_year" />
                    <asp:BoundField DataField="Sale_of_Asset" HeaderText="Sale_of_Asset" SortExpression="Sale_of_Asset" />
                    <asp:BoundField DataField="Month" HeaderText="Month" SortExpression="Month" />
                    <asp:BoundField DataField="Assets_transferred_fromto_other_Divn" HeaderText="Assets_transferred_fromto_other_Divn" SortExpression="Assets_transferred_fromto_other_Divn" />
                    <asp:BoundField DataField="Closing_Value" HeaderText="Closing_Value" SortExpression="Closing_Value" />
                    <asp:BoundField DataField="Cumulative_Depreciation" HeaderText="Cumulative_Depreciation" SortExpression="Cumulative_Depreciation" />
                    <asp:BoundField DataField="Depreciation_during_year" HeaderText="Depreciation_during_year" SortExpression="Depreciation_during_year" />
                    <asp:BoundField DataField="Depreciation_transferred_fromto_other_divns" HeaderText="Depreciation_transferred_fromto_other_divns" SortExpression="Depreciation_transferred_fromto_other_divns" />
                    <asp:BoundField DataField="Assets_whose_WDV_is_eqless_than_Rs_10000_in_year" HeaderText="Assets_whose_WDV_is_eqless_than_Rs_10000_in_year" SortExpression="Assets_whose_WDV_is_eqless_than_Rs_10000_in_year" />
                    <asp:BoundField DataField="Depreciation_adjusted_in_the_year" HeaderText="Depreciation_adjusted_in_the_year" SortExpression="Depreciation_adjusted_in_the_year" />
                    <asp:BoundField DataField="Cumulative_depreciation_as_on" HeaderText="Cumulative_depreciation_as_on" SortExpression="Cumulative_depreciation_as_on" />
                    <asp:BoundField DataField="Net_Block_in_year" HeaderText="Net_Block_in_year" SortExpression="Net_Block_in_year" />
                </Columns>
                <FooterStyle BackColor="#CCCCCC" />
                <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
                <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
                <SortedAscendingCellStyle BackColor="#F1F1F1" />
                <SortedAscendingHeaderStyle BackColor="#808080" />
                <SortedDescendingCellStyle BackColor="#CAC9C9" />
                <SortedDescendingHeaderStyle BackColor="#383838" />
            </asp:GridView>
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Click to Insert New Data to the Database" Width="2954px" BackColor="#99FF99" Font-Bold="True" Font-Italic="False" Font-Names="Broadway" Font-Overline="False" Font-Size="Larger" Font-Underline="True" ForeColor="#990000" Height="37px" style="margin-top: 0px" />
        </div>
    </form>
</body>
</html>
