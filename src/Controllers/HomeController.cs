using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.ApplicationInsights;
using Microsoft.AspNetCore.Diagnostics;
using aspnet_ai.Models;

namespace aspnet_ai.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly TelemetryClient _telemetry;

        public HomeController(ILogger<HomeController> logger, TelemetryClient telemetry)
        {
            _telemetry = telemetry;
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            _telemetry.TrackEvent($"Privacy requested @ {DateTime.UtcNow} UTC");
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            // IExceptionHandlerPathFeature requires Microsoft.AspNetCore.Diagnostics
            // run: dotnet add package Microsoft.AspNetCore.Diagnostics --version 2.2.0
            var error = HttpContext.Features.Get<IExceptionHandlerFeature>();
            if (error != null)
            {
                _telemetry.TrackException(error.Error); 
            }

            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
