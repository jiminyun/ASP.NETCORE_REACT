using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DOTNET_CORE_WEBAPI.Services;
using DOTNET_CORE_WEBAPI.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace DOTNET_CORE_WEBAPI.Controllers
{
    public class AppController : Controller
    {
        private readonly ICityInfoRepository _cityInfoRepository;
        private readonly IMailService _localMailService;

        public AppController(ICityInfoRepository cityInfoRepository, IMailService localMailService)
        {
            _cityInfoRepository = cityInfoRepository;
            _localMailService = localMailService;
        }
        public IActionResult Index()
        {
            var cityEntities = _cityInfoRepository.GetCities();

            return View(cityEntities);

        }

        [HttpGet("contact")]
        public IActionResult Contact()
        {
            //throw new InvalidOperationException("err page test for production");
            ; return View();
        }

        [HttpPost("contact")]
        public IActionResult Contact(ContactViewModel model)
        {
            if (ModelState.IsValid) // Send the mail
            {
                _localMailService.SendMessage("jiminyun7@gmail.com", model.Subject, $"From: {model.Name} - {model.Email}, Message: {model.Message}");
                ViewBag.UserMessage = "Mail Sent";
                ModelState.Clear();
            }
           
            return View(model);
        }

    }
}