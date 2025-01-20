// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

/*
1.    Leer un número entero de dos dígitos y determinar a cuánto es igual la suma de sus dígitos.

2.    Leer un número entero de dos dígitos y determinar si es primo y además si es negativo.

3.    Leer un número entero de dos dígitos y determinar si sus dos dígitos son primos.

4.    Leer dos números enteros de dos dígitos y determinar si la suma de los dos números origina un número par.

5.    Leer un número entero de tres dígitos y determinar en qué posición está el mayor dígito.

6.    Leer un número entero de tres dígitos y determinar si algún dígito es múltiplo de los otros.

7.    Leer tres números enteros y determinar cuál es el mayor. Usar solamente dos variables.

8.    Leer un número entero de cinco dígitos y determinar si es un número Capicúa. 

    Ej. 15651, 59895. 

9.    Leer un número entero de cuatro dígitos y determinar si el segundo dígito es igual al penúltimo.

10. Leer dos números enteros y si la diferencia entre los dos es menor o igual a 10 entonces mostrar en pantalla todos los enteros comprendidos entre el menor y el mayor de los números leídos. 
*/


void ejercicios(int ejercicio) {

    // ejercicio 1

    if (ejercicio == 1) {
        Console.Write("Ejercicio 1: Ingrese un número entero de dos dígitos: ");
        int num1 = int.Parse(Console.ReadLine());
        int suma = Math.Abs(num1 / 10) + Math.Abs(num1 % 10);
        Console.WriteLine($"La suma de los dígitos es: {suma}");
    }

    // ejercicio 2

    if (ejercicio == 2){
        Console.WriteLine("Ejercicio 2: Ingrese un número entero de dos dígitos:");
        int num2 = int.Parse(Console.ReadLine());
        bool esPrimo = EsPrimo(Math.Abs(num2));
        bool esNegativo = num2 < 0;
        Console.WriteLine($"¿Es primo? {esPrimo}, ¿Es negativo? {esNegativo}");
    }

    // ejercicio 3

    if (ejercicio == 3){
        Console.WriteLine("Ejercicio 3: Ingrese un número entero de dos dígitos:");
        int num3 = int.Parse(Console.ReadLine());
        int digito1 = Math.Abs(num3 / 10), digito2 = Math.Abs(num3 % 10);
        Console.WriteLine($"¿Los dígitos son primos? {EsPrimo(digito1) && EsPrimo(digito2)}");
    }

    // ejercicio 4

    if (ejercicio == 4){
        Console.WriteLine("Ejercicio 4: Ingrese dos números enteros de dos dígitos:");
        int num4a = int.Parse(Console.ReadLine());
        int num4b = int.Parse(Console.ReadLine());
        int suma4 = num4a + num4b;
        Console.WriteLine($"¿La suma es par? {suma4 % 2 == 0}");
    }

    // ejercicio 5

    if (ejercicio == 5){
        Console.WriteLine("Ejercicio 5: Ingrese un número entero de tres dígitos:");
        int num5 = int.Parse(Console.ReadLine());
        int[] digitos5 = { Math.Abs(num5 / 100), Math.Abs((num5 / 10) % 10), Math.Abs(num5 % 10) };
        int posMax = Array.IndexOf(digitos5, Math.Max(Math.Max(digitos5[0], digitos5[1]), digitos5[2])) + 1;
        Console.WriteLine($"La posición del mayor dígito es: {posMax}");
    }

    // ejercicio 6

    if (ejercicio == 6) {
        Console.WriteLine("Ejercicio 6: Ingrese un número entero de tres dígitos:");
        int num6 = int.Parse(Console.ReadLine());
        int d1 = Math.Abs(num6 / 100), d2 = Math.Abs((num6 / 10) % 10), d3 = Math.Abs(num6 % 10);
        bool esMultiplo = (d1 != 0 && d2 != 0 && d3 != 0) && 
                          (d1 % d2 == 0 || d2 % d1 == 0 || d3 % d1 == 0 || d3 % d2 == 0);
        Console.WriteLine($"¿Algún dígito es múltiplo de los otros? {esMultiplo}");
    }

    // ejercicio 7

    if (ejercicio == 7) {
        Console.WriteLine("Ejercicio 7: Ingrese tres números enteros:");
        int num7a = int.Parse(Console.ReadLine());
        int num7b = int.Parse(Console.ReadLine());
        int num7c = int.Parse(Console.ReadLine());
        int mayor = Math.Max(Math.Max(num7a, num7b), num7c);
        Console.WriteLine($"El mayor número es: {mayor}");
    }

    // ejercicio 8

    if (ejercicio == 8) {
        Console.WriteLine("Ejercicio 8: Ingrese un número entero de cinco dígitos:");
        int num8 = int.Parse(Console.ReadLine());
        string num8Str = num8.ToString();
        bool esCapicua = num8Str[0] == num8Str[4] && num8Str[1] == num8Str[3]; // el tercero es el numero del medio, no cambia
        Console.WriteLine($"¿Es un número capicúa? {esCapicua}");
    }

    // ejercicio 9

    if (ejercicio == 9){
        Console.WriteLine("Ejercicio 9: Ingrese un número entero de cuatro dígitos:");
        int num9 = int.Parse(Console.ReadLine());
        string strNum9 = Math.Abs(num9).ToString();
        Console.WriteLine($"¿El segundo dígito es igual al penúltimo? {strNum9[1] == strNum9[^2]}");
    }

    // ejercicio 10

    if (ejercicio == 10){
        Console.WriteLine("Ejercicio 10: Ingrese dos números enteros:");
        int num10a = int.Parse(Console.ReadLine());
        int num10b = int.Parse(Console.ReadLine());
        int diferencia = Math.Abs(num10a - num10b);
        if (diferencia <= 10)
        {
            Console.WriteLine("Números entre el menor y el mayor:");
            for (int i = Math.Min(num10a, num10b); i <= Math.Max(num10a, num10b); i++)
                Console.WriteLine(i);
        }
        else
        {
            Console.WriteLine("La diferencia es mayor a 10.");
        }
    }

}   

bool EsPrimo(int numero) {
    if (numero <= 1) return false;
    for (int i = 2; i <= Math.Sqrt(numero); i++)
        if (numero % i == 0) return false;
    return true;
}


ejercicios(2);