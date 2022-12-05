using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Manca_Verifica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Elenco libretto = new Elenco("L123");
        int counter = 0;
        public void aggiorna()
        {
            listView1.Items.Clear();
            for (int i = 0; i < 100; i++)
            {
                if (libretto.Cerca(libretto.getVoto(i)) != -1)
                {
                    Voto p = libretto.getVoto(i);
                    if (p != null)
                    {
                        ListViewItem itm;
                        itm = new ListViewItem(p.ToString());
                        listView1.Items.Add(itm);
                    }

                }
            }
        }
        private void aggiungi_Click(object sender, EventArgs e)
        {
            try
            {
                Voto v = new Voto(Convert.ToString(counter), MateriaA.Text, Convert.ToInt32(ValutazioneA.Text), DataA.Text);
                libretto.Aggiungi(v);
                aggiorna();
                counter++;

            }
            catch (Exception eccezione)
            {
                MessageBox.Show(eccezione.Message);
            }
        }
        private void calcola_Click(object sender, EventArgs e)
        {
            try
            {
                label7.Text = MateriaM.Text;
                label8.Text = Convert.ToString(libretto.MediaMateria(MateriaM.Text));
            }
            catch (Exception eccezione)
            {
                MessageBox.Show(eccezione.Message);
            }
        }
        private void Modifica_Click(object sender, EventArgs e)
        {
            try
            {
                string id = VotoMo.Text.Substring(0,1);
                Voto n = libretto.vot(id);
                Voto v = new Voto(n.Id, MateriaMo.Text, Convert.ToInt32(VotoMo.Text), DataMo.Text);
                libretto.Modifica(n, v);
                aggiorna();
            }
            catch (Exception eccezione)
            {
                MessageBox.Show(eccezione.Message);
            }
        }
        private void Elimina_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("Sicuro di voler eliminare?", "Attenzione", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    string id = VotoMo.Text.Substring(0, 1);
                    Voto n = libretto.vot(id);
                    libretto.Rimuovi(n);
                    aggiorna();
                }
            }
            catch (Exception eccezione)
            {
                MessageBox.Show(eccezione.Message);
            }
        }
        private void tabPage3_Enter(object sender, EventArgs e)
        {
            for (int i = 0; i < 99; i++)
            {
                if (libretto.getVoto(i) != null)
                {
                    string ew = libretto.getVoto(i).ToString()[0] + " " + libretto.getVoto(i).ToString()[1] + " " + libretto.getVoto(i).ToString()[2];
                    VotoMo.Items.Add(ew);
                }
            }
        }
        private void seleziona_Click(object sender, EventArgs e)
        {
            try
            {
                string id = VotoMo.Text.Substring(0, 1);
                Voto n = libretto.vot(id);
                MateriaMo.Text = n.Materia;
                ValutazioneMo.Text = n.Valutazione.ToString();
                DataMo.Text = n.Data;
            }
            catch (Exception eccezione)
            {
                MessageBox.Show(eccezione.Message);
            }
        }
        private void tabPage4_Enter(object sender, EventArgs e)
        {
            for (int i = 0; i < 99; i++)
            {
                if (libretto.getVoto(i) != null)
                {
                    string ew = libretto.getVoto(i).ToString()[0] + " " + libretto.getVoto(i).ToString()[1] + " " + libretto.getVoto(i).ToString()[2];
                    VotoE.Items.Add(ew);
                }
            }
        }
        private void tabPage5_Enter(object sender, EventArgs e)
        {
            listView2.Items.Clear();
            libretto.Ordina();
            for (int i = 0; i < 100; i++)
            {
                if (libretto.Cerca(libretto.getVoto(i)) != -1)
                {
                    Voto p = libretto.getVoto(i);
                    if (p != null)
                    {
                        ListViewItem itm;
                        itm = new ListViewItem(p.ToString());
                        listView2.Items.Add(itm);
                    }

                }
            }
        }
        
    }
}
