namespace AutoConfigNetJM
{
    partial class frmMain
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.mnuMain = new System.Windows.Forms.MenuStrip();
            this.fileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sMnuQuit = new System.Windows.Forms.ToolStripMenuItem();
            this.editMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sMnuClean = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sMnuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.sMnuCompany = new System.Windows.Forms.ToolStripMenuItem();
            this.tbcTabs = new System.Windows.Forms.TabControl();
            this.tbcVlanGen = new System.Windows.Forms.TabPage();
            this.gbOptions = new System.Windows.Forms.GroupBox();
            this.rbAddSNWVV = new System.Windows.Forms.RadioButton();
            this.rbAddSNIV = new System.Windows.Forms.RadioButton();
            this.rbAddCN = new System.Windows.Forms.RadioButton();
            this.rbAddRN = new System.Windows.Forms.RadioButton();
            this.spnVlanNumber = new System.Windows.Forms.NumericUpDown();
            this.vlanList = new System.Windows.Forms.ListBox();
            this.btnAddVlan = new System.Windows.Forms.Button();
            this.lblVlanGen = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.toolTips = new System.Windows.Forms.ToolTip(this.components);
            this.mnuMain.SuspendLayout();
            this.tbcTabs.SuspendLayout();
            this.tbcVlanGen.SuspendLayout();
            this.gbOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spnVlanNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // mnuMain
            // 
            this.mnuMain.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenuItem,
            this.editMenuItem,
            this.aboutMenuItem});
            this.mnuMain.Location = new System.Drawing.Point(0, 0);
            this.mnuMain.Name = "mnuMain";
            this.mnuMain.Size = new System.Drawing.Size(821, 24);
            this.mnuMain.TabIndex = 0;
            // 
            // fileMenuItem
            // 
            this.fileMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sMnuQuit});
            this.fileMenuItem.Name = "fileMenuItem";
            this.fileMenuItem.Size = new System.Drawing.Size(12, 20);
            // 
            // sMnuQuit
            // 
            this.sMnuQuit.Name = "sMnuQuit";
            this.sMnuQuit.Size = new System.Drawing.Size(69, 22);
            this.sMnuQuit.Click += new System.EventHandler(this.QuitToolStripMenuItem_Click);
            // 
            // editMenuItem
            // 
            this.editMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sMnuClean});
            this.editMenuItem.Name = "editMenuItem";
            this.editMenuItem.Size = new System.Drawing.Size(12, 20);
            // 
            // sMnuClean
            // 
            this.sMnuClean.Name = "sMnuClean";
            this.sMnuClean.Size = new System.Drawing.Size(69, 22);
            // 
            // aboutMenuItem
            // 
            this.aboutMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sMnuHelp,
            this.sMnuCompany});
            this.aboutMenuItem.Name = "aboutMenuItem";
            this.aboutMenuItem.Size = new System.Drawing.Size(12, 20);
            // 
            // sMnuHelp
            // 
            this.sMnuHelp.Name = "sMnuHelp";
            this.sMnuHelp.Size = new System.Drawing.Size(69, 22);
            // 
            // sMnuCompany
            // 
            this.sMnuCompany.Name = "sMnuCompany";
            this.sMnuCompany.Size = new System.Drawing.Size(69, 22);
            // 
            // tbcTabs
            // 
            this.tbcTabs.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tbcTabs.Controls.Add(this.tbcVlanGen);
            this.tbcTabs.Controls.Add(this.tabPage2);
            this.tbcTabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbcTabs.Location = new System.Drawing.Point(0, 24);
            this.tbcTabs.Name = "tbcTabs";
            this.tbcTabs.SelectedIndex = 0;
            this.tbcTabs.Size = new System.Drawing.Size(821, 582);
            this.tbcTabs.TabIndex = 1;
            // 
            // tbcVlanGen
            // 
            this.tbcVlanGen.Controls.Add(this.gbOptions);
            this.tbcVlanGen.Controls.Add(this.spnVlanNumber);
            this.tbcVlanGen.Controls.Add(this.vlanList);
            this.tbcVlanGen.Controls.Add(this.btnAddVlan);
            this.tbcVlanGen.Controls.Add(this.lblVlanGen);
            this.tbcVlanGen.Location = new System.Drawing.Point(4, 32);
            this.tbcVlanGen.Name = "tbcVlanGen";
            this.tbcVlanGen.Padding = new System.Windows.Forms.Padding(3);
            this.tbcVlanGen.Size = new System.Drawing.Size(813, 546);
            this.tbcVlanGen.TabIndex = 0;
            this.tbcVlanGen.UseVisualStyleBackColor = true;
            // 
            // gbOptions
            // 
            this.gbOptions.Controls.Add(this.rbAddSNWVV);
            this.gbOptions.Controls.Add(this.rbAddSNIV);
            this.gbOptions.Controls.Add(this.rbAddCN);
            this.gbOptions.Controls.Add(this.rbAddRN);
            this.gbOptions.Location = new System.Drawing.Point(166, 43);
            this.gbOptions.Name = "gbOptions";
            this.gbOptions.Size = new System.Drawing.Size(641, 140);
            this.gbOptions.TabIndex = 4;
            this.gbOptions.TabStop = false;
            // 
            // rbAddSNWVV
            // 
            this.rbAddSNWVV.AutoSize = true;
            this.rbAddSNWVV.Dock = System.Windows.Forms.DockStyle.Top;
            this.rbAddSNWVV.Location = new System.Drawing.Point(3, 70);
            this.rbAddSNWVV.Name = "rbAddSNWVV";
            this.rbAddSNWVV.Padding = new System.Windows.Forms.Padding(0, 1, 2, 2);
            this.rbAddSNWVV.Size = new System.Drawing.Size(635, 16);
            this.rbAddSNWVV.TabIndex = 3;
            this.rbAddSNWVV.UseVisualStyleBackColor = true;
            // 
            // rbAddSNIV
            // 
            this.rbAddSNIV.AutoSize = true;
            this.rbAddSNIV.Dock = System.Windows.Forms.DockStyle.Top;
            this.rbAddSNIV.Location = new System.Drawing.Point(3, 54);
            this.rbAddSNIV.Name = "rbAddSNIV";
            this.rbAddSNIV.Padding = new System.Windows.Forms.Padding(0, 1, 2, 2);
            this.rbAddSNIV.Size = new System.Drawing.Size(635, 16);
            this.rbAddSNIV.TabIndex = 2;
            this.rbAddSNIV.UseVisualStyleBackColor = true;
            // 
            // rbAddCN
            // 
            this.rbAddCN.AutoSize = true;
            this.rbAddCN.Dock = System.Windows.Forms.DockStyle.Top;
            this.rbAddCN.Location = new System.Drawing.Point(3, 38);
            this.rbAddCN.Name = "rbAddCN";
            this.rbAddCN.Padding = new System.Windows.Forms.Padding(0, 1, 2, 2);
            this.rbAddCN.Size = new System.Drawing.Size(635, 16);
            this.rbAddCN.TabIndex = 1;
            this.rbAddCN.UseVisualStyleBackColor = true;
            // 
            // rbAddRN
            // 
            this.rbAddRN.AutoSize = true;
            this.rbAddRN.Checked = true;
            this.rbAddRN.Dock = System.Windows.Forms.DockStyle.Top;
            this.rbAddRN.Location = new System.Drawing.Point(3, 22);
            this.rbAddRN.Name = "rbAddRN";
            this.rbAddRN.Padding = new System.Windows.Forms.Padding(0, 1, 2, 2);
            this.rbAddRN.Size = new System.Drawing.Size(635, 16);
            this.rbAddRN.TabIndex = 0;
            this.rbAddRN.TabStop = true;
            this.rbAddRN.UseVisualStyleBackColor = true;
            // 
            // spnVlanNumber
            // 
            this.spnVlanNumber.Location = new System.Drawing.Point(7, 50);
            this.spnVlanNumber.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.spnVlanNumber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spnVlanNumber.Name = "spnVlanNumber";
            this.spnVlanNumber.Size = new System.Drawing.Size(55, 26);
            this.spnVlanNumber.TabIndex = 3;
            this.spnVlanNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // vlanList
            // 
            this.vlanList.FormattingEnabled = true;
            this.vlanList.ItemHeight = 20;
            this.vlanList.Location = new System.Drawing.Point(7, 82);
            this.vlanList.Name = "vlanList";
            this.vlanList.Size = new System.Drawing.Size(153, 244);
            this.vlanList.TabIndex = 2;
            this.vlanList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.VlanList_MouseDoubleClick);
            // 
            // btnAddVlan
            // 
            this.btnAddVlan.Location = new System.Drawing.Point(68, 43);
            this.btnAddVlan.Name = "btnAddVlan";
            this.btnAddVlan.Size = new System.Drawing.Size(92, 38);
            this.btnAddVlan.TabIndex = 1;
            this.btnAddVlan.UseVisualStyleBackColor = true;
            this.btnAddVlan.Click += new System.EventHandler(this.BtnAddVlan_Click);
            // 
            // lblVlanGen
            // 
            this.lblVlanGen.AutoSize = true;
            this.lblVlanGen.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblVlanGen.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblVlanGen.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVlanGen.Location = new System.Drawing.Point(3, 3);
            this.lblVlanGen.Name = "lblVlanGen";
            this.lblVlanGen.Size = new System.Drawing.Size(0, 23);
            this.lblVlanGen.TabIndex = 0;
            this.lblVlanGen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 32);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(813, 546);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 606);
            this.Controls.Add(this.tbcTabs);
            this.Controls.Add(this.mnuMain);
            this.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mnuMain;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.mnuMain.ResumeLayout(false);
            this.mnuMain.PerformLayout();
            this.tbcTabs.ResumeLayout(false);
            this.tbcVlanGen.ResumeLayout(false);
            this.tbcVlanGen.PerformLayout();
            this.gbOptions.ResumeLayout(false);
            this.gbOptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spnVlanNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuMain;
        private System.Windows.Forms.ToolStripMenuItem fileMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sMnuQuit;
        private System.Windows.Forms.ToolStripMenuItem editMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sMnuClean;
        private System.Windows.Forms.ToolStripMenuItem aboutMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sMnuCompany;
        private System.Windows.Forms.ToolStripMenuItem sMnuHelp;
        private System.Windows.Forms.TabControl tbcTabs;
        private System.Windows.Forms.TabPage tbcVlanGen;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label lblVlanGen;
        private System.Windows.Forms.ListBox vlanList;
        private System.Windows.Forms.Button btnAddVlan;
        private System.Windows.Forms.NumericUpDown spnVlanNumber;
        private System.Windows.Forms.ToolTip toolTips;
        private System.Windows.Forms.GroupBox gbOptions;
        private System.Windows.Forms.RadioButton rbAddSNWVV;
        private System.Windows.Forms.RadioButton rbAddSNIV;
        private System.Windows.Forms.RadioButton rbAddCN;
        private System.Windows.Forms.RadioButton rbAddRN;
    }
}

