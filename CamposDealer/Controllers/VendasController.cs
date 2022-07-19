using CamposDealer.Data;
using CamposDealer.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
namespace CamposDealer.Controllers
{
    public class VendasController : Controller
    {

        private readonly ApplicationDbContext _db;

        public VendasController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<Vendas> objVendasList = _db.Vendas;
            return View(objVendasList);
        }
    }
}
