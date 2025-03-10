using scripts;

Ave ave = new Gallina();
Console.WriteLine(ave.nombreComun); // output "Gallina"
ave.hacerSonido(); // output "Canto de gallina"

ave = new Aguila();
Console.WriteLine(ave.nombreComun); // output "Águila"
ave.hacerSonido(); // output "Canto de águila"