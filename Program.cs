using System.ComponentModel;
using DesafioPOO.Models;

// Testes com as classes Nokia e Iphone
Console. WriteLine("Smartphone Nokia:");
Smartphone Nokia = new Nokia(numero: "123456", modelo: "Modelo 1", imei: "1111111111", memoria: 64);
Nokia.Ligar();
Nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");

Console. WriteLine("Smartphone Iphone:");
Smartphone Iphone = new Iphone(numero: "4987", modelo: "Modelo 2", imei: "222222222", memoria: 128);
Iphone.ReceberLigacao();
Iphone.InstalarAplicativo("Telegram");
