namespace Engleasy
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbn_mypt3 = new System.Windows.Forms.Label();
            this.lbn32 = new System.Windows.Forms.Label();
            this.lbn_mypt1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbn_nomeUsuario = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lb_acesso = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pb_ledLogado = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.lbn_mypt2 = new System.Windows.Forms.Label();
            this.lbn27 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.registrarNovoAlunoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.consultarRankToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administraçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bancoDeDadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.limparRankToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.rtb_changelog = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.timer_updt = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_ledLogado)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.lbn_mypt3);
            this.panel1.Controls.Add(this.lbn32);
            this.panel1.Controls.Add(this.lbn_mypt2);
            this.panel1.Controls.Add(this.lbn27);
            this.panel1.Controls.Add(this.lbn_mypt1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.lbn_nomeUsuario);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lb_acesso);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pb_ledLogado);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 443);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(689, 21);
            this.panel1.TabIndex = 0;
            // 
            // lbn_mypt3
            // 
            this.lbn_mypt3.AutoSize = true;
            this.lbn_mypt3.Location = new System.Drawing.Point(653, 3);
            this.lbn_mypt3.Name = "lbn_mypt3";
            this.lbn_mypt3.Size = new System.Drawing.Size(13, 15);
            this.lbn_mypt3.TabIndex = 10;
            this.lbn_mypt3.Text = "0";
            // 
            // lbn32
            // 
            this.lbn32.AutoSize = true;
            this.lbn32.Location = new System.Drawing.Point(574, 3);
            this.lbn32.Name = "lbn32";
            this.lbn32.Size = new System.Drawing.Size(73, 15);
            this.lbn32.TabIndex = 9;
            this.lbn32.Text = "Game Three:";
            // 
            // lbn_mypt1
            // 
            this.lbn_mypt1.AutoSize = true;
            this.lbn_mypt1.Location = new System.Drawing.Point(431, 3);
            this.lbn_mypt1.Name = "lbn_mypt1";
            this.lbn_mypt1.Size = new System.Drawing.Size(13, 15);
            this.lbn_mypt1.TabIndex = 6;
            this.lbn_mypt1.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(359, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "Game One:";
            // 
            // lbn_nomeUsuario
            // 
            this.lbn_nomeUsuario.AutoSize = true;
            this.lbn_nomeUsuario.Location = new System.Drawing.Point(199, 3);
            this.lbn_nomeUsuario.Name = "lbn_nomeUsuario";
            this.lbn_nomeUsuario.Size = new System.Drawing.Size(22, 15);
            this.lbn_nomeUsuario.TabIndex = 4;
            this.lbn_nomeUsuario.Text = "---";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(152, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Usuário:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // lb_acesso
            // 
            this.lb_acesso.AutoSize = true;
            this.lb_acesso.Location = new System.Drawing.Point(83, 3);
            this.lb_acesso.Name = "lb_acesso";
            this.lb_acesso.Size = new System.Drawing.Size(13, 15);
            this.lb_acesso.TabIndex = 2;
            this.lb_acesso.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Acesso:";
            // 
            // pb_ledLogado
            // 
            this.pb_ledLogado.Image = global::Engleasy.Properties.Resources.led_vermelho;
            this.pb_ledLogado.Location = new System.Drawing.Point(3, 3);
            this.pb_ledLogado.Name = "pb_ledLogado";
            this.pb_ledLogado.Size = new System.Drawing.Size(21, 15);
            this.pb_ledLogado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_ledLogado.TabIndex = 0;
            this.pb_ledLogado.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(298, 3);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 15);
            this.label10.TabIndex = 11;
            this.label10.Text = "Pontos - ";
            // 
            // lbn_mypt2
            // 
            this.lbn_mypt2.AutoSize = true;
            this.lbn_mypt2.Location = new System.Drawing.Point(536, 3);
            this.lbn_mypt2.Name = "lbn_mypt2";
            this.lbn_mypt2.Size = new System.Drawing.Size(13, 15);
            this.lbn_mypt2.TabIndex = 8;
            this.lbn_mypt2.Text = "0";
            // 
            // lbn27
            // 
            this.lbn27.AutoSize = true;
            this.lbn27.Location = new System.Drawing.Point(465, 3);
            this.lbn27.Name = "lbn27";
            this.lbn27.Size = new System.Drawing.Size(65, 15);
            this.lbn27.TabIndex = 7;
            this.lbn27.Text = "Game Two:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loginToolStripMenuItem,
            this.administraçãoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(689, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logonToolStripMenuItem,
            this.logoffToolStripMenuItem,
            this.toolStripMenuItem1,
            this.registrarNovoAlunoToolStripMenuItem,
            this.toolStripMenuItem2,
            this.consultarRankToolStripMenuItem});
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.loginToolStripMenuItem.Text = "Aluno";
            // 
            // logonToolStripMenuItem
            // 
            this.logonToolStripMenuItem.Name = "logonToolStripMenuItem";
            this.logonToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.logonToolStripMenuItem.Text = "Logon";
            this.logonToolStripMenuItem.Click += new System.EventHandler(this.logonToolStripMenuItem_Click);
            // 
            // logoffToolStripMenuItem
            // 
            this.logoffToolStripMenuItem.Name = "logoffToolStripMenuItem";
            this.logoffToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.logoffToolStripMenuItem.Text = "Logoff";
            this.logoffToolStripMenuItem.Click += new System.EventHandler(this.logoffToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(184, 6);
            // 
            // registrarNovoAlunoToolStripMenuItem
            // 
            this.registrarNovoAlunoToolStripMenuItem.Name = "registrarNovoAlunoToolStripMenuItem";
            this.registrarNovoAlunoToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.registrarNovoAlunoToolStripMenuItem.Text = "Registrar Novo Aluno";
            this.registrarNovoAlunoToolStripMenuItem.Click += new System.EventHandler(this.registrarNovoAlunoToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(184, 6);
            // 
            // consultarRankToolStripMenuItem
            // 
            this.consultarRankToolStripMenuItem.Name = "consultarRankToolStripMenuItem";
            this.consultarRankToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.consultarRankToolStripMenuItem.Text = "Consultar Rank";
            // 
            // administraçãoToolStripMenuItem
            // 
            this.administraçãoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bancoDeDadosToolStripMenuItem});
            this.administraçãoToolStripMenuItem.Name = "administraçãoToolStripMenuItem";
            this.administraçãoToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.administraçãoToolStripMenuItem.Text = "Admin";
            // 
            // bancoDeDadosToolStripMenuItem
            // 
            this.bancoDeDadosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.limparRankToolStripMenuItem});
            this.bancoDeDadosToolStripMenuItem.Name = "bancoDeDadosToolStripMenuItem";
            this.bancoDeDadosToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.bancoDeDadosToolStripMenuItem.Text = "Banco de Dados";
            this.bancoDeDadosToolStripMenuItem.Click += new System.EventHandler(this.bancoDeDadosToolStripMenuItem_Click);
            // 
            // limparRankToolStripMenuItem
            // 
            this.limparRankToolStripMenuItem.Name = "limparRankToolStripMenuItem";
            this.limparRankToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.limparRankToolStripMenuItem.Text = "Limpar Rank";
            this.limparRankToolStripMenuItem.Click += new System.EventHandler(this.limparRankToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::Engleasy.Properties.Resources.game1_rank;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(452, 104);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(171, 40);
            this.button1.TabIndex = 2;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImage = global::Engleasy.Properties.Resources.game2_rank;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(452, 166);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(171, 40);
            this.button2.TabIndex = 3;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.BackgroundImage = global::Engleasy.Properties.Resources.game3_rank;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(452, 233);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(171, 40);
            this.button3.TabIndex = 4;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.BackgroundImage = global::Engleasy.Properties.Resources.rank;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(504, 365);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(119, 40);
            this.button4.TabIndex = 5;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // rtb_changelog
            // 
            this.rtb_changelog.Location = new System.Drawing.Point(72, 127);
            this.rtb_changelog.Name = "rtb_changelog";
            this.rtb_changelog.Size = new System.Drawing.Size(187, 243);
            this.rtb_changelog.TabIndex = 6;
            this.rtb_changelog.Text = "";
            this.rtb_changelog.TextChanged += new System.EventHandler(this.rtb_changelog_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(72, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "Notas de atualizações:";
            // 
            // timer_updt
            // 
            this.timer_updt.Enabled = true;
            this.timer_updt.Interval = 5000;
            this.timer_updt.Tick += new System.EventHandler(this.timer_updt_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(689, 464);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rtb_changelog);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Engleasy - v1.0";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_ledLogado)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Label label3;
        private Label label1;
        public Label lbn_nomeUsuario;
        public Label lb_acesso;
        public PictureBox pb_ledLogado;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem loginToolStripMenuItem;
        private ToolStripMenuItem logonToolStripMenuItem;
        private ToolStripMenuItem logoffToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem registrarNovoAlunoToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem2;
        private ToolStripMenuItem consultarRankToolStripMenuItem;
        private ToolStripMenuItem administraçãoToolStripMenuItem;
        private ToolStripMenuItem bancoDeDadosToolStripMenuItem;
        private Button button1;
        private Button button2;
        private Button button3;
        private ToolStripMenuItem limparRankToolStripMenuItem;
        private Button button4;
        private RichTextBox rtb_changelog;
        private Label label2;
        private System.Windows.Forms.Timer timer_updt;
        private Label label10;
        public Label lbn_mypt3;
        private Label lbn32;
        public Label lbn_mypt2;
        private Label lbn27;
        public Label lbn_mypt1;
        private Label label5;
    }
}