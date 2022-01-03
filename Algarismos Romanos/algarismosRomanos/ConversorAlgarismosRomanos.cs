namespace algarismosRomanos;

public class ConversorAlgarismosRomanos
{
    private static Dictionary<string, int> tabelaAlgarismos = new Dictionary<string, int>
    {
        {"I", 1},
        {"V", 5},
        {"X", 10},
        {"L", 50},
        {"C", 100},
        {"D", 500},
        {"M", 1000}
    };
    public int Converte(string algarismoRomano)
    {
       var ultimoVizinhoDireita = 0;
       var soma = 0;
       var algarismos = algarismoRomano.ToCharArray().Reverse();
       foreach (var algarismo in algarismos)
       {
           int atual = tabelaAlgarismos[algarismo.ToString()];
           int multiplicador = 1;
           if (atual < ultimoVizinhoDireita)
            multiplicador = -1;

           soma += atual * multiplicador;
           ultimoVizinhoDireita = atual;
       }
       return soma;
    }
}
