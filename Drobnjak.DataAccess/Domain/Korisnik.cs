using System;
using System.Collections.Generic;

namespace Drobnjak.DataAccess.Domain
{
    public partial class Korisnik
    {
        public int KorisnikId { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Email { get; set; }
        public string Lozinka { get; set; }
        public int UlogaId { get; set; }
    }
}
