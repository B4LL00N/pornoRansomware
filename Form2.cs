using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace pöcs_balek
{
    public partial class backgroundWorker : Form
    {
        public backgroundWorker()
        {
            InitializeComponent();
        }

        private void backgroundWorker_Load(object sender, EventArgs e)
        {
            new visualPayload().Show();
            this.Close();
        }
    }
}
