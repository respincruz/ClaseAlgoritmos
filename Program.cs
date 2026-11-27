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
/*
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
                estudiantes.
                break;
          case 4: Console.WriteLine($"Tenemos {estudiantes.Count} estudiantes");
          break;  

    }
}while(opcion!=5);
Console.WriteLine("Fin de programa");
*/
#endregion

#region Diccionario
/*using System.Collections.Generic;
using System.Xml.Serialization;

Dictionary<string, string> productos=new Dictionary<string,string>();
int? opcion;

do
{
    Console.WriteLine("=================");
    Console.WriteLine("1. Agrega Producto");
    Console.WriteLine("2. Mostrar Productos");
    Console.WriteLine("3. Eliminar Producto");
    Console.WriteLine("4. Cantidad de Productos");
    Console.WriteLine("5. Salir");
    opcion=Convert.ToInt32(Console.ReadLine());
    //opcion=Int32.Parse(Console.ReadLine());

    switch (opcion)
    {
        case 1: Console.WriteLine("Ingrese el codigo de Producto:");
                string? codigo=(Console.ReadLine()!);
                Console.WriteLine("Ingrese el nombre del Producto:");
                string nombre=(Console.ReadLine()!);
        productos.Add(codigo,nombre);
        break;
        case 2: foreach(var producto in productos)
            {
                Console.WriteLine($"Producto Cod: {producto.Key}, Nombre: {producto.Value}");
            }
            break;
        case 3: Console.WriteLine("Ingrese el codigo a eliminar");
                string? codDelete=(Console.ReadLine()!);
                productos.Remove(codDelete);
                break;
        case 4: Console.WriteLine($"Cantidad de Tipos de Productos: {productos.Count}");
        break;
                
    }
}while(opcion!=5);

Console.WriteLine("Fin del Programa");*/
#endregion


#region tuplas
/*using System.Reflection.Metadata.Ecma335;

var producto=( 
    Codigo:20,
    Nombre:"Monitor",
    Precio:250.75m
);

Console.WriteLine($"Codigo:{producto.Codigo}");
Console.WriteLine($"Nombre:{producto.Nombre}");
Console.WriteLine($"Precio: {producto.Precio}");
producto.Precio=280m;
Console.WriteLine($"Precio: {producto.Precio}");

var productoRecuperado=fnTupla();

Console.WriteLine(productoRecuperado.Codigo);
Console.WriteLine(productoRecuperado.Nombre);
Console.WriteLine(productoRecuperado.Precio);

static (int Codigo, string Nombre, decimal Precio)  fnTupla()
{
    return (18, "Mouse", 18.5m);
}*/
#endregion

#region clases01
/*
Vehiculo Renault=new Vehiculo();
Renault.Marca="Renault";
Renault.Modelo="Duster";
Renault.Anio=2019;
Renault.Velocidad=0;
for(int i = 0; i < 5; i++)
{
    Console.WriteLine("Cuanto quieres aumentar la velocidad en km?");
    int aumento=Convert.ToInt32(Console.ReadLine()!);
    Renault.Acelerar(aumento);

    Renault.MostrarInfoVehiculo();
}
class Vehiculo
{
    public string? Marca {get;set;}
    public string? Modelo {get; set;}
    public int? Anio {get; set;}
    public int? Velocidad {get; set;}

    public Vehiculo()
    {
        
    }
    public void MostrarInfoVehiculo()
    {
        Console.WriteLine("============================");
        Console.WriteLine($"Marca:{Marca}");
        Console.WriteLine($"Modelo:{Modelo}");
        Console.WriteLine($"Anio:{Anio}");
        Console.WriteLine($"Velocidad:{Velocidad}");
        Console.WriteLine("============================");
    }

    public void Acelerar(int aumento)
    {
        Velocidad+=aumento;
    }

    public void Frenar(int reducir)
    {
        Velocidad-=reducir;
    }

}
*/

#endregion

#region herencia
/*
Automovil renault=new Automovil();
renault.Marca="Renault";
renault.Modelo="Duster";
renault.NumeroPuertas=5;

renault.MostrarDatos();


Moto kawasaki=new Moto();
kawasaki.Marca="Kawasaki";
kawasaki.Modelo="H500";
kawasaki.Tipo="Deportiva";

kawasaki.MostrarDatos();
class Vehiculo
{
    public string? Marca;
    public string? Modelo;
    public void MostrarDatos()
    {
        Console.WriteLine($"Marca: {Marca}");
        Console.WriteLine($"Modelo: {Modelo}");

    }
}

class Automovil : Vehiculo
{
    public int? NumeroPuertas;
}

class Moto : Vehiculo
{
    public string? Tipo;
}

*/
#endregion

#region polimorfismo
/*
Pago pago1=new PagoTarjeta();
Pago pago2=new PagoEfectivo();
Pago pago3=new PagoTransferencia();

pago1.ProcesarPago();
pago2.ProcesarPago();
pago3.ProcesarPago();
public class Pago
{
    public virtual void ProcesarPago()
    {
        Console.WriteLine("Procesando Pago....");
    }
}

public class PagoTarjeta : Pago
{
    public override void ProcesarPago()
    {
        base.ProcesarPago();
        Console.WriteLine("Procesando Pago.... Esperando Señal DataFast");
    }
}

public class PagoEfectivo : Pago
{
    public override void ProcesarPago()
    {
        Console.WriteLine("Calculando si debo realizar/pagar el vuelto");
    }
}

public class PagoTransferencia : Pago
{
    public override void ProcesarPago()
    {
        Console.WriteLine("Esperando señal Pago De Una");
    }
}*/
#endregion

#region colas
/*using System.Collections.Generic;
Queue<string> clientes=new Queue<string>();   // Queue<T> nombre_variable=new Queue<T>();

clientes.Enqueue("Ana");
clientes.Enqueue("Pedro");
clientes.Enqueue("Maria");

Console.WriteLine(clientes.Peek());
 clientes.Dequeue();

 Console.WriteLine(clientes.Peek());

 foreach(var cliente in clientes){
    
    Console.WriteLine(cliente);
}*/
#endregion


#region pilas
/*using System.Collections.Generic;
Stack<string> paginas=new Stack<string>();////Stack<T> nombre=new Stack<T>(); Donde T es el tipo de dato sea primitivo o una clase
paginas.Push("Google");
paginas.Push("www.elcomercio.com");
paginas.Push("www.eluniverso.com");
paginas.Push("www.pichincha.com");
paginas.Push("www.dragonspace.usfq.edu.ec");

Console.WriteLine(paginas.Peek());

paginas.Pop();

Console.WriteLine(paginas.Peek());
foreach(string pagina in paginas)
{
    Console.WriteLine(pagina);
}*/
#endregion

#region listasenlazadas
/*using System.Collections.Generic;
LinkedList<string> canciones=new LinkedList<string>();

canciones.AddLast("Imagine");
canciones.AddLast("Bohemian Raphsody");
canciones.AddFirst("It's My life");
LinkedListNode<string>? nodo=canciones.Find("It's My life");

canciones.AddAfter(nodo,"Eye of the tiger");
foreach(var cancion in canciones)
{
    Console.WriteLine(cancion);
}

Console.WriteLine("Primera Cancion de la lista: "+canciones.First.Value);

canciones.Remove("It's my life");

foreach(var cancion in canciones)
{
    Console.WriteLine(cancion);
}
if(canciones.Contains("Eye of the tiger"))
   Console.WriteLine("Si esta en el playlist");
else
    Console.WriteLine("No existe la cancion");
*/
#endregion

#region ColaBanco
using System.Collections.Generic;

/*Cliente cliente1=new Cliente();
cliente1.Nombre="Ruben";
cliente1.Edad=40;
cliente1.Saldo=5000;
Console.WriteLine(cliente1.ToString());

Queue<Cliente> colanormal=new Queue<Cliente>();
Queue<Cliente> colapreferencial=new Queue<Cliente>();

int opcion=0;
do
{
   Console.WriteLine("==============================");
   Console.WriteLine("Banco Galapagos USFQ");
   Console.WriteLine("==============================");
   Console.WriteLine("Menu de opciones");
   Console.WriteLine("1. Ingresar cliente");
   Console.WriteLine("2 Mostrar proximo cliente");
   Console.WriteLine("3 Atender cliente");
   Console.WriteLine("4 Progreso de Colas");
   Console.WriteLine("5 Mostrar todas las colas");
   Console.WriteLine("6 Salir");
   Console.WriteLine("Ingresar una opcion del menu");
   opcion=Convert.ToInt32(Console.ReadLine());
    switch (opcion)
    {
        case 1: Console.WriteLine("Ingrese los nombres");
                string nombre=Console.ReadLine();

                Console.WriteLine("Ingrese la Edad:");
                int edad=Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Ingrese su saldo:");
                decimal saldo=Convert.ToDecimal(Console.ReadLine());

                Cliente cliente=new Cliente()
                {
                    Nombre=nombre,
                    Edad=edad,
                    Saldo=saldo
                };
            if (edad > 65)
            {
                colapreferencial.Enqueue(cliente);
                Console.WriteLine($"{cliente.Nombre} ha sido agregado a la cola preferencial");
            }
            else
            {
                colanormal.Enqueue(cliente);
                Console.WriteLine($"{cliente.Nombre} esta en la cola normal");
            }
            break;
            case 2:
            if (colanormal.Count > 0){
                
                    Console.WriteLine("Proximo Cliente en cola normal");
                    Console.WriteLine(colanormal.Peek());
                    }
            else
            {
                Console.WriteLine("No hay clientes en la cola normal");
            }
            if (colapreferencial.Count > 0){
                    Console.WriteLine("Proximo cliente en cola preferencial");
                    Console.WriteLine(colapreferencial.Peek());
             }
             else
            {
                Console.WriteLine("No hay clientes en la cola preferencial");
            }
            break;
            case 3: Console.WriteLine("Punto de atencion clientes");
                    Console.WriteLine("Que cola voy a atender?");
                    Console.WriteLine("Normal");
                    Console.WriteLine("Preferencial");
                    string submenu=Console.ReadLine();
            switch (submenu)
            {
                case "Normal":
                    if (colanormal.Count > 0)
                    {
                        Cliente atendido=colanormal.Dequeue();
                        Console.WriteLine($"Se atiende a {atendido.Nombre}");
                    }
                    else
                        Console.WriteLine("No hay clientes en cola normal");
                break;
                case "Preferencial":
                    if (colapreferencial.Count > 0)
                    {
                        Cliente atendido=colapreferencial.Dequeue();
                        Console.WriteLine($"Se atiende a {atendido.Nombre}");
                    }
                    else
                        Console.WriteLine("No hay clientes en cola preferencial");
                break;
            }
            break;
            case 4: Console.WriteLine("Progresos de colas");
                    Console.WriteLine($"# de Clientes en cola normal:{colanormal.Count}");
                    Console.WriteLine($"# de Clientes en cola preferencial:{colapreferencial.Count}");

            break;
            case 5: Console.WriteLine("Cola Normal");
                    foreach(Cliente c in colanormal)
                    {
                        Console.WriteLine(c.ToString());
                    }
                    Console.WriteLine("Cola Preferencial");
                    foreach(Cliente c in colapreferencial)
                    {
                        Console.WriteLine(c.ToString());
                    }
            break;
    }

}while(opcion!=6);
class Cliente
{
    public string? Nombre{ get; set;}
    public int Edad{get;set;}
    public decimal Saldo{get; set;}

    public override string ToString()
    {
        return $"Nombre: {Nombre} |  Edad: {Edad} | Saldo: {Saldo}";
    }
}

*/
#endregion

#region Recursivas
/* esto no se debe realizar. La funcion recursiva no tiene una salida o condicion para salir
void Ejemplo()
{
    Ejemplo();
}
Ejemplo();
fin de funcion mal realizada recursiva*/

static int Sumar(int n)
{
    if (n == 1)
  
        return 1;
    
     
     return n+Sumar(n-1);
}

static int Factorial(int n)
{
    if (n==1)
    return 1;

    return n*Factorial(n-1);
}

Console.WriteLine("Ingrese un numero para calcular su serie geometrica:");
int valor=Convert.ToInt16(Console.ReadLine()!);
Console.WriteLine($"El factorial de {valor} es {Factorial(valor)}");
/*
//Console.WriteLine($"El resultado es:{Sumar(valor)}");
if (valor > 5)
{
     Console.WriteLine("El numero es mayor a 5");
    valor=valor+1;
}
else
    Console.WriteLine("Es menor");

Console.WriteLine(valor);*/
#endregion




