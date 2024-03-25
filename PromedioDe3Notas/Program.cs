//Consigna: Cálcular el promedio de 3 notas.

//Introducción

var bienvenida = "Éste es un Programa de Consola que saca un PROMEDIO usando 3 notas";
Console.WriteLine(bienvenida + "\n");

var inicio = "Presione cualquier tecla para continuar";
Console.WriteLine(inicio + "\n");
Console.ReadKey();
Console.Clear();    


float nota1;
Console.WriteLine("Ingrese la PRIMERA NOTA (Puede ser un número entero o decimal)" + "\n");
nota1 = float.Parse(Console.ReadLine());
Console.Clear();

float nota2;
Console.WriteLine("Ingrese la SEGUNDA NOTA (Puede ser un número entero o decimal)" + "\n");
nota2 = float.Parse(Console.ReadLine());
Console.Clear();

float nota3;
Console.WriteLine("Ingrese la TERCERA NOTA (Puede ser un número entero o decimal)" + "\n");
nota3 = float.Parse(Console.ReadLine());
Console.Clear();
var resultado = "El Promedio es de:";
var promedio = (nota1 + nota2 + nota3) / 3;

Console.WriteLine(resultado + "\n" + "\n" + promedio + "\n" + "\n" + "Notas que ingresaste:" + "\n" + nota1 + "\n" + nota2 + "\n" + nota3 + "\n");
Console.ReadKey();


