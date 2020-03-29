using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _132_Exercicio_heranca_polimorfismo.Entidades
{
    class Produto //super Classe.
    {
        public string Name { get; set; }
        public double Preco { get; set; }

        public Produto()
        {

        }

        public Produto(string name, double preco)
        {
            Name = name;
            Preco = preco;
        }

        public virtual string Tag()
        {
            string etiqueta = Name + " $ " + Convert.ToString(Preco) + "\n";
            return etiqueta;
        }
    }
}
