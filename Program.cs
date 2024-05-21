using DesafioPOO.Models;

// Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("Testes com o Nokia: ");
Smartphone nokia = new Nokia(numero: "4343-4343", modelo: "1100", imei: "1236456454540", memoria: 128);

nokia.Ligar();
nokia.InstalarAplicativo("Instagram");

Console.WriteLine("\n");

Console.WriteLine("Testes com o Iphone: ");
Smartphone iphone = new Iphone(numero: "4343-4343", modelo: "15 Pro", imei: "5165115615151651", memoria: 128);

iphone.Ligar();
iphone.InstalarAplicativo("WhatsApp");

