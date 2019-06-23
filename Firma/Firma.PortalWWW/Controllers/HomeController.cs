using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Firma.PortalWWW.Models;
using Firma.Data.Data;
namespace Firma.PortalWWW.Controllers
{
    public class HomeController : Controller
    {
        private readonly FirmaContext _context;
        public HomeController(FirmaContext context)
        {
            _context = context;
        }
        public IActionResult Index(int? id)
        {
            ViewBag.ModelStrony =
            (
            from strona in _context.Strona
            orderby strona.Pozycja
            select strona
        ).ToList();
            ViewBag.ModelAktualnosci =
            (
            from aktualnosc in _context.Aktualnosc
            orderby aktualnosc.Pozycja
            select aktualnosc
            ).ToList();
            if (id == null)
                id = _context.Strona.First().IdStrony;
            var item = _context.Strona.Find(id);
            return View(item);
        }
        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";
            return View();
        }
        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore =
        true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel
            {
                RequestId = Activity.Current?.Id ??
            HttpContext.TraceIdentifier
            });
        }
    }
}

/*

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Firma.PortalWWW.Models;
using Firma.Data.Data;

namespace Firma.PortalWWW.Controllers
{
    public class HomeController : Controller
    {
        // to jest obiekt reprezentujacy cala baze danych
        private readonly FirmaContext _context;

        public HomeController(FirmaContext context)
        {
            _context = context;
        }

        public IActionResult Index(int? id)
        {
            // do zmiennej ModelStrony przekazanej do widoku za pomoca ViewBag (bo ViewBag sluzy do komunikacji miedzy np 
            // Controllerem a Widokiem) przekazuje wszystkie strony ktore sa w bazie posortowane wzgledem pozycji.
            ViewBag.ModelStrony =
                (
                    from strona in _context.Strona
                    orderby strona.Pozycja
                    select strona
                ).ToList();

            // do zmiennej ModelAktualnosci przekazanej do widoku za pomoca ViewBag przekazuje wszystkie aktualnosci ktore sa w bazie posortowane wzgledem pozycji.
            ViewBag.ModelAktualnosci =
                (
                    from aktualnosc in _context.Aktualnosc
                    orderby aktualnosc.Pozycja
                    select aktualnosc
                ).ToList();

            if (id == null)
            {
                // przy pierwszym zaladowaniu witryny jako pierwsza pojawi sie pierwsza strona z bazy
                // przy kolejnym kliknieciu na linki do innych stron, id tych stron bedzie przekazywane w zmiennej id
                id = _context.Strona.First().IdStrony;
            }

            // zatem do widoku przekazujemy strone o danym id - kliknietym lub domyslnym pierwszym 
            var item = _context.Strona.Find(id); // zatem w bazie danych znajdujemy strone o danym id i przekazujemy ja do widoku
            return View(item);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}


*/















//using System;
//using System.Collections.Generic;
//using System.Diagnostics;
//using System.Linq;
//using System.Threading.Tasks;
//using Microsoft.AspNetCore.Mvc;
//using Firma.PortalWWW.Models;
//using Firma.Data.Data;

//namespace Firma.PortalWWW.Controllers
//{
//    public class HomeController : Controller
//    {
//        private readonly FirmaContext _context;
//        public HomeController(FirmaContext context)
//        {
//            _context = context;
//        }
//        public IActionResult Index(int? id)
//        {
//            ViewBag.ModelStrony =
//                (
//                    from strona in _context.Strona
//                    orderby strona.Pozycja
//                    select strona
//                ).ToList();
//            ViewBag.ModelAktualnosci =
//                (
//                    from aktualnosc in _context.Aktualnosc
//                    orderby aktualnosc.Pozycja
//                    select aktualnosc
//                ).ToList();
//            if (id == null)
//                id = _context.Strona.First().IdStrony;
//            var item = _context.Strona.Find(id);
//            return View(item);
//        }

//        public IActionResult About()
//        {
//            ViewData["Message"] = "Your application description page.";

//            return View();
//        }

//        public IActionResult Contact()
//        {
//            ViewData["Message"] = "Your contact page.";

//            return View();
//        }

//        public IActionResult Privacy()
//        {
//            return View();
//        }

//        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
//        public IActionResult Error()
//        {
//            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
//        }
//    }
//}