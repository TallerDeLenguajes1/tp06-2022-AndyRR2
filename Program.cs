using EspacioCalculadora;
using System;
Calculadora Calc = new Calculadora();
string? opcion, entrada;
bool res1=true, resultado; 
double num=0;
int opc;

Console.WriteLine("Usar Calculadora: (1-Si, otro-No)");
opcion = Console.ReadLine();
resultado = int.TryParse(opcion, out opc);
while (opc==1){
    Console.WriteLine("1-Sumar");
    Console.WriteLine("2-Restar");
    Console.WriteLine("3-Multiplicar");
    Console.WriteLine("4-Dividir");
    Console.WriteLine("5-Limpiar");
    Console.WriteLine("0-Cerrar Calculadora");
    opcion = Console.ReadLine();
    resultado = int.TryParse(opcion, out opc);
    if (opc!=5){
        Console.WriteLine("Entre un numero: ");
        entrada = Console.ReadLine();
        res1 = double.TryParse(entrada, out num);
        while (!res1){
            Console.WriteLine("El numero ingresado es invalido.");
            Console.WriteLine("Entre un numero: ");
            entrada = Console.ReadLine();
            res1 = double.TryParse(entrada, out num);
        }
    }
    
    switch (opc){
        case 1: Calc.Suma(num);break;
        case 2: Calc.Resta(num);break;
        case 3: Calc.Mult(num);break;
        case 4: Calc.Div(num);break;
        case 5: Calc.Limpiar();break;
    }
    Console.WriteLine("Resultado actual: " + Calc.Resultado);
    Console.WriteLine("Realizar otra operacion con el resultado: (1-Si, 0-No)");
    opcion = Console.ReadLine();
    resultado = int.TryParse(opcion, out opc);
    
}
Console.WriteLine("Resultado final: " + Calc.Resultado);
