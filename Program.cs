// See https://aka.ms/new-console-template for more information
using Humanizer;

Console.WriteLine("Por favor ingrese un nombre");
var nombre = Console.ReadLine();
Console.WriteLine("Por afvor ingrese su cargo");
var cargo = Console.ReadLine();
Console.WriteLine("Por favor ingrese su edad real");
var edad = int.Parse(Console.ReadLine());

Console.WriteLine($"Mi nombre es {nombre}, Mi edad es: {edad.ToWords(new System.Globalization.CultureInfo("es"))} y mi cargo es {cargo}");
