using System.Net.WebSockets;
using DesafioPOO.Models;

Console.WriteLine("Nokia:");
Smartphone nokia = new Nokia("87999998888", "Lanterninha", "123456789", 8);
nokia.Ligar();
nokia.InstalarAplicativo("Cobrinha");

Console.WriteLine("\n");

Console.WriteLine("Iphone:");
Smartphone iphone = new Iphone("87988889999", "X", "987654321", 128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Whatsapp");