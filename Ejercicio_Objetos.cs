abstract class Figura
{
    
    public Figura(){}

    public abstract void CalcularArea();
}

class Cuadrado : Figura { 

    protected int BaseFigura { get; set; }
    protected int AlturaFigura { get; set; }

    public Cuadrado(int baseFigura, int alturaFigura) : base() {

        BaseFigura = baseFigura;
        AlturaFigura = alturaFigura;    
    
    }

    public override void CalcularArea()
    {
        Console.WriteLine($"El area del cuadrado es: {BaseFigura * AlturaFigura}");

    }
}

class Circulo : Figura { 

    protected float RadioCirculo { get; set; }

    public Circulo(float radioCirculo) : base() {

        RadioCirculo = radioCirculo;
    
    }
 
    public override void CalcularArea()
    {
        Console.WriteLine($"El area del circulo es: {Math.PI * RadioCirculo * RadioCirculo}");

    }
}

class Program
{
   
    static void Main()
    {
        Figura unCuadradoRandom = new Cuadrado(7, 7);
        unCuadradoRandom.CalcularArea();

        Figura unCirculoRandom = new Circulo(5);
        unCirculoRandom.CalcularArea();

    }

}
