﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AppleWebsite.Models;
namespace AppleWebsite.Controllers
{
    public class DeviceController : Controller
    {
        // GET: Device
        public ActionResult Index(int id)
        {
            AppleDBContext db = new AppleDBContext();
            List<Device> devices = db.Devices.Where(row => row.id_cate == id).ToList();
            return View(devices);
        }
        public ActionResult Details(int id)
        {
            AppleDBContext db = new AppleDBContext();
           Device device_matched = db.Devices.Where(row => row.id_dev == id).FirstOrDefault();
            return View(device_matched);
        }
      
        [HttpPost]
        public ActionResult Search(string search_name)
        {
            AppleDBContext db = new AppleDBContext();
            List<Device> devices = db.Devices.Where(row =>  row.name_dev.ToLower().Contains(search_name.ToLower())).ToList();
            if(devices.Count !=0)
			{

            return View(devices);
			}
			{
                ViewBag.name = search_name;
                return View("NotFound");
			}
        }
    }
}