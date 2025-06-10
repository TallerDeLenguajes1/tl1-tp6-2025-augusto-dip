// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//PROBANDO C#
// int a;
// int b;
// a=10;
// b=a;
// Console.WriteLine("valor de a:"+a);
// Console.WriteLine("valor de b:"+b);

//EJERCICIO 1

// string texto = Console.ReadLine();
// int numero;
// bool esNum = int.TryParse(texto, out numero);

// if (esNum) {
//     if (numero > 0) {
//         int invertido = 0;
//         while(numero > 0){
//             invertido = invertido * 10 + numero % 10;
//             numero = numero / 10;
//         }
//         Console.WriteLine("El numero invertido es " + invertido);
//     }
//     else {
//         Console.WriteLine("El numero ingresado no es mayor que cero");
//     }
// }
// else {
//     Console.WriteLine("El texto ingresado no es un numero entero");
// }

//EJERCICIO 2
// float solicitarNumero(){
//     string numero = Console.ReadLine();
//     float num;

//     while(!float.TryParse(numero, out num)){
//         numero = Console.ReadLine();
//     }
//     return num;
// }

// float suma(float num1, float num2){
//     return num1 + num2;
// }

// float resta(float num1, float num2){
//     return num1 - num2;
// }

// float multiplicacion(float num1, float num2){
//     return num1 * num2;
// }

// float division(float num1, float num2){
//         return num1 / num2;
// }

// string opcionElegida;
// int opcionInt = 0;
// float num1, num2;

// while(opcionInt != 5 ){
//     Console.WriteLine("\n°°°°°°°°°°°°°°°°°°°°°°°°\n");
//     Console.WriteLine("Seleccione una opcion:");
//     Console.WriteLine("1. Sumar");
//     Console.WriteLine("2. Restar");
//     Console.WriteLine("3. Multiplicar");
//     Console.WriteLine("4. Dividir");
//     Console.WriteLine("5. Salir");
//     Console.WriteLine("\n°°°°°°°°°°°°°°°°°°°°°°°°\n");

//     opcionElegida = Console.ReadLine();

//     bool opcionValida = int.TryParse(opcionElegida, out opcionInt);
//     Console.WriteLine("\n°°°°°°°°°°°°°°°°°°°°\n");
//     if (opcionValida && opcionInt > 0 && opcionInt < 5)
//     {
//         Console.WriteLine("Ingrese el primer numero:");
//         num1 = solicitarNumero();
//         Console.WriteLine("\nIngrese el segundo numero");
//         num2 = solicitarNumero();
//         Console.WriteLine("\n°°°°°°°°°°°°°°°°°°°°\n");
//         switch (opcionInt)
//         {
//             case 1:
//                 Console.WriteLine(num1 + " + " + num2 + " = " + suma(num1, num2));
//                 break;
//             case 2:
//                 Console.WriteLine(num1 + " - " + num2 + " = " + resta(num1, num2));
//                 break;
//             case 3:
//                 Console.WriteLine(num1 + " * " + num2 + " = " + multiplicacion(num1, num2));
//                 break;
//             case 4:
//                 if (num2 != 0)
//                 {
//                     Console.WriteLine(num1 + " / " + num2 + " = " + division(num1, num2));
//                 }
//                 else
//                 {
//                     Console.WriteLine("Error, division en cero");
//                 }
//                 break;
//         }   
//     }
// }
// EJERCICIO 3
// float solicitarNumero()
// {
//     string numString = Console.ReadLine();
//     float num;

//     while (!float.TryParse(numString, out num))
//     {
//         Console.Write("Ingrese un numero valido");
//         numString = Console.ReadLine();
//     }
//     return num;
// }
// Console.Write("Ingrese un numero: ");
// float num = solicitarNumero();

// Console.WriteLine("|" + num + "| = " + Math.Abs(num));
// Console.WriteLine(num + "^2 = " + num * num);
// if (num >= 0)
// {
//     Console.WriteLine("Raiz cuadrada de " + num + " = " + Math.Sqrt(num));
// }
// else
// {
//    Console.WriteLine("No podemos calcular raiz cuadrada de un numero negativo"); 
// }
// Console.WriteLine("sen(" + num + ") = " + Math.Sin(num));
// Console.WriteLine("cos(" + num + ") = " + Math.Cos(num));
// Console.WriteLine("Parte entera de " + num + " = " + Math.Truncate(num));

// Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~");

// Console.Write("Ingrese el numero 1: ");
// float num1 = solicitarNumero();
// Console.Write("Ingrese el numero 2: ");
// float num2 = solicitarNumero();

// if (num1 > num2)
// {
//     Console.WriteLine("Maximo: " + num1);
//     Console.WriteLine("Minimo: " + num2);
// }
// else if (num2 > num1)
// {
//     Console.WriteLine("Maximo: " + num2);
//     Console.WriteLine("Minimo: " + num1);
// }
// else
// {
//     Console.WriteLine("Los dos numeros son iguales");
// }
// EJERCICIO 4
string cadena, cadena2;

Console.Write("Ingrese una cadena: ");
cadena = Console.ReadLine();

Console.WriteLine("Longitud de la cadena: " + cadena.Length);

Console.Write("Ingrese una segunda cadena: ");
cadena2 = Console.ReadLine();

Console.WriteLine("Cadena 1 + Cadena 2 = " + cadena + cadena2);

Console.WriteLine("Substring de cadena1: " + cadena.Substring(2, 2));

foreach (var caracter in cadena)
{
    Console.WriteLine(caracter);
}

if (cadena.ToLower().Contains("hola"))
{
    Console.WriteLine("\"hola\" se encuentra dentro de la cadena: " + cadena);
}
else
{
    Console.WriteLine("\"hola\" no se encuentra dentro de la cadena: " + cadena);
}

Console.WriteLine("Cadena en mayusculas: " + cadena.ToUpper());
Console.WriteLine("Cadena en minusculas: " + cadena.ToLower());

Console.Write("Ingrese el separador: ");
char separador = Console.ReadLine()[0];

Console.Write("Ingrese la cadena a separar: ");
string cadena3 = Console.ReadLine();

Console.Write("[");
foreach (var cad in cadena3.Split(separador))
{
    Console.Write($" {cad} ");
}
Console.Write("]");




