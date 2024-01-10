using DesafioPOO.Models;


Console.WriteLine("Smartphon Nokia: ");
Smartphone nokia = new Nokia(modelo: "modelo c53", numero: "88210974", imie: "11111",memoria: 128 );
nokia.Ligar();
nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine("\n");

Console.WriteLine("Smartphon Iphone:");
Smartphone iphone = new Iphone(modelo: "iphone 15", numero: "85158967", imie: "15639",memoria: 128 );
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Instagram");