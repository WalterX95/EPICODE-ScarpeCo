using Microsoft.AspNetCore.Mvc;
using ScarpeCo.Models; // Importa il Model
using System.Collections.Generic;
using System.Linq;

namespace ScarpeCo.Controllers
{
    public class ScarpeController : Controller
    {
        private static List<Scarpa> scarpe = new List<Scarpa>
        {
            new Scarpa { Id = 1, Nome = "Nike Air Zoom", Prezzo = 120.00m, Descrizione = "Scarpa da tennis leggera e resistente.", Copertina = "nike_air_zoom.jpg", Img1 = "nike_air_zoom_1.jpg", Img2 = "nike_air_zoom_2.jpg" },
            new Scarpa { Id = 2, Nome = "Adidas CourtJam", Prezzo = 95.00m, Descrizione = "Scarpa ideale per superfici dure.", Copertina = "adidas_courtjam.jpg", Img1 = "adidas_courtjam_1.jpg", Img2 = "adidas_courtjam_2.jpg" }
        };

        public IActionResult Index()
        {
            return View(scarpe);
        }

        public IActionResult Dettaglio(int id)
        {
            var scarpa = scarpe.FirstOrDefault(s => s.Id == id);
            if (scarpa == null)
            {
                return NotFound();
            }
            return View(scarpa);
        }

        public IActionResult Modifica(int id)
        {
            var scarpa = scarpe.FirstOrDefault(s => s.Id == id);
            if (scarpa == null)
            {
                return NotFound();
            }
            return View(scarpa);
        }

        [HttpPost]
        public IActionResult Modifica(Scarpa scarpaModificata)
        {
            var scarpa = scarpe.FirstOrDefault(s => s.Id == scarpaModificata.Id);
            if (scarpa != null)
            {
                scarpa.Nome = scarpaModificata.Nome;
                scarpa.Prezzo = scarpaModificata.Prezzo;
                scarpa.Descrizione = scarpaModificata.Descrizione;
                scarpa.Copertina = scarpaModificata.Copertina;
                scarpa.Img1 = scarpaModificata.Img1;
                scarpa.Img2 = scarpaModificata.Img2;
            }
            return RedirectToAction("Index");
        }
    }
}
