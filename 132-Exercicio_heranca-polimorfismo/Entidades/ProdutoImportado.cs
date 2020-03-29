using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _132_Exercicio_heranca_polimorfismo.Entidades
{
    class ProdutoImportado : Produto
    {
        public double Custo { get; set; }

        public ProdutoImportado()
        {

        }

        public ProdutoImportado(string name, double preco, double custo)
            : base(name, preco)
        {
            Custo = custo;
        }

        public override string Tag() //metodo com polimorfismo. OVERRIDE
        {
            return base.Tag() + " Custo de Importação: " + Convert.ToString(Custo);
        }


    }
}
