namespace DesafioPOO.Models
{
    // Herança da classe "Smartphone"
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
            // Construtor da classe base (Smartphone) é chamado com os parâmetros necessários.
        }

        // Método "InstalarAplicativo"
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o aplicativo {nomeApp} em um Nokia...");
        }
    }
}
