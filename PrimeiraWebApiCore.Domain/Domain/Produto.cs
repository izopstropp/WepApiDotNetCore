using System;
using System.Collections.Generic;
using System.Text;

namespace PrimeiraWebApiCore.Domain.Domain
{
    public class Produto
    {
        public int ProdutoId { get; set; }
        public string Nome { get; set; }
        public bool Status { get; set; }
    }
}
