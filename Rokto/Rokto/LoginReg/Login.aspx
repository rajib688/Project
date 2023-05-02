<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/SiteMaster.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Rokto.LoginReg.Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section id="loginpart">
        <div class="container">
            <div class="login_head">
                <h2>Login with Rokto</h2>
                <p>Login with us to avail all the features.</p>
            </div>
            <div class="login-box">
                <div class="card">
                    <h4 class="text-center mt-5">Welcome Please  Login</h4>
                    <div class="input-group">
                        <div class="card-body">
                            <div class="col-md-6">
                                <label class="form-label">Email</label>
                                <asp:TextBox ID="txtEmail" runat="server" CssClass="form-control" placeholder="Enter your email"></asp:TextBox>
                            </div>
                            <div class="col-md-6">
                                <div class="form-group">
                                    <label class="form-label">Password</label>
                                    <asp:TextBox ID="txtPassword" runat="server" CssClass="form-control" placeholder="Enter your password"></asp:TextBox>
                                </div>
                            </div>
                            <div class="form-group mt-1">
                                <asp:Button ID="btnLogin" runat="server" Text="Login" CssClass="btn btn-danger btn-lg " OnClick="btnLogin_Click" />
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </section>
</asp:Content>
