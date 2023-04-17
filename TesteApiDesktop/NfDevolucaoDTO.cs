using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteApiDesktop
{
    public class NfDevolucaoDTO
    {
        public String Nf { get; set; }
        public String Emissao { get; set; }
        public List<ProdutoDevolucaoDTO> Produtos { get; set; }
    }
}
