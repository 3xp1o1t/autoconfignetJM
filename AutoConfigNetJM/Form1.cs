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

        static string[] vlans_range = Properties.Resources.spnRange.Split(',');
        readonly int MIN_VLAN_RANGE = int.Parse(vlans_range[0]);
        readonly int MAX_VLAN_RANGE = int.Parse(vlans_range[1]);
        Vlan vlan = new Vlan();
        public frmMain()
        {
            InitializeComponent();
            InitilizeProperties();
        }

        public void InitilizeProperties()
        {   
            // Main application
            this.Text = Properties.Resources.appName + " - version: " + Properties.Resources.appVersion;
            // Tabs
            this.tbcVlanGen.Text = Properties.Resources.tabVlan;
            // Menu items.
            this.fileMenuItem.Text = Properties.Resources.OptionFile;
            this.editMenuItem.Text = Properties.Resources.OptionEdit;
            this.aboutMenuItem.Text = Properties.Resources.OptionAbout;
            this.sMnuQuit.Text = Properties.Resources.subOptionFileQuit;
            this.sMnuClean.Text = Properties.Resources.subOptionEditClean;
            this.sMnuHelp.Text = Properties.Resources.subOptionAboutHelp;
            this.sMnuCompany.Text = Properties.Resources.subOptionAboutCompany;
            this.gbOptions.Text = Properties.Resources.gbOptions;
            this.rbAddRN.Text = Properties.Resources.rbOptionAddRN;
            this.rbAddCN.Text = Properties.Resources.rbOptionAddCN;
            this.rbAddSNIV.Text = Properties.Resources.rbOptionAddSNIV;
            this.rbAddSNWVV.Text = Properties.Resources.rbOptionAddSNWVV;

            // Labels
            this.lblVlanGen.Text = Properties.Resources.lblVlanGen;
            
            // Buttons
            this.btnAddVlan.Text = Properties.Resources.btnAddVlan;

            // Spinners
            this.spnVlanNumber.Minimum = MIN_VLAN_RANGE;
            this.spnVlanNumber.Maximum = MAX_VLAN_RANGE;

            // Tooltips items.
            this.toolTips.SetToolTip(this.btnAddVlan, Properties.Resources.ttVlanNumber);
            this.toolTips.SetToolTip(this.vlanList, Properties.Resources.ttVlanList);
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            
        }

        private void QuitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void BtnAddVlan_Click(object sender, EventArgs e)
        {
            bool result = vlan.AddVlanToList((int)spnVlanNumber.Value, vlanList);
            if (!result)
                MessageBox.Show("La vlan " + spnVlanNumber.Value + " ya fue agregada!",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void VlanList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            vlanList.Items.Remove(vlanList.SelectedItem);
        }
    }
}
