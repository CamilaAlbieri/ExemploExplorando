using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploExplorando.Models
{
    public class Venda
    {

        public Venda(int Id, string Produto, decimal Preco)
        {
            this.Id = Id;
            this.Produto = Produto;
            this.Preco = Preco;
        }
                 
        
        public int Id { get; set; }
        public string Produto { get; set; }
        public decimal Preco { get; set; }

    }
}