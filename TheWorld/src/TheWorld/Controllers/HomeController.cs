using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using TheWorld.Options;
using Microsoft.Extensions.OptionsModel;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace TheWorld.Controllers
{
    public class HomeController : Controller
    {
        private AppSettings _appSettings;
        public HomeController(IOptions<AppSettings> appSettings)
        {
            this._appSettings = appSettings.Value;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            ViewData["Settings"] = this._appSettings.Logging.LogLevel.Microsoft;
            return View();
        }
    }
}
