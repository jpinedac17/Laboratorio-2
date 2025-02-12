//Parte 1: Declaración y Uso de Variables

Console.WriteLine("Ingrese un número entero: ");
int numero = int.Parse(Console.ReadLine());

Console.WriteLine("Ingrese un número decimal: ");
double numeroDecimal = double.Parse(Console.ReadLine());

Console.WriteLine("Ingrese un texto: ");
string texto = Console.ReadLine();

bool valorBooleano = false;
string valor;
Console.WriteLine("Ingrese verdadero (v) o falso (f):");
valor = Console.ReadLine();
if (valor == "v") {
    valorBooleano = true;
} else if (valor == "f") {
    valorBooleano = false;
}

Console.WriteLine("Número entero: " + numero);
Console.WriteLine("Número decimal: " + numeroDecimal);
Console.WriteLine("Texto: " + texto);
Console.WriteLine("Valor verdadero o falso: " + valorBooleano);