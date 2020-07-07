using Entidades;
using Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace JardinUtn
{
    public static class Listas
    {
        public static List<Docente> listaDocentes { get; set; } = new List<Docente>();
        public static List<Alumno> listaAlumnos { get; set; } = new List<Alumno>();
        public static List<Aula> lstaAula { get; set; } = new List<Aula>();
        public static List<Thread> hilos { get; set; } = new List<Thread>();

    }
}
