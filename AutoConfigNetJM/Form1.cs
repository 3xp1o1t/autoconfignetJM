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
        List<string> vlan_names = new List<string>();
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
            this.gbScriptOptions.Text = Properties.Resources.gbScriptOptions;
            this.gbOutput.Text = Properties.Resources.gbOutput;
            this.rbAddRN.Text = Properties.Resources.rbOptionAddRN;
            this.rbAddCN.Text = Properties.Resources.rbOptionAddCN;            
            this.rbAddSNWVV.Text = Properties.Resources.rbOptionAddSNWVV;

            // Labels
            this.lblVlanGen.Text = Properties.Resources.lblVlanGen;
            
            // Buttons
            this.btnAddVlan.Text = Properties.Resources.btnAddVlan;
            this.btnGenerate.Text = Properties.Resources.btnGenerate;
            this.btnCopy.Text = Properties.Resources.btnCopy;
            this.ctxMnuItemDelete.Text = Properties.Resources.ctxMnuItemDelete;
            this.ctxMnuItemUpdate.Text = Properties.Resources.ctxMnuItemUpdate;
            // Spinners
            this.spnVlanNumber.Minimum = MIN_VLAN_RANGE;
            this.spnVlanNumber.Maximum = MAX_VLAN_RANGE;

            // Tooltips items.
            this.toolTips.SetToolTip(this.btnAddVlan, Properties.Resources.ttVlanNumber);
            this.toolTips.SetToolTip(this.vlanList, Properties.Resources.ttVlanList);
            this.toolTips.SetToolTip(this.btnGenerate, Properties.Resources.ttBtnGenerate);
            this.toolTips.SetToolTip(this.btnCopy, Properties.Resources.ttBtnCopy);
            this.toolTips.SetToolTip(this.chbTelnet, Properties.Resources.ttAddTelnet);
            this.toolTips.SetToolTip(this.chbSSH, Properties.Resources.ttAddSHH);
            this.toolTips.SetToolTip(this.chbHTTP, Properties.Resources.ttAddHTTP);

            // CheckBoxs
            this.chbTelnet.Text = Properties.Resources.chbTelnet;
            this.chbSSH.Text = Properties.Resources.chbSSH;
            this.chbHTTP.Text = Properties.Resources.chbHTTP;
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

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void DeleteVlanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(vlanList.SelectedItems.Count > 0)
            {
                vlanList.Items.Remove(vlanList.SelectedItem);
            }
        }

        private void CtxMnuItemUpdate_Click(object sender, EventArgs e)
        {

            if (vlanList.SelectedItems.Count > 0)
            {
                string vlanNumber = Microsoft.VisualBasic.Interaction.InputBox(
                    Properties.Resources.msgUpdateVlanText,
                    Properties.Resources.msgUpdateVlanTitle);
                int new_number = 0;
                try
                {
                    new_number = int.Parse(vlanNumber);
                }
                catch
                {
                    MessageBox.Show("Error, invalid number.");
                    return;
                }

                if(new_number > 0 && new_number < 4095)
                {
                    if(vlanList.Items.Contains("vlan " + new_number))
                    {
                        MessageBox.Show("Error, number was defined.");
                        return;
                    }
                    else
                    {
                        int index = vlanList.SelectedIndex;
                        vlanList.Items.RemoveAt(index);                        
                        vlanList.Items.Insert(index, "vlan " + new_number);                        
                    }
                }              
            }
        }
    }
}
