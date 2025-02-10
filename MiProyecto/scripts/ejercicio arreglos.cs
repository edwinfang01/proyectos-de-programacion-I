namespace MiProyecto.scripts
{
    internal class EjerciciosArreglos
    {
        static bool EsPrimo(int num)
        {
            if (num <= 1) return false;
            for (int i = 2; i <= Math.Sqrt(num); i++)
                if (num % i == 0) return false;
            return true;
        }
        static void Run(int ejercicio)
        {
            int[] numeros = new int[10];
            Console.WriteLine("Ingrese 10 numeros enteros");
            Console.Write("Numero 1: "); bool result = int.TryParse(Console.ReadLine(), out int num1);
            if (result) numeros[0] = num1;
            Console.Write("Numero 2: "); bool result2 = int.TryParse(Console.ReadLine(), out int num2);
            if (result2) numeros[1] = num2;
            Console.Write("Numero 3: "); bool result3 = int.TryParse(Console.ReadLine(), out int num3);
            if (result3) numeros[2] = num3;
            Console.Write("Numero 4: "); bool result4 = int.TryParse(Console.ReadLine(), out int num4);
            if (result4) numeros[3] = num4;
            Console.Write("Numero 5: "); bool result5 = int.TryParse(Console.ReadLine(), out int num5);
            if (result5) numeros[4] = num5;
            Console.Write("Numero 6: "); bool result6 = int.TryParse(Console.ReadLine(), out int num6);
            if (result6) numeros[5] = num6;
            Console.Write("Numero 7: "); bool result7 = int.TryParse(Console.ReadLine(), out int num7);
            if (result7) numeros[6] = num7;
            Console.Write("Numero 8: "); bool result8 = int.TryParse(Console.ReadLine(), out int num8);
            if (result8) numeros[7] = num8;
            Console.Write("Numero 9: "); bool result9 = int.TryParse(Console.ReadLine(), out int num9);
            if (result9) numeros[8] = num9;
            Console.Write("Numero 10: "); bool result10 = int.TryParse(Console.ReadLine(), out int num10);
            if (result10) numeros[9] = num10;

            switch (ejercicio)
            {
                case 1:
                    int numMayor = 0;
                    foreach (int num in numeros)
                    {
                        if (num > numMayor) numMayor = num;
                    }
                    break;

                case 2:
                    int numMenorPar = 0;
                    foreach (int num in numeros)
                    {
                        if (num < numMenorPar && num%2 == 0) numMenorPar = num;
                    }
                    break;
                case 3:
                    int sumaPares = 0;
                    foreach (int num in numeros)
                    {
                        if (num % 2 == 0) sumaPares += num;
                    }
                    break;
                case 4:
                    int sumaPrimerDigitoPrimo = 0;
                    int primerDigito(int n)
                    {
                        while (n > 9) n /= 10;
                        return n;
                    }
                    foreach (int num in numeros)
                    {
                        if (EsPrimo(primerDigito(num))) sumaPrimerDigitoPrimo++;
                    }
                    Console.WriteLine("La cantidad de números cuyo primer dígito es primo es: " + sumaPrimerDigitoPrimo);
                    break;
                case 5:
                    int posicionPrimoConMayorDigitosPares;
                    int mayorDigitosPares = 0;
                    int digitosPares(int num)
                    {
                        int digitos = 0;
                        while (num > 0)
                        {
                            if ((num % 10) % 2 == 0) digitos++;
                            num /= 10;
                        }
                        return digitos;
                    }
                    foreach (int num in numeros)
                    {
                        if (EsPrimo(num) && digitosPares(num) > mayorDigitosPares)
                        {
                            mayorDigitosPares = digitosPares(num);
                            posicionPrimoConMayorDigitosPares = Array.IndexOf(numeros, num);
                        } 
                    }
                    break;
            }
        }
    }
}