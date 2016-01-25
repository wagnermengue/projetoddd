using System;
using System.Collections.Generic;
using ProjetoDDD.Domain.Entities;
using ProjetoDDD.Domain.Interfaces.Services;
using ProjetoDDD.Domain.Interfaces.Repositories;

namespace ProjetoDDD.Domain.Services
{
    public class ProdutoService : ServiceBase<Produto>, IProdutoService
    {

        private readonly IProdutoRepository _produtoRepository;

        public ProdutoService (IProdutoRepository produtoRepository)
            :base(produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }

        public IEnumerable<Produto> BuscaPorNome(string nome)
        {
            return _produtoRepository.BuscaPorNome(nome);
        }
    }
}
