namespace practicaNumero9000 {
    class Program
    {
        
        static void Main()
        {
            Reserva reservaPremium = new Reserva(Destinos.BRASIL, Actividades.FUTBOL_BRASILERO, 10000, 100);
            Cliente unCliente = new Cliente
            {
                Id = 1,
                Nombre = "Pablito",
                Reserva = reservaPremium
            };

            reservaPremium.MostrarDetallesPaquete();
        }

    }

}