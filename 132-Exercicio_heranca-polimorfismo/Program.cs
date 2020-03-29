using _132_Exercicio_heranca_polimorfismo.Entidades;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _132_Exercicio_heranca_polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Produto> lista = new List<Produto>(); 

            Console.Write("Insira a quantidade de produtos: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <=n; i++ )
            {
                Console.WriteLine("I para Importado / C para comum / U para Usado");
                char opc = char.Parse(Console.ReadLine());

                Console.WriteLine($"{i}º Produto");
                Console.Write($"nome do {i} produto: ");
                string nome = Console.ReadLine();
                Console.Write($"Preço do {i} produto: ");
                double preco = double.Parse(Console.ReadLine());

                if (opc == 'i')
                {
                    Console.Write($"Custo de Importação do {i} produto: ");
                    double custo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    

                    lista.Add(new ProdutoImportado(nome, preco, custo));

                }
                else if (opc == 'u')
                {
                    Console.Write($"Data de fabrica do  {i} produto: ");
                    DateTime dtfabrica = DateTime.Parse(Console.ReadLine());
                    

                    lista.Add(new ProdutoUsado(nome, preco, dtfabrica));
                }
                else
                {
                  
                    lista.Add(new Produto(nome, preco));
                }

            }
            Console.WriteLine("\n\tDados Levantados....");

            foreach (Produto prod in lista)
            {
                Console.WriteLine(prod.Tag().ToString());
            }

        }
    }
}
