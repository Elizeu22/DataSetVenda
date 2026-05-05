using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataSet
{
    public class MapeamentoExcel
    {
        public int IDPedido { get; set; }
        public DateTime DataVenda { get; set; }

        public string Cliente { get; set; }
        public string Produto { get; set; }
        public string Categoria { get; set; }
        public int Quantidade { get; set; }
        public double PrecoUnitario { get; set; }
        public double Desconto { get; set; }

        public double ValorTotal { get; set; }
        public double Custo { get; set; }
        public double Lucro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Regiao { get; set; }
        public string Vendedor { get; set; }
        public string CanalVenda { get; set; }

    }
}
