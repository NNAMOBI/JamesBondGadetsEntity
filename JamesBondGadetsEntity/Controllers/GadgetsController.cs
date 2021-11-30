using JamesBondApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JamesBondApp.Controllers
{
    public class GadgetsController : Controller
    {
        // GET: Default
        public ActionResult Index()
        {

            // generate some dummy data and return it to the view
          List<GadgetModel> gadgets = new List<GadgetModel>(); // this will call the first constructor without params
            

            GadgetsDAO gadgetDAO = new GadgetsDAO();

            gadgets = gadgetDAO.FetchAll();

            return View("Index", gadgets);
        }

        //create another Action
        public ActionResult Details(int id)
        {
            //instatiate the Gadget Data Access Object class responsible for queryin the DB
            GadgetsDAO gadgetDAO = new GadgetsDAO();
            GadgetModel gadget = gadgetDAO.FetchOneByID(id);

            return View("Details", gadget);
        }
        //action to create a form
        public ActionResult Create()
        {
            return View("GadgetForm");
        }


        public ActionResult Edit(int id)
        {

            GadgetsDAO gadgetDAO = new GadgetsDAO();
            GadgetModel gadget = gadgetDAO.FetchOneByID(id);
            return View("GadgetForm", gadget); ;
        }

        public ActionResult Delete(int id)
        {
            GadgetsDAO gadgetDAO = new GadgetsDAO();
            gadgetDAO.Delete(id);

            List<GadgetModel> gadgets = gadgetDAO.FetchAll();
            return View("Index", gadgets);
        }



        //action to submit and process the form
        public ActionResult CreateGadgets(GadgetModel gadgetModel)
        {
            GadgetsDAO gadgetDAO = new GadgetsDAO();

            gadgetDAO.CreateOrUpdate(gadgetModel);

            return View("Details", gadgetModel);
        }
    }
}