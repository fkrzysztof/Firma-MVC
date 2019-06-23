using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Firma.Data.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Firma.PortalWWW.Controllers
{
    public class SklepController : Controller
    {
        private readonly FirmaContext _context;
        public SklepController(FirmaContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index(int? id)
        {
            //uwaga dodaj using Microsoft.EntityFrameworkCore;
            ViewBag.Rodzaje = await _context.Rodzaj.ToListAsync();
            if (id == null)
            {
                var pierwszy = await _context.Rodzaj.FirstAsync();
                id = pierwszy.IdRodzaju;
            }
            return View(await _context.Towar.Where(t => t.IdRodzaju == id).ToListAsync());
        }
    }
}