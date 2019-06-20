using Drobnjak.Application.Commands;
using Drobnjak.Application.DataTransfer;
using Drobnjak.DataAccess.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Drobnjak.EfCommands
{
    public class EfCreatFilmCommand : ICreatFilmCommand
    {
        private readonly DrobnjakFilmContext _context;

        public EfCreatFilmCommand(DrobnjakFilmContext context)
        {
            _context = context;
        }
        public void Execute(CreatFilmDto request)
        {
            
            _context.Film.Add(new Film {

                Naziv = request.Naziv,
                Opis = request.Opis,
                DatumPrikaza = request.DatumPrikaza,
                Trajanje = request.Trajanje

            });

            _context.SaveChanges();
        }
    }
}
