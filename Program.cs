#region 01Clase
/*Console.WriteLine("Hello, World!");
int edad = 25;
string nombre = "Juan";
//Console.WriteLine("Mi edad es: " + edad);
Console.WriteLine($"Mi edad es: {edad}");
Console.WriteLine("Mi nombre es: " + nombre +" y mi edad es: " + edad);
Console.WriteLine($"Mi nombre es: {nombre} y mi edad es: {edad}");

DateTime dateTime = DateTime.Now;
Console.WriteLine($"La fecha y hora actual es: {dateTime}");

DateTime FechaHoy = DateTime.Today;
Console.WriteLine($"La fecha de hoy es: {FechaHoy}");

DateTime FechaNacimiento = new DateTime(1998, 5, 15);
Console.WriteLine($"Mi fecha de nacimiento es: {FechaNacimiento}");

int diferenciaDias=(FechaHoy - FechaNacimiento).Days;
Console.WriteLine($"La diferencia en días entre hoy y mi fecha de nacimiento es: {diferenciaDias} días");   */

/*int edadJuan=25;
int edadJose=30;

edadJuan=edadJose;
Console.WriteLine($"Edad Juan {edadJuan}, edad Jose {edadJose}");

Persona p1=new Persona();

p1.Nombre="Ruben";

Persona p2=new Persona();
p2.Nombre="Juan";

p2=p1;
Console.WriteLine($"El nombre de P1 es {p1.Nombre} y el Nombre de P2 es {p2.Nombre}");


class Persona
{
    public string? Nombre;
}*/
#endregion


#region ejercicio guiado C
/*
Auto auto1=new Auto();
auto1.Marca="Toyota";

Auto auto2=auto1;
auto2.Marca="Peugeot";

Console.WriteLine(auto1.Marca);
Console.WriteLine(auto2.Marca);
class Auto
{
    public string? Marca;
}

*/

#endregion

#region Arreglos

//int[] numeros=new int [5];
/*int[] numeros={10,20,30,40,50};

for (var i=0; i<numeros.Length; i++)
{
    Console.WriteLine($"Elemento {i}: {numeros[i]}");
}*/

/*
using System.Security.Cryptography;

/// por valor
int cantidad=0;
Console.WriteLine("Ingrese la cantidad de estudiantes");
cantidad=int.Parse(Console.ReadLine()!);

string[]? Nombres=new string[cantidad];
double[]? notas=new double[cantidad];


for(int i=0;i<cantidad; i++)
{
    Console.WriteLine("Ingrese el nombre del Estudiante");
    Nombres[i]=Console.ReadLine()!;
    Console.WriteLine("Ingrese la nota:");
    notas[i]=double.Parse(Console.ReadLine()!);
}

foreach(string nombre in Nombres)
{
    Console.WriteLine(nombre);
}

foreach(double nota in notas)
{
    Console.WriteLine(nota);
}

double suma=0;
for(int j = 0; j < notas.Length; j++)
{
    suma+=notas[j];
}

double promedio=suma/notas.Length;
Console.WriteLine($"El promedio de la clase es {promedio}");*/
#endregion

#region listas
using System.Collections.Generic;
List <string> estudiantes=new List<string>();

int? opcion;

do
{
    Console.WriteLine("=================");
    Console.WriteLine("1. Agrega Estudiante");
    Console.WriteLine("2. Mostrar Estudiantes");
    Console.WriteLine("3. Eliminar Estudiante");
    Console.WriteLine("4. Cantidad de Estudiantes");
    Console.WriteLine("5. Salir");
    opcion=Convert.ToInt32(Console.ReadLine());
    //opcion=Int32.Parse(Console.ReadLine());

    switch (opcion)
    {
        case 1: Console.WriteLine("Ingrese el nombre");
                string? nombre=(Console.ReadLine()!);
                estudiantes.Add(nombre);
                //estudiantes.Add(Console.ReadLine());
                break;
        case 2: foreach(string estudiante in estudiantes)
            {
                Console.WriteLine(estudiante);
            }
            break;
        case 3:  Console.WriteLine("A quien desea eliminar?");
                string? eliminado=(Console.ReadLine()!);
                estudiantes.Remove(eliminado);
                break;
          case 4: Console.WriteLine($"Tenemos {estudiantes.Count} estudiantes");
          break;  

    }
}while(opcion!=5);
Console.WriteLine("Fin de programa");

#endregion

