using Microsoft.AspNetCore.Mvc;
using HotelCrud.Data;

namespace HotelCrud.Controllers
{
    public class AccountController : Controller
    {
        private readonly HotelContext _db;

        public AccountController(HotelContext db)
        {
            _db = db;
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(string email, string senha)
        {
            var usuario = _db.Funcionarios.FirstOrDefault(f => f.Email == email && f.Senha == senha);

            if (usuario != null)
            {
                HttpContext.Session.SetString("Usuario", usuario.Nome);
                return RedirectToAction("Index", "Home");
            }

            ViewBag.Erro = "E-mail ou senha inválidos!";
            return View();
        }

        
        public IActionResult Logout()
        {
            
            HttpContext.Session.Clear();

            
            return RedirectToAction("Login", "Account");
        }
    }
}