namespace EspacioCalculadora;
// using System;

public class Calculadora{
    private double dato=0;
    public double Resultado { get => dato;}
    public void Suma(double termino){
        dato=dato+termino;
    }
    public void Resta(double termino){
        dato=dato-termino;
    }
    public void Mult(double termino){
        dato=dato*termino;
    }
    public void Div(double termino){
        dato=dato/termino;
    }
    public void Limpiar(){
        dato=0;
    }
}
