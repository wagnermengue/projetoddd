﻿using ProjetoDDD.Domain.Entities;
using System.Collections.Generic;

namespace ProjetoDDD.Application.Interface
{
    public interface IProdutoAppService : IAppServiceBase<Produto>
    {
        IEnumerable<Produto> BuscarPorNome(string nome);
    }
}
