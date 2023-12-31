﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empresa_do_Zoorebas
{
    internal class Produto
    {
        private string nome;
        private double preco;
        private int quantidadedeprodutos;
        private double precototalemestoque;
        Caixa caixa = new Caixa();

        public Produto()
        {

        }
        public Produto(string nome, float preco, int quantidadedeprodutos)
        {
            this.nome = nome;
            this.preco = preco;
            this.quantidadedeprodutos = quantidadedeprodutos;
            AtualizaPreço();
        }
        public void SetPreco(double preco)
        {
            this.preco = preco;
        }
        public double GetPreco()
        {
            return preco;
        }

        public double GetPrecoTotal()
        {
            return precototalemestoque;
        }
        public void SetNome(string nomedoproduto)
        {
            this.nome = nomedoproduto;
        }
        public string GetNome()
        {
            return nome;
        }

        private void ComprarMais(int quantia)
        {
            this.quantidadedeprodutos += quantia;
        }
        public int GetQuantia()
        {
            return quantidadedeprodutos;
        }
        public void removeitem(int quantidade)
        {
            this.quantidadedeprodutos -= quantidade;
        }
        public void Vendeu(Caixa caixa, int quantidade)
        {
            if (quantidade <= quantidadedeprodutos)
            {
                this.caixa = caixa;
                this.quantidadedeprodutos -= quantidade;
                
                caixa.Vendeu(quantidade * preco);
                AtualizaPreço();
            }
            else
            {
                Console.WriteLine($"Não há esta quantidade:{quantidade} de {this.nome}");
            }
        }
        private void AtualizaPreço()
        {
            precototalemestoque = quantidadedeprodutos * preco;
        }
        public void AlmoxarifadoComprarDaEmpresa(int quantidade)

        {

            double valorquecompra = preco / 2;
            valorquecompra = valorquecompra * quantidade;
            if(caixa.getSaldo() >= valorquecompra)
            {
               ComprarMais(quantidade);
                caixa.Comprando(valorquecompra);
                AtualizaPreço();
            }
            Console.WriteLine("O caixa da loja esta insuficiente para tal compra");


        }


    }
}
