using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Engleasy
{
    public partial class Gametwo : Form
    {
        SoundPlayer soundA = new SoundPlayer();
        SoundPlayer soundB = new SoundPlayer();
        SoundPlayer soundOp = new SoundPlayer();
        string ar;
        char teste;
        int a;
        int b;
        int res;
        bool nonplayed = true;


        public static string[] aud = new string[12];
        public Gametwo()
        {
            InitializeComponent();



        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_send_Click(object sender, EventArgs e)
        {
            tb_answerShow.Text = tb_answer.Text;
            System.Diagnostics.Debug.WriteLine("A : "+a);
            System.Diagnostics.Debug.WriteLine("B : " + b);
            System.Diagnostics.Debug.WriteLine("res : " + res);
            System.Diagnostics.Debug.WriteLine("digitado : " + tb_answerShow.Text);

            if (nonplayed == true)
            {
                nullAnswer();
            }else if (tb_answerShow.Text != "" &&  int.Parse(tb_answerShow.Text) == res)
            {
                rightAnswer();
            }
            else if (tb_answerShow.Text != "" && int.Parse(tb_answerShow.Text) != res)
            {
                wrongAnswer();
            }

        }

        private void btn_play_Click(object sender, EventArgs e) //gera som, compara, acerta path & play
        {
            nonplayed = false;
            SoundPlayer sound = new SoundPlayer();
            a = geraNum();
            b = geraNum();
            string op = geraOp();
            res = acertaOp(a, b, op);
            System.Diagnostics.Debug.WriteLine(a);
            System.Diagnostics.Debug.WriteLine(b);
            System.Diagnostics.Debug.WriteLine(op);
            System.Diagnostics.Debug.WriteLine(res);

            //seta path som, de acordo com o rand
            switch (a)
            {
                case 0:
                    soundA.SoundLocation = @"C:\Users\pjeromel\source\repos\Engleasy\Engleasy\Resources\0.wav";
                    break;
                case 1:
                    soundA.SoundLocation = @"C:\Users\pjeromel\source\repos\Engleasy\Engleasy\Resources\1.wav";
                    break;
                case 2:
                    soundA.SoundLocation = @"C:\Users\pjeromel\source\repos\Engleasy\Engleasy\Resources\2.wav";
                    break;
                case 3:
                    soundA.SoundLocation = @"C:\Users\pjeromel\source\repos\Engleasy\Engleasy\Resources\3.wav";
                    break;
                case 4:
                    soundA.SoundLocation = @"C:\Users\pjeromel\source\repos\Engleasy\Engleasy\Resources\4.wav";
                    break;
                case 5:
                    soundA.SoundLocation = @"C:\Users\pjeromel\source\repos\Engleasy\Engleasy\Resources\5.wav";
                    break;
                case 6:
                    soundA.SoundLocation = @"C:\Users\pjeromel\source\repos\Engleasy\Engleasy\Resources\6.wav";
                    break;
                case 7:
                    soundA.SoundLocation = @"C:\Users\pjeromel\source\repos\Engleasy\Engleasy\Resources\7.wav";
                    break;
                case 8:
                    soundA.SoundLocation = @"C:\Users\pjeromel\source\repos\Engleasy\Engleasy\Resources\8.wav";
                    break;
                case 9:
                    soundA.SoundLocation = @"C:\Users\pjeromel\source\repos\Engleasy\Engleasy\Resources\9.wav";
                    break;
                case 10:
                    soundA.SoundLocation = @"C:\Users\pjeromel\source\repos\Engleasy\Engleasy\Resources\10.wav";
                    break;
            }
            switch (b)
            {
                case 0:
                    soundB.SoundLocation = @"C:\Users\pjeromel\source\repos\Engleasy\Engleasy\Resources\0.wav";
                    break;
                case 1:
                    soundB.SoundLocation = @"C:\Users\pjeromel\source\repos\Engleasy\Engleasy\Resources\1.wav";
                    break;
                case 2:
                    soundB.SoundLocation = @"C:\Users\pjeromel\source\repos\Engleasy\Engleasy\Resources\2.wav";
                    break;
                case 3:
                    soundB.SoundLocation = @"C:\Users\pjeromel\source\repos\Engleasy\Engleasy\Resources\3.wav";
                    break;
                case 4:
                    soundB.SoundLocation = @"C:\Users\pjeromel\source\repos\Engleasy\Engleasy\Resources\4.wav";
                    break;
                case 5:
                    soundB.SoundLocation = @"C:\Users\pjeromel\source\repos\Engleasy\Engleasy\Resources\5.wav";
                    break;
                case 6:
                    soundB.SoundLocation = @"C:\Users\pjeromel\source\repos\Engleasy\Engleasy\Resources\6.wav";
                    break;
                case 7:
                    soundB.SoundLocation = @"C:\Users\pjeromel\source\repos\Engleasy\Engleasy\Resources\7.wav";
                    break;
                case 8:
                    soundB.SoundLocation = @"C:\Users\pjeromel\source\repos\Engleasy\Engleasy\Resources\8.wav";
                    break;
                case 9:
                    soundB.SoundLocation = @"C:\Users\pjeromel\source\repos\Engleasy\Engleasy\Resources\9.wav";
                    break;
                case 10:
                    soundB.SoundLocation = @"C:\Users\pjeromel\source\repos\Engleasy\Engleasy\Resources\10.wav";
                    break;
            }

            soundA.Play();
            System.Threading.Thread.Sleep(1000);
            soundOp.Play();
            System.Threading.Thread.Sleep(2000);
            soundB.Play();
        }
        private int geraNum() // gera aleatorio
        {
            Random rnd = new Random();
            int num = rnd.Next(0, 10);
            return num;
        }

        private string geraOp() // rand som sinal op
        {
            string ar;
            Random rnd = new Random();
            int randomNumber = rnd.Next(0,3);
            ar = "-";
            if (randomNumber == 0)
            {
                 ar = "+";
                soundOp.SoundLocation = @"C:\Users\pjeromel\source\repos\Engleasy\Engleasy\Resources\+.wav";

            } else if  (randomNumber == 1)
            {
                ar = "-";
                soundOp.SoundLocation = @"C:\Users\pjeromel\source\repos\Engleasy\Engleasy\Resources\-.wav";

            } else if (randomNumber == 2)
            {
                ar = "*";
                soundOp.SoundLocation = @"C:\Users\pjeromel\source\repos\Engleasy\Engleasy\Resources\x.wav";

            }
            return ar;
        }
        private static int acertaOp(int a, int b, string op) // acerta res
        {
            if (op == "+")
            {
                return a + b;

            }else if (op == "-")
            {
                return a - b;
            }else if (op=="*")
            { 
                return a * b;
            }else
            {
                return a;
            }
        }

        private async void rightAnswer()
        {
            tb_answerShow.Text = tb_answer.Text;
            tb_answerShow.Visible = true;
            pb_answer.Visible = true;
            await Task.Delay(1000);
            pb_rightanswer.Visible = true;
            tb_points.Text = (int.Parse(tb_points.Text) + 10).ToString();
            lb_acertou.Visible = true;
            //System.Threading.Thread.Sleep(4000);
            await Task.Delay(4000);
            lb_acertou.Visible = false;
            tb_answerShow.Visible = false;
            pb_answer.Visible = false;
            pb_rightanswer.Visible = false;
        }

        private async void wrongAnswer()
        {
            tb_answerShow.Text = tb_answer.Text;
            tb_answerShow.Visible = true;
            pb_answer.Visible = true;
            await Task.Delay(1000);
            pb_wronganswer.Visible = true;
            //System.Threading.Thread.Sleep(4000);
            await Task.Delay(4000);
            tb_answerShow.Visible = false;
            pb_answer.Visible = false;
            pb_wronganswer.Visible = false;
        }

        private async void nullAnswer()
        {
            tb_answerShow.Text = tb_answer.Text;
            tb_answerShow.Visible = true;
            pb_answer.Visible = true;
            await Task.Delay(1000);
            pb_nullAnswer.Visible = true;
            //System.Threading.Thread.Sleep(4000);
            await Task.Delay(4000);
            tb_answerShow.Visible = false;
            pb_answer.Visible = false;
            pb_nullAnswer.Visible = false;
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            string vquerySelect = "SELECT N_PONTOGAMETWO FROM tb_usuarios WHERE N_IDUSUARIO = '" + Globais.id + "'";
            dt = Banco.dql(vquerySelect);
            //soma banco + atual
            int pts = (int.Parse(tb_points.Text) + int.Parse(dt.Rows[0].Field<Int64>("N_PONTOGAMETWO").ToString()));
            //atualiza
            string vqueryUpdate = "UPDATE tb_usuarios SET N_PONTOGAMETWO = ('" + pts + "') WHERE N_IDUSUARIO = '" + Globais.id + "'";                                                                                      //WHERE T_USERNAME='"+u.username+"'";
            Banco.dml(vqueryUpdate);

            this.Close();
        }
    }
}
