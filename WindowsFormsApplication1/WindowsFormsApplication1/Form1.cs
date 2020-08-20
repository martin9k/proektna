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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
        }
        public static string prenos;
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=G:\PROEKTNA-NOVA-VERZIJA\PROEKTNA\DATA1.MDF;Integrated Security=True;Connect Timeout=30;User Instance=True");
            SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) From Login Where username='" + textBox1.Text + "' and password='" + textBox2.Text + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                prenos = textBox1.Text;
                this.Hide();
                Main ss = new Main();
                ss.Show();

            }
            else MessageBox.Show("Ve molam proverete go vaseto korisnicko ime i lozinka");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=G:\PROEKTNA-NOVA-VERZIJA\PROEKTNA\DATA1.MDF;Integrated Security=True;Connect Timeout=30;User Instance=True");
                con.Open();
                string sql = "INSERT INTO Login(username,password) VALUES('" + textBox1.Text + "','" + textBox2.Text + "')";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Uspesno kreirano korisnicko ime", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception exc)
            {
                MessageBox.Show("greska korisnikot veke postoi ili ne vnese lozinka", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        

        
    }
}
