using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Nokia nokia = new Nokia(numero: "9999-9999", modelo: "Nokia x1", imei: "123213", memoria: 340);
Iphone iphone = new Iphone(numero: "1111-1111", modelo: "IPhone 8", imei: "aedasd1", memoria: 240);

nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("99pop");
Console.WriteLine("---------------------");

iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("99pop");
