<%@ Page Title="Loans Calculator" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="textC">
    <div class="titleC">
        <h1>Student Loans Calculator</h1>
        <p class="lead">Enter your information into the form below to receive information on paying back your student loan. This form assumes you paid the highest possible amount as an undergraduate.</p>
        </div>

    <div class="row form-group">
        <div class="col-md-6 leftSide">
            <h2>Loan Information</h2>
            <br /><br />
            <h4>What year did you begin your course?</h4>
            <asp:TextBox ID="YearInput" runat="server" Placeholder="The year you began"></asp:TextBox>
            <br /><br />
            <h4>How many years was your course?</h4>
            <asp:DropDownList ID="LengthList" runat="server">
                <asp:ListItem Value="1">1</asp:ListItem>
                <asp:ListItem Value="2">2</asp:ListItem>
                <asp:ListItem Value="3">3</asp:ListItem>
                <asp:ListItem Value="4">4</asp:ListItem>
                <asp:ListItem Value="5">5</asp:ListItem>
            </asp:DropDownList>
            <br /><br />
            <h4>Did you take out a maintenance loan? If so, input how much per year you borrowed.</h4>
            <asp:TextBox ID="MaintenanceInput" runat="server" Placeholder="The amount you borrowed"></asp:TextBox>
            
            <br /><br />
            <h2>Earning Information</h2>
           <h4>How much do you earn currently or expect to earn?</h4>
            <asp:TextBox ID="Salary" runat="server" Placeholder="Amount"></asp:TextBox>
            <asp:Button ID="Calculate" runat="server" Text="Calculate" OnClick="Calculate_Click" />
        </div>
        <div class="col-md-6 rightSide">
            
            <h2>Your Result</h2>
         <asp:Label ID="Result" runat="server">             
            </asp:Label>
            <div id="chartContainer"></div>   
        </div>
            
            
       </div>
    </div>
</asp:Content>
