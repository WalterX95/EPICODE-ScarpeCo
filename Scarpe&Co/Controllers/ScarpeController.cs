using Microsoft.AspNetCore.Mvc;
using ScarpeCo.Models; 
using System.Collections.Generic;
using System.Linq;

namespace ScarpeCo.Controllers
{
    public class ScarpeController : Controller
    {
        private static List<Scarpa> scarpe = new List<Scarpa>
        {
            new Scarpa { Id = 1, 
                        Nome = "Nike Air Zoom",
                        Prezzo = 120.00m, Descrizione = "Scarpa da tennis leggera e resistente.", 
                        Copertina = "https://i8.amplience.net/i/jpl/jd_720692_a?qlt=92&w=950&h=673&v=1&fmt=auto",
                        Img1 = "https://noirfonce.it/cdn/shop/files/Nike_Pegasus_41_Black_White_-_Anthracite_FD2722-002.jpg?v=1727089860&width=1800", 
                        Img2 = "nike_air_zoom_2.jpg" },

            new Scarpa { Id = 2, 
                         Nome = "Adidas CourtJam", 
                         Prezzo = 95.00m, 
                         Descrizione = "Scarpa ideale per superfici dure.", 
                         Copertina = "https://maxi.gumlet.io/media/catalog/product/cache/0545fe0dfa15ac1f18243c5c8f281222/n/i/nike-fd2722-air-zoom-pegasus-41-scarpe-running-uomo-049226701-002_1.jpg", 
                         Img1 = "https://maxi.gumlet.io/media/catalog/product/cache/0545fe0dfa15ac1f18243c5c8f281222/n/i/nike-fd2722-air-zoom-pegasus-41-scarpe-running-uomo-049226701-002_1.jpg",
                         Img2 = "https://maxi.gumlet.io/media/catalog/product/cache/0545fe0dfa15ac1f18243c5c8f281222/n/i/nike-fd2722-air-zoom-pegasus-41-scarpe-running-uomo-049226701-002_1.jpg" },

            new Scarpa { Id = 3,
                         Nome = "Adidas Zanotti Editions", 
                         Prezzo = 225.00m, 
                         Descrizione = "Scarpa ideale per essere sempre eleganti \n con tocco di leggerezza", 
                         Copertina = "https://static.nike.com/a/images/t_PDP_1728_v1/f_auto,q_auto:eco/f0f32ff8-8df1-4f0a-ab0b-a57e7dcd96ee/W+NIKE+AIR+MAX+PORTAL.png",
                         Img1 = "https://static.nike.com/a/images/t_PDP_1728_v1/f_auto,q_auto:eco/f0f32ff8-8df1-4f0a-ab0b-a57e7dcd96ee/W+NIKE+AIR+MAX+PORTAL.png",
                         Img2 = "https://static.nike.com/a/images/t_PDP_1728_v1/f_auto,q_auto:eco/f0f32ff8-8df1-4f0a-ab0b-a57e7dcd96ee/W+NIKE+AIR+MAX+PORTAL.png" },

            new Scarpa { Id = 4,
                         Nome = "Scarpe Matte Kelly Kelly", 
                         Prezzo = 145.00m, 
                         Descrizione = "Scarpa con calzature molto trendy \n colori sgargianti",
                         Copertina = "https://static.nike.com/a/images/t_PDP_1728_v1/f_auto,q_auto:eco/f0f32ff8-8df1-4f0a-ab0b-a57e7dcd96ee/W+NIKE+AIR+MAX+PORTAL.png", 
                         Img1 = "https://static.nike.com/a/images/t_PDP_1728_v1/f_auto,q_auto:eco/f0f32ff8-8df1-4f0a-ab0b-a57e7dcd96ee/W+NIKE+AIR+MAX+PORTAL.png",
                         Img2 = "https://static.nike.com/a/images/t_PDP_1728_v1/f_auto,q_auto:eco/f0f32ff8-8df1-4f0a-ab0b-a57e7dcd96ee/W+NIKE+AIR+MAX+PORTAL.png" },

            new Scarpa { Id = 5,
                         Nome = "Scarpe QueryBase X67", 
                         Prezzo = 245.00m, 
                         Descrizione = "Scarpa con calzature fenamenali \n colori sgargianti",
                         Copertina = "https://static.nike.com/a/images/t_PDP_1728_v1/f_auto,q_auto:eco/f0f32ff8-8df1-4f0a-ab0b-a57e7dcd96ee/W+NIKE+AIR+MAX+PORTAL.png", 
                         Img1 = "https://static.nike.com/a/images/t_PDP_1728_v1/f_auto,q_auto:eco/f0f32ff8-8df1-4f0a-ab0b-a57e7dcd96ee/W+NIKE+AIR+MAX+PORTAL.png", 
                         Img2 = "https://static.nike.com/a/images/t_PDP_1728_v1/f_auto,q_auto:eco/de982c24-5870-4621-aefe-26afe51e2bde/NIKE+DUNK+LOW.png" },

            new Scarpa { Id = 6, 
                         Nome = "Scarpe Sciantal Versione Base", 
                         Prezzo = 45.00m,
                         Descrizione = "Scarpa con calzature fenamenali \n colori sgargianti", 
                         Copertina = "https://static.nike.com/a/images/t_PDP_1728_v1/f_auto,q_auto:eco/fa6b0f9f-8041-4c84-8823-af20a825c4ab/NIKE+P-6000+%28GS%29.png",
                         Img1 = "https://static.nike.com/a/images/t_PDP_1728_v1/f_auto,q_auto:eco/fa6b0f9f-8041-4c84-8823-af20a825c4ab/NIKE+P-6000+%28GS%29.png", 
                         Img2 = "https://static.nike.com/a/images/t_PDP_1728_v1/f_auto,q_auto:eco/fa6b0f9f-8041-4c84-8823-af20a825c4ab/NIKE+P-6000+%28GS%29.png" }

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
            if (scarpa != null || !ModelState.IsValid)
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
