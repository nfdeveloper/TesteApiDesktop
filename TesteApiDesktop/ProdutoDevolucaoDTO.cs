using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteApiDesktop
{
    public class ProdutoDevolucaoDTO
    {
        public String Ean { get; set; }
        public String Cod_Fornecedor { get; set; }
        public String Descricao { get; set; }
        public double Quantidade { get; set; }
        public double Valor { get; set; }
    }
}
