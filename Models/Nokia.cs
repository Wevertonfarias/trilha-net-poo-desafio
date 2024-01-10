namespace DesafioPOO.Models
{
    
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string imie, string modelo, int memoria) : base(numero, imie, modelo, memoria)
        {

        }
        

        public override void InstalarAplicativo (string nomeApp) 
        {
            Console.WriteLine($"Instalando aplicativos {nomeApp} no Nokia");
        }
    }
}