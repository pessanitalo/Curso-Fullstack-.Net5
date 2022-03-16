using System;

namespace ProEventos.Domain.Models
{
    public class Lote
    {
        public int Id { get; set; }
        public string Nomes { get; set; }
        public decimal Precos { get; set; }
        public DateTime? DataInicios { get; set; }
        public DateTime? DataFims { get; set; }
        public int Quantidades { get; set; }
        public int EventoIDs { get; set; }
        public Evento Eventos { get; set; }
    }
}
