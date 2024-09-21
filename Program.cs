using System.ComponentModel;
using DesafioPOO.Models;



        Smartphone c1 = new Iphone("11999999999", "iPhone 15", "123456789", 500);
        c1.Ligar();
        c1.ReceberLigacao();
        c1.InstalarAplicativo("Tiktok");

        
        Smartphone c2 = new Nokia("11900000000", "Nokia 3", "987654321", 10);
        c2.Ligar();
        c2.ReceberLigacao();
        c2.InstalarAplicativo("");