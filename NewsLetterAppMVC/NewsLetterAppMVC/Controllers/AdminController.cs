﻿using NewsLetterAppMVC.Models;
using NewsLetterAppMVC.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NewsLetterAppMVC.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            using (NewsLetterEntities db = new NewsLetterEntities())
            {
                //var signups = db.SignUps.Where(x => x.Removed == null).ToList();
                var signups = (from c in db.SignUps
                               where c.Removed == null
                               select c).ToList();
                var signupVMs = new List<SignUpVM>();
                foreach (var signup in signups)
                {
                    var signupVM = new SignUpVM();
                    signupVM.Id = signup.Id;
                    signupVM.FirstName = signup.FirstName;
                    signupVM.LastName = signup.LastName;
                    signupVM.EmailAddress = signup.EmailAddress;
                    signupVMs.Add(signupVM);
                }
                return View(signupVMs);
            }
        }

        public ActionResult Unsubscribe(int Id)
        {
            using (NewsLetterEntities db = new NewsLetterEntities())
            {
                var signup = db.SignUps.Find(Id);
                signup.Removed = DateTime.Now;
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }
    }
}