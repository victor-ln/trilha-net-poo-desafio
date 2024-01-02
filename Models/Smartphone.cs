namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public const int Kilobyte = 1024;
        public const int Megabyte = Kilobyte * 1024;
        public const int Gigabyte = Megabyte * 1024;
        public const long Terabyte = Gigabyte * 1024L;
        protected const int QuantidadeDigitosIMEI = 15;

        public string Numero { get; set; }
        protected string Modelo { get; set; }
        protected string IMEI { get; set; }
        protected long Memoria { get; set; }

        public Smartphone(
            string numero,
            string modelo,
            string imei,
            long memoria)
        {
            if (!IMEIValido(imei))
                throw new ArgumentException("IMEI inválido", nameof(imei));

            Numero = numero;
            Modelo = modelo;
            IMEI = imei;
            Memoria = memoria;
        }

        /*
        ** Propriedades do número IMEI:
        *
        * - Todos os telefones celulares e smartphones possuem um exclusivo.
        * - Deve ser composto por quinze dígitos.
        * - Sua validação é verificada pelo algoritmo Luhn.
        */
        private static bool IMEIValido(string imei) {
            if (string.IsNullOrEmpty(imei) || imei.Length != QuantidadeDigitosIMEI)
            {
                return false;
            }

            if (!imei.All(char.IsDigit))
            {
                return false;
            }

            return AlgoritmoDeLuhn.ValidarDigitoDeChecagem(imei);
        }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}