using System;
using System.Collections.Generic;
using System.Text;

namespace LojaMoveis
{
    class ItemPedido
    {
        int quantidade;
        double porcentagemDesconto;
        Produto produto;

        public ItemPedido(int quantidade, double porcentagemDesconto, Produto produto)
        {
            this.produto = produto;
            this.porcentagemDesconto = porcentagemDesconto;
            this.quantidade = quantidade;
        }

        public double subTotal()
        {
            return this.quantidade * produto.getPreco();
        }
    }
}
