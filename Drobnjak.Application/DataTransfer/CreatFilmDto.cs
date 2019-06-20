using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Drobnjak.Application.DataTransfer
{
    public class CreatFilmDto
    {
        [Required]
        public string Naziv { get; set; }
        [Required]
        public string Opis { get; set; }
        public DateTime? DatumPrikaza { get; set; }
        [RegularExpression("^[0-9]*$", ErrorMessage = "Slova nisu dozvoljena")]
        public string Trajanje { get; set; }
    }
}
