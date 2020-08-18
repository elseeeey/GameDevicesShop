using GameDevicesStore.Domain.Services.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GameDevicesStore.Client.Controllers
{
    public class DevicesController : Controller
    {

        private readonly IDeviceService deviceService;

        // GET: Devices
        public ActionResult Index()
        {
            return View();
        }
    }
}