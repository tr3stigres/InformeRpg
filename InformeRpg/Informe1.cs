public class Informe1 : Informe
{
    public List<Ficha> FichaDatos { get; }
    public Informe1(List<Ficha> fichaDatos) : base(fichaDatos)
    {
        FichaDatos = fichaDatos;
    }

    public override void GenerarInforme()
    {
        var res = FichaDatos.Where(j => j.Vida == 0).Select(j => j.Nombre).ToList();
        Console.WriteLine($"Derrotados: {res.Count}");   
    }
}
