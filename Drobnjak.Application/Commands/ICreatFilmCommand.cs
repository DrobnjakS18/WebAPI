using Drobnjak.Application.DataTransfer;
using Drobnjak.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Drobnjak.Application.Commands
{
    public interface ICreatFilmCommand : ICommand<CreatFilmDto>
    {
    }
}
