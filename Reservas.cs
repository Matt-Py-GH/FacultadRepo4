namespace practicaNumero9000
{
    internal class Reserva
    {
        private Destinos _destino;
        private Actividades _actividad;
        private float _precio;
        private int _duracion;

        public Destinos Destino { get { return _destino; } set { _destino = value; } }
        public Actividades Actividad { get { return _actividad; } set { _actividad = value; } }
        public float Precio { get { return _precio; } set { _precio = value; } }
        public int Duracion { get { return _duracion; } set { _duracion = value; } }

        public Reserva(Destinos destino, Actividades actividad, float precio, int duracion)
        {
            _destino = destino;
            _actividad = actividad;
            _precio = precio;
            _duracion = duracion;
        }

        public void MostrarDetallesPaquete()
        {
            Console.WriteLine($"Destino:{Destino}\nActividad:{Actividad}\nDuracion:{Duracion}\nPrecio:{Precio}");
        }
    }
}
