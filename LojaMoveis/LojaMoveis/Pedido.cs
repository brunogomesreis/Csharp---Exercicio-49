using System;
using System.Collections.Generic;
using System.Text;

namespace LojaMoveis
{
    class Pedido
    {
        int codigo;
        DateTime data;
        List<ItemPedido> itemPedidos = new List<ItemPedido>();

        public Pedido(int codigo, DateTime data, List<ItemPedido> itemPedidos)
        {
            this.codigo = codigo;
            this.data = data;
            this.itemPedidos = itemPedidos;
        }

        public double valorTotal()
        {
            double precototal = 0;
            foreach (ItemPedido item in itemPedidos) {
                precototal = precototal + item.subTotal();
            }
            return precototal;
        }
    }
}
