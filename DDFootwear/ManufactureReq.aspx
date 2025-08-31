<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ManufactureReq.aspx.cs" Inherits="DDFootwear.ManufactureReq" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Manufacture</title>
    <link rel="stylesheet" href="https://maxst.icons8.com/vue-static/landings/line-awesome/line-awesome/1.3.0/css/line-awesome.min.css">
    <link rel="stylesheet" href="adminpanelstyle.css">
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0-alpha2/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-aFq/bzH65dt+w6FI2ooMVUpc+21e0SRygnTpmBvdBgSdnuTN7QbdgL+OapgHtvPp" crossorigin="anonymous">
    <script src="https://cdn.jsdelivr.net/npm/@popperjs/core@2.11.6/dist/umd/popper.min.js" integrity="sha384-oBqDVmMz9ATKxIep9tiCxS/Z9fNfEXiDAYTujMAeBAsjFuCZSmKbSSUnQlmh/jp3" crossorigin="anonymous"></script>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0-alpha2/dist/js/bootstrap.min.js" integrity="sha384-heAjqF+bCxXpCWLa6Zhcp4fu20XoNIA98ecBC1YkdXhszjoejr5y9Q77hIrv8R9i" crossorigin="anonymous"></script>
</head>
<body>
    <form id="form1" runat="server">
    <input type="checkbox" id="nav-toggle">
        <div class="sidebar">
            <div class="sidebar-brand">
                <h2><span class="las la-shoe-prints"></span><span>DD Footwear</span></h2>
            </div>


            <div class="sidebar-menu">

                <ul>

                    <li>
                        <a href="CompanyPortal.aspx" ><span class="las la-chart-bar"></span>
                        <span>Dashboard</span></a>
                    </li>    

                    <li>
                        <a href="Userportal.aspx" ><span class="las la-user-circle"></span>
                        <span>Manage Users</span></a>
                    </li>

                    <li>
                        <a href="ManageItems.aspx"><span class="lab la-opencart"></span>
                        <span>Manage Items</span></a>
                    </li>

                    <li>
                        <a href="ManufactureReq.aspx" class="active"><span class="las la-plus-circle"></span>
                        <span>Manufacture Items</span></a>
                    </li>

                    <li>
                        <a href="ManageSize.aspx"><span class="las la-upload"></span>
                        <span>Manage Sizes</span></a>
                    </li>

                    <li>
                        <a href="ManageDiscount.aspx"><span class="las la-upload"></span>
                        <span>Manage Discounts</span></a>
                    </li>
                </ul>

            </div>
        </div>

        <div class="main-content">
            <header>
                <h2>
                    <label for="nav-toggle">
                        <span class="las la-bars"></span>
                    </label>

                    Manufacture Sections
                </h2>



            </header>



            <main>
                
                <div class="recent-gridPatientM">
                    <div class="project">

                        <div class="card">
                            

                            <div class="card-header">
                                <h3>Manufacture</h3>
                                <asp:Button ID="btnRefresh" class="btn btn-info" runat="server" Text="Refresh" />
                                

                            </div>


                            <div class="card-body">
                                <div class="table-responsive">
        

                                        <asp:GridView ID="drvManufacture" runat="server"></asp:GridView>

                                </div>
                            </div>

                            <div class="card-header">
                                <h3>Manage Accounts</h3>
                                <asp:Button ID="btnSearch" class="btn btn-primary" runat="server" Text="Search" />
                                <asp:TextBox ID="txtEnter" runat="server" placeholder="Type here.."></asp:TextBox>
                            </div>
                            <asp:TextBox ID="txtMessage" class="form-control" runat="server" ReadOnly="True" Font-Bold="True" Font-Size="Medium" ForeColor="#00CC00"></asp:TextBox>
                            
                        
                        </div>

                    </div>

                </div>

                <div class="mainpregistermenu" id="formrHide">
            <div class="container">
                    <div class="pregistertitle">Search,Update and Delete</div>
                        <div class="puser-details">
                            <div class="pinput-box">
                                <span class="details">User Email</span>
                                <asp:TextBox ID="txtEmail" class="form-control" runat="server"></asp:TextBox>
                            </div>

                            <div class="pinput-box">
                                <span class="details">Product ID</span>
                                <asp:TextBox ID="txtProID" class="form-control" runat="server"></asp:TextBox>
                            </div>

                            <div class="pinput-box">
                                <span class="details">Quantity</span>
                                <asp:TextBox ID="txtqty" class="form-control" runat="server" TextMode="Number" ></asp:TextBox>
                            </div>   
                            
                        </div>
                        
                </div>

                

            </div>

                 
            </main>

        </div>
    </form>
</body>
</html>
