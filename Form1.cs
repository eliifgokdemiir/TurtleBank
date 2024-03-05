using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;


namespace Turtle_Bank
{
    public partial class Form1 : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        void baglanti()
        {
            string connstring = "Data Source=DESKTOP-Q5TKKUP\\SQLEXPRESS;Initial Catalog=bankasistem;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connstring);
            if (conn.State == ConnectionState.Closed)
                conn.Open();
        }
        public Form1()
        {
           
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void cikisyap_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void girisyap_Click(object sender, EventArgs e)
        {
        string personelid= bpersonelid.Text;
        string personelsifre = bpersonelsifre.Text;
        string connstring = "Data Source=DESKTOP-Q5TKKUP\\SQLEXPRESS;Initial Catalog=bankasistem;Integrated Security=True";
        SqlConnection conn = new SqlConnection(connstring);
        SqlCommand cmd = new SqlCommand();
            conn.Open();
            cmd.Connection= conn;
            cmd.CommandText= "SELECT * FROM personeller where idpersonel='" + bpersonelid.Text + "' AND personelsifre='" + bpersonelsifre.Text + "'";
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                Form2 form2 = new Form2();
                form2.Show();
            }
            
            else
            {   
                HataForm hataform = new HataForm();
                hataform.Show();

            }
        }

       
    }
}
