using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace stm_controller
{
    public partial class txPktSettings : Form
    {
        //**************************************************************************
        //*                              DEFINES
        //**************************************************************************
        public const string DEFAULT_SOT = "0x10";

        public string SOT = DEFAULT_SOT;

        public bool SOTcheckBoxSt = false;

        public txPktSettings()
        {
            InitializeComponent();
        }

        private void saveSettingButton_Click(object sender, EventArgs e)
        {
            if (SOTcheckBox.Checked)
            {
                SOTcheckBoxSt = true;
            }
            else
            {
                SOTcheckBoxSt = false;
            }
        }
    }
}
