public class Informe1 : Informe
{
    public List<Ficha> FichaDatos { get; }
    public Informe1(List<Ficha> fichaDatos) : base(fichaDatos)
    {
        FichaDatos = fichaDatos;
    }

    public override void GenerarInforme()
    {
        Console.WriteLine("Informe 1: Jugadores con vida mayor a 0");
        foreach (Ficha jugador in FichaDatos)
        {
            if (jugador.Vida > 0)
            {
                Console.WriteLine($"Nombre: {jugador.Nombre}, Vida: {jugador.Vida}, Tipo: {jugador.Tipo}");
            }
        }
    }
}
