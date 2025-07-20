namespace DesafioPOO.Models
{
    // Implementado
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {

        }
        // Implementado
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Baixando {nomeApp} da App Store...");
            Console.WriteLine($"Instalando {nomeApp}...");
            Console.WriteLine($"{nomeApp} instalado com sucesso.");
        }
    }
}