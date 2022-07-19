using CamposDealer.Data;
using CamposDealer.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace CamposDealer.Controllers
{
    public class ProdutosController : Controller
    {
        //Para recuperar os dados do BD
        private readonly ApplicationDbContext _db;

        public ProdutosController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<Produtos> objProdutosList = _db.Produtos;
            return View(objProdutosList);
        }
    }
}
