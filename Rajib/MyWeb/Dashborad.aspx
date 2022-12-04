<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/SiteMaster.Master" AutoEventWireup="true" CodeBehind="Dashborad.aspx.cs" Inherits="MyWeb.Dashborad" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
        <!-- ======= Hero Section ======= -->
    <section id="hero" class="d-flex flex-column justify-content-center align-items-center">
        <div class="hero-container" data-aos="fade-in">
            <h1 runat="server" id="Name"></h1>
            <p>I'm <span class="typed" data-typed-items="Developer, Designer, Freelancer, Photographer"></span></p>
        </div>
    </section>
    <!-- End Hero -->
    <!--Start #Main-->
    <main id="main">
        <!-- ======= About Section ======= -->
        <section id="about" class="about">
            <div class="container">
                <div class="section-title">
                    <h2>About</h2>
                    <p runat="server" id="abTitle"></p>
                </div>
                <div class="row">
                    <div class="col-lg-4" data-aos="fade-right">
                        <img src="Asset/img/CustomIMG/Rajib.jpeg" class="img-fluid" alt="">
                    </div>
                    <div class="col-lg-8 pt-4 pt-lg-0 content" data-aos="fade-left">
                        <h3 runat="server" id="Designation"></h3>
                        <p class="fst-italic" runat="server" id="SubTi">                           
                        </p>
                        <div class="row">
                            <div class="col-lg-6">
                                <ul>
                                    <li><i class="bi bi-chevron-right"></i><strong>Birthday:</strong> <span runat="server" id="Birth"></span></li>
                                    <li><i class="bi bi-chevron-right"></i><strong>Website:</strong> <span runat="server" id="web"></span></li>
                                    <li><i class="bi bi-chevron-right"></i><strong>Phone:</strong> <span runat="server" id="Phn"></span></li>
                                    <li><i class="bi bi-chevron-right"></i><strong>City:</strong> <span runat="server" id="Ct"></span></li>
                                </ul>
                            </div>
                            <div class="col-lg-6">
                                <ul>
                                    <li><i class="bi bi-chevron-right"></i><strong>Age:</strong> <span runat="server" id="Ag"></span></li>
                                    <li><i class="bi bi-chevron-right"></i><strong>Degree:</strong> <span runat="server" id="Deg"></span></li>
                                    <li><i class="bi bi-chevron-right"></i><strong>Email:</strong> <span runat="server" id="Emal"></span></li>
                                    <li><i class="bi bi-chevron-right"></i><strong>Developer:</strong> <span runat="server" id="Dev"></span></li>
                                </ul>
                            </div>
                        </div>
                            <blockquote class="text_part" runat="server" id="Descr">                               
                            </blockquote>
                    </div>
                </div>
            </div>
        </section>
        <!-- End About Section -->

        <!-- ======= Skills Section ======= -->
        <section id="skills" class="skills section-bg">
            <div class="container">
                <div class="section-title">
                    <h2>Skills</h2>
                    <p runat="server" id="STitle"></p>
                </div>
                <div class="row skills-content">
                    <div class="col-lg-6" data-aos="fade-up">
                        <div class="progress">
                            <span class="skill">HTML<i class="val">100%</i></span>
                            <div class="progress-bar-wrap">
                                <div class="progress-bar" role="progressbar" aria-valuenow="100" aria-valuemin="0" aria-valuemax="100"></div>
                            </div>
                        </div>
                        <div class="progress">
                            <span class="skill">CSS<i class="val">90%</i></span>
                            <div class="progress-bar-wrap">
                                <div class="progress-bar" role="progressbar" aria-valuenow="90" aria-valuemin="0" aria-valuemax="100"></div>
                            </div>
                        </div>
                        <div class="progress">
                            <span class="skill">JavaScript<i class="val">30%</i></span>
                            <div class="progress-bar-wrap">
                                <div class="progress-bar" role="progressbar" aria-valuenow="30" aria-valuemin="0" aria-valuemax="100"></div>
                            </div>
                        </div>
                        <div class="progress">
                            <span class="skill">SQL Server Operation<i class="val">80%</i></span>
                            <div class="progress-bar-wrap">
                                <div class="progress-bar" role="progressbar" aria-valuenow="80" aria-valuemin="0" aria-valuemax="100"></div>
                            </div>
                        </div>
                        <div class="progress">
                            <span class="skill">Operating System(Linux)<i class="val">50%</i></span>
                            <div class="progress-bar-wrap">
                                <div class="progress-bar" role="progressbar" aria-valuenow="50" aria-valuemin="0" aria-valuemax="100"></div>
                            </div>
                        </div>
                    </div>
                    <div class="col-lg-6" data-aos="fade-up" data-aos-delay="100">
                        <div class="progress">
                            <span class="skill">C#<i class="val">80%</i></span>
                            <div class="progress-bar-wrap">
                                <div class="progress-bar" role="progressbar" aria-valuenow="80" aria-valuemin="0" aria-valuemax="100"></div>
                            </div>
                        </div>
                        <div class="progress">
                            <span class="skill">C<i class="val">80%</i></span>
                            <div class="progress-bar-wrap">
                                <div class="progress-bar" role="progressbar" aria-valuenow="80" aria-valuemin="0" aria-valuemax="100"></div>
                            </div>
                        </div>
                        <div class="progress">
                            <span class="skill">Dot-Net Framework<i class="val">80%</i></span>
                            <div class="progress-bar-wrap">
                                <div class="progress-bar" role="progressbar" aria-valuenow="80" aria-valuemin="0" aria-valuemax="100"></div>
                            </div>
                        </div>
                        <div class="progress">
                            <span class="skill">Photoshop<i class="val">50%</i></span>
                            <div class="progress-bar-wrap">
                                <div class="progress-bar" role="progressbar" aria-valuenow="50" aria-valuemin="0" aria-valuemax="100"></div>
                            </div>
                        </div>
                        <div class="progress">
                            <span class="skill">Operating System(Windows 7, 10)<i class="val">90%</i></span>
                            <div class="progress-bar-wrap">
                                <div class="progress-bar" role="progressbar" aria-valuenow="90" aria-valuemin="0" aria-valuemax="100"></div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </section>
        <!-- End Skills Section -->

        <!-- ======= Resume Section ======= -->
        <section id="resume" class="resume">
            <div class="container">
                <div class="section-title">
                    <h2>Resume</h2>
                    <p runat="server" id="TitleResume"></p>
                </div>
                <div class="row">
                    <div class="col-lg-6" data-aos="fade-up">
                        <h3 class="resume-title">Sumary</h3>
                        <div class="resume-item pb-0">
                            <h4 runat="server" id="PersonalResume"></h4>
                            <p><em runat="server" id="Titlesumary"></em></p>
                            <ul>
                                <li runat="server" id="Locat"></li>
                                <li runat="server" id="phnnmbr"></li>
                                <li runat="server" id="eml"></li>
                            </ul>
                        </div>

                        <h3 class="resume-title">Education</h3>
                        <div class="resume-item">
                            <h4 runat="server" id="cse"></h4>
                            <h5 runat="server" id="session"></h5>
                            <p><em runat="server" id="cseloc"></em></p>
                            <p class="text_part" runat="server" id="descriCse"></p>
                        </div>
                        <div class="resume-item">
                            <h4 runat="server" id="hscTitle"></h4>
                            <h5 runat="server" id="hscSession"></h5>
                            <p><em runat="server" id="hscschool"></em></p>
                            <p class="text_part" runat="server" id="hscDescription"></p>
                        </div>
                        <div class="resume-item">
                            <h4 runat="server" id="sscTitle"></h4>
                            <h5 runat="server" id="SscSession"></h5>
                            <p><em runat="server" id="SSCschoolName"></em></p>
                            <p class="text_part" runat="server" id="SSCDescri"></p>
                        </div>
                        <div class="resume-item">
                            <h4 runat="server" id="JscTitle"></h4>
                            <h5 runat="server" id="JscSession"></h5>
                            <p><em runat="server" id="JscSchool"></em></p>
                            <p class="text_part" runat="server" id="JscDescri"></p>
                        </div>
                    </div>
                    <div class="col-lg-6" data-aos="fade-up" data-aos-delay="100">
                        <h3 class="resume-title">Professional Experience</h3>
                        <div class="resume-item">
                            <h4 runat="server" id="dotTitle"></h4>
                            <h5 runat="server" id="DotSession"></h5>
                            <p><em runat="server" id="DotLoc"></em></p>
                            <ul class="text_part">
                                <li runat="server" id="descri1st"></li>
                                <li runat="server" id="descr2nd"></li>                               
                            </ul>
                        </div>
                        <div class="resume-item">
                            <h4 runat="server" id="DmTitle"></h4>
                            <h5 runat="server" id="DmSession"></h5>
                            <p><em runat="server" id="DmLocat"></em></p>
                            <ul class="text_part">
                                <li runat="server" id="descrip1st"></li>
                                <li runat="server" id="descrip2nd"></li>
                                <li runat="server" id="descrip3rd"></li>                                
                            </ul>
                        </div>
                        <div class="resume-item">
                            <h4 runat="server" id="AdTitle"></h4>
                            <h5 runat="server" id="AdSession"></h5>
                            <p><em runat="server" id="AdLocat"></em></p>
                            <ul class="text_part">
                                <li runat="server" id="AdDescrip"></li>                                                        
                            </ul>
                        </div>
                        <div class="resume-item">
                            <h4 runat="server" id="ExTitle"></h4>
                            <h5 runat="server" id="ExSession"></h5>
                            <p><em runat="server" id="ExLocat"></em></p>
                            <ul class="text_part">
                                <li runat="server" id="Exdescr"></li>                                                            
                            </ul>
                        </div>
                    </div>
                </div>
            </div>
        </section>
        <!-- End Resume Section -->

        <!-- ======= Facts Section ======= -->
        <section id="facts" class="facts">
            <div class="container">

                <div class="section-title">
                    <h2>Project</h2>
                    <p>Magnam dolores commodi suscipit. Necessitatibus eius consequatur ex aliquid fuga eum quidem. Sit sint consectetur velit. Quisquam quos quisquam cupiditate. Et nemo qui impedit suscipit alias ea. Quia fugiat sit in iste officiis commodi quidem hic quas.</p>
                </div>

                <div class="row no-gutters">

                    <div class="col-lg-3 col-md-6 d-md-flex align-items-md-stretch" data-aos="fade-up">
                        <div class="count-box">
                            <i class="bi bi-emoji-smile"></i>
                            <span data-purecounter-start="0" data-purecounter-end="4" data-purecounter-duration="1" class="purecounter"></span>
                            <p><strong>Happy Clients</strong> Web Base Project</p>
                        </div>
                    </div>

                    <div class="col-lg-3 col-md-6 d-md-flex align-items-md-stretch" data-aos="fade-up" data-aos-delay="100">
                        <div class="count-box">
                            <i class="bi bi-journal-richtext"></i>
                            <span data-purecounter-start="0" data-purecounter-end="521" data-purecounter-duration="1" class="purecounter"></span>
                            <p><strong>Projects</strong> adipisci atque cum quia aut</p>
                        </div>
                    </div>

                    <div class="col-lg-3 col-md-6 d-md-flex align-items-md-stretch" data-aos="fade-up" data-aos-delay="200">
                        <div class="count-box">
                            <i class="bi bi-headset"></i>
                            <span data-purecounter-start="0" data-purecounter-end="1453" data-purecounter-duration="1" class="purecounter"></span>
                            <p><strong>Hours Of Support</strong> aut commodi quaerat</p>
                        </div>
                    </div>

                    <div class="col-lg-3 col-md-6 d-md-flex align-items-md-stretch" data-aos="fade-up" data-aos-delay="300">
                        <div class="count-box">
                            <i class="bi bi-people"></i>
                            <span data-purecounter-start="0" data-purecounter-end="32" data-purecounter-duration="1" class="purecounter"></span>
                            <p><strong>Hard Workers</strong> rerum asperiores dolor</p>
                        </div>
                    </div>

                </div>

            </div>
        </section>
        <!-- End Facts Section -->

        <!-- ======= Portfolio Section ======= -->
        <section id="portfolio" class="portfolio section-bg">
            <div class="container">
                <div class="section-title">
                    <h2>Gellery</h2>
                    <p>Childhood photos remind me of every moment and different memories of every person with friends, girlfriends, and my family.</p>
                </div>

                <div class="row" data-aos="fade-up">
                    <div class="col-lg-12 d-flex justify-content-center">
                        <ul id="portfolio-flters">
                            <li data-filter="*" class="filter-active">All</li>
                            <li data-filter=".filter-app">App</li>
                            <li data-filter=".filter-card">Card</li>
                            <li data-filter=".filter-web">Web</li>
                        </ul>
                    </div>
                </div>

                <div class="row portfolio-container" data-aos="fade-up" data-aos-delay="100">

                    <div class="col-lg-4 col-md-6 portfolio-item filter-app">
                        <div class="portfolio-wrap">
                            <img src="../Asset/img/portfolio/portfolio-1.jpg" class="img-fluid" alt="">
                            <div class="portfolio-links">
                                <a href="../Asset/img/portfolio/portfolio-1.jpg" data-gallery="portfolioGallery" class="portfolio-lightbox" title="App 1"><i class="bx bx-plus"></i></a>
                                <a href="portfolio-details.html" title="More Details"><i class="bx bx-link"></i></a>
                            </div>
                        </div>
                    </div>

                    <div class="col-lg-4 col-md-6 portfolio-item filter-web">
                        <div class="portfolio-wrap">
                            <img src="../Asset/img/portfolio/portfolio-2.jpg" class="img-fluid" alt="">
                            <div class="portfolio-links">
                                <a href="../Asset/img/portfolio/portfolio-2.jpg" data-gallery="portfolioGallery" class="portfolio-lightbox" title="Web 3"><i class="bx bx-plus"></i></a>
                                <a href="portfolio-details.html" title="More Details"><i class="bx bx-link"></i></a>
                            </div>
                        </div>
                    </div>

                    <div class="col-lg-4 col-md-6 portfolio-item filter-app">
                        <div class="portfolio-wrap">
                            <img src="../Asset/img/portfolio/portfolio-3.jpg" class="img-fluid" alt="">
                            <div class="portfolio-links">
                                <a href="../Asset/img/portfolio/portfolio-3.jpg" data-gallery="portfolioGallery" class="portfolio-lightbox" title="App 2"><i class="bx bx-plus"></i></a>
                                <a href="portfolio-details.html" title="More Details"><i class="bx bx-link"></i></a>
                            </div>
                        </div>
                    </div>

                    <div class="col-lg-4 col-md-6 portfolio-item filter-card">
                        <div class="portfolio-wrap">
                            <img src="../Asset/img/portfolio/portfolio-4.jpg" class="img-fluid" alt="">
                            <div class="portfolio-links">
                                <a href="../Asset/img/portfolio/portfolio-4.jpg" data-gallery="portfolioGallery" class="portfolio-lightbox" title="Card 2"><i class="bx bx-plus"></i></a>
                                <a href="portfolio-details.html" title="More Details"><i class="bx bx-link"></i></a>
                            </div>
                        </div>
                    </div>

                    <div class="col-lg-4 col-md-6 portfolio-item filter-web">
                        <div class="portfolio-wrap">
                            <img src="../Asset/img/portfolio/portfolio-5.jpg" class="img-fluid" alt="">
                            <div class="portfolio-links">
                                <a href="../Asset/img/portfolio/portfolio-5.jpg" data-gallery="portfolioGallery" class="portfolio-lightbox" title="Web 2"><i class="bx bx-plus"></i></a>
                                <a href="portfolio-details.html" title="More Details"><i class="bx bx-link"></i></a>
                            </div>
                        </div>
                    </div>

                    <div class="col-lg-4 col-md-6 portfolio-item filter-app">
                        <div class="portfolio-wrap">
                            <img src="../Asset/img/portfolio/portfolio-6.jpg" class="img-fluid" alt="">
                            <div class="portfolio-links">
                                <a href="../Asset/img/portfolio/portfolio-6.jpg" data-gallery="portfolioGallery" class="portfolio-lightbox" title="App 3"><i class="bx bx-plus"></i></a>
                                <a href="portfolio-details.html" title="More Details"><i class="bx bx-link"></i></a>
                            </div>
                        </div>
                    </div>

                    <div class="col-lg-4 col-md-6 portfolio-item filter-card">
                        <div class="portfolio-wrap">
                            <img src="../Asset/img/portfolio/portfolio-7.jpg" class="img-fluid" alt="">
                            <div class="portfolio-links">
                                <a href="../Asset/img/portfolio/portfolio-7.jpg" data-gallery="portfolioGallery" class="portfolio-lightbox" title="Card 1"><i class="bx bx-plus"></i></a>
                                <a href="portfolio-details.html" title="More Details"><i class="bx bx-link"></i></a>
                            </div>
                        </div>
                    </div>

                    <div class="col-lg-4 col-md-6 portfolio-item filter-card">
                        <div class="portfolio-wrap">
                            <img src="../Asset/img/portfolio/portfolio-8.jpg" class="img-fluid" alt="">
                            <div class="portfolio-links">
                                <a href="../Asset/img/portfolio/portfolio-8.jpg" data-gallery="portfolioGallery" class="portfolio-lightbox" title="Card 3"><i class="bx bx-plus"></i></a>
                                <a href="portfolio-details.html" title="More Details"><i class="bx bx-link"></i></a>
                            </div>
                        </div>
                    </div>

                    <div class="col-lg-4 col-md-6 portfolio-item filter-web">
                        <div class="portfolio-wrap">
                            <img src="../Asset/img/portfolio/portfolio-9.jpg" class="img-fluid" alt="">
                            <div class="portfolio-links">
                                <a href="../Asset/img/portfolio/portfolio-9.jpg" data-gallery="portfolioGallery" class="portfolio-lightbox" title="Web 3"><i class="bx bx-plus"></i></a>
                                <a href="portfolio-details.html" title="More Details"><i class="bx bx-link"></i></a>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </section>
        <!-- End Portfolio Section -->

        <!-- ======= Contact Section ======= -->
        <section id="contact" class="contact">
            <div class="container">
                <div class="section-title">
                    <h2>Contact</h2>
                    <p runat="server" id="ConTitle"></p>
                </div>
                <div class="row info">
                    <div class="col-md-6">
                        <div class="col-md-12">
                            <div class="form-group">
                                <label class="form-label">Your Name</label>
                                <asp:TextBox ID="txtname" runat="server" CssClass="form-control" placeholder="Enter your Name"></asp:TextBox>
                            </div>
                        </div>
                        <div class="col-md-12">
                            <div class="form-group">
                                <label class="form-label">Phone </label>
                                <asp:TextBox ID="txtPhn" runat="server" CssClass="form-control" placeholder="Enter you Phone"></asp:TextBox>
                            </div>
                        </div>
                        <div class="col-md-12">
                            <div class="form-group">
                                <label class="form-label">Email</label>
                                <asp:TextBox ID="txtEmail" runat="server" CssClass="form-control" placeholder="Enter your Email" TextMode="Email"></asp:TextBox>
                            </div>
                        </div>
                        <div class="col-md-12">
                            <div class="form-group">
                                <label class="form-label">Message</label>
                                <asp:TextBox ID="txtMessage" runat="server" CssClass="form-control" placeholder="Enter your Message" TextMode="MultiLine"></asp:TextBox>
                            </div>
                        </div>
                    </div>
                    <div class="col-md-6">
                        <div class="address">
                            <i class="bi bi-geo-alt"></i>
                            <h4>Location:</h4>
                            <p runat="server" id="Location"></p>
                        </div>

                        <div class="email">
                            <i class="bi bi-envelope"></i>
                            <h4>Email:</h4>
                            <p runat="server" id="EmailAddre"></p>
                        </div>

                        <div class="phone">
                            <i class="bi bi-phone"></i>
                            <h4>Call:</h4>
                            <p runat="server" id="Callnun"></p>                       
                        </div>
                        <div class="col-md-12">
                            <div class="form-group">
                                <label class="form-label">&nbsp;</label>
                                <asp:Button ID="btnSubmit" CssClass="btn btn-success form-control" runat="server" Text="Submit" OnClick="btnSubmit_Click" />
                            </div>                           
                        </div>
                    </div>
                </div>
                <div class="mt-5">
                    <iframe src="https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d1199.019224929507!2d90.44331955916354!3d22.40282888200144!2m3!1f0!2f39.13007695350523!3f0!3m2!1i1024!2i768!4f35!3m3!1m2!1s0x30aac555ab11c803%3A0xd39eb093a480febb!2sChabua%20Jame%20Masjid!5e1!3m2!1sen!2sbd!4v1662998873681!5m2!1sen!2sbd" width="1020" height="300" style="border:0;" allowfullscreen="" loading="lazy" referrerpolicy="no-referrer-when-downgrade"></iframe>
                </div>
            </div>
        </section>
        <!-- End Contact Section -->
    </main>
    <!-- End #main -->
</asp:Content>
