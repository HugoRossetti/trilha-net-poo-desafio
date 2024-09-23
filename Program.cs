using DesafioPOO.Models;

Smartphone nokia = new Nokia("12345", "Nokia 3310", "ABC123456", 128);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine();

        
Smartphone iphone = new iPhone("67890", "iPhone 14", "XYZ987654", 256);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Instagram");