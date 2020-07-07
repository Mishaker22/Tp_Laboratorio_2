using Entidades.SQL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Entidades
{
    public class Aula
    {
        private int idAula;
        private string salita;
        private List<Aula> listSalitas;

        #region Propiedades
        public int IdAula
        {
            get { return this.idAula; }
            set { this.idAula = value; }
        }
        public String Salita
        {
            get { return this.salita; }
            set { this.salita = value; }
        }
        public List<Aula> ListaAulas
        {
            get { return this.listSalitas; }
            set { this.listSalitas = value; }
        }
        #endregion

        #region Constructor
        public Aula()
        {
            this.listSalitas = AulaDAO.SelectAll();
        }
        public Aula(int id, string sala)
        {
            this.IdAula = id;
            this.Salita = sala;
        }
        #endregion

        #region Metodos
        
        
        public string MostrarAula()
        {
            return this.Salita;
        }
        #endregion
    }
}
