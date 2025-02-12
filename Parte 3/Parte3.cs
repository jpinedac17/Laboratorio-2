// Parte 3: Operaciones Lógicas

Console.WriteLine("Ingrese un número entero: ");
int num1 = int.Parse(Console.ReadLine());

Console.WriteLine("Ingrese otro número entero: ");
int num2 = int.Parse(Console.ReadLine());

if (num1 > num2) {
    Console.WriteLine($"{num1} es mayor que {num2}");
}

if (num1 < num2) {
    Console.WriteLine($"{num1} es menor que {num2}");
}

if (num1 == num2) {
    Console.WriteLine($"{num1} es igual que {num2}");
}

if (num1 < num2 && num1 > 0) {
    Console.WriteLine($"{num1} es menor que {num2}, pero es mayor que 0");
}

if (num1 < num2 || num1 == num2) {
    Console.WriteLine($"{num1} es menor o igual que {num2}");
}