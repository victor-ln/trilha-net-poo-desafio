using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(
    numero: "+1 (332) 409-0570",
    modelo: "G42",
    imei: "350693149355115",
    memoria: 128L * Smartphone.Gigabyte
);

nokia.InstalarAplicativo("Facebook");
nokia.ReceberLigacao();

Smartphone iphone = new Iphone(
    numero: "+1 (332) 160-3602",
    modelo: "15 Pro Max",
    imei: "353042531036197",
    memoria: Smartphone.Terabyte
);

iphone.InstalarAplicativo("X");
iphone.ReceberLigacao();
