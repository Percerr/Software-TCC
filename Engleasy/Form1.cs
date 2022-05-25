//using MySql.Data;
using System.Data;

namespace Engleasy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            F_Login f_Login = new F_Login(this);
            f_Login.ShowDialog();
            rtb_changelog.Text = File.ReadAllText(""+Globais.caminhoBanco + Globais.nomeChangelog);
            rtb_changelog.SelectAll();
            rtb_changelog.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void logonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_Login f_Login = new F_Login(this);
            f_Login.ShowDialog();
        }

        private void logoffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lb_acesso.Text = "0";
            lbn_nomeUsuario.Text = "---";
            pb_ledLogado.Image = Properties.Resources.led_vermelho;
            Globais.nivel = 0;
            Globais.logado = false;
            Globais.id = 0;

        }

        private void bancoDeDadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Globais.logado)
            {
                if (Globais.nivel >= 3)
                {
                    //PROCEDURES
                }
                else
                {
                    MessageBox.Show("Acesso não permitido");
                }
            }
            else
            {
                MessageBox.Show("É necessário ter um usuário logado");
            }
        }

        private void registrarNovoAlunoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Globais.logado==false)
            {
                if (Globais.nivel >= 0)
                {
                    F_NovoUsuario f_NovoUsuario = new F_NovoUsuario();
                    f_NovoUsuario.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Acesso não permitido");
                }
            }
            else
            {
                MessageBox.Show("É necessário fazer logoff para criar um novo Usuario");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Globais.logado == true)
            {
                MessageBox.Show("- O Objetivo deste jogo é encontrar dentre os objetos as palavras solicitadas no menu inferior antes que o tempo se esgote. \n- Cada palavra traduzida vale metade da pontuação.");
                Gameone gameone = new Gameone();
                gameone.ShowDialog();
            }
            else
            {
                MessageBox.Show("É Necessario estar logado para iniciar um jogo");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Globais.logado == true)
            {
                MessageBox.Show("- O Objetivo deste jogo é interpretar os audios e acertar o resultado da operação.");
                Gametwo gametwo = new Gametwo();
                gametwo.ShowDialog();
            }
            else
            {
                MessageBox.Show("É Necessario estar logado para iniciar um jogo");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Globais.logado == true)
            {
                MessageBox.Show("- O Objetivo deste jogo é encontrar duas cartas correspondentes, cada figura possui um nome correspondente.");
                Gamethree gamethree = new Gamethree();
                gamethree.ShowDialog();
            }
            else
            {
                MessageBox.Show("É Necessario estar logado para iniciar um jogo");
            }
        }

        private void limparRankToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (Globais.logado == true)
            {
                if (Globais.nivel >= 3)
                {
                    
                    DataTable dt = new DataTable();
                        //string vquerySelect = "SELECT N_PONTOGAMETWO FROM tb_usuarios WHERE N_IDUSUARIO = '" + Globais.id + "'";
                        //dt = Banco.dql(vquerySelect);
                        //soma banco + atual
                    int pts = 0;
                        //atualiza
                    string vqueryUpdate = "UPDATE tb_usuarios SET N_PONTOGAMEONE = ('" + pts + "'), N_PONTOGAMETWO = ('" + pts + "'), N_PONTOGAMETHREE = ('" + pts + "') ";
                    Banco.dml(vqueryUpdate);
                    MessageBox.Show("Pontuação do Rank foi limpa com sucesso");
                        //this.Close();
                    
                }
                else
                {
                    MessageBox.Show("Acesso não permitido");
                }
            }
            else
            {
                MessageBox.Show("É necessário fazer login para limpar o rank");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (Globais.logado == true)
            {
                Rank rank = new Rank();
                rank.ShowDialog();
            }
            else
            {
                MessageBox.Show("É Necessario estar logado para ver o Rank");
            }
        }

        private void rtb_changelog_TextChanged(object sender, EventArgs e)
        {

        }

        private void timer_updt_Tick(object sender, EventArgs e)
        {
            if (Globais.id == 0)
            {
                lbn_mypt1.Text = "0";
                lbn_mypt2.Text = "0";
                lbn_mypt3.Text = "0";
            }
            if (Globais.id != 0)
            {

            
            //lbn_mypt1.Text = "ae";
            DataTable dt = new DataTable();
            DataTable dt2 = new DataTable();
            DataTable dt3 = new DataTable();
            string vquerySelect = "SELECT N_PONTOGAMEONE FROM tb_usuarios WHERE N_IDUSUARIO = '" + Globais.id + "'";
            string vquerySelect2 = "SELECT N_PONTOGAMETWO FROM tb_usuarios WHERE N_IDUSUARIO = '" + Globais.id + "'";
            string vquerySelect3 = "SELECT N_PONTOGAMETHREE FROM tb_usuarios WHERE N_IDUSUARIO = '" + Globais.id + "'";
            dt = Banco.dql(vquerySelect);
            dt2 = Banco.dql(vquerySelect2);
            dt3 = Banco.dql(vquerySelect3);
            //soma banco + atual
            //int pts = (int.Parse(tb_points.Text) + int.Parse(dt.Rows[0].Field<Int64>("N_PONTOGAMEONE").ToString()));
            //atualiza
            lbn_mypt1.Text = dt.Rows[0][0].ToString();
            lbn_mypt2.Text = dt2.Rows[0][0].ToString();
            lbn_mypt3.Text = dt3.Rows[0][0].ToString();
            }
        }
    }
}
