using System;
using System.Collections.Generic;

namespace Drobnjak.DataAccess.Domain
{
    public partial class Film
    {
        public int FilmId { get; set; }
        public string Naziv { get; set; }
        public string Opis { get; set; }
        public DateTime? DatumPrikaza { get; set; }
        public string Trajanje { get; set; }
    }
}
