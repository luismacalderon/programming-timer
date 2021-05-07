using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace programming_timer
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnInciar_Click(object sender, EventArgs e)
        {
            btnInciar.Enabled = false;
            this.TopMost = true;

            if (btnInciar.Text == "Resume")
            {
                btnInciar.Text = "Start";
                btnPausar.Enabled = true;
                tmrContador.Start();
                lblInfo.Text = "Focus..";               
                return;
            }
            
            if(rb30.Checked == true)
            {
                lblTimer.Text = "00:30:00";
            }
            else if (rb45.Checked == true)
            {
                lblTimer.Text = "00:45:00";
            }
            else if (rb60.Checked == true)
            {
                lblTimer.Text = "01:00:00";
            }
            else if (rb90.Checked == true)
            {
                lblTimer.Text = "01:30:00";
            }
            else if (rb120.Checked == true)
            {
                lblTimer.Text = "02:00:00";
            }
            else if (rb150.Checked == true)
            {
                lblTimer.Text = "02:30:00";
            }
            else if (rb180.Checked == true)
            {
                lblTimer.Text = "03:00:00";
            }
            else if (rbTimer.Checked == true)
            {
                lblTimer.Text = "00:00:00";
            }

            tmrContador.Interval = 1;
            tmrContador.Enabled = true;

            lblInfo.Text = "Focus..";
            notifyIcon1.Visible = true;
            notifyIcon1.BalloonTipTitle = "Programming Timer";
            notifyIcon1.BalloonTipText = lblTimer.Text;
            notifyIcon1.ShowBalloonTip(1000);
            this.WindowState = FormWindowState.Minimized;
            this.Hide();
        }

        private void tmrContador_Tick(object sender, EventArgs e)
        {
            DateTime TiempoDefinido = Convert.ToDateTime(lblTimer.Text);

            if (rbTimer.Checked == false)
            {
                lblTimer.Text = TiempoDefinido.AddSeconds(-1).ToString("HH:mm:ss");

                if(lblTimer.Text == "00:00:00")
                {
                    tmrContador.Enabled = false;
                    tmrContador.Stop();
                    btnInciar.Enabled = true;

                    lblInfo.Text = "Finish !!";

                    MostrarAplicacion();
                }

                notifyIcon1.BalloonTipText = lblTimer.Text;
            }
            else
            {
                lblTimer.Text = TiempoDefinido.AddSeconds(1).ToString("HH:mm:ss");
            }

        }

        private void btnPausar_Click(object sender, EventArgs e)
        {
            if(lblTimer.Text == "00:00:00")
            {
                return;
            }

            tmrContador.Stop();
            btnPausar.Enabled = false;
            btnInciar.Enabled = true;
            btnInciar.Text = "Continue";
            lblInfo.Text = "Paused";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            tmrContador.Enabled = false;
            btnInciar.Text = "Start";
            btnInciar.Enabled = true;
            btnPausar.Enabled = true;
            lblTimer.Text = "00:00:00";
            lblInfo.Text = "";
            btnOcultar.Enabled = false;
        }

        private void CambiarColorRadios()
        {
            foreach(Control control in gbxTiempos.Controls)
            {
                ((RadioButton)control).ForeColor = Color.DimGray;
            }
        }

        private void MostrarAplicacion()
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;      
            this.Activate();
            this.BringToFront();
            notifyIcon1.Visible = true;
            btnOcultar.Enabled = true;
        }

        private void rb30_CheckedChanged(object sender, EventArgs e)
        {
            CambiarColorRadios();
            rb30.ForeColor = Color.White;
        }

        private void rb60_CheckedChanged(object sender, EventArgs e)
        {
            CambiarColorRadios();
            rb60.ForeColor = Color.White;
        }

        private void rb90_CheckedChanged(object sender, EventArgs e)
        {
            CambiarColorRadios();
            rb90.ForeColor = Color.White;
        }

        private void rb120_CheckedChanged(object sender, EventArgs e)
        {
            CambiarColorRadios();
            rb120.ForeColor = Color.White;
        }

        private void rb150_CheckedChanged(object sender, EventArgs e)
        {
            CambiarColorRadios();
            rb150.ForeColor = Color.White;
        }

        private void rb180_CheckedChanged(object sender, EventArgs e)
        {
            CambiarColorRadios();
            rb180.ForeColor = Color.White;
        }

        private void rb45_CheckedChanged(object sender, EventArgs e)
        {
            CambiarColorRadios();
            rb45.ForeColor = Color.White;
        }

        private void notifyIcon1_DoubleClick(object sender, EventArgs e)
        {
            MostrarAplicacion();
        }

        private void btnOcultar_Click(object sender, EventArgs e)
        {
            notifyIcon1.Visible = true;
            this.WindowState = FormWindowState.Minimized;
            notifyIcon1.ShowBalloonTip(1000);
            this.Hide();
        }

        private void frmMain_Shown(object sender, EventArgs e)
        {
            notifyIcon1.BalloonTipTitle = "Programming Timer";
            notifyIcon1.BalloonTipText = lblTimer.Text;          
            btnOcultar.Enabled = false;
        }
    }
}
