namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string modelo,string imei, string memoria) : base(numero)
        {
            Numero = numero;
          
        }   
       public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine("Instalando aplicativo");
        }
        // TODO: Sobrescrever o método "InstalarAplicativo"
    }
}