namespace DesafioPOO.Models
{
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string modelo, string imei, long memoria)
            : base(numero, modelo, imei, memoria)
        {}

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o aplicativo \"{nomeApp}\" no {ToString()} pela Apple App Store");
        }

        public override string ToString() {
            return $"Iphone {Modelo}";
        }
    }
}