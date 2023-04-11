using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace todolist_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static List<string>
           YapılacaklarListesi = new List<string>();

        public static List<string>
           TamamlananlarListesi = new List<string>();

        private List<TodoItem> Gorevlerim = new List<TodoItem>(); 

        private void ListeleriDoldur()



        {
            this.lstTamamlananlarListesi.Items.Clear();
            this.clbYapılacaklarListesi.Items.Clear();
            foreach (TodoItem gorev in Gorevlerim)
            {

                if (gorev.Tamamlandi == false)
                    this.clbYapılacaklarListesi.Items.Add(gorev);
                else
                    this.lstTamamlananlarListesi.Items.Add(gorev);
            }
        }


        private void yeniToolStripButton_Click(object sender, EventArgs e)
        {
            TodoItem yeniGörev = new TodoItem()
            {
                Id = Guid.NewGuid(),
                GorevMetni = txtYeniGörev.Text,
                Tamamlandi = false
            };
            
            this.Gorevlerim.Add(yeniGörev);
            this.ListeleriDoldur();
            
           // this.clbYapılacaklarListesi.Items.Add(yeniGörev);
        }

        private void mnuHakkında_Click(object sender, EventArgs e)
        {

        }

        private void btnDüzelt_Click(object sender, EventArgs e)
        {
            if (clbYapılacaklarListesi.SelectedIndex == -1)
                MessageBox.Show("Lütfen düzeltme işlemi için bir görev seçiniz.");
                return;
            TodoItem gorev = (TodoItem)clbYapılacaklarListesi.SelectedItem;

            gorev.GorevMetni = txtYeniGörev.Text;

            this.ListeleriDoldur();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            //clbYapılacaklarListesi.Items.Remove(clbYapılacaklarListesi.SelectedItem);
            if (clbYapılacaklarListesi.SelectedIndex == -1)
                MessageBox.Show("Lütfen silme işlemi için bir görev seçiniz.");
            return;

            this.Gorevlerim.Remove((TodoItem)clbYapılacaklarListesi.SelectedItem);

            this.ListeleriDoldur();


        }

        private void clbYapılacaklarListesi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (clbYapılacaklarListesi.SelectedIndex == -1)
                return;

            TodoItem gorev = (TodoItem)clbYapılacaklarListesi.SelectedItem;
            txtYeniGörev.Text = gorev.GorevMetni;
        }

        private void btnKes_Click(object sender, EventArgs e)
        {
            txtYeniGörev.Cut();
        }

        private void btnKopyala_Click(object sender, EventArgs e)
        {
            txtYeniGörev.Copy();
        }

        private void btnYapıştır_Click(object sender, EventArgs e)
        {
            txtYeniGörev.Paste();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtYeniGörev.Text = string.Empty;
        }

        private void clbYapılacaklarListesi_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if(e.NewValue == CheckState.Checked)
            {
                TodoItem gorev = (TodoItem)clbYapılacaklarListesi.SelectedItem;
                gorev.Tamamlandi = true;
                gorev.TamamlanmaTarihi = DateTime.Now;

                
            }
        }

        private void clbYapılacaklarListesi_MouseUp(object sender, MouseEventArgs e)
        {
            if (clbYapılacaklarListesi.CheckedItems.Count < 0)
                this.ListeleriDoldur();
                this.ListeleriDoldur();
            
        }

        private void mnuÇıkış_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mnuYardım_Click(object sender, EventArgs e)
        {

        }

        private void mnuUglHakkında_Click(object sender, EventArgs e)
        {
            AboutBox1 about = new AboutBox1();
            about.ShowDialog();

        }
    }
}
