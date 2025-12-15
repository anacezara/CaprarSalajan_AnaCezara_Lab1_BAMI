using Microsoft.AspNetCore.Mvc;

namespace CaprarSalajan_AnaCezara_Lab1.Controllers
{
    public class DemoController : Controller
    {
        public string Index()
        {
            return "Bun venit în aplicația mea ASP.NET Core MCV!";
        }

        public string Salut()
        {
            return "Salut!";
        }

        public string MesajPersonalizat(string nume, int varsta)
        {
            return $"Salut {nume}, ai varsta de {varsta} ani - acesta este un mesaj personalizat!";
        }
    }
}
