using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using de.etas.cebra.toolAPI.Inca;

namespace incademo
{
    public partial class FrmINCA : Form
    {
        private Inca m_Inca;
        public FrmINCA()
        {
            InitializeComponent();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            m_Inca = new Inca();
            this.txtVersion.Text=m_Inca.APIVersion();
        }
    }
}
