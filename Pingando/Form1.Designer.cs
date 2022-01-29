
namespace Pingando
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
            this.servidorPing = new System.Windows.Forms.TextBox();
            this.maxPing = new System.Windows.Forms.NumericUpDown();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnPingar = new MetroFramework.Controls.MetroTile();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.pacotesEnviados = new MetroFramework.Controls.MetroLabel();
            this.pacotesPerdidos = new MetroFramework.Controls.MetroLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.maxPing)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // servidorPing
            // 
            this.servidorPing.Location = new System.Drawing.Point(23, 155);
            this.servidorPing.Name = "servidorPing";
            this.servidorPing.Size = new System.Drawing.Size(300, 23);
            this.servidorPing.TabIndex = 3;
            this.servidorPing.Text = "1.1.1.1";
            // 
            // maxPing
            // 
            this.maxPing.Location = new System.Drawing.Point(481, 155);
            this.maxPing.Maximum = new decimal(new int[] {
            1215752191,
            23,
            0,
            0});
            this.maxPing.Name = "maxPing";
            this.maxPing.Size = new System.Drawing.Size(120, 23);
            this.maxPing.TabIndex = 6;
            this.maxPing.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            // 
            // btnPingar
            // 
            this.btnPingar.Location = new System.Drawing.Point(702, 404);
            this.btnPingar.Name = "btnPingar";
            this.btnPingar.Size = new System.Drawing.Size(75, 23);
            this.btnPingar.TabIndex = 9;
            this.btnPingar.Text = "Pingar";
            this.btnPingar.Click += new System.EventHandler(this.metroTile1_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 133);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(167, 19);
            this.metroLabel1.TabIndex = 10;
            this.metroLabel1.Text = "Ip do Servidor para Pingar";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(481, 133);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(106, 19);
            this.metroLabel2.TabIndex = 11;
            this.metroLabel2.Text = "Maximo de Ping";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(187, 284);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(60, 19);
            this.metroLabel3.TabIndex = 12;
            this.metroLabel3.Text = "Enviados";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(305, 284);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(60, 19);
            this.metroLabel4.TabIndex = 13;
            this.metroLabel4.Text = "Perdidos";
            // 
            // pacotesEnviados
            // 
            this.pacotesEnviados.AutoSize = true;
            this.pacotesEnviados.Location = new System.Drawing.Point(187, 303);
            this.pacotesEnviados.Name = "pacotesEnviados";
            this.pacotesEnviados.Size = new System.Drawing.Size(16, 19);
            this.pacotesEnviados.TabIndex = 14;
            this.pacotesEnviados.Text = "0";
            // 
            // pacotesPerdidos
            // 
            this.pacotesPerdidos.AutoSize = true;
            this.pacotesPerdidos.Location = new System.Drawing.Point(305, 303);
            this.pacotesPerdidos.Name = "pacotesPerdidos";
            this.pacotesPerdidos.Size = new System.Drawing.Size(16, 19);
            this.pacotesPerdidos.TabIndex = 15;
            this.pacotesPerdidos.Text = "0";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Pingando.Properties.Resources._5257718;
            this.pictureBox1.Location = new System.Drawing.Point(495, 268);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(106, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pacotesPerdidos);
            this.Controls.Add(this.pacotesEnviados);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.btnPingar);
            this.Controls.Add(this.maxPing);
            this.Controls.Add(this.servidorPing);
            this.Name = "Form1";
            this.Text = "Pingando";
            ((System.ComponentModel.ISupportInitialize)(this.maxPing)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox servidorPing;
        private System.Windows.Forms.TextBox maxPings;
        private System.Windows.Forms.NumericUpDown maxPing;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private MetroFramework.Controls.MetroTile btnPingar;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel pacotesEnviados;
        private MetroFramework.Controls.MetroLabel pacotesPerdidos;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

