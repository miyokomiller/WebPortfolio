﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Portfolio.Controllers
{
    public class ContactController : Controller
    {
        Models.sp5EricEntities contactDb = new Models.sp5EricEntities();

        // GET: Contact
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SendContact(FormCollection values)
        {
            // Add the contact info to the database
            contactDb.AddNewContact(values["fullname"],values["emailAddress"],values["body"]);
            contactDb.SaveChanges();
            ViewData["name"] = values["fullname"];
            return View("ThankYou");
        }
    }
}