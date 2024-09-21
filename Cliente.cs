namespace practicaNumero9000
{
    internal class Cliente
    {
        private String _nombre;
        private Int32 _id;
        private Reserva reservaCliente;

        public String Nombre { get { return _nombre; } set { _nombre = value; } }
        public Int32 Id { get { return _id; } set { _id = value; } }
        public Reserva Reserva { get { return reservaCliente; } set { reservaCliente = value; } }

    }
}
