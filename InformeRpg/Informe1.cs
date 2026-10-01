public class Informe1 : Informe
{
    public IEnumerable<Ficha> FichaDatos { get; }
    public Informe1(IEnumerable<Ficha> fichaDatos) : base(fichaDatos)
    {
        FichaDatos = fichaDatos;
    }

    public override void GenerarInforme()
    {
        bool vacia = FichaDatos.Count() == 0;
        double media = 0;
        int derrotados = 0;
        var resContar = FichaDatos.GroupBy(j => j.Tipo).Select(g => new { Tipo = g.Key, Cantidad = g.Count() }).ToList();
        
        if (!vacia)
        {
            var resMedia = FichaDatos.Average(j => j.Vida);
            media = (double)resMedia;
            var resDerrotados = FichaDatos.Where(j => j.Vida == 0).Select(j => j.Nombre).ToList();
            derrotados = (int)resDerrotados.Count;          
        }
        Console.WriteLine($"Media de vida: {media:F2}");
        Console.WriteLine($"Derrotados: {derrotados}");
        Console.WriteLine("\nAgrupaciones:");
        if (!resContar.Any())
        {
            Console.WriteLine("No hay datos para mostrar agrupaciones.");
        }
        else
        {
            foreach (var j in resContar)
            {
                Console.WriteLine($"{j.Tipo}: {j.Cantidad}");
            }
        }
    }
}
