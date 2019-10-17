using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Labirent
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Point baslangicNoktasi = panel1.Location;
            baslangicNoktasi.Offset(30, 30);
            Cursor.Position = PointToScreen(baslangicNoktasi);
        }

        private void Finish_Enter(object sender, EventArgs e)
        {
            MessageBox.Show("you won");
        }

        private void Label1_MouseEnter(object sender, EventArgs e)
        {
            if (MessageBox.Show("Kaybettiniz Tekrar Oynamak İster Misiniz ?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                Point baslangicNoktasi = panel1.Location;
                baslangicNoktasi.Offset(30, 30);
                Cursor.Position = PointToScreen(baslangicNoktasi);
            }
            else
            {
                this.Close();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Bitmap bm = new Bitmap(Properties.Resources.iconfinder_Poke_Ball_1703896,20, 20);
            this.Cursor = new Cursor(bm.GetHicon());
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

            if(e.KeyCode == Keys.A)
            {
                this.Cursor = new Cursor(Cursor.Current.Handle);
                Cursor.Position = new Point(Cursor.Position.X - 10, Cursor.Position.Y);
            }

            if (e.KeyCode == Keys.S)
            {
                this.Cursor = new Cursor(Cursor.Current.Handle);
                Cursor.Position = new Point(Cursor.Position.X, Cursor.Position.Y + 10);
            }

            if (e.KeyCode == Keys.D)
            {
                this.Cursor = new Cursor(Cursor.Current.Handle);
                Cursor.Position = new Point(Cursor.Position.X + 10, Cursor.Position.Y);
            }

            if (e.KeyCode == Keys.W)
            {
                this.Cursor = new Cursor(Cursor.Current.Handle);
                Cursor.Position = new Point(Cursor.Position.X, Cursor.Position.Y - 10);
            }
        }

    
    }
}
