<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/admin.Master" AutoEventWireup="true" CodeBehind="Profile.aspx.cs" Inherits="Rokto.Profile" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section id="loginpart">
        <div class="container">
            <div class="login_head">
                <h2>Profile</h2>
                <p>Your profile to get Blood requests properly.</p>
            </div>
        </div>
        <div class="container">
            <h5 class="mt-5" style="text-align: center; color: forestgreen">Basic Info</h5>
            <hr />
        </div>
        <div class="card-body">
            <div class="container mt-5">
                <div class="row">
                    <div class="col-md-4">
                        <div class="form-group">
                            <label class="form-label">Name</label>
                            <asp:TextBox ID="txtName" runat="server" CssClass="form-control" placeholder="Enter your name"></asp:TextBox>
                        </div>
                    </div>
                    <div class="col-md-4">
                        <div class="form-group">
                            <label class="form-label">Blood Group</label>
                            <asp:DropDownList ID="ddlbloodgroup" runat="server" CssClass="form-control dropdown"></asp:DropDownList>
                        </div>
                    </div>
                    <div class="col-md-4">
                        <div class="form-group">
                            <label class="form-label">Gender</label>
                            <asp:DropDownList ID="ddlGender" runat="server" CssClass="form-control dropdown">
                                <asp:ListItem Value="0">Select</asp:ListItem>
                                <asp:ListItem Value="1">Male</asp:ListItem>
                                <asp:ListItem Value="2">Female</asp:ListItem>
                            </asp:DropDownList>
                        </div>
                    </div>
                    <div class="col-md-4">
                        <div class="form-group">
                            <label class="form-label">Date Of Birth</label>
                            <asp:TextBox ID="txtDateOfBirth" runat="server" CssClass="form-control" TextMode="Date"></asp:TextBox>
                        </div>
                    </div>
                    <div class="col-md-4">
                        <div class="form-group">
                            <label class="form-label">National ID Number</label>
                            <asp:TextBox ID="txtNID" runat="server" CssClass="form-control" placeholder="Enter your NID number"></asp:TextBox>
                        </div>
                    </div>
                    <div class="col-md-4">
                        <div class="form-group">
                            <label class="form-label">Present Address</label>
                            <asp:TextBox ID="txtPresentAddress" runat="server" CssClass="form-control" placeholder="Enter your present address" TextMode="MultiLine"></asp:TextBox>
                        </div>
                    </div>
                    <div class="col-md-4">
                        <div class="form-group">
                            <label class="form-label">Present District</label>
                            <asp:DropDownList ID="ddlPresentDistrict" runat="server" CssClass="form-control dropdown">
                                <asp:ListItem Value="0">Select</asp:ListItem>
                                <asp:ListItem Value="1">Dhaka</asp:ListItem>
                                <asp:ListItem Value="2">Barisal</asp:ListItem>
                                <asp:ListItem Value="3">Patuakhali</asp:ListItem>
                            </asp:DropDownList>
                        </div>
                    </div>
                    <div class="col-md-4">
                        <div class="form-group">
                            <label class="form-label">Permanent Address</label>
                            <asp:TextBox ID="txtpermanentAddress" runat="server" CssClass="form-control" placeholder="Enter your permanent address" TextMode="MultiLine"></asp:TextBox>
                        </div>
                    </div>
                    <div class="col-md-4">
                        <div class="form-group">
                            <label class="form-label">Permanent District</label>
                            <asp:DropDownList ID="ddlPermanentDistrict" runat="server" CssClass="form-control dropdown">
                                <asp:ListItem Value="0">Select</asp:ListItem>
                                <asp:ListItem Value="1">Dhaka</asp:ListItem>
                                <asp:ListItem Value="2">Barisal</asp:ListItem>
                                <asp:ListItem Value="3">Patuakhali</asp:ListItem>
                            </asp:DropDownList>
                        </div>
                    </div>
                    <div class="col-md-4">
                        <div class="form-group">
                            <label class="form-label">&nbsp;</label>
                            <asp:Button ID="btnSave" runat="server" Text="Save" CssClass="btn text-bg-success btn-lg" OnClick="btnSave_Click" />
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </section>
</asp:Content>
