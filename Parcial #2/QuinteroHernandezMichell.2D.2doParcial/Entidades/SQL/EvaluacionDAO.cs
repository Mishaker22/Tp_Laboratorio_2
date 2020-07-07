using Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.SQL
{
    public class EvaluacionDAO:ConexionSQL
    {
        public static void InsertarEvaluaciones(int idAlumno, int idDocente, int idAula, int nota1, int nota2, float notaFinal, string observacion)
        {
            EvaluacionDAO.Comando.CommandText = "INSERT INTO dbo.Evaluaciones (idAlumno, idDocente, idAula, Nota_1, Nota_2, NotaFinal, Observaciones) VALUES (@idAlumno, @idDocente, @idAula, @Nota_1, @Nota_2, @NotaFinal, @Observaciones);";
            EvaluacionDAO.Comando.Parameters.Clear();
            EvaluacionDAO.Comando.Parameters.AddWithValue("@idAlumno", idAlumno);
            EvaluacionDAO.Comando.Parameters.AddWithValue("@idDocente", idDocente);
            EvaluacionDAO.Comando.Parameters.AddWithValue("@idAula", idAula);
            EvaluacionDAO.Comando.Parameters.AddWithValue("@Nota_1", nota1);
            EvaluacionDAO.Comando.Parameters.AddWithValue("@Nota_2", nota2);
            EvaluacionDAO.Comando.Parameters.AddWithValue("@NotaFinal", notaFinal);
            EvaluacionDAO.Comando.Parameters.AddWithValue("@Observaciones", observacion);
            
            EvaluacionDAO.Ejecutar();
        }
    }
}
