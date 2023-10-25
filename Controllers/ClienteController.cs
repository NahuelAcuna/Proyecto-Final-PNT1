using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Proyecto_Final.Models;
using Proyecto_Final.Models.Entities;

namespace Proyecto_Final.Controllers
{
    public class ClienteController : Controller
    {
        Context context = new Context();

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            List<Cliente> clientes = await context.Clientes.ToListAsync();

            return View(clientes);
        }

        [HttpGet]
        public IActionResult CreateCliente()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateCliente(Cliente cliente)
        {
            if (cliente != null)
            {
                context.Clientes.Add(cliente);
                await context.SaveChangesAsync();
            }

            return RedirectToAction(nameof(Index));
        }
    }
}
