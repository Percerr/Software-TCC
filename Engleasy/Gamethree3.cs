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
    public partial class Gamethree : Form
    {
        public static int[] cartaimg = new int[32];
        public static PictureBox[] cartachoosed = new PictureBox[32];
        int pick = 0;
        int ctrl = 0;
        int z=1;
        int nameoldcount = 0;
        //bool para checar as cartas reveladas
        bool reveal1 = false, reveal2 = false, reveal3 = false, reveal4 = false, reveal5 = false,
        reveal6 = false, reveal7 = false, reveal8 = false, reveal9 = false, reveal10 = false,
        reveal11 = false, reveal12 = false, reveal13 = false, reveal14 = false, reveal15 = false,
        reveal16 = false, reveal17 = false, reveal18 = false, reveal19 = false, reveal20 = false,
        reveal21 = false, reveal22 = false, reveal23 = false, reveal24 = false, reveal25 = false,
        reveal26 = false, reveal27 = false, reveal28 = false, reveal29 = false, reveal30 = false,
        reveal31 = false, reveal32 = false;
        //int para checar se tem 2 cartas reveladas
        int allReveal = 0;
        //bool para checar se a carta ja foi revelada 1x
        bool revealed1 = false, revealed2 = false, revealed3 = false, revealed4 = false, revealed5 = false,
        revealed6 = false, revealed7 = false, revealed8 = false, revealed9 = false, revealed10 = false,
        revealed11 = false, revealed12 = false, revealed13 = false, revealed14 = false, revealed15 = false,
        revealed16 = false, revealed17 = false, revealed18 = false, revealed19 = false, revealed20 = false, 
        revealed21 = false, revealed22 = false, revealed23 = false, revealed24 = false, revealed25 = false, 
        revealed26 = false, revealed27 = false, revealed28 = false, revealed29 = false, revealed30 = false,
        revealed31 = false, revealed32 = false;



        //int para marcar posi do card (ctrl) já revelado 1x
        int pb1, pb2, pb3, pb4, pb5, pb6, pb7, pb8, pb9, pb10, pb11, pb12, pb13, pb14, pb15,
        pb16, pb17, pb18, pb19, pb20, pb21, pb22, pb23, pb24, pb25, pb26, pb27, pb28, pb29, pb30, pb31, pb32;

        PictureBox nameold = new PictureBox();
        PictureBox tocheck2 = new PictureBox();
        int lasta;
        int lastb;
        Random rnd = new Random();
        
        public Gamethree()
        {
            InitializeComponent();
            cartaimg = populaCasa(cartaimg);
            //cartaword = populaCasa(cartaword);

            for (int i = 0; i <= cartaimg.Length-1; i++)
            {
                System.Diagnostics.Debug.Write(cartaimg[i]+"|");

            }

            nameold.Image = null;
            tocheck2.Image = null;



            //picturbox[1] = new PictureBox();
            //picturbox[1].Image = Properties.Resources.SeekPng_com_card_back_png_3492279;
            //picturbox[1].SizeMode = PictureBoxSizeMode.StretchImage;
            //picturbox[1].BackColor = Color.Transparent;
            //picturbox[1].Visible = true;
            //picturbox[1].Location = new Point(125, 141);
            //picturbox[1].Size = new Size(123, 164);
            //this.Controls.Add(picturbox[1]);

            

        }

        private int[] populaCasa(int[] casas)
        {
            Random randNum = new Random();
            for (int i = 0; i < casas.Length; i++)
            {
                casas[i] = i;
                if (i == 31)
                {
                    casas = casas.OrderBy(x => randNum.Next()).ToArray();
                }
            }
            return casas;
        } // deixa os vetores aleatórios


        private void pb_card1_Click_1(object sender, EventArgs e)
        {
            if (reveal1 == true)
            {
                return;
            }
            if (nameoldcount % 2 == 0)
            {
                nameold = (PictureBox)sender;
            }
            nameoldcount++;
            if (allReveal == 2)
            {
                limpALL();

            }
            if (reveal1 == false && revealed1 == false)
            {
                PictureBox pb = (PictureBox)sender;
                reveal1 = true;
                if (pb != null)
                {
                    geraImg(pb);
                }
                reveal1 = true;
                allReveal++;
                revealed1 = true;
                pb1 = ctrl - 1;
            }
            else if (reveal1 == false && revealed1 == true)
            {
                PictureBox pb = (PictureBox)sender;
                reveal1 = true;
                if (pb != null)
                {
                    geraImg2(pb1, pb);
                    reveal1 = true;
                    allReveal++;
                    revealed1 = true;
                }
            }
        }

        private void pb_card2_Click(object sender, EventArgs e)
        {
            if (reveal2 == true)
            {
                return;
            }
            if (nameoldcount % 2 == 0)
            {
                nameold = (PictureBox)sender;
            }
            nameoldcount++;
            if (allReveal == 2)
            {
                limpALL();

            }
            if (reveal2 == false && revealed2 == false)
            {
                PictureBox pb = (PictureBox)sender;
                reveal2 = true;
                if (pb != null)
                {
                    geraImg(pb);
                }
                reveal2 = true;
                allReveal++;
                revealed2 = true;
                pb2 = ctrl - 1;
            }
            else if (reveal2 == false && revealed2 == true)
            {
                PictureBox pb = (PictureBox)sender;
                reveal2 = true;
                if (pb != null)
                {
                    geraImg2(pb2, pb);
                    reveal2 = true;
                    allReveal++;
                    revealed2 = true;
                }
            }
        }

        private void pb_card3_Click(object sender, EventArgs e)
        {
            if (reveal3 == true)
            {
                return;
            }
            if (nameoldcount % 2 == 0)
            {
                nameold = (PictureBox)sender;
            }
            nameoldcount++;
            if (allReveal == 2)
            {
                limpALL();

            }
            if (reveal3 == false && revealed3 == false)
            {
                PictureBox pb = (PictureBox)sender;
                reveal3 = true;
                if (pb != null)
                {
                    geraImg(pb);
                }
                reveal3 = true;
                allReveal++;
                revealed3 = true;
                pb3 = ctrl - 1;
            }
            else if (reveal3 == false && revealed3 == true)
            {
                PictureBox pb = (PictureBox)sender;
                reveal3 = true;
                if (pb != null)
                {
                    geraImg2(pb3, pb);
                    reveal3 = true;
                    allReveal++;
                    revealed3 = true;
                }
            }
        }

        private void pb_card4_Click(object sender, EventArgs e)
        {
            if (reveal4 == true)
            {
                return;
            }
            if (nameoldcount % 2 == 0)
            {
                nameold = (PictureBox)sender;
            }
            nameoldcount++;
            if (allReveal == 2)
            {
                limpALL();

            }
            if (reveal4 == false && revealed4 == false)
            {
                PictureBox pb = (PictureBox)sender;
                reveal4 = true;
                if (pb != null)
                {
                    geraImg(pb);
                }
                reveal4 = true;
                allReveal++;
                revealed4 = true;
                pb4 = ctrl - 1;
            }
            else if (reveal4 == false && revealed4 == true)
            {
                PictureBox pb = (PictureBox)sender;
                reveal4 = true;
                if (pb != null)
                {
                    geraImg2(pb4, pb);
                    reveal4 = true;
                    allReveal++;
                    revealed4 = true;
                }
            }
        }

        private void pb_card5_Click(object sender, EventArgs e)
        {
            if (reveal5 == true)
            {
                return;
            }
            if (nameoldcount % 2 == 0)
            {
                nameold = (PictureBox)sender;
            }
            nameoldcount++;
            if (allReveal == 2)
            {
                limpALL();

            }
            if (reveal5 == false && revealed5 == false)
            {
                PictureBox pb = (PictureBox)sender;
                reveal5 = true;
                if (pb != null)
                {
                    geraImg(pb);
                }
                reveal5 = true;
                allReveal++;
                revealed5 = true;
                pb5 = ctrl - 1;
            }
            else if (reveal5 == false && revealed5 == true)
            {
                PictureBox pb = (PictureBox)sender;
                reveal5 = true;
                if (pb != null)
                {
                    geraImg2(pb5, pb);
                    reveal5 = true;
                    allReveal++;
                    revealed5 = true;
                }
            }
        }

        private void pb_card6_Click(object sender, EventArgs e)
        {
            if (reveal6 == true)
            {
                return;
            }
            if (nameoldcount % 2 == 0)
            {
                nameold = (PictureBox)sender;
            }
            nameoldcount++;
            if (allReveal == 2)
            {
                limpALL();

            }
            if (reveal6 == false && revealed6 == false)
            {
                PictureBox pb = (PictureBox)sender;
                reveal6 = true;
                if (pb != null)
                {
                    geraImg(pb);
                }
                reveal6 = true;
                allReveal++;
                revealed6 = true;
                pb6 = ctrl - 1;
            }
            else if (reveal6 == false && revealed6 == true)
            {
                PictureBox pb = (PictureBox)sender;
                reveal6 = true;
                if (pb != null)
                {
                    geraImg2(pb6, pb);
                    reveal6 = true;
                    allReveal++;
                    revealed6 = true;
                }
            }
        }

        private void pb_card7_Click(object sender, EventArgs e)
        {
            if (reveal7 == true)
            {
                return;
            }
            if (nameoldcount % 2 == 0)
            {
                nameold = (PictureBox)sender;
            }
            nameoldcount++;
            if (allReveal == 2)
            {
                limpALL();

            }
            if (reveal7 == false && revealed7 == false)
            {
                PictureBox pb = (PictureBox)sender;
                reveal7 = true;
                if (pb != null)
                {
                    geraImg(pb);
                }
                reveal7 = true;
                allReveal++;
                revealed7 = true;
                pb7 = ctrl - 1;
            }
            else if (reveal7 == false && revealed7 == true)
            {
                PictureBox pb = (PictureBox)sender;
                reveal7 = true;
                if (pb != null)
                {
                    geraImg2(pb7, pb);
                    reveal7 = true;
                    allReveal++;
                    revealed7 = true;
                }
            }
        }

        private void pb_card8_Click(object sender, EventArgs e)
        {
            if (reveal8 == true)
            {
                return;
            }
            if (nameoldcount % 2 == 0)
            {
                nameold = (PictureBox)sender;
            }
            nameoldcount++;
            if (allReveal == 2)
            {
                limpALL();

            }
            if (reveal8 == false && revealed8 == false)
            {
                PictureBox pb = (PictureBox)sender;
                reveal8 = true;
                if (pb != null)
                {
                    geraImg(pb);
                }
                reveal8 = true;
                allReveal++;
                revealed8 = true;
                pb8 = ctrl - 1;
            }
            else if (reveal8 == false && revealed8 == true)
            {
                PictureBox pb = (PictureBox)sender;
                reveal8 = true;
                if (pb != null)
                {
                    geraImg2(pb8, pb);
                    reveal8 = true;
                    allReveal++;
                    revealed8 = true;
                }
            }
        }

        private void pb_card9_Click(object sender, EventArgs e)
        {
            if (reveal9 == true)
            {
                return;
            }
            if (nameoldcount % 2 == 0)
            {
                nameold = (PictureBox)sender;
            }
            nameoldcount++;
            if (allReveal == 2)
            {
                limpALL();

            }
            if (reveal9 == false && revealed9 == false)
            {
                PictureBox pb = (PictureBox)sender;
                reveal9 = true;
                if (pb != null)
                {
                    geraImg(pb);
                }
                reveal9 = true;
                allReveal++;
                revealed9 = true;
                pb9 = ctrl - 1;
            }
            else if (reveal9 == false && revealed9 == true)
            {
                PictureBox pb = (PictureBox)sender;
                reveal9 = true;
                if (pb != null)
                {
                    geraImg2(pb9, pb);
                    reveal9 = true;
                    allReveal++;
                    revealed9 = true;
                }
            }
        }

        private void pb_card10_Click(object sender, EventArgs e)
        {
            if (reveal10 == true)
            {
                return;
            }
            if (nameoldcount % 2 == 0)
            {
                nameold = (PictureBox)sender;
            }
            nameoldcount++;
            if (allReveal == 2)
            {
                limpALL();

            }
            if (reveal10 == false && revealed10 == false)
            {
                PictureBox pb = (PictureBox)sender;
                reveal10 = true;
                if (pb != null)
                {
                    geraImg(pb);
                }
                reveal10 = true;
                allReveal++;
                revealed10 = true;
                pb10 = ctrl - 1;
            }
            else if (reveal10 == false && revealed10 == true)
            {
                PictureBox pb = (PictureBox)sender;
                reveal10 = true;
                if (pb != null)
                {
                    geraImg2(pb10, pb);
                    reveal10 = true;
                    allReveal++;
                    revealed10 = true;
                }
            }
        }

        private void pb_card11_Click(object sender, EventArgs e)
        {
            if (reveal11 == true)
            {
                return;
            }
            if (nameoldcount % 2 == 0)
            {
                nameold = (PictureBox)sender;
            }
            nameoldcount++;
            if (allReveal == 2)
            {
                limpALL();

            }
            if (reveal11 == false && revealed11 == false)
            {
                PictureBox pb = (PictureBox)sender;
                reveal11 = true;
                if (pb != null)
                {
                    geraImg(pb);
                }
                reveal11 = true;
                allReveal++;
                revealed11 = true;
                pb11 = ctrl - 1;
            }
            else if (reveal11 == false && revealed11 == true)
            {
                PictureBox pb = (PictureBox)sender;
                reveal11 = true;
                if (pb != null)
                {
                    geraImg2(pb11, pb);
                    reveal11 = true;
                    allReveal++;
                    revealed11 = true;
                }
            }
        }

        private void pb_card12_Click(object sender, EventArgs e)
        {
            if (reveal12 == true)
            {
                return;
            }
            if (nameoldcount % 2 == 0)
            {
                nameold = (PictureBox)sender;
            }
            nameoldcount++;
            if (allReveal == 2)
            {
                limpALL();

            }
            if (reveal12 == false && revealed12 == false)
            {
                PictureBox pb = (PictureBox)sender;
                reveal12 = true;
                if (pb != null)
                {
                    geraImg(pb);
                }
                reveal12 = true;
                allReveal++;
                revealed12 = true;
                pb12 = ctrl - 1;
            }
            else if (reveal12 == false && revealed12 == true)
            {
                PictureBox pb = (PictureBox)sender;
                reveal12 = true;
                if (pb != null)
                {
                    geraImg2(pb12, pb);
                    reveal12 = true;
                    allReveal++;
                    revealed12 = true;
                }
            }
        }

        private void pb_card13_Click(object sender, EventArgs e)
        {
            if (reveal13 == true)
            {
                return;
            }
            if (nameoldcount % 2 == 0)
            {
                nameold = (PictureBox)sender;
            }
            nameoldcount++;
            if (allReveal == 2)
            {
                limpALL();

            }
            if (reveal13 == false && revealed13 == false)
            {
                PictureBox pb = (PictureBox)sender;
                reveal13 = true;
                if (pb != null)
                {
                    geraImg(pb);
                }
                reveal13 = true;
                allReveal++;
                revealed13 = true;
                pb13 = ctrl - 1;
            }
            else if (reveal13 == false && revealed13 == true)
            {
                PictureBox pb = (PictureBox)sender;
                reveal13 = true;
                if (pb != null)
                {
                    geraImg2(pb13, pb);
                    reveal13 = true;
                    allReveal++;
                    revealed13 = true;
                }
            }
        }

        private void pb_card14_Click(object sender, EventArgs e)
        {
            if (reveal14 == true)
            {
                return;
            }
            if (nameoldcount % 2 == 0)
            {
                nameold = (PictureBox)sender;
            }
            nameoldcount++;
            if (allReveal == 2)
            {
                limpALL();

            }
            if (reveal14 == false && revealed14 == false)
            {
                PictureBox pb = (PictureBox)sender;
                reveal14 = true;
                if (pb != null)
                {
                    geraImg(pb);
                }
                reveal14 = true;
                allReveal++;
                revealed14 = true;
                pb14 = ctrl - 1;
            }
            else if (reveal14 == false && revealed14 == true)
            {
                PictureBox pb = (PictureBox)sender;
                reveal14 = true;
                if (pb != null)
                {
                    geraImg2(pb14, pb);
                    reveal14 = true;
                    allReveal++;
                    revealed14 = true;
                }
            }
        }

        private void pb_card15_Click(object sender, EventArgs e)
        {
            if (reveal15 == true)
            {
                return;
            }
            if (nameoldcount % 2 == 0)
            {
                nameold = (PictureBox)sender;
            }
            nameoldcount++;
            if (allReveal == 2)
            {
                limpALL();

            }
            if (reveal15 == false && revealed15 == false)
            {
                PictureBox pb = (PictureBox)sender;
                reveal15 = true;
                if (pb != null)
                {
                    geraImg(pb);
                }
                reveal15 = true;
                allReveal++;
                revealed15 = true;
                pb15 = ctrl - 1;
            }
            else if (reveal15 == false && revealed15 == true)
            {
                PictureBox pb = (PictureBox)sender;
                reveal15 = true;
                if (pb != null)
                {
                    geraImg2(pb15, pb);
                    reveal15 = true;
                    allReveal++;
                    revealed15 = true;
                }
            }
        }

        private void pb_card16_Click(object sender, EventArgs e)
        {
            if (reveal16 == true)
            {
                return;
            }
            if (nameoldcount % 2 == 0)
            {
                nameold = (PictureBox)sender;
            }
            nameoldcount++;
            if (allReveal == 2)
            {
                limpALL();

            }
            if (reveal16 == false && revealed16 == false)
            {
                PictureBox pb = (PictureBox)sender;
                reveal16 = true;
                if (pb != null)
                {
                    geraImg(pb);
                }
                reveal16 = true;
                allReveal++;
                revealed16 = true;
                pb16 = ctrl - 1;
            }
            else if (reveal16 == false && revealed16 == true)
            {
                PictureBox pb = (PictureBox)sender;
                reveal16 = true;
                if (pb != null)
                {
                    geraImg2(pb16, pb);
                    reveal16 = true;
                    allReveal++;
                    revealed16 = true;
                }
            }
        }

        private void pb_card17_Click(object sender, EventArgs e)
        {
            if (reveal17 == true)
            {
                return;
            }
            if (nameoldcount % 2 == 0)
            {
                nameold = (PictureBox)sender;
            }
            nameoldcount++;
            if (allReveal == 2)
            {
                limpALL();

            }
            if (reveal17 == false && revealed17 == false)
            {
                PictureBox pb = (PictureBox)sender;
                reveal17 = true;
                if (pb != null)
                {
                    geraImg(pb);
                }
                reveal17 = true;
                allReveal++;
                revealed17 = true;
                pb17 = ctrl - 1;
            }
            else if (reveal17 == false && revealed17 == true)
            {
                PictureBox pb = (PictureBox)sender;
                reveal17 = true;
                if (pb != null)
                {
                    geraImg2(pb17, pb);
                    reveal17 = true;
                    allReveal++;
                    revealed17 = true;
                }
            }
        }

        private void pb_card18_Click(object sender, EventArgs e)
        {
            if (reveal18 == true)
            {
                return;
            }
            if (nameoldcount % 2 == 0)
            {
                nameold = (PictureBox)sender;
            }
            nameoldcount++;
            if (allReveal == 2)
            {
                limpALL();

            }
            if (reveal18 == false && revealed18 == false)
            {
                PictureBox pb = (PictureBox)sender;
                reveal18 = true;
                if (pb != null)
                {
                    geraImg(pb);
                }
                reveal18 = true;
                allReveal++;
                revealed18 = true;
                pb18 = ctrl - 1;
            }
            else if (reveal18 == false && revealed18 == true)
            {
                PictureBox pb = (PictureBox)sender;
                reveal18 = true;
                if (pb != null)
                {
                    geraImg2(pb18, pb);
                    reveal18 = true;
                    allReveal++;
                    revealed18 = true;
                }
            }
        }

        private void pb_card19_Click(object sender, EventArgs e)
        {
            if (reveal19 == true)
            {
                return;
            }
            if (nameoldcount % 2 == 0)
            {
                nameold = (PictureBox)sender;
            }
            nameoldcount++;
            if (allReveal == 2)
            {
                limpALL();

            }
            if (reveal19 == false && revealed19 == false)
            {
                PictureBox pb = (PictureBox)sender;
                reveal19 = true;
                if (pb != null)
                {
                    geraImg(pb);
                }
                reveal19 = true;
                allReveal++;
                revealed19 = true;
                pb19 = ctrl - 1;
            }
            else if (reveal19 == false && revealed19 == true)
            {
                PictureBox pb = (PictureBox)sender;
                reveal19 = true;
                if (pb != null)
                {
                    geraImg2(pb19, pb);
                    reveal19 = true;
                    allReveal++;
                    revealed19 = true;
                }
            }
        }

        private void pb_card20_Click(object sender, EventArgs e)
        {
            if (reveal20 == true)
            {
                return;
            }
            if (nameoldcount % 2 == 0)
            {
                nameold = (PictureBox)sender;
            }
            nameoldcount++;
            if (allReveal == 2)
            {
                limpALL();

            }
            if (reveal20 == false && revealed20 == false)
            {
                PictureBox pb = (PictureBox)sender;
                reveal20 = true;
                if (pb != null)
                {
                    geraImg(pb);
                }
                reveal20 = true;
                allReveal++;
                revealed20 = true;
                pb20 = ctrl - 1;
            }
            else if (reveal20 == false && revealed20 == true)
            {
                PictureBox pb = (PictureBox)sender;
                reveal20 = true;
                if (pb != null)
                {
                    geraImg2(pb20, pb);
                    reveal20 = true;
                    allReveal++;
                    revealed20 = true;
                }
            }
        }

        private void pb_card21_Click(object sender, EventArgs e)
        {
            if (reveal21 == true)
            {
                return;
            }
            if (nameoldcount % 2 == 0)
            {
                nameold = (PictureBox)sender;
            }
            nameoldcount++;
            if (allReveal == 2)
            {
                limpALL();

            }
            if (reveal21 == false && revealed21 == false)
            {
                PictureBox pb = (PictureBox)sender;
                reveal21 = true;
                if (pb != null)
                {
                    geraImg(pb);
                }
                reveal21 = true;
                allReveal++;
                revealed21 = true;
                pb21 = ctrl - 1;
            }
            else if (reveal21 == false && revealed21 == true)
            {
                PictureBox pb = (PictureBox)sender;
                reveal21 = true;
                if (pb != null)
                {
                    geraImg2(pb21, pb);
                    reveal21 = true;
                    allReveal++;
                    revealed21 = true;
                }
            }
        }

        private void pb_card22_Click(object sender, EventArgs e)
        {
            if (reveal22 == true)
            {
                return;
            }
            if (nameoldcount % 2 == 0)
            {
                nameold = (PictureBox)sender;
            }
            nameoldcount++;
            if (allReveal == 2)
            {
                limpALL();

            }
            if (reveal22 == false && revealed22 == false)
            {
                PictureBox pb = (PictureBox)sender;
                reveal22 = true;
                if (pb != null)
                {
                    geraImg(pb);
                }
                reveal22 = true;
                allReveal++;
                revealed22 = true;
                pb2 = ctrl - 1;
            }
            else if (reveal22 == false && revealed22 == true)
            {
                PictureBox pb = (PictureBox)sender;
                reveal22 = true;
                if (pb != null)
                {
                    geraImg2(pb2, pb);
                    reveal22 = true;
                    allReveal++;
                    revealed22 = true;
                }
            }
        }

        private void pb_card23_Click(object sender, EventArgs e)
        {
            if (reveal23 == true)
            {
                return;
            }
            if (nameoldcount % 2 == 0)
            {
                nameold = (PictureBox)sender;
            }
            nameoldcount++;
            if (allReveal == 2)
            {
                limpALL();

            }
            if (reveal23 == false && revealed23 == false)
            {
                PictureBox pb = (PictureBox)sender;
                reveal23 = true;
                if (pb != null)
                {
                    geraImg(pb);
                }
                reveal23 = true;
                allReveal++;
                revealed23 = true;
                pb23 = ctrl - 1;
            }
            else if (reveal23 == false && revealed23 == true)
            {
                PictureBox pb = (PictureBox)sender;
                reveal23 = true;
                if (pb != null)
                {
                    geraImg2(pb23, pb);
                    reveal23 = true;
                    allReveal++;
                    revealed23 = true;
                }
            }
        }

        private void pb_card24_Click(object sender, EventArgs e)
        {
            if (reveal24 == true)
            {
                return;
            }
            if (nameoldcount % 2 == 0)
            {
                nameold = (PictureBox)sender;
            }
            nameoldcount++;
            if (allReveal == 2)
            {
                limpALL();

            }
            if (reveal24 == false && revealed24 == false)
            {
                PictureBox pb = (PictureBox)sender;
                reveal24 = true;
                if (pb != null)
                {
                    geraImg(pb);
                }
                reveal24 = true;
                allReveal++;
                revealed24 = true;
                pb24 = ctrl - 1;
            }
            else if (reveal24 == false && revealed24 == true)
            {
                PictureBox pb = (PictureBox)sender;
                reveal24 = true;
                if (pb != null)
                {
                    geraImg2(pb24, pb);
                    reveal24 = true;
                    allReveal++;
                    revealed24 = true;
                }
            }
        }

        private void pb_card25_Click(object sender, EventArgs e)
        {
            if (reveal25 == true)
            {
                return;
            }
            if (nameoldcount % 2 == 0)
            {
                nameold = (PictureBox)sender;
            }
            nameoldcount++;
            if (allReveal == 2)
            {
                limpALL();

            }
            if (reveal25 == false && revealed25 == false)
            {
                PictureBox pb = (PictureBox)sender;
                reveal25 = true;
                if (pb != null)
                {
                    geraImg(pb);
                }
                reveal25 = true;
                allReveal++;
                revealed25 = true;
                pb25 = ctrl - 1;
            }
            else if (reveal25 == false && revealed25 == true)
            {
                PictureBox pb = (PictureBox)sender;
                reveal25 = true;
                if (pb != null)
                {
                    geraImg2(pb25, pb);
                    reveal25 = true;
                    allReveal++;
                    revealed25 = true;
                }
            }
        }

        private void pb_card26_Click(object sender, EventArgs e)
        {
            if (reveal26 == true)
            {
                return;
            }
            if (nameoldcount % 2 == 0)
            {
                nameold = (PictureBox)sender;
            }
            nameoldcount++;
            if (allReveal == 2)
            {
                limpALL();

            }
            if (reveal26 == false && revealed26 == false)
            {
                PictureBox pb = (PictureBox)sender;
                reveal26 = true;
                if (pb != null)
                {
                    geraImg(pb);
                }
                reveal26 = true;
                allReveal++;
                revealed26 = true;
                pb26 = ctrl - 1;
            }
            else if (reveal26 == false && revealed26 == true)
            {
                PictureBox pb = (PictureBox)sender;
                reveal26 = true;
                if (pb != null)
                {
                    geraImg2(pb26, pb);
                    reveal26 = true;
                    allReveal++;
                    revealed26 = true;
                }
            }
        }

        private void pb_card27_Click(object sender, EventArgs e)
        {
            if (reveal27 == true)
            {
                return;
            }
            if (nameoldcount % 2 == 0)
            {
                nameold = (PictureBox)sender;
            }
            nameoldcount++;
            if (allReveal == 2)
            {
                limpALL();

            }
            if (reveal27 == false && revealed27 == false)
            {
                PictureBox pb = (PictureBox)sender;
                reveal27 = true;
                if (pb != null)
                {
                    geraImg(pb);
                }
                reveal27 = true;
                allReveal++;
                revealed27 = true;
                pb27 = ctrl - 1;
            }
            else if (reveal27 == false && revealed27 == true)
            {
                PictureBox pb = (PictureBox)sender;
                reveal27 = true;
                if (pb != null)
                {
                    geraImg2(pb27, pb);
                    reveal27 = true;
                    allReveal++;
                    revealed27 = true;
                }
            }
        }

        private void pb_card28_Click(object sender, EventArgs e)
        {
            if (reveal28 == true)
            {
                return;
            }
            if (nameoldcount % 2 == 0)
            {
                nameold = (PictureBox)sender;
            }
            nameoldcount++;
            if (allReveal == 2)
            {
                limpALL();

            }
            if (reveal28 == false && revealed28 == false)
            {
                PictureBox pb = (PictureBox)sender;
                reveal28 = true;
                if (pb != null)
                {
                    geraImg(pb);
                }
                reveal28 = true;
                allReveal++;
                revealed28 = true;
                pb28 = ctrl - 1;
            }
            else if (reveal28 == false && revealed28 == true)
            {
                PictureBox pb = (PictureBox)sender;
                reveal28 = true;
                if (pb != null)
                {
                    geraImg2(pb28, pb);
                    reveal28 = true;
                    allReveal++;
                    revealed28 = true;
                }
            }
        }

        private void pb_card29_Click(object sender, EventArgs e)
        {
            if (reveal29 == true)
            {
                return;
            }
            if (nameoldcount % 2 == 0)
            {
                nameold = (PictureBox)sender;
            }
            nameoldcount++;
            if (allReveal == 2)
            {
                limpALL();

            }
            if (reveal29 == false && revealed29 == false)
            {
                PictureBox pb = (PictureBox)sender;
                reveal29 = true;
                if (pb != null)
                {
                    geraImg(pb);
                }
                reveal29 = true;
                allReveal++;
                revealed29 = true;
                pb29 = ctrl - 1;
            }
            else if (reveal29 == false && revealed29 == true)
            {
                PictureBox pb = (PictureBox)sender;
                reveal29 = true;
                if (pb != null)
                {
                    geraImg2(pb29, pb);
                    reveal29 = true;
                    allReveal++;
                    revealed29 = true;
                }
            }
        }

        private void pb_card30_Click(object sender, EventArgs e)
        {
            if (reveal30 == true)
            {
                return;
            }
            if (nameoldcount % 2 == 0)
            {
                nameold = (PictureBox)sender;
            }
            nameoldcount++;
            if (allReveal == 2)
            {
                limpALL();

            }
            if (reveal30 == false && revealed30 == false)
            {
                PictureBox pb = (PictureBox)sender;
                reveal30 = true;
                if (pb != null)
                {
                    geraImg(pb);
                }
                reveal30 = true;
                allReveal++;
                revealed30 = true;
                pb30 = ctrl - 1;
            }
            else if (reveal30 == false && revealed30 == true)
            {
                PictureBox pb = (PictureBox)sender;
                reveal30 = true;
                if (pb != null)
                {
                    geraImg2(pb30, pb);
                    reveal30 = true;
                    allReveal++;
                    revealed30 = true;
                }
            }
        }

        private void pb_card31_Click(object sender, EventArgs e)
        {
            if (reveal31 == true)
            {
                return;
            }
            if (nameoldcount % 2 == 0)
            {
                nameold = (PictureBox)sender;
            }
            nameoldcount++;
            if (allReveal == 2)
            {
                limpALL();

            }
            if (reveal31 == false && revealed31 == false)
            {
                PictureBox pb = (PictureBox)sender;
                reveal31 = true;
                if (pb != null)
                {
                    geraImg(pb);
                }
                reveal31 = true;
                allReveal++;
                revealed31 = true;
                pb31 = ctrl - 1;
            }
            else if (reveal31 == false && revealed31 == true)
            {
                PictureBox pb = (PictureBox)sender;
                reveal31 = true;
                if (pb != null)
                {
                    geraImg2(pb31, pb);
                    reveal31 = true;
                    allReveal++;
                    revealed31 = true;
                }
            }
        }

        private void pb_card32_Click(object sender, EventArgs e)
        {
            if (reveal32 == true)
            {
                return;
            }
            if (nameoldcount % 2 == 0)
            {
                nameold = (PictureBox)sender;
            }
            nameoldcount++;
            if (allReveal == 2)
            {
                limpALL();

            }
            if (reveal32 == false && revealed32 == false)
            {
                PictureBox pb = (PictureBox)sender;
                reveal32 = true;
                if (pb != null)
                {
                    geraImg(pb);
                }
                reveal32 = true;
                allReveal++;
                revealed32 = true;
                pb32 = ctrl - 1;
            }
            else if (reveal32 == false && revealed32 == true)
            {
                PictureBox pb = (PictureBox)sender;
                reveal32 = true;
                if (pb != null)
                {
                    geraImg2(pb32, pb);
                    reveal32 = true;
                    allReveal++;
                    revealed32 = true;
                }
            }
        }

        private void limpALL ()
        {
            pb_card1.Image = Properties.Resources.SeekPng_com_card_back_png_3492279;
            pb_card1.SizeMode = PictureBoxSizeMode.StretchImage;
            pb_card1.BackColor = Color.Transparent;
            pb_card2.Image = Properties.Resources.SeekPng_com_card_back_png_3492279;
            pb_card2.SizeMode = PictureBoxSizeMode.StretchImage;
            pb_card2.BackColor = Color.Transparent;
            pb_card3.Image = Properties.Resources.SeekPng_com_card_back_png_3492279;
            pb_card3.SizeMode = PictureBoxSizeMode.StretchImage;
            pb_card3.BackColor = Color.Transparent;
            pb_card4.Image = Properties.Resources.SeekPng_com_card_back_png_3492279;
            pb_card4.SizeMode = PictureBoxSizeMode.StretchImage;
            pb_card4.BackColor = Color.Transparent;
            pb_card5.Image = Properties.Resources.SeekPng_com_card_back_png_3492279;
            pb_card5.SizeMode = PictureBoxSizeMode.StretchImage;
            pb_card5.BackColor = Color.Transparent;
            pb_card6.Image = Properties.Resources.SeekPng_com_card_back_png_3492279;
            pb_card6.SizeMode = PictureBoxSizeMode.StretchImage;
            pb_card6.BackColor = Color.Transparent;
            pb_card7.Image = Properties.Resources.SeekPng_com_card_back_png_3492279;
            pb_card7.SizeMode = PictureBoxSizeMode.StretchImage;
            pb_card7.BackColor = Color.Transparent;
            pb_card8.Image = Properties.Resources.SeekPng_com_card_back_png_3492279;
            pb_card8.SizeMode = PictureBoxSizeMode.StretchImage;
            pb_card8.BackColor = Color.Transparent;
            pb_card9.Image = Properties.Resources.SeekPng_com_card_back_png_3492279;
            pb_card9.SizeMode = PictureBoxSizeMode.StretchImage;
            pb_card9.BackColor = Color.Transparent;
            pb_card10.Image = Properties.Resources.SeekPng_com_card_back_png_3492279;
            pb_card10.SizeMode = PictureBoxSizeMode.StretchImage;
            pb_card10.BackColor = Color.Transparent;
            pb_card11.Image = Properties.Resources.SeekPng_com_card_back_png_3492279;
            pb_card11.SizeMode = PictureBoxSizeMode.StretchImage;
            pb_card11.BackColor = Color.Transparent;
            pb_card12.Image = Properties.Resources.SeekPng_com_card_back_png_3492279;
            pb_card12.SizeMode = PictureBoxSizeMode.StretchImage;
            pb_card12.BackColor = Color.Transparent;
            pb_card13.Image = Properties.Resources.SeekPng_com_card_back_png_3492279;
            pb_card13.SizeMode = PictureBoxSizeMode.StretchImage;
            pb_card13.BackColor = Color.Transparent;
            pb_card14.Image = Properties.Resources.SeekPng_com_card_back_png_3492279;
            pb_card14.SizeMode = PictureBoxSizeMode.StretchImage;
            pb_card14.BackColor = Color.Transparent;
            pb_card15.Image = Properties.Resources.SeekPng_com_card_back_png_3492279;
            pb_card15.SizeMode = PictureBoxSizeMode.StretchImage;
            pb_card15.BackColor = Color.Transparent;
            pb_card16.Image = Properties.Resources.SeekPng_com_card_back_png_3492279;
            pb_card16.SizeMode = PictureBoxSizeMode.StretchImage;
            pb_card16.BackColor = Color.Transparent;
            pb_card17.Image = Properties.Resources.SeekPng_com_card_back_png_3492279;
            pb_card17.SizeMode = PictureBoxSizeMode.StretchImage;
            pb_card17.BackColor = Color.Transparent;
            pb_card18.Image = Properties.Resources.SeekPng_com_card_back_png_3492279;
            pb_card18.SizeMode = PictureBoxSizeMode.StretchImage;
            pb_card18.BackColor = Color.Transparent;
            pb_card19.Image = Properties.Resources.SeekPng_com_card_back_png_3492279;
            pb_card19.SizeMode = PictureBoxSizeMode.StretchImage;
            pb_card19.BackColor = Color.Transparent;
            pb_card20.Image = Properties.Resources.SeekPng_com_card_back_png_3492279;
            pb_card20.SizeMode = PictureBoxSizeMode.StretchImage;
            pb_card20.BackColor = Color.Transparent;
            pb_card21.Image = Properties.Resources.SeekPng_com_card_back_png_3492279;
            pb_card21.SizeMode = PictureBoxSizeMode.StretchImage;
            pb_card21.BackColor = Color.Transparent;
            pb_card22.Image = Properties.Resources.SeekPng_com_card_back_png_3492279;
            pb_card22.SizeMode = PictureBoxSizeMode.StretchImage;
            pb_card22.BackColor = Color.Transparent;
            pb_card23.Image = Properties.Resources.SeekPng_com_card_back_png_3492279;
            pb_card23.SizeMode = PictureBoxSizeMode.StretchImage;
            pb_card23.BackColor = Color.Transparent;
            pb_card24.Image = Properties.Resources.SeekPng_com_card_back_png_3492279;
            pb_card24.SizeMode = PictureBoxSizeMode.StretchImage;
            pb_card24.BackColor = Color.Transparent;
            pb_card25.Image = Properties.Resources.SeekPng_com_card_back_png_3492279;
            pb_card25.SizeMode = PictureBoxSizeMode.StretchImage;
            pb_card25.BackColor = Color.Transparent;
            pb_card26.Image = Properties.Resources.SeekPng_com_card_back_png_3492279;
            pb_card26.SizeMode = PictureBoxSizeMode.StretchImage;
            pb_card26.BackColor = Color.Transparent;
            pb_card27.Image = Properties.Resources.SeekPng_com_card_back_png_3492279;
            pb_card27.SizeMode = PictureBoxSizeMode.StretchImage;
            pb_card27.BackColor = Color.Transparent;
            pb_card28.Image = Properties.Resources.SeekPng_com_card_back_png_3492279;
            pb_card28.SizeMode = PictureBoxSizeMode.StretchImage;
            pb_card28.BackColor = Color.Transparent;
            pb_card29.Image = Properties.Resources.SeekPng_com_card_back_png_3492279;
            pb_card29.SizeMode = PictureBoxSizeMode.StretchImage;
            pb_card29.BackColor = Color.Transparent;
            pb_card30.Image = Properties.Resources.SeekPng_com_card_back_png_3492279;
            pb_card30.SizeMode = PictureBoxSizeMode.StretchImage;
            pb_card30.BackColor = Color.Transparent;
            pb_card31.Image = Properties.Resources.SeekPng_com_card_back_png_3492279;
            pb_card31.SizeMode = PictureBoxSizeMode.StretchImage;
            pb_card31.BackColor = Color.Transparent;
            pb_card32.Image = Properties.Resources.SeekPng_com_card_back_png_3492279;
            pb_card32.SizeMode = PictureBoxSizeMode.StretchImage;
            pb_card32.BackColor = Color.Transparent;
            allReveal = 0;
            reveal1 = false;
            reveal2 = false;
            reveal3 = false;
            reveal4 = false;
            reveal5 = false;
            reveal6 = false;
            reveal7 = false;
            reveal8 = false;
            reveal9 = false;
            reveal10 = false;
            reveal11 = false;
            reveal12 = false;
            reveal13 = false;
            reveal14 = false;
            reveal15 = false;
            reveal16 = false;
            reveal17 = false;
            reveal18 = false;
            reveal19 = false;
            reveal20 = false;
            reveal21 = false;
            reveal22 = false;
            reveal23 = false;
            reveal24 = false;
            reveal25 = false;
            reveal26 = false;
            reveal27 = false;
            reveal28 = false;
            reveal29 = false;
            reveal30 = false;
            reveal31 = false;
            reveal32 = false;
            lasta = 0;
            lastb = 0;
        }
        private void geraImg(PictureBox name)
        {
            
            //cartaimg[0] = 0;
            for (int i = 0; i <= 15; i++)
            {
                //System.Diagnostics.Debug.WriteLine(cartaimg[i] + "|" + cartaword[i]);
                //System.Diagnostics.Debug.Write(cartaimg[i] + "|");
            }
            //System.Diagnostics.Debug.WriteLine(cartaimg[i] + "|" + cartaword[i]);
            //Random rnd = new Random();
            //int randomNumber = rnd.Next(0, 3)
            //for (int i = 0; i < 15; i++)
            //{

            checkMatch(name);
            System.Diagnostics.Debug.WriteLine("name old: " + nameold.Name);
            switch (cartaimg[ctrl])
            {
                case 0:
                    name.Image = Properties.Resources._01;
                    name.SizeMode = PictureBoxSizeMode.StretchImage;
                    name.BackColor = Color.Transparent;
                    
                    ctrl++;
                    break;

                case 1:
                    name.Image = Properties.Resources._02;
                    name.SizeMode = PictureBoxSizeMode.StretchImage;
                    name.BackColor = Color.Transparent;
                    ctrl++;
                    break;

                case 2:
                    name.Image = Properties.Resources._03;
                    name.SizeMode = PictureBoxSizeMode.StretchImage;
                    name.BackColor = Color.Transparent;
                    ctrl++;
                    break;

                case 3:
                    name.Image = Properties.Resources._04;
                    name.SizeMode = PictureBoxSizeMode.StretchImage;
                    name.BackColor = Color.Transparent;
                    ctrl++;
                    break;

                case 4:
                    name.Image = Properties.Resources._05;
                    name.SizeMode = PictureBoxSizeMode.StretchImage;
                    name.BackColor = Color.Transparent;
                    ctrl++;
                    break;

                case 5:
                    name.Image = Properties.Resources._06;
                    name.SizeMode = PictureBoxSizeMode.StretchImage;
                    name.BackColor = Color.Transparent;
                    ctrl++;
                    break;

                case 6:
                    name.Image = Properties.Resources._07;
                    name.SizeMode = PictureBoxSizeMode.StretchImage;
                    name.BackColor = Color.Transparent;
                    ctrl++;
                    break;

                case 7:
                    name.Image = Properties.Resources._08;
                    name.SizeMode = PictureBoxSizeMode.StretchImage;
                    name.BackColor = Color.Transparent;
                    ctrl++;
                    break;

                case 8:
                    name.Image = Properties.Resources._09;
                    name.SizeMode = PictureBoxSizeMode.StretchImage;
                    name.BackColor = Color.Transparent;
                    ctrl++;
                    break;

                case 9:
                    name.Image = Properties.Resources._010;
                    name.SizeMode = PictureBoxSizeMode.StretchImage;
                    name.BackColor = Color.Transparent;
                    ctrl++;
                    break;

                case 10:
                    name.Image = Properties.Resources._011;
                    name.SizeMode = PictureBoxSizeMode.StretchImage;
                    name.BackColor = Color.Transparent;
                    ctrl++;
                    break;

                case 11:
                    name.Image = Properties.Resources._012;
                    name.SizeMode = PictureBoxSizeMode.StretchImage;
                    name.BackColor = Color.Transparent;
                    ctrl++;
                    break;

                case 12:
                    name.Image = Properties.Resources._013;
                    name.SizeMode = PictureBoxSizeMode.StretchImage;
                    name.BackColor = Color.Transparent;
                    ctrl++;
                    break;

                case 13:
                    name.Image = Properties.Resources._014;
                    name.SizeMode = PictureBoxSizeMode.StretchImage;
                    name.BackColor = Color.Transparent;
                    ctrl++;
                    break;

                case 14:
                    name.Image = Properties.Resources._015;
                    name.SizeMode = PictureBoxSizeMode.StretchImage;
                    name.BackColor = Color.Transparent;
                    ctrl++;
                    break;

                case 15:
                    name.Image = Properties.Resources._016;
                    name.SizeMode = PictureBoxSizeMode.StretchImage;
                    name.BackColor = Color.Transparent;
                    ctrl++;
                    break;

                case 16:
                    name.Image = Properties.Resources._001;
                    name.SizeMode = PictureBoxSizeMode.StretchImage;
                    name.BackColor = Color.Transparent;
                    ctrl++;
                    break;

                case 17:
                    name.Image = Properties.Resources._002;
                    name.SizeMode = PictureBoxSizeMode.StretchImage;
                    name.BackColor = Color.Transparent;
                    ctrl++;
                    break;

                case 18:
                    name.Image = Properties.Resources._003;
                    name.SizeMode = PictureBoxSizeMode.StretchImage;
                    name.BackColor = Color.Transparent;
                    ctrl++;
                    break;

                case 19:
                    name.Image = Properties.Resources._004;
                    name.SizeMode = PictureBoxSizeMode.StretchImage;
                    name.BackColor = Color.Transparent;
                    ctrl++;
                    break;

                case 20:
                    name.Image = Properties.Resources._005;
                    name.SizeMode = PictureBoxSizeMode.StretchImage;
                    name.BackColor = Color.Transparent;
                    ctrl++;
                    break;

                case 21:
                    name.Image = Properties.Resources._006;
                    name.SizeMode = PictureBoxSizeMode.StretchImage;
                    name.BackColor = Color.Transparent;
                    ctrl++;
                    break;

                case 22:
                    name.Image = Properties.Resources._007;
                    name.SizeMode = PictureBoxSizeMode.StretchImage;
                    name.BackColor = Color.Transparent;
                    ctrl++;
                    break;

                case 23:
                    name.Image = Properties.Resources._008;

                    name.SizeMode = PictureBoxSizeMode.StretchImage;
                    name.BackColor = Color.Transparent;
                    ctrl++;
                    break;

                case 24:
                    name.Image = Properties.Resources._009;
                    name.SizeMode = PictureBoxSizeMode.StretchImage;
                    name.BackColor = Color.Transparent;
                    ctrl++;
                    break;

                case 25:
                    name.Image = Properties.Resources._0010;
                    name.SizeMode = PictureBoxSizeMode.StretchImage;
                    name.BackColor = Color.Transparent;
                    ctrl++;
                    break;

                case 26:
                    name.Image = Properties.Resources._0011;
                    name.SizeMode = PictureBoxSizeMode.StretchImage;
                    name.BackColor = Color.Transparent;
                    ctrl++;
                    break;

                case 27:
                    name.Image = Properties.Resources._0012;
                    name.SizeMode = PictureBoxSizeMode.StretchImage;
                    name.BackColor = Color.Transparent;
                    ctrl++;
                    break;

                case 28:
                    name.Image = Properties.Resources._0013;
                    name.SizeMode = PictureBoxSizeMode.StretchImage;
                    name.BackColor = Color.Transparent;
                    ctrl++;
                    break;

                case 29:
                    name.Image = Properties.Resources._0014;
                    name.SizeMode = PictureBoxSizeMode.StretchImage;
                    name.BackColor = Color.Transparent;
                    ctrl++;
                    break;

                case 30:
                    name.Image = Properties.Resources._0015;
                    name.SizeMode = PictureBoxSizeMode.StretchImage;
                    name.BackColor = Color.Transparent;
                    ctrl++;
                    break;

                case 31:
                    name.Image = Properties.Resources._0016;
                    name.SizeMode = PictureBoxSizeMode.StretchImage;
                    name.BackColor = Color.Transparent;
                    ctrl++;
                    break;
            }
            //cartachoosed[25] = name;//cartaimg[ctrl];
            //pb1 = cartaimg[ctrl-1];


            //}

        }

        private void checkMatch(PictureBox x)
        {
            if (allReveal == 0)
            {
                 lasta = cartaimg[ctrl];
            }
            if(allReveal == 1)
            {
                 lastb = cartaimg[ctrl];
            }
                    System.Diagnostics.Debug.WriteLine("lastA: "+lasta+" | lastB: "+lastb);
            if ((lasta + lastb == 42 || lasta - lastb == 16 || lasta - lastb == -16) && (lasta != 0) && (lastb != 0))
            {
                System.Diagnostics.Debug.WriteLine("!!!!!! CongRatulatIonS Removeu no A !!!!!!!!!");
                x.Visible = false;
                nameold.Visible = false;
                //lastaInvisible();

                //x.Image = null;
            }
        }

        private bool checkMatch2(int a, PictureBox x)
        {
            bool match = false;
            if (allReveal == 0)
            {
                lasta = cartaimg[a];
            }
            if (allReveal == 1)
            {
                lastb = cartaimg[a];
            }
            System.Diagnostics.Debug.WriteLine("lastA: " + lasta + " | lastB: " + lastb);
            if((lasta + lastb == 42 || lasta - lastb == 16 || lasta - lastb == -16) && (lasta != 0) && (lastb != 0))
            {
                System.Diagnostics.Debug.WriteLine("all reveal: "+allReveal);
                match = true;
            }

            return  match;
        }


        private void geraImg2(int a,PictureBox name)
        {
            bool b = checkMatch2(a, name);
            if (b == true)
            {
                System.Diagnostics.Debug.WriteLine("Remove lastA: " + lasta);
                System.Diagnostics.Debug.WriteLine("Remove lastb: " + lastb);
                System.Diagnostics.Debug.WriteLine("Valor A: " + a);
                System.Diagnostics.Debug.WriteLine("Valor CTRL: " + ctrl);
                System.Diagnostics.Debug.Write("valor doreveal1: " + reveal1);
                System.Diagnostics.Debug.WriteLine("name old: " + nameold.Name);

                name.Visible = false;
                nameold.Visible = false;
                tb_points.Text = (int.Parse(tb_points.Text) + 10).ToString();
                //lastaInvisible();
                System.Diagnostics.Debug.WriteLine("!!!!!! CongRatulatIonS Removeu no B !!!!!!!!!");
                System.Diagnostics.Debug.WriteLine("name old: "+nameold.Name);
                //lastaInvisible(lastb);
                return;
            }
            switch (cartaimg[a])
            {
                case 0:
                    name.Image = Properties.Resources._01;
                    name.SizeMode = PictureBoxSizeMode.StretchImage;
                    name.BackColor = Color.Transparent;

                    break;

                case 1:
                    name.Image = Properties.Resources._02;
                    name.SizeMode = PictureBoxSizeMode.StretchImage;
                    name.BackColor = Color.Transparent;
                    break;

                case 2:
                    name.Image = Properties.Resources._03;
                    name.SizeMode = PictureBoxSizeMode.StretchImage;
                    name.BackColor = Color.Transparent;
                    break;

                case 3:
                    name.Image = Properties.Resources._04;
                    name.SizeMode = PictureBoxSizeMode.StretchImage;
                    name.BackColor = Color.Transparent;
                    break;

                case 4:
                    name.Image = Properties.Resources._05;
                    name.SizeMode = PictureBoxSizeMode.StretchImage;
                    name.BackColor = Color.Transparent;
                    break;

                case 5:
                    name.Image = Properties.Resources._06;
                    name.SizeMode = PictureBoxSizeMode.StretchImage;
                    name.BackColor = Color.Transparent;
                    break;

                case 6:
                    name.Image = Properties.Resources._07;
                    name.SizeMode = PictureBoxSizeMode.StretchImage;
                    name.BackColor = Color.Transparent;
                    break;

                case 7:
                    name.Image = Properties.Resources._08;
                    name.SizeMode = PictureBoxSizeMode.StretchImage;
                    name.BackColor = Color.Transparent;
                    break;

                case 8:
                    name.Image = Properties.Resources._09;
                    name.SizeMode = PictureBoxSizeMode.StretchImage;
                    name.BackColor = Color.Transparent;
                    break;

                case 9:
                    name.Image = Properties.Resources._010;
                    name.SizeMode = PictureBoxSizeMode.StretchImage;
                    name.BackColor = Color.Transparent;
                    break;

                case 10:
                    name.Image = Properties.Resources._011;
                    name.SizeMode = PictureBoxSizeMode.StretchImage;
                    name.BackColor = Color.Transparent;
                    break;

                case 11:
                    name.Image = Properties.Resources._012;
                    name.SizeMode = PictureBoxSizeMode.StretchImage;
                    name.BackColor = Color.Transparent;
                    break;

                case 12:
                    name.Image = Properties.Resources._013;
                    name.SizeMode = PictureBoxSizeMode.StretchImage;
                    name.BackColor = Color.Transparent;
                    break;

                case 13:
                    name.Image = Properties.Resources._014;
                    name.SizeMode = PictureBoxSizeMode.StretchImage;
                    name.BackColor = Color.Transparent;
                    break;

                case 14:
                    name.Image = Properties.Resources._015;
                    name.SizeMode = PictureBoxSizeMode.StretchImage;
                    name.BackColor = Color.Transparent;
                    break;

                case 15:
                    name.Image = Properties.Resources._016;
                    name.SizeMode = PictureBoxSizeMode.StretchImage;
                    name.BackColor = Color.Transparent;
                    break;

                case 16:
                    name.Image = Properties.Resources._001;
                    name.SizeMode = PictureBoxSizeMode.StretchImage;
                    name.BackColor = Color.Transparent;
                    break;

                case 17:
                    name.Image = Properties.Resources._002;
                    name.SizeMode = PictureBoxSizeMode.StretchImage;
                    name.BackColor = Color.Transparent;
                    break;

                case 18:
                    name.Image = Properties.Resources._003;
                    name.SizeMode = PictureBoxSizeMode.StretchImage;
                    name.BackColor = Color.Transparent;
                    break;

                case 19:
                    name.Image = Properties.Resources._004;
                    name.SizeMode = PictureBoxSizeMode.StretchImage;
                    name.BackColor = Color.Transparent;
                    break;

                case 20:
                    name.Image = Properties.Resources._005;
                    name.SizeMode = PictureBoxSizeMode.StretchImage;
                    name.BackColor = Color.Transparent;
                    break;

                case 21:
                    name.Image = Properties.Resources._006;
                    name.SizeMode = PictureBoxSizeMode.StretchImage;
                    name.BackColor = Color.Transparent;
                    break;

                case 22:
                    name.Image = Properties.Resources._007;
                    name.SizeMode = PictureBoxSizeMode.StretchImage;
                    name.BackColor = Color.Transparent;
                    break;

                case 23:
                    name.Image = Properties.Resources._008;
                    name.SizeMode = PictureBoxSizeMode.StretchImage;
                    name.BackColor = Color.Transparent;
                    break;

                case 24:
                    name.Image = Properties.Resources._009;
                    name.SizeMode = PictureBoxSizeMode.StretchImage;
                    name.BackColor = Color.Transparent;
                    break;

                case 25:
                    name.Image = Properties.Resources._0010;
                    name.SizeMode = PictureBoxSizeMode.StretchImage;
                    name.BackColor = Color.Transparent;
                    break;

                case 26:
                    name.Image = Properties.Resources._0011;
                    name.SizeMode = PictureBoxSizeMode.StretchImage;
                    name.BackColor = Color.Transparent;
                    break;

                case 27:
                    name.Image = Properties.Resources._0012;
                    name.SizeMode = PictureBoxSizeMode.StretchImage;
                    name.BackColor = Color.Transparent;
                    break;

                case 28:
                    name.Image = Properties.Resources._0013;
                    name.SizeMode = PictureBoxSizeMode.StretchImage;
                    name.BackColor = Color.Transparent;
                    break;

                case 29:
                    name.Image = Properties.Resources._0014;
                    name.SizeMode = PictureBoxSizeMode.StretchImage;
                    name.BackColor = Color.Transparent;
                    break;

                case 30:
                    name.Image = Properties.Resources._0015;
                    name.SizeMode = PictureBoxSizeMode.StretchImage;
                    name.BackColor = Color.Transparent;
                    break;

                case 31:
                    name.Image = Properties.Resources._0016;
                    name.SizeMode = PictureBoxSizeMode.StretchImage;
                    name.BackColor = Color.Transparent;
                    break;
            }
            //}

        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            string vquerySelect = "SELECT N_PONTOGAMETHREE FROM tb_usuarios WHERE N_IDUSUARIO = '" + Globais.id + "'";
            dt = Banco.dql(vquerySelect);
            //soma banco + atual
            int pts = (int.Parse(tb_points.Text) + int.Parse(dt.Rows[0].Field<Int64>("N_PONTOGAMETHREE").ToString()));
            //atualiza
            string vqueryUpdate = "UPDATE tb_usuarios SET N_PONTOGAMETHREE = ('" + pts + "') WHERE N_IDUSUARIO = '" + Globais.id + "'";                                                                                      //WHERE T_USERNAME='"+u.username+"'";
            Banco.dml(vqueryUpdate);

            this.Close();
        }


    }
}
