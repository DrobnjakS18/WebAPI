using System;
using System.Collections.Generic;

namespace Drobnjak.DataAccess.Domain
{
    public partial class FilmGlumac
    {
        public int FilmGlumacId { get; set; }
        public int FilmId { get; set; }
        public int GlumacId { get; set; }
    }
}
