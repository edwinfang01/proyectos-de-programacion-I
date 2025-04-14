// Archivo: Program.cs
using System;
using System.Collections.Generic;

namespace GestorBiblioteca
{
    abstract class Persona
    {
        public string Nombre { get; set; }
        public string Email { get; set; }

        protected Persona(string nombre, string email)
        {
            Nombre = nombre;
            Email = email;
        }
    }

    class Usuario : Persona
    {
        public int ID { get; set; }
        public List<Prestamo> HistorialPrestamos { get; set; } = new List<Prestamo>();

        public Usuario(int id, string nombre, string email) : base(nombre, email)
        {
            ID = id;
        }
    }

    class Empleado : Persona
    {
        public int IDEmpleado { get; set; }
        public string Cargo { get; set; }

        public Empleado(int idEmpleado, string nombre, string email, string cargo) : base(nombre, email)
        {
            IDEmpleado = idEmpleado;
            Cargo = cargo;
        }
    }

    class Libro
    {
        public string ISBN { get; set; }
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public bool Disponible { get; set; } = true;

        public Libro(string isbn, string titulo, string autor)
        {
            ISBN = isbn;
            Titulo = titulo;
            Autor = autor;
        }
    }

    class Prestamo
    {
        public Libro Libro { get; set; }
        public Usuario Usuario { get; set; }
        public DateTime FechaPrestamo { get; set; }
        public DateTime FechaDevolucion { get; set; }
        public bool Devuelto { get; set; } = false;

        public Prestamo(Libro libro, Usuario usuario)
        {
            Libro = libro;
            Usuario = usuario;
            FechaPrestamo = DateTime.Now;
            FechaDevolucion = FechaPrestamo.AddDays(14);
        }

        public void MarcarDevuelto()
        {
            Devuelto = true;
            Libro.Disponible = true;
        }
    }

    class Programa
    {
        static List<Usuario> usuarios = new List<Usuario>();
        static List<Libro> libros = new List<Libro>();
        static List<Prestamo> prestamos = new List<Prestamo>();

        static void Main()
        {
            while (true)
            {
                Console.WriteLine("\n--- Gestor de Biblioteca ---");
                Console.WriteLine("1. Registrar Usuario");
                Console.WriteLine("2. Agregar Libro");
                Console.WriteLine("3. Prestar Libro");
                Console.WriteLine("4. Devolver Libro");
                Console.WriteLine("5. Salir");
                Console.Write("Seleccione una opción: ");
                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1": RegistrarUsuario(); break;
                    case "2": AgregarLibro(); break;
                    case "3": PrestarLibro(); break;
                    case "4": DevolverLibro(); break;
                    case "5": return;
                    default: Console.WriteLine("Opción inválida."); break;
                }
            }
        }

        static void RegistrarUsuario()
        {
            Console.Write("Nombre: ");
            string nombre = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            int id = usuarios.Count + 1;
            usuarios.Add(new Usuario(id, nombre, email));
            Console.WriteLine("Usuario registrado con ID: " + id);
        }

        static void AgregarLibro()
        {
            Console.Write("ISBN: ");
            string isbn = Console.ReadLine();
            Console.Write("Título: ");
            string titulo = Console.ReadLine();
            Console.Write("Autor: ");
            string autor = Console.ReadLine();
            libros.Add(new Libro(isbn, titulo, autor));
            Console.WriteLine("Libro agregado correctamente.");
        }

        static void PrestarLibro()
        {
            Console.Write("ID Usuario: ");
            int idUsuario = int.Parse(Console.ReadLine());
            Console.Write("ISBN del libro: ");
            string isbn = Console.ReadLine();

            Usuario usuario = usuarios.Find(u => u.ID == idUsuario);
            Libro libro = libros.Find(l => l.ISBN == isbn && l.Disponible);

            if (usuario != null && libro != null)
            {
                Prestamo p = new Prestamo(libro, usuario);
                prestamos.Add(p);
                usuario.HistorialPrestamos.Add(p);
                libro.Disponible = false;
                Console.WriteLine("Libro prestado hasta: " + p.FechaDevolucion.ToShortDateString());
            }
            else
            {
                Console.WriteLine("Usuario o libro no válido o no disponible.");
            }
        }

        static void DevolverLibro()
        {
            Console.Write("ISBN del libro: ");
            string isbn = Console.ReadLine();
            Prestamo p = prestamos.Find(pr => pr.Libro.ISBN == isbn && !pr.Devuelto);

            if (p != null)
            {
                p.MarcarDevuelto();
                Console.WriteLine("Libro devuelto correctamente.");
            }
            else
            {
                Console.WriteLine("No se encontró un préstamo activo para ese libro.");
            }
        }
    }
}
