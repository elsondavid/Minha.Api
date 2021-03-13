using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Minha.Api.Models
{
    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public int Quantidade { get; set; }
        public string UnidadeMedida { get; set; }
    }
}
