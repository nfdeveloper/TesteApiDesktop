using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteApiDesktop
{
    public class DevolucaoDTO
    {
        public Loja Loja { get; set; }
        public List<NfDevolucaoDTO> Devolucoes { get; set; }
    }
}
