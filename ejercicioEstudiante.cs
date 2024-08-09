class Estudiante
{

    private string _nombre;
    private int _legajo;
    private float _promedio;

    public Estudiante(string nombre, int legajo, float promedio)
    {
        _nombre = nombre;
        _legajo = legajo;
        _promedio = promedio;
    }

    public float promedio
    {
        get { return _promedio; }
        set
        {
            if (value < 0 || value > 10)
            {
                Console.WriteLine("Error, promedio no válido, debe ser del 1 al 10");
                _promedio = 0;
            }
            else
            {
                _promedio = value;
            }
        }
    }


    public void ActualizarPromedio()
    {
        int sumaTotal = 0;
        Console.WriteLine("Introduzca la cantidad de notas a promediar: \n");
        int cantidadNotas = int.Parse(Console.ReadLine());
        int[] notas = new int[cantidadNotas];

        for (int i = 0; i < notas.Length; i++)
        {
            Console.WriteLine("Introduzca la nota: \n");
            int nota = int.Parse(Console.ReadLine());
            sumaTotal += nota;
        }

        int promedioNotas = sumaTotal / cantidadNotas;

        promedio = promedioNotas;
    }


}

class Program
{

    static void Main()
    {

        Estudiante mateo = new Estudiante("Mateo", 17773, 8);
        mateo.ActualizarPromedio();
        Console.WriteLine($"El promedio de este alumno es: {mateo.promedio}");

    }

    //getch();

}