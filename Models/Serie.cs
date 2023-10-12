using System;

public class Serie
{
    public int Id { get; set; }
    public string Nombre { get; set; }
    public int AñoInicio { get; set; }
    public string Sinopsis { get; set;}
    public string ImagenSerie { get; set; }
    public List<Temporada> Temporadas { get; set; }
    public List<Actor> Actores { get; set; }
}
