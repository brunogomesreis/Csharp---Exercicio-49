using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;


namespace LojaMoveis
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Produto> produtos = new List<Produto>();
            List<Pedido> pedidos = new List<Pedido>();
            List<ItemPedido> itemPedidos = new List<ItemPedido>();

            Console.WriteLine("Menu de Opções:");
            Console.WriteLine("1- Listar produto ordenadamente");
            Console.WriteLine("2- Cadastrar produto");
            Console.WriteLine("3- Cadastrar pedido");
            Console.WriteLine("4- Mostrar dados de um pedido");
            Console.WriteLine("5- Sair");
            int opcao = int.Parse(Console.ReadLine());

            int codigoproduto, codigopedido, dia, mes, ano, qtd, qtditens;
            double desc;

            while (opcao != 5)
            {
                switch (opcao)
                {
                    case 1:
                        Console.WriteLine("LISTA DE PRODUTOS:");
                        foreach (Produto produto in produtos.OrderBy(o => o.getPreco()).ToList())
                        {
                            Console.WriteLine(produto);
                        }
                        opcao = 6;
                        Console.ReadLine();
                        break;
                    case 2:
                        Console.WriteLine("Digite os dados do produto:");
                        Console.Write("Código: ");
                        codigoproduto = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        Console.Write("Descrição: ");
                        String descproduto = Console.ReadLine();
                        Console.Write("Preço: ");
                        double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                        produtos.Add(new Produto(codigoproduto, descproduto, preco));
                        opcao = 6;
                        Console.ReadLine();
                        break;

                    case 3:
                        Console.WriteLine("Digite os dados do pedido:");
                        Console.Write("Código: ");
                        codigopedido = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        Console.Write("Dia: ");
                        dia = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        Console.Write("Mês: ");
                        mes = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        Console.Write("Ano: ");
                        ano = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        Console.Write("Quantos itens tem o pedido? ");
                        qtditens = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                        List<ItemPedido> itens = new List<ItemPedido>();

                        for (int i = 1; i <= qtditens; i++)
                        {
                            Console.WriteLine(" Digite os dados do " + i + "° item:");
                            Console.Write("Produto (código): ");
                            codigoproduto = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                            Console.Write("Quantidade: ");
                            qtd = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                            Console.Write("Porcentagem de Desconto: ");
                            desc = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                            itens.Add(new ItemPedido(qtd, desc, produtos[produtos.FindIndex(a => a.getCodigo() == codigoproduto)]));

                        }

                        pedidos.Add(new Pedido(codigopedido, new DateTime(ano, mes, dia), itens));

                        opcao = 6;
                        Console.ReadLine();
                        break;

                    case 4:
                        Console.Write("Digite o código do pedido: ");
                        codigopedido = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        Console.WriteLine(pedidos[produtos.FindIndex(a => a.getCodigo() == codigopedido)].ToString());

                        opcao = 6;
                        Console.ReadLine();

                        break;
                    case 5:
                        break;
                    default:
                        Console.WriteLine("Menu de Opções:");
                        Console.WriteLine("1- Listar produto ordenadamente");
                        Console.WriteLine("2- Cadastrar produto");
                        Console.WriteLine("3- Cadastrar pedido");
                        Console.WriteLine("4- Mostrar dados de um pedido");
                        Console.WriteLine("5- Sair");
                        opcao = int.Parse(Console.ReadLine());

                        break;
                }
            }
        }
    }
}
