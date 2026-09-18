using ApiEstudiantes.Data;
using ApiEstudiantes.Models;
using Dapper;
using Microsoft.AspNetCore.Mvc;

namespace ApiEstudiantes.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EstudiantesController : ControllerBase
    {
        private readonly Database _database;

        public EstudiantesController(Database database)
        {
            _database = database;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Estudiante>>> ObtenerEstudiantes()
        {
            try
            {
                using var connection = _database.CreateConnection();

                var estudiantes = await connection.QueryAsync<Estudiante>(
                    @"SELECT 
                        id_estudiante AS IdEstudiante,
                        nombre AS Nombre,
                        apellido AS Apellido,
                        matricula AS Matricula,
                        fecha_nacimiento AS FechaNacimiento,
                        fecha_ingreso AS FechaIngreso,
                        carrera AS Carrera,
                        correo AS Correo,
                        telefono AS Telefono
                      FROM estudiantes
                      ORDER BY id_estudiante ASC"
                );

                return Ok(estudiantes);
            }
            catch (Exception ex)
            {
                return StatusCode(500, new
                {
                    mensaje = "Error al consultar la base de datos",
                    error = ex.Message
                });
            }
        }

        [HttpPost]
        public async Task<ActionResult> CrearEstudiante(Estudiante estudiante)
        {
            try
            {
                using var connection = _database.CreateConnection();

                var sql = @"
                    INSERT INTO estudiantes
                    (nombre, apellido, matricula, fecha_nacimiento, fecha_ingreso, carrera, correo, telefono)
                    VALUES
                    (@Nombre, @Apellido, @Matricula, @FechaNacimiento, @FechaIngreso, @Carrera, @Correo, @Telefono)";

                await connection.ExecuteAsync(sql, estudiante);

                return Ok(new
                {
                    mensaje = "Estudiante guardado correctamente"
                });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new
                {
                    mensaje = "Error al guardar el estudiante",
                    error = ex.Message
                });
            }
        }
    }
}