using System;
using System.Collections.Generic;

namespace Semana7.Models
{
    public partial class Movie
    {
        public int Id { get; set; }
        public string? Genero { get; set; }
        public decimal? Precio { get; set; }
        public DateTime? Lanzamiento { get; set; }
        public string? Titulo { get; set; }
    }
}
