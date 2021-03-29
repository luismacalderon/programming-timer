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

            if (btnInciar.Text == "Continuar")
            {
                btnInciar.Text = "Iniciar";
                btnPausar.Enabled = true;
                tmrContador.Start();
                lblInfo.Text = "Programando..";
                return;
            }
            
            if(rb30.Checked == true)
            {
                lblTimer.Text = "00:30:00";
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

            tmrContador.Interval = 1000;
            tmrContador.Enabled = true;

            lblInfo.Text = "Programando..";
        }

        private void tmrContador_Tick(object sender, EventArgs e)
        {
            DateTime TiempoDefinido = Convert.ToDateTime(lblTimer.Text);
            lblTimer.Text = TiempoDefinido.AddSeconds(-1).ToString("HH:mm:ss");

            if(lblTimer.Text == "00:00:00")
            {
                tmrContador.Enabled = false;
                tmrContador.Stop();
                btnInciar.Enabled = true;
                this.WindowState = FormWindowState.Normal;

                lblInfo.Text = "Tarea finalizada !!";
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
            btnInciar.Text = "Continuar";
            lblInfo.Text = "En Pausa";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            tmrContador.Enabled = false;
            btnInciar.Text = "Iniciar";
            btnInciar.Enabled = true;
            btnPausar.Enabled = true;
            lblTimer.Text = "00:00:00";
            lblInfo.Text = "";
        }

        private void CambiarColorRadios()
        {
            foreach(Control control in gbxTiempos.Controls)
            {
                ((RadioButton)control).ForeColor = Color.DimGray;
            }
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
    }
}
