using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Empresa_do_Zoorebas
{
    internal class Caixa
    {
        private double saldo;
        private double lucro;
        private double dinheiro_gasto_com_compra;
        public void Vendeu(double saldo)
        {
            this.saldo += saldo;
            lucro += saldo / 2;
           
        }
        public double getSaldo()
        {
            Console.WriteLine($"Caixa saldo:{saldo}");
            return saldo;
        }
        public void Comprando(double preco)
        {
            this.saldo -= preco;
            dinheiro_gasto_com_compra += preco;
            Console.WriteLine("Voce comprou e seu saldo abaixou: agora voce têm:"+ saldo);

        }
        public void GetLucroTotal()
        {
            Console.WriteLine($"Lucro total é de:{lucro:F2}");
        }
        public void GetGastoTotal()
        {
            Console.WriteLine($"O gasto total com compras de componentes é de: {dinheiro_gasto_com_compra:F2}");
        }
    }
}

