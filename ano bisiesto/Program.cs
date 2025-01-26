// See https://aka.ms/new-console-template for more information
using Microsoft.VisualBasic;

Console.WriteLine("Hello, World!");

void bisiesto(int leapYear){
    if ( (leapYear % 4 == 0 && leapYear % 100 != 0) || (leapYear % 400 == 0) ) {
        Console.WriteLine("es bisiesto");
        return;
    }
    Console.WriteLine("No es bisiesto");
}

bisiesto(2016);