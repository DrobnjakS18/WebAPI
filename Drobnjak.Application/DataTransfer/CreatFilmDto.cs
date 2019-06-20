using System;
using System.Collections.Generic;
using System.Text;

namespace Drobnjak.Application.DataTransfer
{
    public class CreatFilmDto
    {
        public string Naziv { get; set; }
        public string Opis { get; set; }
        public DateTime? DatumPrikaza { get; set; }
        public string Trajanje { get; set; }
    }
}
