using Itvitae_repair.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Itvitae_repair.Controllers
{
    public class OrderController : Controller
    {

        // GET: Order
        public ActionResult Index()
        {
            return View("OrderView");
        }

        //==========================================
        //------------------------------------------
        public ActionResult ViewUserList()
        {
            return View(new List<UserViewList>());
        }
        public ActionResult ViewWorkerList()
        {
            return View(new List<WorkerViewList>());
        }
        public ActionResult ViewAdminList()
        {
            return View(new List<AdminViewList>());
        }
        //------------------------------------------
        //==========================================
        //------------------------------------------
        public ActionResult CreateOrder()
        {

            return View();
        }
        [HttpPost]
        public ActionResult CreateOrderConfirm()
        {
            ViewBag.message = "Yea thingy got done yay!";
            return View("ConfirmMessageView");
        }
        //------------------------------------------
        //==========================================
        //------------------------------------------
        public ActionResult EditUserOrder()
        {
            return View();
        }
        [HttpPost]
        public ActionResult EditUserOrderConfirm()
        {
            ViewBag.message = "Yea thingy got done yay!";

            return View("ConfirmMessageView");
        }
        //------------------------------------------
        //==========================================
        //------------------------------------------
        public ActionResult EditWorkerOrder()
        {
            return View();
        }
        [HttpPost]
        public ActionResult EditWorkerOrderConfirm()
        {
            ViewBag.message = "Yea thingy got done yay!";
            return View("ConfirmMessageView");
        }
        //------------------------------------------
        //==========================================
        //------------------------------------------
        public ActionResult EditAdminOrder()
        {
            return View();
        }
        [HttpPost]
        public ActionResult EditAdminOrderConfirm()
        {
            ViewBag.message = "Yea thingy got done yay!";
            return View("EditAdminOrder");
        }
        //------------------------------------------
        //==========================================
        //------------------------------------------
        public ActionResult AddParts()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddPartsConfirm(AddParts addPartsModel)
        {

            ViewBag.message = addPartsModel.Name;
            return View("ConfirmMessageView");
        }
        //------------------------------------------
        //==========================================
        //------------------------------------------
        public ActionResult AddPartsToOrder()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddPartsToOrderConfirm()
        {
            ViewBag.message = "Yea thingy got done yay!";
            return View("ConfirmMessageView");
        }
        //------------------------------------------
        //==========================================
    }
}