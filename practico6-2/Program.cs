using System;
using System.Text.RegularExpressions;

public class Calculadora{
    public int Suma(int a, int b){
        return(a+b);
    }
    public int Resta(int a, int b){
        return(a-b);
    }
    public int Mult(int a, int b){
        return(a*b);
    }
    public int Div(int a, int b){
        return(a/b);
    }
    public int Limpiar(int calculo){
        calculo=0;
        return(calculo);
    }
};

public class Program{
    public static void Main(){
        Calculadora NuevaC = new Calculadora();
        string? opcion, numa, numb;
        bool res1=true, res2=true, resultado; 
        int a=0, b=0, opc, calculo=0;
        Console.WriteLine("Usar Calculadora: (1-Si, otro-No)");
        opcion = Console.ReadLine();
        resultado = int.TryParse(opcion, out opc);
        while (opc!=0){
            Console.WriteLine("1-Sumar");
            Console.WriteLine("2-Restar");
            Console.WriteLine("3-Multiplicar");
            Console.WriteLine("4-Dividir");
            Console.WriteLine("5-Limpiar");
            Console.WriteLine("0-Cerrar Calculadora");
            opcion = Console.ReadLine();
            resultado = int.TryParse(opcion, out opc);
            if ((a==0)&&(b==0)){
            Console.WriteLine("Entre el primer numero: ");
            numa = Console.ReadLine();
            res1 = int.TryParse(numa, out a);
            Console.WriteLine("Entre el segundo numero: ");
            numb = Console.ReadLine();
            res2 = int.TryParse(numb, out b);
            while (!res1){
                Console.WriteLine("El numero ingresado es invalido.");
                Console.WriteLine("Entre el primer numero: ");
                numa = Console.ReadLine();
                res1 = int.TryParse(numa, out a);
            }
            while (!res2){
                Console.WriteLine("El numero ingresado es invalido.");
                Console.WriteLine("Entre el segundo numero: ");
                numa = Console.ReadLine();
                res2 = int.TryParse(numa, out b);
            }
            }
            switch (opc){
                case 1: calculo = NuevaC.Suma(a,b);break;
                case 2: calculo = NuevaC.Resta(a,b);break;
                case 3: calculo = NuevaC.Mult(a,b);break;
                case 4: calculo = NuevaC.Div(a,b);break;
                case 5: calculo = NuevaC.Limpiar(calculo);break;
            }
            Console.WriteLine("Resultado: " + calculo);
            Console.WriteLine("Realizar otra operacion con el resultado: (1-Si, 0-No)");
            opcion = Console.ReadLine();
            resultado = int.TryParse(opcion, out opc);
            if (calculo!=0){
                while (opc!=0){
                    Console.WriteLine("1-Sumar");
                    Console.WriteLine("2-Restar");
                    Console.WriteLine("3-Multiplicar");
                    Console.WriteLine("4-Dividir");
                    Console.WriteLine("5-Limpiar");
                    Console.WriteLine("0-Cancelar");
                    opcion = Console.ReadLine();
                    resultado = int.TryParse(opcion, out opc);
                    if (opc!=5){
                        Console.WriteLine("Entre el numero de la operacion: ");
                        numa = Console.ReadLine();
                        res1 = int.TryParse(numa, out a);
                        while (!res1){
                        Console.WriteLine("El numero ingresado es invalido.");
                        Console.WriteLine("Entre el numero de la operacion: ");
                        numa = Console.ReadLine();
                        res1 = int.TryParse(numa, out a);
                        }
                    }
                    switch (opc){
                    case 1: calculo = NuevaC.Suma(calculo,a);break;
                    case 2: calculo = NuevaC.Resta(calculo,a);break;
                    case 3: calculo = NuevaC.Mult(calculo,a);break;
                    case 4: calculo = NuevaC.Div(calculo,a);break;
                    case 5: calculo = NuevaC.Limpiar(calculo);break;
                    }
                    Console.WriteLine("Resultado: " + calculo);
                    Console.WriteLine("Realizar otra operacion con el resultado: (1-Si, 0-No)");
                    opcion = Console.ReadLine();
                    resultado = int.TryParse(opcion, out opc);
                }
            }
            Console.WriteLine("Realizar otra operacion con nuevos numeros: (1-Si, 0-No)");
            opcion = Console.ReadLine();
            resultado = int.TryParse(opcion, out opc);
            if (opc==1){
                a=0;
                b=0;
            }
        }
        Console.WriteLine("Resultado final: " + calculo);
    }  
}


