﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TOURDL.Models;

namespace MVC_Dulich.Controllers
{
    public class ChiTietTourController : Controller
    {
        // GET: ChiTietTour
        private TourDLEntities db = new TourDLEntities();

        public ActionResult ChiTietTour(string id)
        {
            var data = db.SPTOURs.Where(s => s.ID_SPTour == id);
            return View(data);
        }

    }
}