using Minha.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Minha.Api.Repository
{
    public static class ProdutoRepository
    {
        public static List<Produto> Produtos { get; set; } = new List<Produto>();
    }
}
