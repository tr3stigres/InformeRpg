class Program
{


    public static void Main()
    {

        try
        {

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

        }
        catch (Exception error)
        {
            Console.WriteLine($"Se ha producido el siguiente error: {error.Message}");
        }
    }

    

}

