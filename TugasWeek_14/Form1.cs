using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TugasWeek_14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonKonversi_Click(object sender, EventArgs e)
        {
            string NAMA = textBoxKalimat.Text.ToUpper();
            int key = 0;
            string A = textBoxHuruf.Text;
            string B = textBoxMenjadi.Text;
            char[] HURUF = A.ToCharArray();
            char[] MENJADI = B.ToCharArray();
            char[] URUTAN = new char[26] { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
            char[] KALIMAT = NAMA.ToCharArray();
            labelCoba.Text = "";
            if (HURUF[0] < MENJADI[0])
            {
                key = MENJADI[0] + HURUF[0];
            }
            else if (HURUF[0] > MENJADI[0])
            {
                key = HURUF[0] - MENJADI[0];
            }
            for (int i = 0; i < URUTAN.Length; i++)
            {
                for (int j = 0; j < KALIMAT.Length; j++)
                {
                    if (URUTAN[i] == KALIMAT[j])
                    {
                        KALIMAT[j] = URUTAN[(i+key) % 26];
                    }
                }
            }
            labelCoba.Text = new string(KALIMAT);
        }
    }
}
