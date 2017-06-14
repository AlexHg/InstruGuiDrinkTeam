namespace PicWinUSB
{
    partial class PicWinUSB
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PicWinUSB));
            this.BtLedsToggle = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtIniciaADC = new System.Windows.Forms.Button();
            this.AdcBar = new System.Windows.Forms.ProgressBar();
            this.timerADC = new System.Windows.Forms.Timer(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.BtLeds_on = new System.Windows.Forms.Button();
            this.BtPICdivide = new System.Windows.Forms.Button();
            this.TextBoxResultadodivide = new System.Windows.Forms.TextBox();
            this.BtPICmultiplica = new System.Windows.Forms.Button();
            this.TextBoxResultadomultiplica = new System.Windows.Forms.TextBox();
            this.BtPICresta = new System.Windows.Forms.Button();
            this.TextBoxResultadoresta = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtLed_rojo = new System.Windows.Forms.Button();
            this.BtLed_verde = new System.Windows.Forms.Button();
            this.BtLeds_off = new System.Windows.Forms.Button();
            this.BtPICsuma = new System.Windows.Forms.Button();
            this.TextBoxResultadosuma = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.PicBoxOsciloscopio = new System.Windows.Forms.PictureBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxOsciloscopio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // BtLedsToggle
            // 
            this.BtLedsToggle.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtLedsToggle.Location = new System.Drawing.Point(415, 247);
            this.BtLedsToggle.Name = "BtLedsToggle";
            this.BtLedsToggle.Size = new System.Drawing.Size(142, 25);
            this.BtLedsToggle.TabIndex = 0;
            this.BtLedsToggle.Text = "TOGGLE LEDS";
            this.BtLedsToggle.UseVisualStyleBackColor = true;
            this.BtLedsToggle.Click += new System.EventHandler(this.BtLedToggle_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(496, 278);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(96, 90);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // BtIniciaADC
            // 
            this.BtIniciaADC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtIniciaADC.Location = new System.Drawing.Point(17, 321);
            this.BtIniciaADC.Name = "BtIniciaADC";
            this.BtIniciaADC.Size = new System.Drawing.Size(140, 47);
            this.BtIniciaADC.TabIndex = 3;
            this.BtIniciaADC.Text = "Iniciar lecturas del canal AN0";
            this.BtIniciaADC.UseVisualStyleBackColor = true;
            this.BtIniciaADC.Click += new System.EventHandler(this.BtAdc_Click);
            // 
            // AdcBar
            // 
            this.AdcBar.Location = new System.Drawing.Point(163, 321);
            this.AdcBar.Name = "AdcBar";
            this.AdcBar.Size = new System.Drawing.Size(327, 48);
            this.AdcBar.TabIndex = 4;
            this.AdcBar.Click += new System.EventHandler(this.AdcBar_Click);
            // 
            // timerADC
            // 
            this.timerADC.Interval = 1;
            this.timerADC.Tick += new System.EventHandler(this.timerADC_Tick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(149, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(255, 22);
            this.label4.TabIndex = 44;
            this.label4.Text = "ESCUELA SUPERIOR DE CÓMPUTO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(144, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(274, 22);
            this.label3.TabIndex = 43;
            this.label3.Text = "INSTITUTO POLITÉCNICO NACIONAL";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(527, 6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(65, 57);
            this.pictureBox2.TabIndex = 42;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(5, 6);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(41, 57);
            this.pictureBox3.TabIndex = 41;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // BtLeds_on
            // 
            this.BtLeds_on.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BtLeds_on.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtLeds_on.ForeColor = System.Drawing.Color.Black;
            this.BtLeds_on.Location = new System.Drawing.Point(415, 212);
            this.BtLeds_on.Name = "BtLeds_on";
            this.BtLeds_on.Size = new System.Drawing.Size(142, 25);
            this.BtLeds_on.TabIndex = 83;
            this.BtLeds_on.Text = "LEDS ON";
            this.BtLeds_on.UseVisualStyleBackColor = true;
            this.BtLeds_on.Click += new System.EventHandler(this.BtLeds_on_Click);
            // 
            // BtPICdivide
            // 
            this.BtPICdivide.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtPICdivide.Location = new System.Drawing.Point(55, 243);
            this.BtPICdivide.Name = "BtPICdivide";
            this.BtPICdivide.Size = new System.Drawing.Size(124, 25);
            this.BtPICdivide.TabIndex = 81;
            this.BtPICdivide.Text = "Sensor Luz";
            this.BtPICdivide.UseVisualStyleBackColor = true;
            this.BtPICdivide.Click += new System.EventHandler(this.BtPICdivide_Click);
            // 
            // TextBoxResultadodivide
            // 
            this.TextBoxResultadodivide.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxResultadodivide.Location = new System.Drawing.Point(218, 243);
            this.TextBoxResultadodivide.MaxLength = 3;
            this.TextBoxResultadodivide.Name = "TextBoxResultadodivide";
            this.TextBoxResultadodivide.Size = new System.Drawing.Size(118, 23);
            this.TextBoxResultadodivide.TabIndex = 80;
            this.TextBoxResultadodivide.TextChanged += new System.EventHandler(this.TextBoxResultadodivide_TextChanged);
            // 
            // BtPICmultiplica
            // 
            this.BtPICmultiplica.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtPICmultiplica.Location = new System.Drawing.Point(55, 201);
            this.BtPICmultiplica.Name = "BtPICmultiplica";
            this.BtPICmultiplica.Size = new System.Drawing.Size(124, 25);
            this.BtPICmultiplica.TabIndex = 76;
            this.BtPICmultiplica.Text = "Sensor Gas";
            this.BtPICmultiplica.UseVisualStyleBackColor = true;
            this.BtPICmultiplica.Click += new System.EventHandler(this.BtPICmultiplica_Click);
            // 
            // TextBoxResultadomultiplica
            // 
            this.TextBoxResultadomultiplica.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxResultadomultiplica.Location = new System.Drawing.Point(218, 201);
            this.TextBoxResultadomultiplica.MaxLength = 3;
            this.TextBoxResultadomultiplica.Name = "TextBoxResultadomultiplica";
            this.TextBoxResultadomultiplica.Size = new System.Drawing.Size(47, 23);
            this.TextBoxResultadomultiplica.TabIndex = 75;
            // 
            // BtPICresta
            // 
            this.BtPICresta.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtPICresta.Location = new System.Drawing.Point(55, 160);
            this.BtPICresta.Name = "BtPICresta";
            this.BtPICresta.Size = new System.Drawing.Size(124, 25);
            this.BtPICresta.TabIndex = 71;
            this.BtPICresta.Text = "Temperatura";
            this.BtPICresta.UseVisualStyleBackColor = true;
            this.BtPICresta.Click += new System.EventHandler(this.BtPICresta_Click);
            // 
            // TextBoxResultadoresta
            // 
            this.TextBoxResultadoresta.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxResultadoresta.Location = new System.Drawing.Point(218, 161);
            this.TextBoxResultadoresta.MaxLength = 3;
            this.TextBoxResultadoresta.Name = "TextBoxResultadoresta";
            this.TextBoxResultadoresta.Size = new System.Drawing.Size(118, 23);
            this.TextBoxResultadoresta.TabIndex = 70;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(14, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 18);
            this.label5.TabIndex = 67;
            this.label5.Text = "Solicitar Cálculo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(412, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 18);
            this.label2.TabIndex = 66;
            this.label2.Text = "Controlar LED\'s";
            // 
            // BtLed_rojo
            // 
            this.BtLed_rojo.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BtLed_rojo.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtLed_rojo.ForeColor = System.Drawing.Color.Black;
            this.BtLed_rojo.Location = new System.Drawing.Point(415, 181);
            this.BtLed_rojo.Name = "BtLed_rojo";
            this.BtLed_rojo.Size = new System.Drawing.Size(142, 25);
            this.BtLed_rojo.TabIndex = 64;
            this.BtLed_rojo.Text = "LED ROJO ON";
            this.BtLed_rojo.UseVisualStyleBackColor = true;
            this.BtLed_rojo.Click += new System.EventHandler(this.BtLed_rojo_Click);
            // 
            // BtLed_verde
            // 
            this.BtLed_verde.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BtLed_verde.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtLed_verde.ForeColor = System.Drawing.Color.Black;
            this.BtLed_verde.Location = new System.Drawing.Point(415, 149);
            this.BtLed_verde.Name = "BtLed_verde";
            this.BtLed_verde.Size = new System.Drawing.Size(142, 25);
            this.BtLed_verde.TabIndex = 63;
            this.BtLed_verde.Text = "LED VERDE ON";
            this.BtLed_verde.UseVisualStyleBackColor = true;
            this.BtLed_verde.Click += new System.EventHandler(this.BtLed_verde_Click);
            // 
            // BtLeds_off
            // 
            this.BtLeds_off.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BtLeds_off.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtLeds_off.ForeColor = System.Drawing.Color.Black;
            this.BtLeds_off.Location = new System.Drawing.Point(415, 118);
            this.BtLeds_off.Name = "BtLeds_off";
            this.BtLeds_off.Size = new System.Drawing.Size(142, 25);
            this.BtLeds_off.TabIndex = 62;
            this.BtLeds_off.Text = "LEDS OFF";
            this.BtLeds_off.UseVisualStyleBackColor = true;
            this.BtLeds_off.Click += new System.EventHandler(this.BtLeds_off_Click);
            // 
            // BtPICsuma
            // 
            this.BtPICsuma.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtPICsuma.Location = new System.Drawing.Point(55, 120);
            this.BtPICsuma.Name = "BtPICsuma";
            this.BtPICsuma.Size = new System.Drawing.Size(124, 25);
            this.BtPICsuma.TabIndex = 61;
            this.BtPICsuma.Text = "Sensor PIR";
            this.BtPICsuma.UseVisualStyleBackColor = true;
            this.BtPICsuma.Click += new System.EventHandler(this.BtPICsuma_Click);
            // 
            // TextBoxResultadosuma
            // 
            this.TextBoxResultadosuma.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxResultadosuma.Location = new System.Drawing.Point(218, 121);
            this.TextBoxResultadosuma.MaxLength = 3;
            this.TextBoxResultadosuma.Name = "TextBoxResultadosuma";
            this.TextBoxResultadosuma.Size = new System.Drawing.Size(47, 23);
            this.TextBoxResultadosuma.TabIndex = 60;
            this.TextBoxResultadosuma.TextChanged += new System.EventHandler(this.TextBoxResultadosuma_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(14, 302);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(251, 18);
            this.label9.TabIndex = 84;
            this.label9.Text = "Conversión análogica digital";
            // 
            // PicBoxOsciloscopio
            // 
            this.PicBoxOsciloscopio.BackColor = System.Drawing.Color.White;
            this.PicBoxOsciloscopio.Location = new System.Drawing.Point(672, 99);
            this.PicBoxOsciloscopio.Name = "PicBoxOsciloscopio";
            this.PicBoxOsciloscopio.Size = new System.Drawing.Size(401, 256);
            this.PicBoxOsciloscopio.TabIndex = 85;
            this.PicBoxOsciloscopio.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(309, 88);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(44, 57);
            this.pictureBox4.TabIndex = 86;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // PicWinUSB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(1095, 380);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.PicBoxOsciloscopio);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.BtLeds_on);
            this.Controls.Add(this.BtPICdivide);
            this.Controls.Add(this.TextBoxResultadodivide);
            this.Controls.Add(this.BtPICmultiplica);
            this.Controls.Add(this.TextBoxResultadomultiplica);
            this.Controls.Add(this.BtPICresta);
            this.Controls.Add(this.TextBoxResultadoresta);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtLed_rojo);
            this.Controls.Add(this.BtLed_verde);
            this.Controls.Add(this.BtLeds_off);
            this.Controls.Add(this.BtPICsuma);
            this.Controls.Add(this.TextBoxResultadosuma);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.AdcBar);
            this.Controls.Add(this.BtIniciaADC);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BtLedsToggle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "PicWinUSB";
            this.Text = "ESCOM-IPN (PIC-WinUSB)";
            this.Load += new System.EventHandler(this.PicWinUSB_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxOsciloscopio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtLedsToggle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BtIniciaADC;
        private System.Windows.Forms.ProgressBar AdcBar;
        private System.Windows.Forms.Timer timerADC;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button BtLeds_on;
        private System.Windows.Forms.Button BtPICdivide;
        private System.Windows.Forms.TextBox TextBoxResultadodivide;
        private System.Windows.Forms.Button BtPICmultiplica;
        private System.Windows.Forms.TextBox TextBoxResultadomultiplica;
        private System.Windows.Forms.Button BtPICresta;
        private System.Windows.Forms.TextBox TextBoxResultadoresta;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtLed_rojo;
        private System.Windows.Forms.Button BtLed_verde;
        private System.Windows.Forms.Button BtLeds_off;
        private System.Windows.Forms.Button BtPICsuma;
        private System.Windows.Forms.TextBox TextBoxResultadosuma;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox PicBoxOsciloscopio;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}

