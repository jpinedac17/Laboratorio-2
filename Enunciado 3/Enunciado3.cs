// Enunciado 3: Verificación de acceso

string usuario = "admin";
int contraseña = 123;

Console.WriteLine("Ingrese su usuario");
if (Console.ReadLine() != usuario) {
    Console.WriteLine("Usuario no registrado");
    return;
}

Console.WriteLine("Ingrese su contraseña");
if (int.Parse(Console.ReadLine()) != contraseña) {
    Console.WriteLine("Contraseña incorrecta");
    return;
}

Console.WriteLine("Acceso concedido");