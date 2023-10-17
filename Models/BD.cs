using System.Collections.Generic;
using System.Data.SqlClient;
using Dapper;

namespace TP10.Models
{
    public static class BD
    {
        private static string ConnectionString = @"Server=localhost; Database=BDSeries; Trusted_Connection=True";

        public static List<Serie> GetSeries()
        {
            using (SqlConnection db = new SqlConnection(ConnectionString))
            {
                return db.Query<Serie>("SELECT * FROM Series").ToList();
            }
        }

        public static List<Temporada> GetTemporadas(int idSerie)
        {
            using (SqlConnection db = new SqlConnection(ConnectionString))
            {
                return db.Query<Temporada>("SELECT * FROM Temporadas WHERE IdSerie = @idSerie", new { idSerie }).ToList();
            }
        }

        public static List<Actor> GetActores(int idSerie)
        {
            using (SqlConnection db = new SqlConnection(ConnectionString))
            {
                return db.Query<Actor>("SELECT * FROM Actores WHERE IdSerie = @idSerie", new { idSerie }).ToList();
            }
        }
    }
}
