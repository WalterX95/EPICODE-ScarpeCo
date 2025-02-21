using Microsoft.AspNetCore.Mvc;

namespace ScarpeCo.Models
{
    public class Scarpa
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public decimal Prezzo { get; set; }
        public string? Descrizione { get; set; }
        public string? Copertina { get; set; }
        public string? Img1 { get; set; }
        public string? Img2 { get; set; }

        // Metodo per formattare il prezzo
        public string PrezzoFormattato()
        {
            return Prezzo.ToString("C");
        }
    }
}

