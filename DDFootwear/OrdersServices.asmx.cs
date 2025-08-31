using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using BBL;
using System.Data;

namespace DDFootwear
{
    /// <summary>
    /// Summary description for OrdersServices
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class OrdersServices : System.Web.Services.WebService
    {

        [WebMethod]
        public int insertOrder(string oID, string oDate, string email, string dis)
        {
            Orders o1 = new Orders();

            o1.OrderID = oID;
            o1.OrderDate = oDate;
            o1.Useremail = email;
            o1.DiscountID = dis;

            return o1.orderInsert();

        }

        [WebMethod]
        public Boolean orderProduct(string pID,int qty,string oID,string usermail,string stockID)
        {
            int productqty = 0;
            int productreqqty = 0;

            Product p1 = new Product();
            p1.PID = pID;
            p1.productFind();

            productqty = p1.PQty;
            productreqqty = qty;

            if (productqty >= productreqqty)
            {
                //Request Stock from main
                int reqqty = productqty - productreqqty;
                p1.PQty = reqqty;
                p1.productUpdate();

                //stock save
                User u1 = new User();
                u1.Uemail = usermail;
                u1.find();

                if (u1.Utype.Equals("Outlet"))
                {
                    OutletStock os = new OutletStock();
                    os.OutID = stockID;
                    os.ProID = p1.PID;
                    os.qty = productreqqty;
                    os.email = usermail;
                    os.outStockInsert();
                }else
                {
                    PartnerStock ps = new PartnerStock();
                    ps.PatID = stockID;
                    ps.ProID = p1.PID;
                    ps.qty = productreqqty;
                    ps.email = usermail;
                    ps.patStockInsert();
                }

                //Orderdetails Create
                OrderDetails od = new OrderDetails();
                od.OdOrderID = oID;
                od.OdPID = p1.PID;
                od.Odqty = productreqqty;
                od.productInsert();
                

                return true;
            }else
            {
                //add to manufacture table
                int manureq = productreqqty - productqty;

                Manufacture man = new Manufacture();
                man.ProID = p1.PID;
                man.Useremail = usermail;
                man.qty = manureq;
                man.manuInsert();
            }

            return false;


        }

        [WebMethod]
        public Double calculateBill(string pID, int qty)
        {
            Double unitPrice = 0;
            Double unitTotal = 0;

            Product p1 = new Product();
            p1.PID = pID;
            p1.productFind();

            unitPrice = p1.PPrice;

            unitTotal = unitPrice * qty;

            return unitTotal;


        }

        [WebMethod]
        public Double DiscountCalculation(string oID,double total)
        {
            double totalAmount = 0;
            double disRate = 0;

            Orders o1 = new Orders();
            o1.OrderID = oID;
            o1.orderFind();


            DiscountRates dis = new DiscountRates();
            dis.DisID = o1.DiscountID;
            dis.discountfind();
            disRate = dis.DisRate;

            totalAmount = total - (disRate * total);

            return totalAmount;

        }

    }
}
