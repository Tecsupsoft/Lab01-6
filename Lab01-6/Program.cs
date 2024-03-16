﻿using Lab01_6;
using System;

class Program
{
    static void Main(string[] args)
    {
        Grifo grifo = new Grifo(); // Creamos una instancia de la clase Grifo

        // Ciclo para mostrar el menú hasta que el usuario decida salir
        bool salir = false;
        while (!salir)
        {
            // Mostrar el menú de opciones
            Console.WriteLine("\nMenú de opciones:");
            Console.WriteLine("1. Mostrar información de usuarios");
            Console.WriteLine("2. Agregar cliente");
            Console.WriteLine("3. Agregar empleado");
            Console.WriteLine("4. Salir");
            Console.Write("Seleccione una opción: ");

            // Leer la opción ingresada por el usuario
            string opcion = Console.ReadLine();

            // Ejecutar la opción seleccionada
            switch (opcion)
            {
                case "1":
                    Console.WriteLine("\nInformación de usuarios:");
                    grifo.MostrarUsuario();
                    break;
                case "2":
                    Console.Write("\nIngrese el nombre del cliente: ");
                    string nombreCliente = Console.ReadLine();
                    Console.Write("Ingrese el saldo del cliente: ");
                    if (!double.TryParse(Console.ReadLine(), out double saldoCliente))
                    {
                        Console.WriteLine("El saldo ingresado no es válido.");
                        break;
                    }
                    Console.Write("Ingrese los litros cargados del cliente: ");
                    if (!double.TryParse(Console.ReadLine(), out double litrosCargadosCliente))
                    {
                        Console.WriteLine("Los litros cargados ingresados no son válidos.");
                        break;
                    }
                    Cliente cliente = new Cliente(nombreCliente, saldoCliente, litrosCargadosCliente);
                    grifo.AgregarUsuario(cliente);
                    Console.WriteLine("Cliente agregado correctamente.\n");
                    break;
                case "3":
                    Console.Write("\nIngrese el nombre del empleado: ");
                    string nombreEmpleado = Console.ReadLine();
                    Console.Write("Ingrese el saldo del empleado: ");
                    if (!double.TryParse(Console.ReadLine(), out double saldoEmpleado))
                    {
                        Console.WriteLine("El saldo ingresado no es válido.");
                        break;
                    }
                    Console.Write("Ingrese el sueldo del empleado: ");
                    if (!double.TryParse(Console.ReadLine(), out double sueldoEmpleado))
                    {
                        Console.WriteLine("El sueldo ingresado no es válido.");
                        break;
                    }
                    Empleado empleado = new Empleado(nombreEmpleado, saldoEmpleado, sueldoEmpleado);
                    grifo.AgregarUsuario(empleado);
                    Console.WriteLine("Empleado agregado correctamente.\n");
                    break;
                case "4":
                    salir = true;
                    Console.WriteLine("\nSaliendo del programa...");
                    break;
                default:
                    Console.WriteLine("\nOpción no válida. Por favor, seleccione una opción válida.\n");
                    break;
            }
        }
    }
}

