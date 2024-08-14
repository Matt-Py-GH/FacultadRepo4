abstract class Empleado
{
    private string _nombre;
    private float _salario;
    protected float Salario { get { return _salario; } set { _salario = value; } }
    protected string Nombre { get { return _nombre; } set { _nombre = value; } }

    public Empleado(string nombre, float salario)
    {
        _nombre = nombre;
        _salario = salario;
    }
    public abstract void MostrarInformacion();

}

class Gerente : Empleado
{
    private string _departamento;

    public Gerente(string departamento, string nombre, float salario) : base(nombre, salario)
    {
        _departamento = departamento;
    }

    public override void MostrarInformacion()
    {
        Console.WriteLine($"Detalles de este empleado\nNombre: {Nombre}\nDepartamento: {_departamento}\nSalario: {Salario}");
    }
}


abstract class Vehiculo
{
    public string Marca { get; set; }
    public string Modelo { get; set; }

    public Vehiculo(string modelo, string marca)
    {
        Modelo = modelo;
        Marca = marca;
    }

    public abstract void MostrarDetalles();
}

class Auto : Vehiculo
{

    private int _cantidadPuertas;
    public int CantidadPuertas
    {

        get { return _cantidadPuertas; }
        set
        {
            if (value > 5 || value < 1)
            {
                Console.WriteLine("Cantidad de puertas inválida...");
                value = 2;
            }
            else
            {
                _cantidadPuertas = value;
            }
        }
    }

    public Auto (int cantidadPuertas, string modelo, string marca) : base (modelo, marca)
    {
        _cantidadPuertas = cantidadPuertas;
    }

    public override void MostrarDetalles()
    {
        Console.WriteLine($"Detalles: {Marca} {Modelo}, {CantidadPuertas} puertas");
    }

}

class Program
{
    static void Main()
    {
        Vehiculo unAuto = new Auto(3, "Renault", "Megane");
        unAuto.MostrarDetalles();

        Console.WriteLine("\n");

        Empleado unEmpleado = new Gerente("Ingeniería","Sargento pérez", 8000);
        unEmpleado.MostrarInformacion();
    }
}
