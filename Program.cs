using System.Diagnostics.CodeAnalysis;
using System.Reflection.Metadata;

namespace Empresa_do_Zoorebas
{
    internal class Program
    {

        public static Caixa caixa = new Caixa();
        static List<Produto> listdeprodutos = new();
        static double valortotal;
        public int menuPrincipal;

        static void Main(string[] args)
        {
            int menuPrincipal;
            /*Caixa caixa = new Caixa();
            Console.WriteLine("Seja bem vindo a ZorebasCompanny");
            Console.WriteLine("Escolha alguma dessas opções:");
            Console.WriteLine("op1");
            Console.WriteLine("op2");
            Console.WriteLine("op3");
            menuPrincipal = int.Parse(Console.ReadLine());*/
            while (true)
            {
                Console.WriteLine("Seja bem vindo a ZorebasCompanny");
                Console.WriteLine("Escolha alguma dessas opções:");
                Console.WriteLine("1=> Cadastrar um novo protudo <=1");
                Console.WriteLine("2=> Ver o valor do caixa <=2");
                Console.WriteLine("3=> Cadastrar um novo protudo <=3");
                menuPrincipal = int.Parse(Console.ReadLine());
                switch (menuPrincipal)
                {
                    case 1:
                        int menuCadastro;
                        Console.WriteLine("Escolha alguma dessas opções para os componentes você quer cadastrar");
                        Console.WriteLine("1=> Diodo <=1");
                        Console.WriteLine("2=> Resistor <=2");
                        Console.WriteLine("3=> Botão <=3");
                        Console.WriteLine("4=> Capasitor <=4");
                        Console.WriteLine("5=> Trimpot <=5");
                        menuCadastro = int.Parse(Console.ReadLine());

                        switch (menuCadastro)
                        {
                            case 1:

                                Console.WriteLine("Digite a quantidade de diodos que você quer cadastrar");
                                int quantidadeDiodo = int.Parse(Console.ReadLine());
                                Console.WriteLine("Digite o preço do diodo");
                                float precoDiodo = float.Parse(Console.ReadLine());
                                Produto diodo = new("diodo", precoDiodo, quantidadeDiodo);
                                AddProdutoNovoNaLista(diodo);

                                break;

                            case 2:

                                Console.WriteLine("Digite a quantidade de resistores que você quer cadastrar");
                                int quantidadeResistor = int.Parse(Console.ReadLine()); ;
                                Console.WriteLine("Digite o preço do resistor");
                                float precoResistor = float.Parse(Console.ReadLine()); ;
                                Produto resistores = new("Resistores", precoResistor, quantidadeResistor);
                                AddProdutoNovoNaLista(resistores);

                                break;

                            case 3:

                                Console.WriteLine("Digite a quantidade de botão que você quer cadastrar");
                                int quantidadeBotao = int.Parse(Console.ReadLine()); ;
                                Console.WriteLine("Digite o preço do botão");
                                float precoBotao = float.Parse(Console.ReadLine()); ;
                                Produto botao = new("botao", precoBotao, quantidadeBotao);
                                AddProdutoNovoNaLista(botao);

                                break;

                            case 4:

                                Console.WriteLine("Digite a quantidade de capacitor que você quer cadastrar");
                                int quantidadeCapacitor = int.Parse(Console.ReadLine()); ;
                                Console.WriteLine("Digite o preço do capacitor");
                                float precoCapacitor = float.Parse(Console.ReadLine()); ;
                                Produto capacitor = new("capacitor", precoCapacitor, quantidadeCapacitor);
                                AddProdutoNovoNaLista(capacitor);

                                break;

                            case 5:

                                Console.WriteLine("Digite a quantidade de trimpot que você quer cadastrar");
                                int quantidadeTrimpot = int.Parse(Console.ReadLine()); ;
                                Console.WriteLine("Digite o preço do trimpot");
                                float precoTrimpot = float.Parse(Console.ReadLine()); ;
                                Produto trimpot = new("trimpot", precoTrimpot, quantidadeTrimpot);
                                AddProdutoNovoNaLista(trimpot);

                                break;
                        }

                        Console.Clear();

                        break;

                    case 2:
                        ValorTotal();
                        Console.ReadKey();
                        Console.Clear();

                        break;

                    case 3:
                        
                        Console.Clear();

                        break;
                }
            }

            /*
                      
            ValorTotal();
            trimpot.Vendeu(caixa, 10);
            trimpot.AlmoxarifadoComprarDaEmpresa(10);
            ValorTotal();
            caixa.getSaldo();
            
             */
        }

        public static void ValorTotal()
        {
            valortotal = 0;
            foreach (Produto valor in listdeprodutos) 
            { 
                valortotal += valor.GetPrecoTotal();
            }
            Console.WriteLine($"Valor total em estoque que a empresa ZorebasCompanny tem é de: {valortotal}$ Reais");
        }
        public static void AddProdutoNovoNaLista(Produto produto)
        { 
            listdeprodutos.Add(produto);
            Console.WriteLine($"{produto.GetNome()}, adicionado a lista");
            Console.WriteLine($"o {produto.GetNome()} contém: {produto.GetQuantia()} unidades, e o preço dele é: {produto.GetPreco():F2} para cada unidade ");
        }
    }
}