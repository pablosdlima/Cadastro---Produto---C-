using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _132_Exercicio_heranca_polimorfismo.Entidades
{
    class ProdutoUsado : Produto
    {
        public DateTime Fabricacao { get; set; }

        public ProdutoUsado()
        {

        }

        public ProdutoUsado(string name, double preco, DateTime fabricacao)
            : base(name, preco)
        {
            Fabricacao = fabricacao;
        }

        public override string Tag()
        {
            string remanfaturado = " (Usado) " + base.Tag() + " Manufaturado: " + Fabricacao;
            return remanfaturado;
        }
    }
}
