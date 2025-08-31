<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CompanyPortal.aspx.cs" Inherits="DDFootwear.CompanyPortal" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">

<head runat="server">
    <title>DD Company Stock Management Application</title>
    <link rel="stylesheet" href="https://maxst.icons8.com/vue-static/landings/line-awesome/line-awesome/1.3.0/css/line-awesome.min.css">
    <link rel="stylesheet" href="adminpanelstyle.css">
</head>

<body>

        <input type="checkbox" id="nav-toggle">
        <div class="sidebar">
            <div class="sidebar-brand">
                <h2><span class="las la-shoe-prints"></span><span>DD Footwear</span></h2>
            </div>


            <div class="sidebar-menu">

                <ul>

                    <li>
                        <a href="CompanyPortal.aspx" class="active"><span class="las la-chart-bar"></span>
                        <span>Dashboard</span></a>
                    </li>    

                    <li>
                        <a href="Userportal.aspx"><span class="las la-user-circle"></span>
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

                    Dashboard
                </h2>



            </header>



            <main>
                
                <div class="cards">
                    <div class="card-single">
                        <div>
                            <h1>54</h1>
                            <span>Users</span>
                        </div>
                        <div>
                            <span class="las la-users"></span>
                        </div>
                    </div>

                    <div class="card-single">
                        <div>
                            <h1>79</h1>
                            <span>Products</span>
                        </div>
                        <div>
                            <span class="las la-shoe-prints"></span>
                        </div>
                    </div>

                    <div class="card-single">
                        <div>
                            <h1>124</h1>
                            <span>Orders</span>
                        </div>
                        <div>
                            <span class="las la-shopping-bag"></span>
                        </div>
                    </div>

                    <div class="card-single">
                        <div>
                            <h1>6k</h1>
                            <span>Manufacture Requests</span>
                        </div>
                        <div>
                            <span class="las la-users"></span>
                        </div>
                    </div>

                </div>


            </main>


        </div>
</body>
</html>
