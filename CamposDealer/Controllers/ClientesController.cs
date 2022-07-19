using CamposDealer.Data;
using CamposDealer.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace CamposDealer.Controllers
{
    public class ClientesController : Controller
    {
        //Para recuperar os dados do BD
        private readonly ApplicationDbContext _db;

        public ClientesController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<Clientes> objClientesList = _db.Clientes;
            return View(objClientesList);
        }
        //GET
        public IActionResult Create()
        {

            return View();
        }
        //POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Clientes obj)

        {
            if (obj.nmCliente == obj.nomeDaCidade)
            {
                ModelState.AddModelError("nmCliente", "Os parâmetros estão repetidos");
            }
            //Comparar se a entrada é igual ao que foi modelado
            if (ModelState.IsValid)
            {
                _db.Clientes.Add(obj);
                _db.SaveChanges();
                //Alertas com tempdata, pois ele duram apenas uma requisição
                TempData["Sucesso"] = "Cliente adicionado com sucesso";
                //Poderia abrir outras aspas para redirecionar a controller mas como estou na mesma. não precisa
                return RedirectToAction("Index");
            }
            ModelState.AddModelError("", "Todos os campos devem ser preenchidos");
            return View(obj);

        }


        //GET
        public IActionResult Edit(int? ID)
        {
            if (ID == null || ID == 0)
            {
                return NotFound();
            }
            var clientesDb = _db.Clientes.Find(ID);
            if (clientesDb == null)
            {
                return NotFound();
            }
            return View(clientesDb);
        }
        //POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Clientes obj)

        {
            if (obj.nmCliente == obj.nomeDaCidade)
            {
                ModelState.AddModelError("nmCliente", "Os parâmetros estão repetidos");
            }
            //Comparar se a entrada é igual ao que foi modelado
            if (ModelState.IsValid)
            {
                //Em vez de ADD, Update
                _db.Clientes.Update(obj);
                _db.SaveChanges();
                TempData["Sucesso"] = "Cliente editado com sucesso";

                //Poderia abrir outras aspas para redirecionar a controller mas como estou na mesma. não precisa
                return RedirectToAction("Index");
            }
            ModelState.AddModelError("", "Todos os campos devem ser preenchidos");
            return View(obj);

        }

        //GET
        public IActionResult Delete(int? ID)
        {
            if (ID == null || ID == 0)
            {
                return NotFound();
            }
            var clientesDb = _db.Clientes.Find(ID);
            if (clientesDb == null)
            {
                return NotFound();
            }
            return View(clientesDb);
        }
        //POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeletePOST(int? ID)

        {
            var obj = _db.Clientes.Find(ID);
            if (obj == null)
            {
                return NotFound();
            }
            //Em vez de ADD, Update
            _db.Clientes.Remove(obj);
            _db.SaveChanges();
            TempData["Sucesso"] = "Cliente excluído com sucesso";

            //Poderia abrir outras aspas para redirecionar a controller mas como estou na mesma. não precisa
            return RedirectToAction("Index");
                   
        }
    }
}
