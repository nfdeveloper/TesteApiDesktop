﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteApiDesktop
{
    public class Venda
    {
        public string Loja { get; set; }
        public string Cnpj { get; set; }
        public string Data_Venda { get; set; }
        public string Cod_Produto { get; set; }
        public string Descricao_Produto { get; set; }
        public double Quantidade_Vendida { get; set; }
        public double Valor_Vendido { get; set; }
    }
}
