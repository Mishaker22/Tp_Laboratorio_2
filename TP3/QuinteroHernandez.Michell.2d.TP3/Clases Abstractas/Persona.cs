using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Excepciones;

namespace Clases_Abstractas
{
    public abstract class Persona
    {
        #region enumerado
        public enum ENacionalidad
        {
            Argentino,
            Extranjero
        }
        #endregion

        string nombre;
        private string apellido;
        private int dni;
        private ENacionalidad nacionalidad;

        #region Propiedades
        /// <summary>
        /// retorna el nombre de una persona, y lo setea, valida que el nombre sea valido.
        /// </summary>
        public string Nombre
        {
            get { return this.nombre; }
            set
            {
                if (ValidarNombreApellido(value) != null)
                {
                    this.apellido = value;
                }
            }
        }
        /// <summary>
        /// retorna el apellido de una persona y lo setea, valida que el nombre sea valido.
        /// </summary>
        public string Apellido
        {
            get { return this.apellido; }
            set
            {
                if (ValidarNombreApellido(value) != null)
                {
                    this.apellido = value;
                }
            }
        }
        /// <summary>
        /// retorna el dni de una persona, y setea el dni y valida que coincida con la nacionalidad.
        /// </summary>
        public int DNI
        {
            get { return this.dni; }
            set
            {
                try
                {
                    this.dni = ValidarDni(this.nacionalidad, value);

                }
                catch (DniInvalidoException e)
                {

                    throw e;
                }
            }
        }

        public ENacionalidad Nacionalidad
        {
            get { return this.nacionalidad; }
            set
            {
                try
                {
                    ValidarDni(value, this.dni);
                    this.nacionalidad = value;
                }
                catch (DniInvalidoException)
                {

                    throw new NacionalidadInvalidaException("La nacionalidad No coincide con el dni de la persona");
                }
            }
        }
        /// <summary>
        /// setea el string del valor del dni de una persona, se verifica que sea valido y coincida con la nacionalidad e una persona
        /// </summary>
        public string StringToDNI
        {
            set { this.dni = ValidarDni(this.nacionalidad, value); }
        }

        #endregion

        #region Constructores 
        /// <summary>
        /// constructor por defecto
        /// </summary>
        public Persona()
        {

        }

        public Persona(string nombre, string apellido, ENacionalidad nacionalidad) : this()
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.nacionalidad = nacionalidad;
        }
        public Persona(string nombre, string apellido, int dni, ENacionalidad nacionalidad) : this(nombre, apellido, nacionalidad)
        {
            this.dni = dni;
        }
        public Persona(string nombre, string apellido, string dni, ENacionalidad nacionalidad) : this(nombre, apellido, nacionalidad)
        {
            this.StringToDNI = dni;
        }

        #endregion

        #region Metodos
        /// <summary>
        /// Valida que el numero dni coincida con la nacionalidad correspondiente
        /// </summary>
        /// <param name="nacionalidad"></param>
        /// <param name="dato"></param>
        /// <returns></returns>
        private int ValidarDni(ENacionalidad nacionalidad, int dato)
        {
            if (dato >= 1 && dato <= 89999999)
            {
                if (nacionalidad == ENacionalidad.Argentino)
                {
                    return dato;
                }
                throw new NacionalidadInvalidaException();
            }
            else if (dato >= 90000000 && dato <= 99999999)
            {
                if (nacionalidad == ENacionalidad.Extranjero)
                {
                    return dato;
                }
                throw new NacionalidadInvalidaException();
            }
            else
            {
                throw new NacionalidadInvalidaException("¡¡Numero Fuera de rango!!");
            }
        }
        /// <summary>
        /// Valida que los caracteres sean numeros y verifica que el numero dni coincida con la nacionalidad correspondiente
        /// </summary>
        /// <param name="nacionalidad"></param>
        /// <param name="dato"></param>
        /// <returns></returns>
        private int ValidarDni(ENacionalidad nacionalidad, string dato)
        {
            try
            {
                int numDni = int.Parse(dato);
                return ValidarDni(nacionalidad, numDni);
            }
            catch (FormatException)
            {

                throw new DniInvalidoException("La cadena ingresada tiene caracteres que no corresponden a un numero Dni");
            }
        }
        /// <summary>
        /// Valida que el nombre tenga solo letras y no este vacio
        /// </summary>
        /// <param name="dato"></param>
        /// <returns></returns>
        private string ValidarNombreApellido(string dato)
        {
            if (!string.IsNullOrWhiteSpace(dato))
            {
                Regex rx = new Regex(@"[^A-Za-z\s]");
                if (!rx.IsMatch(dato))
                {
                    return dato;
                }
            }
            return null;

        }
        /// <summary>
        /// Muestra los datos de una persona
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("NOMBRE COMPLETO: {0}, {1} \n ", this.Apellido, this.Nombre);
            sb.AppendFormat("Nacionalidad: " + this.Nacionalidad);
            sb.AppendFormat("\n DNI: " + this.DNI);

            return sb.ToString();
        }
        #endregion

    }

}

