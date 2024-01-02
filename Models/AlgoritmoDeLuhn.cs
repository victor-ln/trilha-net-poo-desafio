namespace DesafioPOO.Models
{
    static class AlgoritmoDeLuhn
    {
        public static bool ValidarDigitoDeChecagem(string str)
        {
            int somaDeChecagem = 0;
            var indicePar = true;

            for (int i = str.Length - 2; i >= 0; i--)
            {
                int digitoAtual = (int)char.GetNumericValue(str, i);

                if (indicePar)
                {
                    if (digitoAtual > 4)
                    {
                        somaDeChecagem += digitoAtual * 2 - 9;
                    }
                    else 
                    {
                        somaDeChecagem += digitoAtual * 2;
                    }
                }
                else
                {
                    somaDeChecagem += digitoAtual;
                }
                indicePar = !indicePar;
            }
            int digitoChecagem =  10 - (somaDeChecagem % 10);

            return char.GetNumericValue(str.Last()) == digitoChecagem;
        }
    }
}