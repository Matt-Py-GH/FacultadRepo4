public enum Currency
{
    dolar = 1,
    peso = 2,
    euro = 3
}

public enum TipoUnidad
{
    KG = 1,
    Caja = 2,
    Unidad = 3
}
class Precio
{
    private Currency _currency;

    private float _precioItem;
}

class Producto
{
    private long _id;
    private string _description;
    private int _maxItemsInStock;
    private string _name;
    private Precio _price;
    private int _stock;

    public Producto(long id, string descripcion, int maxItems, string nombre, Precio precio, int stock)
    {
        _id = id;
        _description = descripcion;
        _maxItemsInStock = maxItems;
        _name = nombre;
        _price = precio;
        _stock = stock;
    }

    public int MaxItemsInStock
    {
        get { return _maxItemsInStock; }
        set { if (value <= 0) { Console.WriteLine("ERROR: Maximo de stock invalido..."); }
            else { _maxItemsInStock = value; }
        }
    }

    public int Stock
    {
        get { return _stock; }
        set
        {
            if (value > 0 && value < _maxItemsInStock)
            { _stock = value; }
            else { Console.WriteLine("ERROR: Stock inválido..."); }
        }
    }

    public bool PuntoReorden()
    {
        return _stock < _maxItemsInStock;
    }

    public int ActualizarStock(int cantidad)
    {
        if(cantidad > 0) { _stock += cantidad; }
        else { Console.WriteLine("ERROR: Cantidad invalida..."); }
        return _stock;
        
    }

    public void MostrarDetalles()
    {
        Console.WriteLine($"Detalles:\nStock:{_stock}\nID:{_id}\n");
        Console.WriteLine($"Precio:{_price}\nMaximo de items en stock:{_maxItemsInStock}\n");
        Console.WriteLine($"Nombre:{_name}\nDescripción:{_description}\n");
    }

    public void VistaPrevia()
    {
        Console.WriteLine($"Nombre:{_name}\nID:{_id}");
    }

}

class LineaPedido
{
    private long _id;
    private int _amount;
    private Producto _producto;

    public LineaPedido(long id, int amount, Producto producto, float montoTotal)
    {
        _id = id;
        _amount = amount;
        _producto = producto;
        MontoTotal = montoTotal;
    }

    public void OrdenarItem(int cantidadOrdenada, Producto productoOrdenado)
    {

    }
    public void Ordenar(int cantidad, string nombre, int id, TipoUnidad unidad, float amount, Currency currency)
    {

    }
    public float MontoTotal { get; set; }

}

class Orden
{
    private long _id;
    private List<LineaPedido> _ordenItems;
    private bool _estadoOrden;
    private DateTime _fechaCreacion;
    private DateTime _fechaCumplimiento;
    private string _proveedor;

    public void AñadirItemOrden(LineaPedido item)
    {
        _ordenItems.Add(item);
    }
    public void AñadirProducto(int cantidadAñadida, Producto productoAñadido)
    {

    }

    public void RemoverProducto(LineaPedido item)
    {

    }

    public float CantidadTotal { get; set; }
    public int totalItems { get; set; }

    public void MostrarDetallesOrden()
    {
        Console.WriteLine($"{_id}\n{_ordenItems}\n{_estadoOrden}\n{_fechaCreacion}\n{_fechaCumplimiento}\n{_proveedor}");
    }


}

class Program
{
    static void Main()
    {

    }

}