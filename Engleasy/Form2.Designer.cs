namespace Engleasy
{
    partial class Gametwo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Gametwo));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pb_answer = new System.Windows.Forms.PictureBox();
            this.pb_rightanswer = new System.Windows.Forms.PictureBox();
            this.pb_wronganswer = new System.Windows.Forms.PictureBox();
            this.tb_answerShow = new System.Windows.Forms.TextBox();
            this.tb_answer = new System.Windows.Forms.TextBox();
            this.btn_send = new System.Windows.Forms.Button();
            this.btn_play = new System.Windows.Forms.Button();
            this.tb_points = new System.Windows.Forms.TextBox();
            this.pbox_iconStar = new System.Windows.Forms.PictureBox();
            this.lb_acertou = new System.Windows.Forms.Label();
            this.pb_nullAnswer = new System.Windows.Forms.PictureBox();
            this.btn_Close = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_answer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_rightanswer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_wronganswer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_iconStar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_nullAnswer)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::Engleasy.Properties.Resources.Screenshot_2022_03_21_02_04_25_161_com_whatsapp;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(224, 125);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(405, 765);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pb_answer
            // 
            this.pb_answer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(230)))), ((int)(((byte)(220)))));
            this.pb_answer.BackgroundImage = global::Engleasy.Properties.Resources.emptyanswer;
            this.pb_answer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb_answer.Location = new System.Drawing.Point(402, 506);
            this.pb_answer.Name = "pb_answer";
            this.pb_answer.Size = new System.Drawing.Size(208, 45);
            this.pb_answer.TabIndex = 1;
            this.pb_answer.TabStop = false;
            this.pb_answer.Visible = false;
            // 
            // pb_rightanswer
            // 
            this.pb_rightanswer.BackColor = System.Drawing.Color.OldLace;
            this.pb_rightanswer.BackgroundImage = global::Engleasy.Properties.Resources.rightanswer;
            this.pb_rightanswer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb_rightanswer.Location = new System.Drawing.Point(240, 566);
            this.pb_rightanswer.Name = "pb_rightanswer";
            this.pb_rightanswer.Size = new System.Drawing.Size(281, 50);
            this.pb_rightanswer.TabIndex = 2;
            this.pb_rightanswer.TabStop = false;
            this.pb_rightanswer.Visible = false;
            // 
            // pb_wronganswer
            // 
            this.pb_wronganswer.BackColor = System.Drawing.Color.OldLace;
            this.pb_wronganswer.BackgroundImage = global::Engleasy.Properties.Resources.wronganswer;
            this.pb_wronganswer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb_wronganswer.Location = new System.Drawing.Point(240, 566);
            this.pb_wronganswer.Name = "pb_wronganswer";
            this.pb_wronganswer.Size = new System.Drawing.Size(270, 40);
            this.pb_wronganswer.TabIndex = 3;
            this.pb_wronganswer.TabStop = false;
            this.pb_wronganswer.Visible = false;
            // 
            // tb_answerShow
            // 
            this.tb_answerShow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(255)))), ((int)(((byte)(219)))));
            this.tb_answerShow.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_answerShow.Enabled = false;
            this.tb_answerShow.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_answerShow.Location = new System.Drawing.Point(425, 516);
            this.tb_answerShow.Name = "tb_answerShow";
            this.tb_answerShow.ReadOnly = true;
            this.tb_answerShow.Size = new System.Drawing.Size(63, 25);
            this.tb_answerShow.TabIndex = 5;
            this.tb_answerShow.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tb_answerShow.Visible = false;
            // 
            // tb_answer
            // 
            this.tb_answer.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_answer.Location = new System.Drawing.Point(240, 806);
            this.tb_answer.Name = "tb_answer";
            this.tb_answer.Size = new System.Drawing.Size(270, 32);
            this.tb_answer.TabIndex = 6;
            // 
            // btn_send
            // 
            this.btn_send.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(230)))), ((int)(((byte)(220)))));
            this.btn_send.BackgroundImage = global::Engleasy.Properties.Resources.sendbutton;
            this.btn_send.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_send.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_send.FlatAppearance.BorderSize = 0;
            this.btn_send.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_send.Location = new System.Drawing.Point(570, 795);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(58, 50);
            this.btn_send.TabIndex = 7;
            this.btn_send.UseVisualStyleBackColor = false;
            this.btn_send.Click += new System.EventHandler(this.btn_send_Click);
            // 
            // btn_play
            // 
            this.btn_play.BackgroundImage = global::Engleasy.Properties.Resources.play;
            this.btn_play.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_play.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_play.Location = new System.Drawing.Point(258, 440);
            this.btn_play.Name = "btn_play";
            this.btn_play.Size = new System.Drawing.Size(29, 30);
            this.btn_play.TabIndex = 8;
            this.btn_play.UseVisualStyleBackColor = true;
            this.btn_play.Click += new System.EventHandler(this.btn_play_Click);
            // 
            // tb_points
            // 
            this.tb_points.BackColor = System.Drawing.Color.DarkGray;
            this.tb_points.Enabled = false;
            this.tb_points.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tb_points.Location = new System.Drawing.Point(722, 156);
            this.tb_points.Name = "tb_points";
            this.tb_points.ReadOnly = true;
            this.tb_points.Size = new System.Drawing.Size(58, 27);
            this.tb_points.TabIndex = 11;
            this.tb_points.Text = "0";
            this.tb_points.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pbox_iconStar
            // 
            this.pbox_iconStar.BackColor = System.Drawing.Color.Transparent;
            this.pbox_iconStar.BackgroundImage = global::Engleasy.Properties.Resources.kindpng_6003350;
            this.pbox_iconStar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbox_iconStar.Location = new System.Drawing.Point(658, 146);
            this.pbox_iconStar.Name = "pbox_iconStar";
            this.pbox_iconStar.Size = new System.Drawing.Size(58, 47);
            this.pbox_iconStar.TabIndex = 10;
            this.pbox_iconStar.TabStop = false;
            // 
            // lb_acertou
            // 
            this.lb_acertou.AutoSize = true;
            this.lb_acertou.BackColor = System.Drawing.Color.Transparent;
            this.lb_acertou.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_acertou.ForeColor = System.Drawing.Color.LawnGreen;
            this.lb_acertou.Location = new System.Drawing.Point(711, 186);
            this.lb_acertou.Name = "lb_acertou";
            this.lb_acertou.Size = new System.Drawing.Size(79, 25);
            this.lb_acertou.TabIndex = 12;
            this.lb_acertou.Text = "+10 pts";
            this.lb_acertou.Visible = false;
            // 
            // pb_nullAnswer
            // 
            this.pb_nullAnswer.BackColor = System.Drawing.Color.OldLace;
            this.pb_nullAnswer.BackgroundImage = global::Engleasy.Properties.Resources.nullAnswer;
            this.pb_nullAnswer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb_nullAnswer.Location = new System.Drawing.Point(240, 566);
            this.pb_nullAnswer.Name = "pb_nullAnswer";
            this.pb_nullAnswer.Size = new System.Drawing.Size(281, 50);
            this.pb_nullAnswer.TabIndex = 13;
            this.pb_nullAnswer.TabStop = false;
            this.pb_nullAnswer.Visible = false;
            // 
            // btn_Close
            // 
            this.btn_Close.BackColor = System.Drawing.Color.Transparent;
            this.btn_Close.BackgroundImage = global::Engleasy.Properties.Resources.close_button_red_svg_med;
            this.btn_Close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Close.Location = new System.Drawing.Point(671, 847);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(119, 43);
            this.btn_Close.TabIndex = 14;
            this.btn_Close.UseVisualStyleBackColor = false;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // Gametwo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(874, 1018);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.pb_nullAnswer);
            this.Controls.Add(this.lb_acertou);
            this.Controls.Add(this.tb_points);
            this.Controls.Add(this.pbox_iconStar);
            this.Controls.Add(this.btn_play);
            this.Controls.Add(this.btn_send);
            this.Controls.Add(this.tb_answer);
            this.Controls.Add(this.tb_answerShow);
            this.Controls.Add(this.pb_wronganswer);
            this.Controls.Add(this.pb_rightanswer);
            this.Controls.Add(this.pb_answer);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Gametwo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gametwo";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_answer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_rightanswer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_wronganswer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_iconStar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_nullAnswer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pb_answer;
        private PictureBox pb_rightanswer;
        private PictureBox pb_wronganswer;
        private TextBox tb_answerShow;
        private TextBox tb_answer;
        private Button btn_send;
        private Button btn_play;
        private TextBox tb_points;
        private PictureBox pbox_iconStar;
        private Label lb_acertou;
        private PictureBox pb_nullAnswer;
        private Button btn_Close;
    }
}