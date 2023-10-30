namespace DesafioPOO.Models
{
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {

        }
         public override void InstalarAplicativo(string nome)
        {
            // Implemente o código para instalar o aplicativo no iPhone aqui
            Console.WriteLine($"Instalando aplicativo {nome} no Nokia.");
        }
    }
}
