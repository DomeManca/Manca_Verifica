using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manca_Verifica
{
    public class Voto
    {
        string _id;
        string _materia;
        int _valutazione;//in centesimi
        string _data;

        public Voto(string id, string materia,int valutazione, string data)
        {
            Id = id;
            Materia = materia;
            Valutazione = valutazione;
            Data = data;
        }
        public Voto(string id, int valutazione, string data) : this(id, "N/A", valutazione,data)
        {
        }
        public Voto(string id, string materia, string data) : this(id, materia, 6, data)
        {
        }
        public Voto() : this("IDVUOTO", "N/A", 6, "N/A")
        {
        }
        public Voto(string id, string materia, int valutazione) : this(id, materia, valutazione, "N/A")
        {
        }
        public bool Equals(Voto p)
        {
            if (p == null) return false;

            if (this == p) return true;

            return (this.Id == p.Id);
        }
        public string[] ToString()
        {
            string[] p = { Id, Materia, Convert.ToString(Valutazione), Data };
            return p;
        }
        public int Valutazione
        {
            get
            {
                return _valutazione;
            }
            set
            {
                if (value > 0)
                    _valutazione = value;
                else
                    throw new Exception("Il voto deve essere positivo");
            }
        }
        public string Id
        {
            get
            {
                return _id;
            }
            private set
            {
                if (value != null)
                    _id = value;
                else
                    throw new Exception("Inserire un id valido");
            }
        }
        public string Materia
        {
            get
            {
                return _materia;
            }
            private set
            {
                if (value != null)
                    _materia = value;
                else
                    throw new Exception("Inserire una materia valida");
            }
        }
        public string Data
        {
            get
            {
                return _data;
            }
            private set
            {
                if (value != null)
                    _data = value;
                else
                    throw new Exception("Inserire una data valida");
            }
        }
    }
}
