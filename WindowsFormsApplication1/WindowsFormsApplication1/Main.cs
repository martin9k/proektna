using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace WindowsFormsApplication1
{
    public partial class Main : Form
    {

        
        
       
        public int speed_left = 4;//brzina na topkata
        
        public int speed_top = 4;
        public int poen = 0;//poen
        public Main()
        {
            Cursor.Hide();
            InitializeComponent();
            timer1.Enabled = true;
            Cursor.Hide();//ja krie strelkata
            this.FormBorderStyle = FormBorderStyle.None;//otstranuva granici
            this.TopMost = true;//ja donesuva formata napred
            this.Bounds = Screen.PrimaryScreen.Bounds;//ja pravi na cel ekran
            raket.Top = igraliste.Bottom-(igraliste.Bottom/10);//ja odreduva pozicijata na raketot
            label1.Text = "Poeni:   " + poen;
            textBox1.Text = Form1.prenos;
            label2.Text = textBox1.Text;
            igrazavrsi.Left = (igraliste.Width / 2) - (igrazavrsi.Width/2);//centriranje
            igrazavrsi.Top = (igraliste.Height / 2) - (igrazavrsi.Height / 2);
            igrazavrsi.Visible = false;
            
        }
        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=G:\PROEKTNA-NOVA-VERZIJA\PROEKTNA\DATA1.MDF;Integrated Security=True;Connect Timeout=30;User Instance=True");
        private void timer1_Tick(object sender, EventArgs e)
        {
            raket.Left = Cursor.Position.X -(raket.Width/2);//namesti go centarot na raketot na pozicijata na strelkata
            topka.Left += speed_left;//dvizenje na topkata
            topka.Top += speed_top;
            if (topka.Bottom >= raket.Top && topka.Bottom <= raket.Bottom && topka.Left>= raket.Left && topka.Right <= raket.Right)//raketa kolizija
            {
                speed_top += 2; 
                speed_left += 2;
                speed_top = -speed_top;//menuvanje na dvizenjeto
                poen += 1;
                label1.Text = "Poeni:   " + poen;
                listBox1.Text= poen.ToString();

            }
            if (topka.Bottom >= raket.Top && topka.Bottom <= raket.Bottom && topka.Left >= raket.Left && topka.Right <= raket.Right)
            {
                Random r = new Random(System.Environment.TickCount);
                const int min = 0;
                const int max = 255;
                igraliste.BackColor = Color.FromArgb(r.Next(min, max), r.Next(min, max), r.Next(min, max));
            }

            if (topka.Left <= igraliste.Left)
            {
                speed_left = -speed_left;
            }
            if (topka.Right >= igraliste.Right)
            {
                speed_left = -speed_left;
            }
            if (topka.Top <= igraliste.Top)
            {
                speed_top = -speed_top;
            }
            if(topka.Bottom>=igraliste.Bottom)
            {
                timer1.Enabled = false;//topkata e nadvor iskluci igra
               igrazavrsi.Visible = true;
               SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=G:\PROEKTNA-NOVA-VERZIJA\PROEKTNA\DATA1.MDF;Integrated Security=True;Connect Timeout=30;User Instance=True");
               con.Open();
               string sql = "INSERT INTO Score(poeni,username) VALUES('" + listBox1.Text + "','" + textBox1.Text + "')";
               SqlCommand cmd = new SqlCommand(sql, con);
               cmd.ExecuteNonQuery();              
            }
        }

        private void Main_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Escape){this.Close();}//escape za izlez
            if (e.KeyCode == Keys.F1)
            {
                topka.Top = 50;
                topka.Left = 50;
                speed_left = 4;
                speed_top = 4;
                poen = 0;
                label1.Text = "Poeni:   " + poen;
                timer1.Enabled = true;
                igrazavrsi.Visible = false;
            }
            if (e.KeyCode == Keys.F2)
            {       this.Hide();
            Form2 m = new Form2();
                m.Show();
            }
        }

        
       
  
    }
}
