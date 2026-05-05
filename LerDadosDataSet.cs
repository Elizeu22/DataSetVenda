using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using static Ganss.Excel.ExcelMapper;
using Ganss.Excel;
using System.Globalization;
using NPOI.SS.Formula.Functions;

namespace DataSet
{
    public class LerDadosDataSet
    {

        public DateTime DataVenda { get; set; }

        public double ValorTotal { get; set; }

        public string Estado { get; set; }

        public string Vendedor { get; set; }
   
        private string? Caminho { get; } = "../../DataSet-Vendas/dataset_vendas_portugues.xlsx";

       public List<LerDadosDataSet> gravaDataSet = new List<LerDadosDataSet>();


        public List<LerDadosDataSet> LeituraArquivo()
        {
            try
            {
                var mapeamentoExcel = new ExcelMapper(Caminho);
                var dados = mapeamentoExcel.Fetch<LerDadosDataSet>();

                foreach (var item in dados)
                {
                    gravaDataSet.Add( item );
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao ler arquivo: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Processo finalizado.");
            }
            return gravaDataSet;
        }
    }
}
