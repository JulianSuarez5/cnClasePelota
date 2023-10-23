using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Pelota1
{
    public string Tipo { get; set; }
    public double Diametro { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        int cantidadPelotas;

        Console.Write("Ingrese la cantidad de pelotas: ");
        cantidadPelotas = Convert.ToInt32(Console.ReadLine());

        Pelota1[] pelotas = new Pelota1[cantidadPelotas];

        for (int i = 0; i < cantidadPelotas; i++)
        {
            Console.WriteLine("Ingrese la información de la pelota " + (i + 1));

            pelotas[i] = new Pelota1();

            Console.Write("Tipo (Futbol, Baloncesto Tenis, Rugby etc: ");
            pelotas[i].Tipo = Console.ReadLine();

            Console.Write("Diámetro: ");
            pelotas[i].Diametro = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine();
        }

        Console.WriteLine("Información de las pelotas:");

        int contador = 1;
        foreach (var pelota in pelotas)
        {
            //Encabezado
            Console.WriteLine("Pelota " + contador + ":");

            // Mostrar la información de la pelota
            Console.WriteLine("Tipo: " + pelota.Tipo);
            Console.WriteLine("Diámetro: " + pelota.Diametro);
            Console.WriteLine();

            contador++;
        }

        Console.ReadLine();
    }
}

