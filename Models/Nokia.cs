namespace DesafioPOO.Models
{
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string modelo, string imei, long memoria)
            : base(numero, modelo, imei, memoria)
        {}

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o aplicativo \"{nomeApp}\" no {ToString()} pela Google Play Store");
        }

        public override string ToString() {
            return $"Nokia {Modelo}";
        }
    }
}