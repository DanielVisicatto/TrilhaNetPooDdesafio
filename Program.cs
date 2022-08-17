using System.Reflection;
using System;
using TrilhaNetPooDdesafio.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Iphone iphone = new("(XX) 9XXXX - XXXX", "iPhone 13 Pro Max", "987654321321", 512) ;
Nokia nokia = new("(XX) 9XXXX - XXXX", "Nokia C01 PLus", "123456789789", 256);

iphone.Ligar();
nokia.Ligar();
Console.WriteLine("===============");
iphone.ReceberLigacao();
nokia.ReceberLigacao();
Console.WriteLine("===============");
iphone.InstalarAplicativo("Spotify");
nokia.InstalarAplicativo("Waze");
Console.WriteLine("===============");
Console.WriteLine();
