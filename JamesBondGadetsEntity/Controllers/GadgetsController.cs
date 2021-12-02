using JamesBondGadetsEntity.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JamesBondGadetsEntity.Controllers
{
    public class GadgetsController : Controller
    {   // reference to the ApplicationDbContext Class
        private ApplicationDbContext context;

        public GadgetsController()
        {
            this.context = new ApplicationDbContext();

        }

        //disconnecting connections to the database
        protected override void Dispose(bool disposing)
        {
            context.Dispose();
        }


        // GET: Default
        public ActionResult Index()
        {
  //we create a list called gadgets. The context is a reference of the DBset
            List<GadgetModel> gadgets = context.Gadgets.ToList();
            return View("Index", gadgets);// we want to return a list
        }

        //create another Action
        public ActionResult Details(int id)
        {

            GadgetModel gadget = context.Gadgets.SingleOrDefault(g => g.Id == id);
            return View("Details", gadget);
        }
        //action to create a form
        public ActionResult Create()
        {

            return View("GadgetForm");
        }


        public ActionResult Edit(int id)
        {

            return View("GadgetForm"); ;
        }

        public ActionResult Delete(int id)
        {
            GadgetModel gadget = context.Gadgets.SingleOrDefault(g => g.Id == id);
            context.Entry(gadget).State = EntityState.Deleted;
            context.SaveChanges();
            //instead of View, we want it to redirect the page back to gadgets

            return Redirect("/Gadgets");

        }

        //action to submit and process the form
        public ActionResult CreateGadgets(GadgetModel gadgetModel)
        {
            return View("Details");
        }
    }
}