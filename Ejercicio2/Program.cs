// Exercise 1
Console.WriteLine("Exercise 1:");
string message = "is a very efficient professional.";

Console.WriteLine("Please, enter the following data: ");
Console.Write("Name: ");
string? name = Console.ReadLine();
Console.Write("Age: ");
int age = Convert.ToInt32(Console.ReadLine());
Console.Write("Profession: ");
string? profession = Console.ReadLine();

Console.WriteLine("{0} is {1} years old, is {2} and {3}", name, age, profession, message);



// Exercise 2
Console.WriteLine("\nExercise 2:");

//Coche
int puertas = 4;
int ruedas = 4;
string marca = "Toyota";
bool itv = false;

Console.WriteLine("\nEl coche tiene las siguientes caracteristicas:\nPuertas: {0}.\nRuedas: {1}.\nMarca: {2}.\nITV vigente: {3}", puertas, ruedas, marca, itv);

// Mesa
int peso = 60;
int largo = 20;
string material = "Madera";
string color = "Marron";

Console.WriteLine("\nLa mesa tiene las siguientes caracteristicas:\nPeso: {0} kg.\nLargo: {1} centimetros.\nMaterial: {2}.\nColor: {3}.", peso, largo, material, color);



// Exercise 3
Console.WriteLine("\nExercise 3:");

// Un número es mayor o igual a 18
Console.Write("\nIngresa tu edad: ");
int numberAge = Convert.ToInt32(Console.ReadLine());
if(numberAge >= 18)
{
    Console.WriteLine("Puedes ingresar!");
}
else
{
    Console.WriteLine("No puedes ingresar!");
}

// Un char es 'a'
char vocal = 'a';
if(vocal == 'a')
{
    Console.WriteLine("\nLa vocal es igual a 'a'");
}
else
{
    Console.WriteLine("\nLa vocal no es igual a 'a'");
}

// Se cumplen dos conciones a la vez (ambas verdaderas)
Console.Write("\nIngresa tu usuario: ");
string? user = Console.ReadLine();
Console.Write("Ingresa tu clave: ");
string? password = Console.ReadLine();
if (user == "JuanJK" && password == "123456")
{
    Console.WriteLine("Usuario y clave correctos!");
}
else
{
    Console.WriteLine("Usuario y clave incorrectos!");
}

// Se cumple una de dos condiciones a la vez (una true y otra false)
Console.WriteLine("\n¿Quieres correr?");
string? run = Console.ReadLine();
Console.WriteLine("¿Quieres jugar?");
string? play = Console.ReadLine();

if (run== "si" || play == "si")
{
    Console.WriteLine("Entonces vamos!");
}
else
{
    Console.WriteLine("Ok");
}
