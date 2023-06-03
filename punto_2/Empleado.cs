namespace EspacioEmpleado;
using System;

public enum CARGOS{
    Auxiliar=1,
    Administrativo=2,
    Ingeniero=3,
    Especialista=4,
    Investigador=5
}
public class Empleado{
    private string nombre;
    private string apellido;
    private DateTime fechnac;
    private char estado;
    private char genero;
    private DateTime feching;
    private double sueldo;
    private int antig;
    public CARGOS cargo;

    public string Nombre { get => nombre; set => nombre = value; }
    public string Apellido { get => apellido; set => apellido = value; }
    public DateTime FechNac { get => fechnac; set => fechnac = value; }
    public char Estado { get => estado; set => estado = value; }
    public char Genero { get => genero; set => genero = value; }
    public DateTime FechIng { get => feching; set => feching = value; }
    public double Sueldo { get => sueldo; set => sueldo = value; }
    public int Antig { get => antig; set => antig = value; }

    public int Antiguedad(DateTime FechIng){
        DateTime FechaHoy;
        FechaHoy = DateTime.Now;
        return(FechaHoy.Year-FechIng.Year);
    }
    public int Edad(DateTime FechNac){
        DateTime FechaHoy;
        FechaHoy = DateTime.Now;
        return(FechaHoy.Year-FechNac.Year);
    }
    public int Jubilacion(DateTime FechIng, char Genero){
        DateTime FechaHoy;
        FechaHoy = DateTime.Now;
        int a=0;
        switch (Genero){ 
            case 'M':a=65;break;
            case 'F':a=60;break;
        }
        return(a-Antig);
    }
    public double Salario(double Sueldo, int cargo, int Antig, char Estado){
        double Add=Antig;
        if (Add>=20){
            Add=Sueldo*25/100;
        }else{
            Add=Sueldo*Add/100;
        }
        
        switch (cargo){
            case 3 : Add=Add+Add*50/100;break; 
            case 4 : Add=Add+Add*50/100;break; 
        }
        if (Estado=='C'){
            Add=Add+15000;
        }
        return(Sueldo+Add);
    }
}