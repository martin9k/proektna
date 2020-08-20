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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            Cursor.Show();
        }
        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=G:\PROEKTNA-NOVA-VERZIJA\PROEKTNA\DATA1.MDF;Integrated Security=True;Connect Timeout=30;User Instance=True");
        private void Form2_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=G:\PROEKTNA-NOVA-VERZIJA\PROEKTNA\DATA1.MDF;Integrated Security=True;Connect Timeout=30;User Instance=True");
            // TODO: This line of code loads data into the 'data1DataSet1.Score' table. You can move, or remove it, as needed.
            this.scoreTableAdapter.Fill(this.data1DataSet1.Score);
            Cursor.Show();
            con.Open();
            string prasalnik = "SELECT * FROM Score";
            SqlDataAdapter sda = new SqlDataAdapter(prasalnik, con);
            DataTable dta = new DataTable();
            sda.Fill(dta);
            dataGridView1.DataSource = dta;
            con.Close();
            dataGridView1.Visible = true;
         
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cursor.Show();
            this.Hide();
            Form1 m = new Form1();
            m.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Cursor.Hide();
            this.Hide();
            Main m = new Main();
            m.Show();
        }
        
    }
}
