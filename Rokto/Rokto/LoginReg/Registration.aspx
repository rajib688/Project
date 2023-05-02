<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/SiteMaster.Master" AutoEventWireup="true" CodeBehind="Registration.aspx.cs" Inherits="Rokto.LoginReg.Registration" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section id="loginpart">
        <div class="container">
            <div class="login_head">
                <h2>Register with Rokto</h2>
                <p>Register with us to avail all the features.</p>
            </div>

            <div class="login-box">
                <div class="card">
                    <h4 class="text-center mt-5">Welcome Please  Register</h4>
                    <div id="DivMsg" runat="server" class="alert alert-danger">
                        <asp:Label ID="lblMsg" runat="server" Text=""></asp:Label>
                    </div>
                    <div class="input-group">
                        <div class="card-body">
                            <div class="col-md-6">
                                <label class="form-label">Mobile</label>
                                <asp:TextBox ID="txtMobile" runat="server" CssClass="form-control" placeholder="Enter your mobile" TextMode="Number"></asp:TextBox>
                            </div>
                            <div class="col-md-6">
                                <label class="form-label">Email</label>
                                <asp:TextBox ID="txtEmail" runat="server" CssClass="form-control" placeholder="Enter your email" TextMode="Email"></asp:TextBox>
                            </div>
                            <div class="col-md-6">
                                <div class="form-group">
                                    <label class="form-label">Password</label>
                                    <asp:TextBox ID="txtPassword" runat="server" CssClass="form-control" placeholder="Enter your password" TextMode="Password"></asp:TextBox>
                                </div>
                            </div>
                            <div class="form-group mt-1">
                                <asp:Button ID="btnRegister" runat="server" Text="Register" CssClass="btn btn-danger btn-lg " OnClick="btnRegister_Click" />
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </section>
</asp:Content>
