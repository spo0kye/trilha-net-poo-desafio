namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Nokia(string numero, string modelo, string imei, int memoria) : Smartphone(numero, modelo, imei, memoria)
    {
        // TODO: Sobrescrever o método "InstalarAplicativo"

        public override void InstalarAplicativo(string nome)
        {
            Console.WriteLine($"Aplicativo {nome} instalado com sucesso!");
            return;
        }
    }
}