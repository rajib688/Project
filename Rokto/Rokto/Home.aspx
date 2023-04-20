<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/SiteMaster.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="Rokto.Home" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section id="hero" class="d-flex align-items-center">
        <div class="container">
            <h1>SMS-based platform to connect<br />
                blood searchers with donors</h1>
            <h2>Rokto is a real-time free platform to help blood searchers connect<br />
                voluntary blood donors around Bangladesh.</h2>
            <a href="#" class="btn-get-started">Join as a Donor</a> <a href="#" class="btn-get-started">Search Donors</a>
        </div>
    </section>
    <section id="rokto">
        <div class="container">
            <div class="row">
                <div class="col-md-6">
                    <h2>What is Rokto?</h2>
                    <p>Rokto is an automated blood service that connects blood searchers with voluntary donors in a moment through SMS. Rokto is always a free service for all.</p>
                </div>
                <div class="col-md-6">
                    <h2>Why is Rokto?</h2>
                    <ul>
                        <li>100% Automated</li>
                        <li>Always free</li>
                        <li>24×7 service</li>
                        <li>All data is secured</li>
                    </ul>
                </div>
            </div>
            <div style="text-align: center!important">
                <a href="Navbody/About.aspx" class="btn-get-more">Learn More</a>
            </div>
        </div>
    </section>
    <section id="Area">
        <div class="container">
            <div class="row">
                <h2>We're a network of</h2>
                <hr />
                <div class="col-md-4 box-icon">
                    <span><i class=" fas fa-user-friends"></i></span>
                    <p>5000 Donors</p>
                </div>
                <div class="col-md-4 box-icon">
                    <span><i class="fas fa-map-marker-alt"></i></span>
                    <p>64 Districts</p>
                </div>
                <div class="col-md-4 box-icon">
                    <span><i class="fas fa-boxes"></i></span>
                    <p>8 Blood Groups</p>
                </div>
            </div>
        </div>
    </section>
    <section id="about">
        <div class="container">
            <h2>About Us</h2>
            <p>
                Rokto is an automated blood service that connects blood searchers with
                <br>
                voluntary blood donors in a moment through SMS. Rokto is a not-for-profit
                <br />
                initiative to aware people of voluntary blood donation in Bangladesh.
            </p>
        </div>
        <div style="text-align: center!important">
            <a href="Navbody/About.aspx" class="btn-about-more">Learn More</a>
        </div>
    </section>
</asp:Content>
