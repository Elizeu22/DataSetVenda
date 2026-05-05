
using DataSet;


LerDadosDataSet lerDadosDataSet = new LerDadosDataSet();
FiltroPorRegiaoPeriodo filtroPorRegiaoPeriodo = new FiltroPorRegiaoPeriodo();

lerDadosDataSet.LeituraArquivo();

filtroPorRegiaoPeriodo.FitrarDados();

