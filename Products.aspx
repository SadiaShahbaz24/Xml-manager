<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Products.aspx.cs" Inherits="XML_example.Products" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Products</title>
</head>
<body>
   <form id="form1" runat="server">
       
         <table>
             <tr>
                 <td>
                      <asp:Label ID="Labid" runat="server" Text="Product ID"></asp:Label>
                </td>
                 <td>
                       <asp:TextBox ID="txtid" runat="server" ></asp:TextBox>
                 
                 </td>
                 <td>
                      <asp:Button ID="BTNsearch" runat="server" Text="Search" OnClick="BTNsearch_Click" />
                 </td>
             </tr>
             <tr>
                 <td>
                     <asp:Label ID="Labname" runat="server" Text="Product Name"></asp:Label>
                 </td>
                 <td>
                    <asp:TextBox ID="txtpname" runat="server"></asp:TextBox>
                 </td>
                
             </tr>
             <tr>
                 <td>
                       <asp:Label ID="Labquan" runat="server" Text="Quantity"></asp:Label>
                 </td>
                 <td>
                       <asp:TextBox ID="txtquan" runat="server"></asp:TextBox>
                 </td>
             </tr>
                <tr>
                 <td>
                       <asp:Label ID="Labprice" runat="server" Text="Price"></asp:Label>
                 </td>
                 <td>
                       <asp:TextBox ID="txtprice" runat="server"></asp:TextBox>
                 </td>
             </tr>
                <tr>
                 <td>
                       <asp:Label ID="Labexp" runat="server" Text="Expiry"></asp:Label>
                 </td>
                 <td>
                       <asp:TextBox ID="txtexp" runat="server"></asp:TextBox>
                 </td>
             </tr>
                <tr>
                 <td>
                       <asp:Label ID="LabspId" runat="server" Text="Supplier ID"></asp:Label>
                 </td>
                 <td>
                       <asp:TextBox ID="txtsppID" runat="server"></asp:TextBox>
                 </td>
             </tr>
             <tr>
                 <td>
                      <asp:Button ID="BTNinsert" runat="server" Text="Insert" OnClick="BTNInsert_Click" />
              
                      <asp:Button ID="BTNupdate" runat="server" Text="Update" OnClick="BTNupdate_Click" />
              
                      <asp:Button ID="BTNdelete" runat="server" Text="Delete" OnClick="BTNdelete_Click" />
                 
                     <asp:Button ID="btnReset" runat="server" Text="Reset" OnClick="btnReset_Click"  />
                 </td>
              </tr>
             <tr>
                 <td>
                     <asp:Label ID="test" runat="server"></asp:Label>
                 </td>
             </tr>
         </table>
    
            <asp:GridView ID="GridView1" runat="server" > </asp:GridView>
        </form>

</body>
</html>
