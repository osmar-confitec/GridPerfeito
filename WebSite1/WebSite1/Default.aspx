<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">


    <asp:GridView
        AllowPaging="true" AllowSorting="true" 
        PageSize="10"
        AllowCustomPaging="true"
        
        AutoGenerateColumns="false" 
        ID="GridClientes" runat="server" OnPageIndexChanging="GridClientes_PageIndexChanging">
        <Columns>

      <asp:BoundField DataField="Id" HeaderText="Id" />

      <asp:BoundField DataField="Nome" HeaderText="Nome" />               

      <asp:BoundField DataField="Cpf" HeaderText="Cpf" />               

      <asp:TemplateField>

      <ItemTemplate>

           <input type="checkbox" runat="server" id="chk" value='<%# Eval("Id")%>' />

      </ItemTemplate>

      </asp:TemplateField>

      <asp:TemplateField>

            <ItemTemplate>

                  <a href="#" ID="lnk" runat="server">Detalhe</a>                       

            </ItemTemplate>

      </asp:TemplateField>               

      </Columns>         
                </asp:GridView>

  
</asp:Content>
