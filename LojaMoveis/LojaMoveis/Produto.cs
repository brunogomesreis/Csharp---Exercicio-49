using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace LojaMoveis
{
    class Produto
    {
        int codigo;
        String descricao;
        double preco;

        public Produto(int codigo, String descricao, double preco)
        {
            this.codigo = codigo;
            this.preco = preco;
            this.descricao = descricao;
        }
        public double getPreco()
        {
            return this.preco;
        }

        public int getCodigo()
        {
            return this.codigo;
        }

        public override string ToString()
        {
            return codigo.ToString() + ", " + descricao + ", " + preco.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
