// See https://aka.ms/new-console-template for more information



using Tarea_S4.Models;

Console.WriteLine("Bienvenido al banco Debussy");
Console.WriteLine("****  1. Ver cuenta ****");
Console.WriteLine("****  2. Hacer un retiro****");
Console.WriteLine("****  3. Hacer compra ****");
Console.WriteLine("****  4. Salir  ****");
Console.WriteLine("****  Elija una opción a realizar  ****");

Console.Write("opcion: ");
string opcion = Console.ReadLine();

switch (opcion)
{
    case "1":
        Movimiento m1 = new Movimiento();
        {
           

        }




        break;
    default:
        Console.WriteLine(" Opción fuera de reango ");
        break;
}