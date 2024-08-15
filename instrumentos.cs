namespace instrumentos
{
    class Instrumentos
    {
        public string Nombre { get; set; }
        public string TipoInstrumento { get; set; }

        public Instrumentos(string nombre, string tipoInstrumento)
        {
            Nombre = nombre;
            TipoInstrumento = tipoInstrumento;
        }

        public void MostrarInfo()
        {
            Console.WriteLine($"Tipo: {TipoInstrumento}\nNombre: {Nombre}");
        }
    }

    class InstrumentoDeViento : Instrumentos
    {
        public InstrumentoDeViento(string nombre, string tipoInstrumento)
            : base(nombre, tipoInstrumento) { }

        public void MostrarInformacion()
        {
            MostrarInfo();
        }
    }

    class InstrumentoDePercusion : Instrumentos
    {
        public InstrumentoDePercusion(string nombre, string tipoInstrumento)
            : base(nombre, tipoInstrumento) { }

        public void MostrarInformacion()
        {
            MostrarInfo();
        }
    }

    class InstrumentoDeCuerda : Instrumentos
    {
        public int CantidadCuerdas { get; set; }

        public InstrumentoDeCuerda(string nombre, string tipoInstrumento, int cantidadCuerdas)
            : base(nombre, tipoInstrumento)
        {
            CantidadCuerdas = cantidadCuerdas;
        }

        public void MostrarInformacion()
        {
            MostrarInfo();
            Console.WriteLine($"Cantidad de cuerdas: {CantidadCuerdas}");
        }
    }

    class Guitarra : InstrumentoDeCuerda
    {
        public Guitarra(string nombre, string tipoInstrumento, int cantidadCuerdas)
            : base(nombre, tipoInstrumento, cantidadCuerdas) { }
    }

    class Flauta : InstrumentoDeViento
    {
        public Flauta(string nombre, string tipoInstrumento)
            : base(nombre, tipoInstrumento) { }
    }

    class Tambor : InstrumentoDePercusion
    {
        public Tambor(string nombre, string tipoInstrumento)
            : base(nombre, tipoInstrumento) { }
    }

    class Program
    {
        static void Main()
        {
            InstrumentoDeCuerda unaGuitarra = new Guitarra("PIPI", "Guitarra", 6);
            InstrumentoDePercusion unTambor = new Tambor("tambor", "Percusión");
            InstrumentoDeViento unaFlauta = new Flauta("flautelin", "Viento");

            unaGuitarra.MostrarInformacion();
            unaFlauta.MostrarInformacion();
            unTambor.MostrarInformacion();
        }
    }
}
