using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ContosoPO.DAL;
using ContosoPO.Models;

namespace ContosoPO.Controllers
{
    public class PurchaseOrdersController : Controller
    {
        private POContext db = new POContext();

        // GET: PurchaseOrders
        public ActionResult Index()
        {
            var purchaseOrders = db.PurchaseOrders.Include(p => p.Owner);
            purchaseOrders.Include(p => p.LineItems);
            return View(purchaseOrders.ToList());
        }


        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
