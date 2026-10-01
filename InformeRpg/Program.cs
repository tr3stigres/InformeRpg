class Program
{


    public static void Main()
    {

        try
        {

            Console.WriteLine("Informe con datos");
            var jugadores = new List<Ficha>
            {
                new ("Ada", 80, "Mago"),
                new ("Bruno", 0, "Guerrero"),
                new ("Carla", 50, "Mago"),
                new ("Diego", 100, "Guerrero"),
                new ("Eva", 0, "Mago")
            };

            Informe1 informe = new Informe1(jugadores);
            informe.GenerarInforme();

            Console.WriteLine("\n\nInforme vacío");
            jugadores = new List<Ficha>{};
            informe = new Informe1(jugadores);
            informe.GenerarInforme();

            Console.WriteLine("\n\nInforme con solo Bruno y vida 0");
            jugadores = new List<Ficha>
            {
                new ("Bruno", 0, "Guerrero")
            };
            informe = new Informe1(jugadores);
            informe.GenerarInforme();

            Console.WriteLine("\n\nInforme con todos vida = 50");
            jugadores = new List<Ficha>
            {
                new ("Ada", 50, "Mago"),
                new ("Bruno", 50, "Guerrero"),
                new ("Carla", 50, "Mago"),
                new ("Diego", 50, "Guerrero"),
                new ("Eva", 50, "Mago")
            };
            informe = new Informe1(jugadores);
            informe.GenerarInforme();




        }
        catch (Exception error)
        {
            Console.WriteLine($"Se ha producido el siguiente error: {error.Message}");
        }
    }

    

}

