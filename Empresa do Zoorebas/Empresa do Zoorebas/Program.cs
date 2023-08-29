using System.Reflection.Metadata;

namespace Empresa_do_Zoorebas
{
    internal class Program
    {

        public static Caixa caixa = new Caixa();
        static List<Produto> listdeprodutos = new();
        static double valortotal;

        static void Main(string[] args)
        {
            Caixa caixa = new Caixa();
            Console.WriteLine("ZorebasCompanny");
            Produto resistores = new("Resistores", 0.20f, 10);
            Produto diodo = new("diodo", 0.25f, 10);
            Produto botao = new("botao", 0.10f, 10);
            Produto capacitor = new("capacitor", 0.20f, 10);
            Produto trimpot = new("trimpot", 0.30f, 10);
            AddProdutoNovoNaLista(diodo);
            AddProdutoNovoNaLista(resistores);
            AddProdutoNovoNaLista(botao);
            AddProdutoNovoNaLista(capacitor);
            AddProdutoNovoNaLista(trimpot);
            ValorTotal();
            trimpot.Vendeu(caixa, 10);
            trimpot.AlmoxarifadoComprarDaEmpresa(10);
            ValorTotal();
            caixa.getSaldo();

        }
        
        public static void ValorTotal()
        {
            valortotal = 0;
            foreach (Produto valor in listdeprodutos) { valortotal += valor.GetPrecoTotal(); }
            Console.WriteLine($"Valor total em estoque que a empresa ZorebasCompanny tem é de: {valortotal}");
        }
        public static void AddProdutoNovoNaLista(Produto produto)
        { 
            listdeprodutos.Add(produto);
            Console.WriteLine($"{produto.GetNome()}, adicionado a lista");
            Console.WriteLine($"o {produto.GetNome()} contém: {produto.GetQuantia()} unidades, e o preço dele é: {produto.GetPreco():F2} para cada unidade ");
        }
    }
}