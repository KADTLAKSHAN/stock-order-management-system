<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Userportal.aspx.cs" Inherits="DDFootwear.Userportal" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">


<head runat="server">
    <title>DD Users</title>
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
                        <a href="Userportal.aspx" class="active"><span class="las la-user-circle"></span>
                        <span>Manage Users</span></a>
                    </li>

                    <li>
                        <a href="ManageItems.aspx"><span class="lab la-opencart"></span>
                        <span>Manage Items</span></a>
                    </li>

                    <li>
                        <a href="ManufactureReq.aspx"><span class="las la-plus-circle"></span>
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

                    Users
                </h2>



            </header>



            <main>
                
                <div class="recent-gridPatientM">
                    <div class="project">

                        <div class="card">
                            

                            <div class="card-header">
                                <h3>Users</h3>
                                <asp:Button ID="btnRefresh" class="btn btn-info" runat="server" Text="Refresh" OnClick="btnRefresh_Click" />
                                

                            </div>


                            <div class="card-body">
                                <div class="table-responsive">
        

                                        <asp:GridView ID="drvUsers" runat="server"></asp:GridView>

                                </div>
                            </div>

                            <div class="card-header">
                                <h3>Manage Accounts</h3>
                                <asp:Button ID="btnSearch" class="btn btn-primary" runat="server" Text="Search" OnClick="btnSearch_Click" />
                                <button type="button" class="btn btn-primary" data-bs-toggle="modal" data-bs-target="#exampleModal" data-bs-whatever="@mdo">Add</button>
                                <asp:Button ID="btnDelete" class="btn btn-danger" runat="server" Text="Delete" OnClick="btnDelete_Click" />
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
                                <span class="details">Password</span>
                                <asp:TextBox ID="txtpassup" class="form-control" runat="server"></asp:TextBox>
                            </div>

                            <div class="pinput-box">
                                <span class="details">Address</span>
                                <asp:TextBox ID="txtaddressup" class="form-control" runat="server"></asp:TextBox>
                            </div>

                            <div class="pinput-box">
                                <span class="details">Email</span>
                                <asp:TextBox ID="txtcontactup" class="form-control" runat="server"></asp:TextBox>
                            </div>

                           <div class="pinput-box">
                        <label for="recipient-name" class="col-form-label">User Type</label>
                        <asp:DropDownList class="form-control" ID="dplusertypeup" runat="server">
                            <asp:ListItem>Customer</asp:ListItem>
                            <asp:ListItem>Outlet</asp:ListItem>
                            <asp:ListItem>Partner</asp:ListItem>
                            <asp:ListItem>Company</asp:ListItem>
                            </asp:DropDownList>
                        </div>

                           
                            
                        </div>

                <asp:Button ID="btnUpdate" class="btn btn-success" runat="server" Text="Update" OnClick="btnUpdate_Click" />

                        
                </div>

                

            </div>

                 
            </main>
            
            <div class="modal fade" id="exampleModal" tabindex="-1" aria-labelledby="exampleModalLabel" aria-hidden="true">
            <div class="modal-dialog">
                <div class="modal-content">
                <div class="modal-header">
                    <h1 class="modal-title fs-5" id="exampleModalLabel">Add User</h1>
                    <button type="button" class="btn-close" data-bs-dismiss="modal" aria-label="Close"></button>
                </div>
                <div class="modal-body">
                  
                    <div class="mb-3">
                        <label for="recipient-name" class="col-form-label">User Email:</label>
                        <asp:TextBox ID="txtEmail" class="form-control" runat="server" TextMode="Email"></asp:TextBox>
                    </div>

                    <div class="mb-3">
                        <label for="recipient-name" class="col-form-label">User Password:</label>
                        <asp:TextBox ID="txtUserPassword" class="form-control" runat="server" TextMode="Password"></asp:TextBox>
                    </div>

                    <div class="mb-3">
                        <label for="recipient-name" class="col-form-label">User Address:</label>
                        <asp:TextBox ID="txtUserAddress" class="form-control" runat="server"></asp:TextBox>
                    </div>

                    <div class="mb-3">
                        <label for="recipient-name" class="col-form-label">User Contact Number:</label>
                        <asp:TextBox ID="txtUserContact" class="form-control" runat="server" TextMode="Phone"></asp:TextBox>
                    </div>

                    <div class="mb-3">
                        <label for="recipient-name" class="col-form-label">User Type</label>
                        <asp:DropDownList class="form-control" ID="dplUserType" runat="server">
                            <asp:ListItem>Customer</asp:ListItem>
                            <asp:ListItem>Outlet</asp:ListItem>
                            <asp:ListItem>Partner</asp:ListItem>
                            <asp:ListItem>Company</asp:ListItem>
                            </asp:DropDownList>
                    </div>



                    
                </div>
                <div class="modal-footer">
                    <button type="button" class="btn btn-secondary" data-bs-dismiss="modal">Close</button>
                    <asp:Button ID="btnAdd" class="btn btn-primary" runat="server" Text="Add New User" OnClick="btnAdd_Click" /> 
                </div>
                </div>
            </div>
            </div>



            

            


        </div>

   </form>

</body>
</html>
