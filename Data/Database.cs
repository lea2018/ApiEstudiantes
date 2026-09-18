using Microsoft.Data.SqlClient;

namespace ApiEstudiantes.Data
{
    public class Database
    {
        private readonly IConfiguration _configuration;

        public Database(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public SqlConnection CreateConnection()
        {
            var connectionString = _configuration.GetConnectionString("DBEstudiantes");

            if (string.IsNullOrWhiteSpace(connectionString))
            {
                throw new InvalidOperationException(
                    "No se encontró la cadena de conexión 'DBEstudiantes'."
                );
            }

            return new SqlConnection(connectionString);
        }
    }
}
