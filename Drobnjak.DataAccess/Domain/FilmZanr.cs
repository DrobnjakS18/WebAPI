using System;
using System.Collections.Generic;

namespace Drobnjak.DataAccess.Domain
{
    public partial class FilmZanr
    {
        public int FilmZanrId { get; set; }
        public int FilmId { get; set; }
        public int ZanrId { get; set; }
    }
}
