// Enunciado 1: Clasificación de edades

Console.WriteLine("Ingresa tu edad para determinar tu categoría: ");
int edad = int.Parse(Console.ReadLine());

if (edad < 12) {
    Console.WriteLine("Eres un niño");
}

if (edad >= 12 && edad <= 17) {
    Console.WriteLine("Eres un adolescente");
}

if (edad >= 18 && edad <= 59) {
    Console.WriteLine("Eres un adulto");
}

if (edad >= 60) {
    Console.WriteLine("Eres un adulto mayor");
}