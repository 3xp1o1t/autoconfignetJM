using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoConfigNetJM
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            initilizeProperties();
        }

        public void initilizeProperties()
        {
            this.Text = Properties.Resources.appName + " - version: " + Properties.Resources.appVersion;
            this.tbcVlanGen.Text = Properties.Resources.tabVlan;
            this.fileMenuItem.Text = Properties.Resources.OptionFile;
            this.editMenuItem.Text = Properties.Resources.OptionEdit;
            this.aboutMenuItem.Text = Properties.Resources.OptionAbout;
            this.sMnuQuit.Text = Properties.Resources.subOptionFileQuit;
            this.sMnuClean.Text = Properties.Resources.subOptionEditClean;
            this.sMnuHelp.Text = Properties.Resources.subOptionAboutHelp;
            this.sMnuCompany.Text = Properties.Resources.subOptionAboutCompany;

            this.lblVlanGen.Text = Properties.Resources.lblVlanGen;
            this.btnAddVlan.Text = Properties.Resources.btnAddVlan;
            this.toolTips.SetToolTip(this.btnAddVlan, Properties.Resources.ttVlanNumber);
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            
        }

        private void QuitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void ToolTips_Popup(object sender, PopupEventArgs e)
        {            
        }
    }
}
