using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace tic_tac_toe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int turn = 0;

       

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            if(turn %2==0)
            {
                arri_izq_x.Visible = true;
                circ_izq_O.Visible = false;
            }
            else{
                arri_izq_x.Visible = false;
                circ_izq_O.Visible = true;

            }
            turn++;
        }

        private void circ_izq_O_Click(object sender, EventArgs e)
        {

        }

        private void cent_arriba_Click(object sender, EventArgs e)
        {
            if (turn % 2 == 0)
            {
                arrib_cent_x.Visible = true;
                arib_cent_O.Visible = false;
            }
            else
            {
                arrib_cent_x.Visible = false;
                arib_cent_O.Visible = true;

            }
            turn++;
        }

        private void der_arriba_Click(object sender, EventArgs e)
        {
            if (turn % 2 == 0)
            {
                arrib_der_x.Visible = true;
                arrib_der_O.Visible = false;
            }
            else
            {
                arrib_der_x.Visible = false;
                arrib_der_O.Visible = true;

            }
            turn++;
        }

        private void izq_cent_Click(object sender, EventArgs e)
        {
            if (turn % 2 == 0)
            {
                cent_izq_x.Visible = true;
                cent_izq_O.Visible = false;
            }
            else
            {
                cent_izq_x.Visible = false;
                cent_izq_O.Visible = true;

            }
            turn++;
        }

        private void cent_cent_Click(object sender, EventArgs e)
        {
            if (turn % 2 == 0)
            {
                cent_cent_x.Visible = true;
                cent_cent_o.Visible = false;
            }
            else
            {
                cent_cent_x.Visible = false;
                cent_cent_o.Visible = true;

            }
            turn++;
        }

        private void cent_der_Click(object sender, EventArgs e)
        {
            if (turn % 2 == 0)
            {
                cent_derc_x.Visible = true;
                cent_der_O.Visible = false;
            }
            else
            {
                cent_derc_x.Visible = false;
                cent_der_O.Visible = true;

            }
            turn++;
        }

        private void izq_aba_Click(object sender, EventArgs e)
        {
            if (turn % 2 == 0)
            {
                aba_izq_x.Visible = true;
                aba_izq_O.Visible = false;
            }
            else
            {
                aba_izq_x.Visible = false;
                aba_izq_O.Visible = true;

            }
            turn++;
        }

        private void cent_aba_Click(object sender, EventArgs e)
        {
            if (turn % 2 == 0)
            {
                aba_cent_x.Visible = true;
                aba_cent_O.Visible = false;
            }
            else
            {
                aba_cent_x.Visible = false;
                aba_cent_O.Visible = true;

            }
            turn++;
        }

        private void der_aba_Click(object sender, EventArgs e)
        {
            if (turn % 2 == 0)
            {
                aba_der_x.Visible = true;
                aba_der_O.Visible = false;
            }
            else
            {
                aba_der_x.Visible = false;
                aba_der_O.Visible = true;

            }
            turn++;
        }

        private void aba_izq_O_Click(object sender, EventArgs e)
        {

        }

        private void cent_cent_o_Click(object sender, EventArgs e)
        {

        }

        private void btnReinicia_Click(object sender, EventArgs e)
        {
            arri_izq_x.Visible = false;
            circ_izq_O.Visible = false;

            arib_cent_O.Visible = false;
            arrib_cent_x.Visible = false;

            arrib_der_x.Visible = false;
            arrib_der_O.Visible = false;

            cent_izq_x.Visible = false;
            cent_izq_O.Visible = false;

            cent_cent_x.Visible = false;
            cent_cent_o.Visible = false;

            cent_derc_x.Visible = false;
            cent_der_O.Visible = false;

            aba_der_x.Visible = false;
            aba_der_O.Visible = false;

            aba_cent_x.Visible = false;
            aba_cent_O.Visible = false;

            aba_izq_x.Visible = false;
            aba_izq_O.Visible = false;

        }
    }
}
