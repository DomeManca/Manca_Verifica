using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manca_Verifica
{
    public class Elenco
    {
        private string _id;
        private Voto[] _voti = new Voto[100];

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
        public Voto getVoto(int i)
        {
            return _voti[i];
        }
        public Elenco(string id)
        {
            this.Id = id;
            Svuota();
        }
        private int getNumVoti()
        {
            int i = 0;
            while (i < _voti.Length && _voti[i] != null)
            {
                i++;
            }

            if (i != _voti.Length)
                return i;
            else
                throw new Exception("Il libretto è pieno");
        }
        public void Aggiungi(Voto p)
        {
            if (p != null)
                _voti[getNumVoti()] = p;
            else
                throw new Exception("Inserire un voto valido");
        }
        public Voto Rimuovi(Voto p)
        {
            int pos = Cerca(p);
            if (pos != -1)
            {
                _voti[pos] = null;
                for (int i = pos; i < 99; i++)
                {
                    _voti[i] = _voti[i + 1];
                }
                return p;
            }
            else
                throw new Exception("Voto non esistente!");
        }
        public void Modifica(Voto r, Voto n)
        {
            int i = Cerca(r);
            if (i >= 0)
            {
                _voti[i] = n;
            }
            else
                throw new Exception("Voto non trovato!");
        }
        public int Cerca(Voto p)
        {
            int pos = -1;
            for (int i = 0; i < 99; i++)
            {
                if (_voti[i] == p)
                {
                    pos = i;
                }
            }
            return pos;
        }
        public int MediaMateria(string m)
        {
            int media = 0;
            int somma = 0;
            for (int i = 0; i < 99; i++)
            {
                if (_voti[i] != null)
                {
                    if (_voti[i].Materia == m)
                    {
                        somma = somma + _voti[i].Valutazione;
                        media++;
                    }
                }
            }
            if (media!=0)
                media = somma / media;
            else
                throw new Exception("Media non valida!");
            return media;
        }
        public void Svuota()
        {
            for (int i = 0; i < 100; i++)
            {
                _voti[i] = null;
            }
        }
        public Voto vot(string a)
        {
            Voto p;
            for (int i = 0; i < 99; i++)
            {
                if (_voti[i] != null)
                {
                    if (_voti[i].Id == a)
                    {
                        p = _voti[i];
                        return p;
                    }
                }
            }
            throw new Exception("Voto non esistente!");
        }
        //non va
        public void Ordina()
        {
            int m1, g1, a1;
            int m2, g2, a2;
            for (int i = 0; i < _voti.Length - 1; i++)
            {
                g1 = Convert.ToInt32(_voti[i].Data.Substring(0, 2));
                m1 = Convert.ToInt32(_voti[i].Data.Substring(4, 2));
                a1 = Convert.ToInt32(_voti[i].Data.Substring(7, 4));
                for (int j = i + 1; j < _voti.Length; j++)
                {
                    g2 = Convert.ToInt32(_voti[j].Data.Substring(0, 2));
                    m2 = Convert.ToInt32(_voti[j].Data.Substring(4, 2));
                    a2 = Convert.ToInt32(_voti[j].Data.Substring(7, 4));
                    if (a1 < a2)
                    {
                        Voto tmp = _voti[j];
                        _voti[j] = _voti[j + 1];
                        _voti[j + 1] = tmp;
                    }
                    else if(m1 < m2)
                    {
                        Voto tmp = _voti[j];
                        _voti[j] = _voti[j + 1];
                        _voti[j + 1] = tmp;
                    }
                    else if(g1 < g2)
                    {
                        Voto tmp = _voti[j];
                        _voti[j] = _voti[j + 1];
                        _voti[j + 1] = tmp;
                    }
                }
            }
        }
    }
}  