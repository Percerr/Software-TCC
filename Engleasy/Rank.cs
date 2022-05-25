using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Engleasy
{
    public partial class Rank : Form
    {
        public Rank()
        {
            InitializeComponent();
            geraptGameone();
            geraptTwo();
            geraptThree();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void geraptGameone()
        {
            DataTable dt = new DataTable();
            string vquerySelect = "SELECT * FROM tb_usuarios ORDER BY N_PONTOGAMEONE DESC";
            dt = Banco.dql(vquerySelect);

            // SETA NAME/PT EM ORDEM
            lbn_nameone1.Text = dt.Rows[0][1].ToString();
            lbn_nameone2.Text = dt.Rows[1][1].ToString();
            lbn_nameone3.Text = dt.Rows[2][1].ToString();
            lbn_ptone1.Text = dt.Rows[0][6].ToString();
            lbn_ptone2.Text = dt.Rows[1][6].ToString();
            lbn_ptone3.Text = dt.Rows[2][6].ToString();
        }

        private void geraptTwo()
        {
            DataTable dt = new DataTable();
            string vquerySelect = "SELECT * FROM tb_usuarios ORDER BY N_PONTOGAMETWO DESC";
            dt = Banco.dql(vquerySelect);

            // SETA NAME/PT EM ORDEM
            lbn_nametwo1.Text = dt.Rows[0][1].ToString();
            lbn_nametwo2.Text = dt.Rows[1][1].ToString();
            lbn_nametwo3.Text = dt.Rows[2][1].ToString();
            lbn_pttwo1.Text = dt.Rows[0][7].ToString();
            lbn_pttwo2.Text = dt.Rows[1][7].ToString();
            lbn_pttwo3.Text = dt.Rows[2][7].ToString();
        }

        private void geraptThree()
        {
            DataTable dt = new DataTable();
            string vquerySelect = "SELECT * FROM tb_usuarios ORDER BY N_PONTOGAMETHREE DESC";
            dt = Banco.dql(vquerySelect);

            // SETA NAME/PT EM ORDEM
            lbn_namethree1.Text = dt.Rows[0][1].ToString();
            lbn_namethree2.Text = dt.Rows[1][1].ToString();
            lbn_namethree3.Text = dt.Rows[2][1].ToString();
            lbn_ptthree1.Text = dt.Rows[0][8].ToString();
            lbn_ptthree2.Text = dt.Rows[1][8].ToString();
            lbn_ptthree3.Text = dt.Rows[2][8].ToString();
        }

        private void Rank_Load(object sender, EventArgs e)
        {

        }
    }
}
