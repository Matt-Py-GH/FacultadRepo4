using System;


abstract class Figura
{
    protected int BaseFigura { get; set; }
    protected int AlturaFigura { get; set; }

    public Figura(int baseFigura, int alturaFigura)
    {
        BaseFigura = baseFigura;
        AlturaFigura = alturaFigura;
    }

    public abstract void CalcularArea();
}

class Cuadrado : Figura
{
    public Cuadrado(int baseFigura, int alturaFigura) : base(baseFigura, alturaFigura) { }

    public override void CalcularArea()
    {
        Console.WriteLine($"El area del cuadrado es: {BaseFigura * AlturaFigura}");

    }
}

class Circulo
{

    protected int RadioCirculo;
    public Circulo(int radioCirculo)
    {
        RadioCirculo = radioCirculo;
    }

    public void CalcularArea()
    {
        Console.WriteLine($"El area del cuadrado es: {3.14 * RadioCirculo}");

    }
}
class Empleado
{
    protected string nombreEmpleado;
    protected int DNIEmpleado;
    protected int horasDeTrabajo;

    public Empleado(string Nombre, int DNI, int Horas)
    {
        nombreEmpleado = Nombre;
        DNIEmpleado = DNI;
        horasDeTrabajo = Horas;

    }

    public void Despedir()
    {
        Console.WriteLine($"Used ha despedido al empleado {this.nombreEmpleado}");
    }

}

class Program
{
    static void Main()
    {
        Cuadrado unCuadradoRandom = new Cuadrado(8, 8);
        unCuadradoRandom.CalcularArea();

        Circulo unCirculoRandom = new Circulo(5);
        unCirculoRandom.CalcularArea();

        Empleado jorgito = new Empleado("Jorge", 45899011, 4);
        Empleado pablito = new Empleado("Pablo", 21134352, 8);

        jorgito.Despedir();

    }


}

Figura unCuadrado = new Cuadrado(parameters);


se puede hacer eso y no se puede solo generar una figura porque es abstracta


podemos hacer uso del polimorfismo con las funciones para calcular distintas areas, la del cuadrado y la del circulo, revisar eso con el override

