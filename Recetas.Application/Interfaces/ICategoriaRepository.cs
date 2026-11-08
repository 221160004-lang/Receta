using System;
using System.Collections.Generic;
using System.Text;
using Recetas.Domain.Entities;

namespace Recetas.Application.Interfaces
{
    public interface ICategoriaRepository
    {
        Task<List<Categoria>> ObtenerTodasAsync();
    }
}
