using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IP_Final_4046.Models;
using Microsoft.AspNetCore.Mvc;

namespace IP_Final_4046.Controllers
{
    public class SportController : Controller
    {
        private readonly ISportRepo _context;
        
        public SportController(ISportRepo context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View(_context.GetSports());
        }
    }
}