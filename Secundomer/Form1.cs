using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Secundomer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            btnStart.Click += btnStart_Start_Click;
            btnStart.Text = "Старт";
        }

       

        private void tmrSecundomer_Tick(object sender, EventArgs e)
        {
            int tmp = int.Parse(txtSeconds.Text);
            int tmp1 = int.Parse(txtMinutes.Text);
            tmp += 1;
            
            if (tmp == 60 )
            {
                tmp1 += 1;
                tmp = 0;
                txtMinutes.Text = tmp1.ToString();
            }
            txtSeconds.Text = tmp.ToString();


        }
        void btnStart_Stop_Click(object sender, EventArgs e)
        {
            
            btnStart.Text = "Старт";
            tmrSecundomer.Enabled = false;
            btnStart.Click -= new EventHandler(btnStart_Stop_Click);
            btnStart.Click += new EventHandler(btnStart_Start_Click);
        }

        private void btnStart_Start_Click(object sender, EventArgs e)
        {
            tmrSecundomer.Enabled = true;
            btnStart.Text = "Стоп";
            btnStart.Click -= new EventHandler(btnStart_Start_Click);
            btnStart.Click += new EventHandler(btnStart_Stop_Click);   
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void txtMinutes_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
