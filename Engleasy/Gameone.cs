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
    public partial class Gameone : Form
    {
        public static Random randNum = new Random();
        public static int rnd1;
        public static int rnd2;
        public static int rnd3;
        public static bool translatedpts1 = false;
        public static bool translatedpts2 = false;
        public static bool translatedpts3 = false;
        public static int ctrl;
        public static int[] var = new int[28];
        public static int[] casas = new int[28];

        public Gameone()
        {

            Random randNum = new Random();
            InitializeComponent();
            timer1.Start();

            casas = populaCasa(casas);
            rnd1 = casas[0];
            rnd2 = casas[1];
            rnd3 = casas[2];
            ctrl = 3;
            //casas[28] = 777;
            //casas[29] = 777;
            //casas[30] = 777;
            //casas[31] = 777;
            //casas[32] = 777;
            //casas[33] = 777;
            //casas[34] = 777;

            //primeiro btn fill
            btn_palavraUm.Text = Banco.emptyWorld().Rows[rnd1][1].ToString();
            btn_palavraDois.Text = Banco.emptyWorlddois().Rows[rnd2][1].ToString();
            btn_palavraTres.Text = Banco.emptyWorldtres().Rows[rnd3][1].ToString();

            System.Diagnostics.Debug.WriteLine("pos 0 :"+casas[0].ToString());
            System.Diagnostics.Debug.WriteLine("pos 1 :"+casas[1].ToString());
            //System.Diagnostics.Debug.WriteLine("pos 50 :" + casas[50].ToString());
            //System.Diagnostics.Debug.WriteLine("pos 51 :" + casas[51].ToString());
            //System.Diagnostics.Debug.WriteLine("pos 52 :" + casas[52].ToString());

            
            for (int i = 0; i < casas.Length; i++)
            {
                System.Diagnostics.Debug.Write(" "+casas[i].ToString());
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value > 0)
            {
                progressBar1.Value--;
                tbox_timer.Text = progressBar1.Value.ToString();
            }

            if (progressBar1.Value == 0)
            {
                    pictureBox16.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox24.Visible = false;
                    pictureBox7.Visible = false;
                    pictureBox8.Visible = false;
                    pictureBox17.Visible = false;
                    pictureBox11.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox15.Visible = false;
                    pictureBox13.Visible = false;
                    pictureBox19.Visible = false;
                    pictureBox23.Visible = false;
                    pictureBox5.Visible = false;
                    pictureBox25.Visible = false;
                    pictureBox22.Visible = false;
                    pictureBox21.Visible = false;
                    pictureBox10.Visible = false;
                    pictureBox6.Visible = false;
                    pictureBox12.Visible = false;
                    pictureBox20.Visible = false;
                    pictureBox18.Visible = false;
                    pictureBox14.Visible = false;
                    pictureBox26.Visible = false;
                    pictureBox27.Visible = false;
                    pictureBox28.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox9.Visible = false;
                    pb_gameover.BackColor = Color.Black;
                    pictureBox1.Visible = false;
                    btn_close.Visible = true;
                    pb_gameover.Visible = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }


        //vetor controle das casas
        private int[] populaCasa(int[] casas)
        {
            Random randNum = new Random();
            for (int i = 0; i <= 27; i++)
            {
                casas[i] = i;
                if (i == 27)
                {
                    //casas = casas.OrderBy(x => randNum.Next()).ToArray();
                }
            }
            return casas;
        }


        //traduz btn, seta meio valor nos points
        private void btn_traduzirUm_Click(object sender, EventArgs e)
        {
            btn_palavraUm.Text = Banco.emptyWorld().Rows[rnd1][2].ToString();
            translatedpts1 = true;
        }
        private void btn_traduzirDois_Click(object sender, EventArgs e)
        {
            btn_palavraDois.Text = Banco.emptyWorld().Rows[rnd2][2].ToString();
            translatedpts2 = true;
        }
        private void btn_traduzirTres_Click(object sender, EventArgs e)
        {
            btn_palavraTres.Text = Banco.emptyWorld().Rows[rnd3][2].ToString();
            translatedpts3 = true;
        }


        // popula rnd, gera rnd, seta points
        private void worldFazTudo(int a, PictureBox naime)
        {
            System.Diagnostics.Debug.WriteLine(naime.Name);
            System.Diagnostics.Debug.WriteLine(a);
            if (rnd1 == a && ctrl <= 27)
            {
                progressBar1.Value = 20;
                naime.Visible = false;
                rnd1 = casas[ctrl];
                ctrl = ctrl + 1;
                btn_palavraUm.Text = Banco.emptyWorld().Rows[rnd1][1].ToString();
                if (translatedpts1 == false)
                {
                    tb_points.Text = (int.Parse(tb_points.Text) + 10).ToString();
                }
                else if (translatedpts1 == true)
                {
                    tb_points.Text = (int.Parse(tb_points.Text) + 5).ToString();
                    translatedpts1 = false;
                }
            }
            if (rnd2 == a && ctrl <= 27)
            {
                progressBar1.Value = 20;
                naime.Visible = false;
                rnd2 = casas[ctrl];
                ctrl = ctrl + 1;
                btn_palavraDois.Text = Banco.emptyWorld().Rows[rnd2][1].ToString();
                if (translatedpts2 == false)
                {
                    tb_points.Text = (int.Parse(tb_points.Text) + 10).ToString();
                }
                else if (translatedpts2 == true)
                {
                    tb_points.Text = (int.Parse(tb_points.Text) + 5).ToString();
                    translatedpts2 = false;
                }
            }
            if (rnd3 == a && ctrl <= 27)
            {
                progressBar1.Value = 20;
                naime.Visible = false;
                rnd3 = casas[ctrl];
                ctrl = ctrl + 1;
                btn_palavraTres.Text = Banco.emptyWorld().Rows[rnd3][1].ToString();
                if (translatedpts3 == false)
                {
                    tb_points.Text = (int.Parse(tb_points.Text) + 10).ToString();
                }
                else if (translatedpts3 == true)
                {
                    tb_points.Text = (int.Parse(tb_points.Text) + 5).ToString();
                    translatedpts3 = false;
                }
            }
            if (rnd3 == a && ctrl == 28)
            {
                progressBar1.Value = 40;
                naime.Visible = false;
                btn_palavraTres.Text = "---";
                if (translatedpts3 == false)
                {
                    tb_points.Text = (int.Parse(tb_points.Text) + 10).ToString();
                }
                else if (translatedpts3 == true)
                {
                    tb_points.Text = (int.Parse(tb_points.Text) + 5).ToString();
                    translatedpts3 = false;
                }
            }
            if (rnd1 == a && ctrl == 28)
            {
                progressBar1.Value = 40;
                naime.Visible = false;
                btn_palavraUm.Text = "---";
                if (translatedpts3 == false)
                {
                    tb_points.Text = (int.Parse(tb_points.Text) + 10).ToString();
                }
                else if (translatedpts3 == true)
                {
                    tb_points.Text = (int.Parse(tb_points.Text) + 5).ToString();
                    translatedpts3 = false;
                }
            }
            if (rnd2 == a && ctrl == 28)
            {
                progressBar1.Value = 40;
                naime.Visible = false;
                btn_palavraDois.Text = "---";
                if (translatedpts3 == false)
                {
                    tb_points.Text = (int.Parse(tb_points.Text) + 10).ToString();
                }
                else if (translatedpts3 == true)
                {
                    tb_points.Text = (int.Parse(tb_points.Text) + 5).ToString();
                    translatedpts3 = false;
                }
            }
        }


        


        //btn save

        private void btn_close_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            string vquerySelect = "SELECT N_PONTOGAMEONE FROM tb_usuarios WHERE N_IDUSUARIO = '" + Globais.id + "'";
            dt = Banco.dql(vquerySelect);
            //soma banco + atual
            int pts = (int.Parse(tb_points.Text) + int.Parse(dt.Rows[0].Field<Int64>("N_PONTOGAMEONE").ToString()));
            //atualiza
            string vqueryUpdate = "UPDATE tb_usuarios SET N_PONTOGAMEONE = ('" + pts + "') WHERE N_IDUSUARIO = '" + Globais.id + "'";                                                                                      //WHERE T_USERNAME='"+u.username+"'";
            Banco.dml(vqueryUpdate);

            this.Close();
        }

        //metodo das pbs

        private void pictureBox11_Click_1(object sender, EventArgs e) // pão
        {
            PictureBox pb = (PictureBox)sender;
            if (pb != null)
            {

                worldFazTudo(18, pb);
            }
        }

        private void pictureBox27_Click_1(object sender, EventArgs e) // pincel
        {
            PictureBox pb = (PictureBox)sender;
            if (pb != null)
            {

                worldFazTudo(0, pb);
            }
        }

        private void pictureBox6_Click_1(object sender, EventArgs e) // morango
        {
            PictureBox pb = (PictureBox)sender;
            if (pb != null)
            {

                worldFazTudo(14, pb);
            }
        }

        private void pictureBox19_Click_1(object sender, EventArgs e) // carta
        {
            PictureBox pb = (PictureBox)sender;
            if (pb != null)
            {

                worldFazTudo(25, pb);
            }
        }

        private void pictureBox16_Click_1(object sender, EventArgs e)// termometro
        {
            PictureBox pb = (PictureBox)sender;
            if (pb != null)
            {

                worldFazTudo(23, pb);
            }
        }

        private void pictureBox15_Click_1(object sender, EventArgs e) //almofadas
        {
            PictureBox pb = (PictureBox)sender;
            if (pb != null)
            {

                worldFazTudo(22, pb);
            }
        }
        private void pictureBox25_Click_1(object sender, EventArgs e) // computador portatil
        {
            PictureBox pb = (PictureBox)sender;
            if (pb != null)
            {

                worldFazTudo(7, pb);
            }
        }

        private void pictureBox22_Click_1(object sender, EventArgs e) // luz de mesa
        {
            PictureBox pb = (PictureBox)sender;
            if (pb != null)
            {

                worldFazTudo(4, pb);
            }
        }

        private void pictureBox10_Click_1(object sender, EventArgs e) // bone vermelho
        {
            PictureBox pb = (PictureBox)sender;
            if (pb != null)
            {

                worldFazTudo(17, pb);
            }
        }

        private void pictureBox18_Click_1(object sender, EventArgs e) // bola de basquete
        {
            PictureBox pb = (PictureBox)sender;
            if (pb != null)
            {

                worldFazTudo(24, pb);
            }
        }

        private void pictureBox2_Click_1(object sender, EventArgs e) // estilingue
        {
            PictureBox pb = (PictureBox)sender;
            if (pb != null)
            {

                worldFazTudo(9, pb);
            }
        }

        private void pictureBox13_Click_1(object sender, EventArgs e) // abacate
        {
            PictureBox pb = (PictureBox)sender;
            if (pb != null)
            {

                worldFazTudo(20, pb);
            }
        }

        private void pictureBox14_Click_1(object sender, EventArgs e) // toalhas
        {
            PictureBox pb = (PictureBox)sender;
            if (pb != null)
            {

                worldFazTudo(21, pb);
            }
        }

        private void pictureBox24_Click_1(object sender, EventArgs e) // oculos de sol
        {
            PictureBox pb = (PictureBox)sender;
            if (pb != null)
            {

                worldFazTudo(6, pb);
            }
        }

        private void pictureBox21_Click_1(object sender, EventArgs e) // martelo de madeira
        {
            PictureBox pb = (PictureBox)sender;
            if (pb != null)
            {

                worldFazTudo(3, pb);
            }
        }

        private void pictureBox12_Click_1(object sender, EventArgs e) // livros
        {
            PictureBox pb = (PictureBox)sender;
            if (pb != null)
            {

                worldFazTudo(19, pb);
            }
        }

        private void pictureBox26_Click_1(object sender, EventArgs e) // guarda-chuva
        {
            PictureBox pb = (PictureBox)sender;
            if (pb != null)
            {

                worldFazTudo(27, pb);
            }
        }

        private void pictureBox4_Click_1(object sender, EventArgs e) // bone cinza
        {
            PictureBox pb = (PictureBox)sender;
            if (pb != null)
            {

                worldFazTudo(12, pb);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e) // fita adesiva
        {
            PictureBox pb = (PictureBox)sender;
            if (pb != null)
            {

                worldFazTudo(8, pb);
            }
        }

        private void pictureBox9_Click_1(object sender, EventArgs e) // garrafa de agua
        {
            PictureBox pb = (PictureBox)sender;
            if (pb != null)
            {

                worldFazTudo(16, pb);
            }
        }

        private void pictureBox20_Click_1(object sender, EventArgs e) //maça
        {
            PictureBox pb = (PictureBox)sender;
            if (pb != null)
            {

                worldFazTudo(26, pb);
            }
        }

        private void pictureBox17_Click_1(object sender, EventArgs e) // lente de aumento
        {
            PictureBox pb = (PictureBox)sender;
            if (pb != null)
            {

                worldFazTudo(2, pb);
            }
        }

        private void pictureBox23_Click_1(object sender, EventArgs e) // comida de cachorro
        {
            PictureBox pb = (PictureBox)sender;
            if (pb != null)
            {

                worldFazTudo(5, pb);
            }
        }

        private void pictureBox3_Click_1(object sender, EventArgs e) // camera fotografica
        {
            PictureBox pb = (PictureBox)sender;
            if (pb != null)
            {

                worldFazTudo(11, pb);
            }
        }

        private void pictureBox5_Click_1(object sender, EventArgs e) // carteira
        {
            PictureBox pb = (PictureBox)sender;
            if (pb != null)
            {

                worldFazTudo(13, pb);
            }
        }

        private void pictureBox8_Click_1(object sender, EventArgs e) // nozes
        {
            PictureBox pb = (PictureBox)sender;
            if (pb != null)
            {

                worldFazTudo(15, pb);
            }
        }

        private void pictureBox7_Click_1(object sender, EventArgs e) // anel de noivado
        {
            PictureBox pb = (PictureBox)sender;
            if (pb != null)
            {

                worldFazTudo(1, pb);
            }
        }

        private void pictureBox28_Click_1(object sender, EventArgs e) // capcete de proteção
        {
            PictureBox pb = (PictureBox)sender;
            if (pb != null)
            {

                worldFazTudo(10, pb);
            }
        }
    }
    

}


