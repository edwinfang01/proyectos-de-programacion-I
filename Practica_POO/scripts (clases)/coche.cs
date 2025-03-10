using System;
using System.Reflection;

namespace clases
{
    internal class Coche(string marca, string modelo)
    {
        private Motor? motor;
        private string marca = marca;
        private string modelo = modelo;

        // precio acumulado de las averias
        private double precio = 0;

        // getter para motor
        public Motor GetMotor()
        {
            if (motor == null)
            {
                motor = new Motor(100);
            }
            return motor;
        }

        // getter para marca
        public string GetMarca()
        {
            return marca;
        }

        // getter para modelo
        public string GetModelo()
        {
            return modelo;
        }

        // getter para precio
        public double GetPrecio()
        {
            return precio;
        }

        public void acumularAveria(double precio)
        {
            this.precio += precio;
        }

        public void MostrarAtributos()
        {
            Type tipo = this.GetType();
            Console.WriteLine($"Atributos de la clase {tipo.Name}:");

            // Obtener todas las propiedades públicas
            foreach (PropertyInfo prop in tipo.GetProperties(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance))
            {
                Console.WriteLine($"{prop.Name}: {prop.GetValue(this)}");
            }

            // Obtener todos los campos (incluyendo privados)
            foreach (FieldInfo field in tipo.GetFields(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance))
            {
                if (field.Name != "motor")
                {
                    Console.WriteLine($"{field.Name}: {field.GetValue(this)}");
                }
                else
                {
                    Motor motor = GetMotor();
                    Console.WriteLine($"Motor: {motor.GetPotencia()} CV, {motor.GetLitrosDeAceite()} litros de aceite");
                }
            }
        }
    }

    
}