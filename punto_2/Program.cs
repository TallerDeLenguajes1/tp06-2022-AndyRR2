using System;
using EspacioEmpleado;

string? entrada, cargo="\0";
bool result;
char caracter;
double valor, suma=0, Sal=0;
int num=0, selec=0, menor=100, edad=0, jub=0;
DateTime fecha;
Empleado[] Emp = new Empleado[2];//doy tamaño al arreglo de tipo clase
for (int i = 0; i < 2; i++){
    Console.WriteLine("Entre el nombre: ");
    /*entrada=Console.ReadLine();//una forma
    Emp[i]=new Empleado {Nombre=entrada};*/
    Emp[i]=new Empleado();//otra forma
    Emp[i].Nombre = Console.ReadLine();
    Console.WriteLine("Entre el apellido: ");
    Emp[i].Apellido = Console.ReadLine();
    Console.WriteLine("Entre la fecha de nacimiento (mes/dia/año): ");
    entrada = Console.ReadLine();
    result = DateTime.TryParse(entrada, out fecha);
    Emp[i].FechNac=fecha;
    Console.WriteLine("Entre el estado civil (S,C) ");
    entrada = Console.ReadLine();
    result = char.TryParse(entrada, out caracter);
    Emp[i].Estado=caracter;
    Console.WriteLine("Entre el Genero (M,F): ");
    entrada = Console.ReadLine();
    result = char.TryParse(entrada, out caracter);
    Emp[i].Genero=caracter;
    Console.WriteLine("Entre la fecha de ingreso (mes/dia/año): ");
    entrada = Console.ReadLine();
    result = DateTime.TryParse(entrada, out fecha);
    Emp[i].FechIng=fecha;
    Console.WriteLine("Entre el sueldo: ");
    entrada = Console.ReadLine();
    result=double.TryParse(entrada,out valor);
    Emp[i].Sueldo=valor;
    Console.WriteLine("Entre el numero del cargo: ");
    Console.WriteLine("1-Auxiliar\n2-Administrativo\n3-Ingeniero\n4-Especialista\n5-Investigador");
    entrada=Console.ReadLine();
    result=int.TryParse(entrada, out num);
    cargo=Enum.GetName(typeof(CARGOS),num);
}

for (int i = 0; i < 2; i++){
    Console.WriteLine("Usuario #" + (i+1));
    Console.WriteLine("Nombre: " + Emp[i].Nombre);
    Console.WriteLine("Apellido: " + Emp[i].Apellido);
    Console.WriteLine("Fecha de nacimiento: " + Emp[i].FechNac.ToString("dd/MM/yyyy"));
    Console.WriteLine("Estado civil: " + Emp[i].Estado);
    Console.WriteLine("Genero: " + Emp[i].Genero);
    Console.WriteLine("Fecha de ingreso: " + Emp[i].FechIng.ToString("dd/MM/yyyy"));
    Console.WriteLine("Sueldo: " + Emp[i].Sueldo);
    Console.WriteLine("Cargo: " + cargo);
    Emp[i].Antig=Emp[i].Antiguedad(Emp[i].FechIng);
    Console.WriteLine("Antiguedad: " + Emp[i].Antig + " años");
    edad=Emp[i].Edad(Emp[i].FechNac);
    Console.WriteLine("Edad: " + edad + " años");
    jub=Emp[i].Jubilacion(Emp[i].FechIng,Emp[i].Genero);
    Console.WriteLine("Falta para jubilarse: " + jub + " años");
    Sal=Emp[i].Salario(Emp[i].Sueldo,num,Emp[i].Antig,Emp[i].Estado);
    Console.WriteLine("Salario: " + Sal);
    suma +=Sal;
    if (jub<=menor){
        selec=i;
        menor=jub;
    }
}
    Console.WriteLine("Usuario mas proximo a jubilarse #" + (selec+1));
    Console.WriteLine("Nombre: " + Emp[selec].Nombre);
    Console.WriteLine("Apellido: " + Emp[selec].Apellido);
    Console.WriteLine("Fecha de nacimiento: " + Emp[selec].FechNac.ToString("dd/MM/yyyy"));
    Console.WriteLine("Estado civil: " + Emp[selec].Estado);
    Console.WriteLine("Genero: " + Emp[selec].Genero);
    Console.WriteLine("Fecha de ingreso: " + Emp[selec].FechIng.ToString("dd/MM/yyyy"));
    Console.WriteLine("Sueldo: " + Emp[selec].Sueldo);
    Console.WriteLine("Cargo: " + cargo);
    Emp[selec].Antig=Emp[selec].Antiguedad(Emp[selec].FechIng);
    Console.WriteLine("Antiguedad: " + Emp[selec].Antig + " años");
    edad=Emp[selec].Edad(Emp[selec].FechNac);
    Console.WriteLine("Edad: " + edad + " años");
    jub=Emp[selec].Jubilacion(Emp[selec].FechIng,Emp[selec].Genero);
    Console.WriteLine("Falta para jubilarse: " + jub + " años");
    Sal=Emp[selec].Salario(Emp[selec].Sueldo,num,Emp[selec].Antig,Emp[selec].Estado);
    Console.WriteLine("Salario: " + Sal);
    Console.WriteLine("Total entre los salarios: " + suma);




