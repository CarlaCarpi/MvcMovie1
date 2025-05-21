using Microsoft.AspNetCore.Mvc;
using MvcMovie1.Models;

namespace MvcMovie1.Controllers
{
    public class UsuarioController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public ActionResult ForMethod(string username, string password, string name, string fechanacimiento, string email)
        {

            UsuarioModel usuario;
            List<UsuarioModel> listUsuario = new List<UsuarioModel>();

            if (password == "password")
            {
                ViewBag.Error = "ERROR";
            }
            else
            {


                for (int i = 0; i <= 5; i++)
                {
                    usuario = new UsuarioModel();
                    usuario.email = "carlavc_86@hotmail.com";// a nuestro usuario le estamos asignando estos valores
                    usuario.username = "ccarpinetti";
                    usuario.password = "password";
                    usuario.fechanacimiento = DateTime.Now;
                    usuario.name = "Carla Carpinetti";
                    usuario.id = i;

                    listUsuario.Add(usuario);
                }
            ViewBag.ListaUsuario = listUsuario;
            }
            return View("Index");
        }
    }
}
