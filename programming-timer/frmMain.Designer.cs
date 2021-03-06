namespace programming_timer
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            Infragistics.Win.Appearance appearance1 = new Infragistics.Win.Appearance();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.lblTimer = new System.Windows.Forms.Label();
            this.tmrContador = new System.Windows.Forms.Timer(this.components);
            this.btnInciar = new Infragistics.Win.Misc.UltraButton();
            this.ultraGroupBox1 = new Infragistics.Win.Misc.UltraGroupBox();
            this.btnOcultar = new Infragistics.Win.Misc.UltraButton();
            this.lblInfo = new Infragistics.Win.Misc.UltraLabel();
            this.gbxTiempos = new Infragistics.Win.Misc.UltraGroupBox();
            this.rb45 = new System.Windows.Forms.RadioButton();
            this.rbTimer = new System.Windows.Forms.RadioButton();
            this.rb180 = new System.Windows.Forms.RadioButton();
            this.rb150 = new System.Windows.Forms.RadioButton();
            this.rb120 = new System.Windows.Forms.RadioButton();
            this.rb90 = new System.Windows.Forms.RadioButton();
            this.rb60 = new System.Windows.Forms.RadioButton();
            this.rb30 = new System.Windows.Forms.RadioButton();
            this.btnCancelar = new Infragistics.Win.Misc.UltraButton();
            this.btnPausar = new Infragistics.Win.Misc.UltraButton();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ultraGroupBox1)).BeginInit();
            this.ultraGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gbxTiempos)).BeginInit();
            this.gbxTiempos.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTimer
            // 
            this.lblTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimer.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblTimer.Location = new System.Drawing.Point(84, 96);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(429, 111);
            this.lblTimer.TabIndex = 0;
            this.lblTimer.Text = "00:00:00";
            this.lblTimer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tmrContador
            // 
            this.tmrContador.Tick += new System.EventHandler(this.tmrContador_Tick);
            // 
            // btnInciar
            // 
            this.btnInciar.Location = new System.Drawing.Point(493, 261);
            this.btnInciar.Name = "btnInciar";
            this.btnInciar.Size = new System.Drawing.Size(66, 34);
            this.btnInciar.TabIndex = 2;
            this.btnInciar.Text = "Start";
            this.btnInciar.Click += new System.EventHandler(this.btnInciar_Click);
            // 
            // ultraGroupBox1
            // 
            this.ultraGroupBox1.Controls.Add(this.btnOcultar);
            this.ultraGroupBox1.Controls.Add(this.lblInfo);
            this.ultraGroupBox1.Controls.Add(this.gbxTiempos);
            this.ultraGroupBox1.Controls.Add(this.btnCancelar);
            this.ultraGroupBox1.Controls.Add(this.btnPausar);
            this.ultraGroupBox1.Controls.Add(this.lblTimer);
            this.ultraGroupBox1.Controls.Add(this.btnInciar);
            this.ultraGroupBox1.Location = new System.Drawing.Point(12, 12);
            this.ultraGroupBox1.Name = "ultraGroupBox1";
            this.ultraGroupBox1.Size = new System.Drawing.Size(597, 318);
            this.ultraGroupBox1.TabIndex = 3;
            // 
            // btnOcultar
            // 
            this.btnOcultar.Location = new System.Drawing.Point(43, 261);
            this.btnOcultar.Name = "btnOcultar";
            this.btnOcultar.Size = new System.Drawing.Size(66, 34);
            this.btnOcultar.TabIndex = 6;
            this.btnOcultar.Text = "Hide";
            this.btnOcultar.Click += new System.EventHandler(this.btnOcultar_Click);
            // 
            // lblInfo
            // 
            appearance1.ForeColor = System.Drawing.Color.White;
            appearance1.TextHAlignAsString = "Center";
            appearance1.TextVAlignAsString = "Middle";
            this.lblInfo.Appearance = appearance1;
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.Location = new System.Drawing.Point(43, 197);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(516, 52);
            this.lblInfo.TabIndex = 5;
            // 
            // gbxTiempos
            // 
            this.gbxTiempos.Controls.Add(this.rb45);
            this.gbxTiempos.Controls.Add(this.rbTimer);
            this.gbxTiempos.Controls.Add(this.rb180);
            this.gbxTiempos.Controls.Add(this.rb150);
            this.gbxTiempos.Controls.Add(this.rb120);
            this.gbxTiempos.Controls.Add(this.rb90);
            this.gbxTiempos.Controls.Add(this.rb60);
            this.gbxTiempos.Controls.Add(this.rb30);
            this.gbxTiempos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxTiempos.ForeColor = System.Drawing.Color.Black;
            this.gbxTiempos.Location = new System.Drawing.Point(20, 21);
            this.gbxTiempos.Name = "gbxTiempos";
            this.gbxTiempos.Size = new System.Drawing.Size(559, 65);
            this.gbxTiempos.TabIndex = 4;
            // 
            // rb45
            // 
            this.rb45.AutoSize = true;
            this.rb45.ForeColor = System.Drawing.Color.DimGray;
            this.rb45.Location = new System.Drawing.Point(29, 36);
            this.rb45.Name = "rb45";
            this.rb45.Size = new System.Drawing.Size(64, 20);
            this.rb45.TabIndex = 4;
            this.rb45.Text = "45 min";
            this.rb45.UseVisualStyleBackColor = true;
            this.rb45.CheckedChanged += new System.EventHandler(this.rb45_CheckedChanged);
            // 
            // rbTimer
            // 
            this.rbTimer.AutoSize = true;
            this.rbTimer.ForeColor = System.Drawing.Color.DimGray;
            this.rbTimer.Location = new System.Drawing.Point(464, 36);
            this.rbTimer.Name = "rbTimer";
            this.rbTimer.Size = new System.Drawing.Size(61, 20);
            this.rbTimer.TabIndex = 3;
            this.rbTimer.Text = "Timer";
            this.rbTimer.UseVisualStyleBackColor = true;
            this.rbTimer.CheckedChanged += new System.EventHandler(this.rb180_CheckedChanged);
            // 
            // rb180
            // 
            this.rb180.AutoSize = true;
            this.rb180.ForeColor = System.Drawing.Color.DimGray;
            this.rb180.Location = new System.Drawing.Point(464, 10);
            this.rb180.Name = "rb180";
            this.rb180.Size = new System.Drawing.Size(71, 20);
            this.rb180.TabIndex = 3;
            this.rb180.Text = "180 min";
            this.rb180.UseVisualStyleBackColor = true;
            this.rb180.CheckedChanged += new System.EventHandler(this.rb180_CheckedChanged);
            // 
            // rb150
            // 
            this.rb150.AutoSize = true;
            this.rb150.ForeColor = System.Drawing.Color.DimGray;
            this.rb150.Location = new System.Drawing.Point(297, 36);
            this.rb150.Name = "rb150";
            this.rb150.Size = new System.Drawing.Size(71, 20);
            this.rb150.TabIndex = 3;
            this.rb150.Text = "150 min";
            this.rb150.UseVisualStyleBackColor = true;
            this.rb150.CheckedChanged += new System.EventHandler(this.rb150_CheckedChanged);
            // 
            // rb120
            // 
            this.rb120.AutoSize = true;
            this.rb120.ForeColor = System.Drawing.Color.DimGray;
            this.rb120.Location = new System.Drawing.Point(297, 10);
            this.rb120.Name = "rb120";
            this.rb120.Size = new System.Drawing.Size(71, 20);
            this.rb120.TabIndex = 3;
            this.rb120.Text = "120 min";
            this.rb120.UseVisualStyleBackColor = true;
            this.rb120.CheckedChanged += new System.EventHandler(this.rb120_CheckedChanged);
            // 
            // rb90
            // 
            this.rb90.AutoSize = true;
            this.rb90.ForeColor = System.Drawing.Color.DimGray;
            this.rb90.Location = new System.Drawing.Point(155, 36);
            this.rb90.Name = "rb90";
            this.rb90.Size = new System.Drawing.Size(64, 20);
            this.rb90.TabIndex = 2;
            this.rb90.Text = "90 min";
            this.rb90.UseVisualStyleBackColor = true;
            this.rb90.CheckedChanged += new System.EventHandler(this.rb90_CheckedChanged);
            // 
            // rb60
            // 
            this.rb60.AutoSize = true;
            this.rb60.ForeColor = System.Drawing.Color.DimGray;
            this.rb60.Location = new System.Drawing.Point(155, 10);
            this.rb60.Name = "rb60";
            this.rb60.Size = new System.Drawing.Size(64, 20);
            this.rb60.TabIndex = 1;
            this.rb60.Text = "60 min";
            this.rb60.UseVisualStyleBackColor = true;
            this.rb60.CheckedChanged += new System.EventHandler(this.rb60_CheckedChanged);
            // 
            // rb30
            // 
            this.rb30.AutoSize = true;
            this.rb30.ForeColor = System.Drawing.Color.DimGray;
            this.rb30.Location = new System.Drawing.Point(29, 10);
            this.rb30.Name = "rb30";
            this.rb30.Size = new System.Drawing.Size(64, 20);
            this.rb30.TabIndex = 1;
            this.rb30.Text = "30 min";
            this.rb30.UseVisualStyleBackColor = true;
            this.rb30.CheckedChanged += new System.EventHandler(this.rb30_CheckedChanged);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(326, 261);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(66, 34);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancel";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnPausar
            // 
            this.btnPausar.Location = new System.Drawing.Point(410, 261);
            this.btnPausar.Name = "btnPausar";
            this.btnPausar.Size = new System.Drawing.Size(66, 34);
            this.btnPausar.TabIndex = 3;
            this.btnPausar.Text = "Pause";
            this.btnPausar.Click += new System.EventHandler(this.btnPausar_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Programming Timer";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.DoubleClick += new System.EventHandler(this.notifyIcon1_DoubleClick);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(621, 342);
            this.Controls.Add(this.ultraGroupBox1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Programming Timer - by Master Solutions - NIC";
            this.Shown += new System.EventHandler(this.frmMain_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.ultraGroupBox1)).EndInit();
            this.ultraGroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gbxTiempos)).EndInit();
            this.gbxTiempos.ResumeLayout(false);
            this.gbxTiempos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Timer tmrContador;
        private Infragistics.Win.Misc.UltraButton btnInciar;
        private Infragistics.Win.Misc.UltraGroupBox ultraGroupBox1;
        private Infragistics.Win.Misc.UltraButton btnCancelar;
        private Infragistics.Win.Misc.UltraButton btnPausar;
        private Infragistics.Win.Misc.UltraGroupBox gbxTiempos;
        private System.Windows.Forms.RadioButton rb180;
        private System.Windows.Forms.RadioButton rb150;
        private System.Windows.Forms.RadioButton rb120;
        private System.Windows.Forms.RadioButton rb90;
        private System.Windows.Forms.RadioButton rb60;
        private System.Windows.Forms.RadioButton rb30;
        private Infragistics.Win.Misc.UltraLabel lblInfo;
        private System.Windows.Forms.RadioButton rb45;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private Infragistics.Win.Misc.UltraButton btnOcultar;
        private System.Windows.Forms.RadioButton rbTimer;
    }
}

