using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova2_LavaJato
{
    class Lavagem
    {
        public int Id { get; set; }
        public string TipoAutomovel { get; set; }
        public string  NomeCliente { get; set; }
        public string TelefoneCliente { get; set; }
        public DateTime DataLavagem { get; set; }
        public int IdFuncResponsavel { get; set; }
        public string TipoLavagem { get; set; }
        public double Preco { get; set; }

    }
}
