using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace DOTNEW_WEBAPI.Controllers
{
    [Route("[controller]")]
    public class GetAllApiData : Controller
    {
        private readonly ILogger<GetAllApiData> _logger;

        public GetAllApiData(ILogger<GetAllApiData> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}