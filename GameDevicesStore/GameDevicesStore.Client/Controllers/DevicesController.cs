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

        private readonly IDeviceService _deviceService;

        public DevicesController(IDeviceService deviceService)
        {
            _deviceService = deviceService;
        }

        // GET: Devices
        public ActionResult Index()
        {
            var devices = _deviceService.GetDevices();
            ViewBag.Devices = devices;
            return View();
        }

    }

}