using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bulanık_Mantık___Çamaşır_Makinesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        BulanikMantik bulanik;

        private void TrackBar1_ValueChanged(object sender, EventArgs e)
        {
            trackandlabel(tbhassaslik, lblHassas);
        }
        private void tbMiktar_ValueChanged(object sender, EventArgs e)
        {
            trackandlabel(tbmiktar, lblMiktar);
        }
        private void tbKirli_ValueChanged(object sender, EventArgs e)
        {
            trackandlabel(tbkirlilik, lblKirli);
        }

        private void trackandlabel(TrackBar track, Label lbl)
        {
            if (track.Value <10)
            {
                lbl.Text = "0," + track.Value.ToString();
            }
            else if (track.Value > 10 && track.Value < 100)
            {
                lbl.Text = track.Value.ToString().Substring(0, 1) + "," + track.Value.ToString().Substring(1);
            }
            else if (track.Value == 100)
            {
                lbl.Text = "10,0";
            }

            Durum();
        }



        void Durum()
        {
            bulanik = new BulanikMantik(Convert.ToDouble(lblHassas.Text), Convert.ToDouble(lblMiktar.Text), Convert.ToDouble(lblKirli.Text));
            lbhassaslık.Text = bulanik.Durum()[0];
            lMiktar.Text = bulanik.Durum()[1];
            lKirlilik.Text = bulanik.Durum()[2];
        }


        void Listgöster()
        {
            double x=1;
            list_göster.Columns.Clear();
            list_göster.Columns.Add("Sıra", (int)(50), HorizontalAlignment.Center);
            list_göster.Columns.Add("Hassaslık", (int)(90), HorizontalAlignment.Center);
            list_göster.Columns.Add("Miktar", (int)(70 ), HorizontalAlignment.Center);
            list_göster.Columns.Add("Kirlilik", (int)(70), HorizontalAlignment.Center);
            list_göster.Columns.Add("DönüşHızı", (int)(130), HorizontalAlignment.Center);
            list_göster.Columns.Add("Süre", (int)(120), HorizontalAlignment.Center);
            list_göster.Columns.Add("Deterjan", (int)(90), HorizontalAlignment.Center);
            list_göster.View = View.Details;
        }
        void KurallariDoldur()
        {
            list_göster.Items.Clear();

            for (int i = 0; i < 27; i++)
            {
                ListViewItem satir = new ListViewItem((i+1).ToString());
                for (int j = 0; j < 6; j++)
                {
                    satir.SubItems.Add(Kural.clastablomuz[i, j]);
                }
                list_göster.Items.Add(satir);
            }
        }

        void tablorenk_ata()
        {
            int sira = 0;
            int[] tablodanGelenler = new int[8];

            string[,] kural = Kural.clastablomuz; 
            for (int i = 0; i < 27; i++)
            {
                if (
                    bulanik.hassaslik.IndexOf(kural[i,0])!=-1 &&
                    bulanik.miktarı.IndexOf(kural[i, 1]) != -1 &&
                    bulanik.kirlilik.IndexOf(kural[i, 2]) != -1
                    )
                {
                    list_göster.Items[i].Selected = true;
                    list_göster.Items[i].ForeColor = Color.WhiteSmoke;
                    list_göster.Items[i].BackColor = Color.DarkGray;
                    tablodanGelenler[sira] = i;
                    sira++;
                }
            }
            label1.Text = bulanik.hassasdegeri[1].ToString() + "    " + bulanik.miktardegeri[0].ToString() + "    " + bulanik.kirlilikdegeri[0].ToString();
            label2.Text= bulanik.hassasdegeri[1].ToString() + "    " + bulanik.miktardegeri[0].ToString() + "    " + bulanik.kirlilikdegeri[1].ToString();
            label3.Text = bulanik.hassasdegeri[1].ToString() + "    " + bulanik.miktardegeri[1].ToString() + "    " + bulanik.kirlilikdegeri[0].ToString();



        }



        private void Form1_Load(object sender, EventArgs e)
        {
            trackandlabel(tbhassaslik, lblHassas);
            trackandlabel(tbmiktar, lblMiktar);
            trackandlabel(tbkirlilik, lblKirli);
            Listgöster();
            Durum();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (lKirlilik.Text!="---")
            {
            KurallariDoldur();
            tablorenk_ata();
                return;
            }
            MessageBox.Show("Değerler girilmemiş!!!");
            tablorenk_ata();
        }
        private void label5_Click(object sender, EventArgs e)
        {

        }

        

        private void chart2_Click(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        
    }
}
