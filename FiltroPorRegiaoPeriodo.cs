using NPOI.Util.Optional;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataSet
{
    public class FiltroPorRegiaoPeriodo
    {
        private DateTime DataInicial { get; } = new DateTime(2025,03,01);
        private DateTime DataFinal { get; } = new DateTime(2025,05,01);



        public void FitrarDados() {

            try
            {
                LerDadosDataSet lerDadosDataSet = new LerDadosDataSet();
                var dados = lerDadosDataSet.LeituraArquivo();

                var result = dados.Where(x => x.DataVenda > DataInicial
                && x.DataVenda < DataFinal && x.Estado.Contains("SP"))
                    .GroupBy(x => x.Vendedor)
                    .Select(k => new
                    {
                        IDPedido = k.Key,
                        Quantidade = k.Count(),
                        ValorTotal = k.Sum(x => x.ValorTotal),
                        Media = k.Average(x => x.ValorTotal),
                        Maximo = k.Max(x => x.ValorTotal)
                    })
                    .OrderByDescending(x => x.Quantidade)
                    .ToList();
                    

                Console.WriteLine("Resultado da pesquisa:");

                foreach (var item in result)
                {
                    Console.WriteLine($"Nome Vendedor:{item.IDPedido}," +
                        $"Quantidade:{item.Quantidade}," +
                        $"Valor Total:{item.ValorTotal:F2}," +
                        $"Media:{item.Media:F2}," +
                        $"Maximo:{item.Maximo:F2},"
                        );
                }


                Console.WriteLine($"Total:{result.Count()}");
            }
            catch (Exception ex) 
            {
                Console.WriteLine(ex.ToString());
            }
            finally 
            {
                Console.WriteLine("Filtro realizado com sucesso.");
            }



        }
    }
}
