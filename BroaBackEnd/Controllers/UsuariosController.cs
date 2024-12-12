using BroaBackEnd.Data;
using BroaBackEnd.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


namespace BroaBackEnd.Controllers
{
    public class UsuariosController : Controller
    {
        private readonly BroaDbContext _context;

        public UsuariosController(BroaDbContext context)
        {

            _context = context;

        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register([Bind("Nome,Email,Senha")] Usuario usuario)
        {
            if (ModelState.IsValid)
            {
                _context.Add(usuario);
                await _context.SaveChangesAsync();
                return RedirectToAction("Login");
            }
            return View(usuario);
        }


        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(string email, string senha)
        {
            var usuario = await _context.Usuarios
                .FirstOrDefaultAsync(u => u.Email == email && u.Senha == senha);

            if (usuario != null)
            {
     
                return RedirectToAction("Index", "Produtos");
            }

            ViewBag.Error = "E-mail ou senha inválidos!";
            return View();
        }
    }
}