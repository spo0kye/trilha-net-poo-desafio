using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Teste Nokia:");
Nokia nokia = new Nokia(numero: "52332", modelo: "Nokia 512", imei: "00010", memoria: 256);
nokia.Ligar();
nokia.InstalarAplicativo("AppStore");
Console.WriteLine(nokia.Numero);

Console.WriteLine("\n");

Console.WriteLine("Teste Iphone:");
Iphone iphone = new Iphone(numero: "487954", modelo: "Iphone 7", imei: "11121", memoria: 256);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Whatsapp");
Console.WriteLine(iphone.Numero);