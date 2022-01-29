using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.NetworkInformation;
using System.IO;

namespace Pingando
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            int pacotes = 0;
            int perdidos = 0;
            for (int i = 0; i < maxPing.Value; i++)
            {
                pacotes++;
                try
                {
                    var reply = Program.Pingar(servidorPing.Text);
                    if (reply == null || reply.Status != IPStatus.Success)
                    {
                        perdidos++;
                    }
                }
                catch
                {
                    perdidos++;
                }

                backgroundWorker1.ReportProgress(0, new int[] { pacotes, perdidos });
                
            }

            //pictureBox1.Visible = false;
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {  
            pacotesPerdidos.Text = ((int[])e.UserState)[1].ToString();
            pacotesEnviados.Text = ((int[])e.UserState)[0].ToString();
            pacotesEnviados.Update();
            pacotesPerdidos.Update();

            if (((int[])e.UserState)[1] + ((int[])e.UserState)[0] >= maxPing.Value)
                pictureBox1.Visible = false;
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            backgroundWorker1.RunWorkerAsync();
            backgroundWorker1.WorkerReportsProgress = true;
        }
    }
}
