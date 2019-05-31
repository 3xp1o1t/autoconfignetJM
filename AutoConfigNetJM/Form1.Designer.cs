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
            this.gbOutput = new System.Windows.Forms.GroupBox();
            this.btnCopy = new System.Windows.Forms.Button();
            this.txtOutput = new System.Windows.Forms.RichTextBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.gbScriptOptions = new System.Windows.Forms.GroupBox();
            this.chbHTTP = new System.Windows.Forms.CheckBox();
            this.chbSSH = new System.Windows.Forms.CheckBox();
            this.chbTelnet = new System.Windows.Forms.CheckBox();
            this.gbOptions = new System.Windows.Forms.GroupBox();
            this.rbAddSNWVV = new System.Windows.Forms.RadioButton();
            this.rbAddCN = new System.Windows.Forms.RadioButton();
            this.rbAddRN = new System.Windows.Forms.RadioButton();
            this.spnVlanNumber = new System.Windows.Forms.NumericUpDown();
            this.vlanList = new System.Windows.Forms.ListBox();
            this.ctxMnuVlanList = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ctxMnuItemDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxMnuItemUpdate = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAddVlan = new System.Windows.Forms.Button();
            this.lblVlanGen = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.toolTips = new System.Windows.Forms.ToolTip(this.components);
            this.mnuMain.SuspendLayout();
            this.tbcTabs.SuspendLayout();
            this.tbcVlanGen.SuspendLayout();
            this.gbOutput.SuspendLayout();
            this.gbScriptOptions.SuspendLayout();
            this.gbOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spnVlanNumber)).BeginInit();
            this.ctxMnuVlanList.SuspendLayout();
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
            this.tbcTabs.Size = new System.Drawing.Size(821, 567);
            this.tbcTabs.TabIndex = 1;
            // 
            // tbcVlanGen
            // 
            this.tbcVlanGen.Controls.Add(this.gbOutput);
            this.tbcVlanGen.Controls.Add(this.btnGenerate);
            this.tbcVlanGen.Controls.Add(this.gbScriptOptions);
            this.tbcVlanGen.Controls.Add(this.gbOptions);
            this.tbcVlanGen.Controls.Add(this.spnVlanNumber);
            this.tbcVlanGen.Controls.Add(this.vlanList);
            this.tbcVlanGen.Controls.Add(this.btnAddVlan);
            this.tbcVlanGen.Controls.Add(this.lblVlanGen);
            this.tbcVlanGen.Location = new System.Drawing.Point(4, 32);
            this.tbcVlanGen.Name = "tbcVlanGen";
            this.tbcVlanGen.Padding = new System.Windows.Forms.Padding(3);
            this.tbcVlanGen.Size = new System.Drawing.Size(813, 531);
            this.tbcVlanGen.TabIndex = 0;
            this.tbcVlanGen.UseVisualStyleBackColor = true;
            // 
            // gbOutput
            // 
            this.gbOutput.Controls.Add(this.btnCopy);
            this.gbOutput.Controls.Add(this.txtOutput);
            this.gbOutput.Location = new System.Drawing.Point(166, 268);
            this.gbOutput.Name = "gbOutput";
            this.gbOutput.Size = new System.Drawing.Size(638, 258);
            this.gbOutput.TabIndex = 9;
            this.gbOutput.TabStop = false;
            // 
            // btnCopy
            // 
            this.btnCopy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCopy.Location = new System.Drawing.Point(476, 216);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(156, 34);
            this.btnCopy.TabIndex = 8;
            this.btnCopy.UseVisualStyleBackColor = true;
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(9, 25);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(623, 185);
            this.txtOutput.TabIndex = 5;
            this.txtOutput.Text = "";
            // 
            // btnGenerate
            // 
            this.btnGenerate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGenerate.Location = new System.Drawing.Point(698, 225);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(106, 34);
            this.btnGenerate.TabIndex = 7;
            this.btnGenerate.UseVisualStyleBackColor = true;
            // 
            // gbScriptOptions
            // 
            this.gbScriptOptions.Controls.Add(this.chbHTTP);
            this.gbScriptOptions.Controls.Add(this.chbSSH);
            this.gbScriptOptions.Controls.Add(this.chbTelnet);
            this.gbScriptOptions.Location = new System.Drawing.Point(166, 151);
            this.gbScriptOptions.Name = "gbScriptOptions";
            this.gbScriptOptions.Size = new System.Drawing.Size(641, 68);
            this.gbScriptOptions.TabIndex = 6;
            this.gbScriptOptions.TabStop = false;
            // 
            // chbHTTP
            // 
            this.chbHTTP.AutoSize = true;
            this.chbHTTP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chbHTTP.Dock = System.Windows.Forms.DockStyle.Left;
            this.chbHTTP.Location = new System.Drawing.Point(43, 22);
            this.chbHTTP.Name = "chbHTTP";
            this.chbHTTP.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.chbHTTP.Size = new System.Drawing.Size(25, 43);
            this.chbHTTP.TabIndex = 2;
            this.chbHTTP.UseVisualStyleBackColor = true;
            // 
            // chbSSH
            // 
            this.chbSSH.AutoSize = true;
            this.chbSSH.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chbSSH.Dock = System.Windows.Forms.DockStyle.Left;
            this.chbSSH.Location = new System.Drawing.Point(18, 22);
            this.chbSSH.Name = "chbSSH";
            this.chbSSH.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.chbSSH.Size = new System.Drawing.Size(25, 43);
            this.chbSSH.TabIndex = 1;
            this.chbSSH.UseVisualStyleBackColor = true;
            // 
            // chbTelnet
            // 
            this.chbTelnet.AutoSize = true;
            this.chbTelnet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chbTelnet.Dock = System.Windows.Forms.DockStyle.Left;
            this.chbTelnet.Location = new System.Drawing.Point(3, 22);
            this.chbTelnet.Name = "chbTelnet";
            this.chbTelnet.Size = new System.Drawing.Size(15, 43);
            this.chbTelnet.TabIndex = 0;
            this.chbTelnet.UseVisualStyleBackColor = true;
            this.chbTelnet.CheckedChanged += new System.EventHandler(this.CheckBox1_CheckedChanged);
            // 
            // gbOptions
            // 
            this.gbOptions.Controls.Add(this.rbAddSNWVV);
            this.gbOptions.Controls.Add(this.rbAddCN);
            this.gbOptions.Controls.Add(this.rbAddRN);
            this.gbOptions.Location = new System.Drawing.Point(166, 43);
            this.gbOptions.Name = "gbOptions";
            this.gbOptions.Size = new System.Drawing.Size(641, 102);
            this.gbOptions.TabIndex = 4;
            this.gbOptions.TabStop = false;
            // 
            // rbAddSNWVV
            // 
            this.rbAddSNWVV.AutoSize = true;
            this.rbAddSNWVV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbAddSNWVV.Dock = System.Windows.Forms.DockStyle.Top;
            this.rbAddSNWVV.Location = new System.Drawing.Point(3, 54);
            this.rbAddSNWVV.Name = "rbAddSNWVV";
            this.rbAddSNWVV.Padding = new System.Windows.Forms.Padding(0, 1, 2, 2);
            this.rbAddSNWVV.Size = new System.Drawing.Size(635, 16);
            this.rbAddSNWVV.TabIndex = 3;
            this.rbAddSNWVV.UseVisualStyleBackColor = true;
            // 
            // rbAddCN
            // 
            this.rbAddCN.AutoSize = true;
            this.rbAddCN.Cursor = System.Windows.Forms.Cursors.Hand;
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
            this.rbAddRN.Cursor = System.Windows.Forms.Cursors.Hand;
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
            this.vlanList.ContextMenuStrip = this.ctxMnuVlanList;
            this.vlanList.FormattingEnabled = true;
            this.vlanList.ItemHeight = 20;
            this.vlanList.Location = new System.Drawing.Point(7, 82);
            this.vlanList.Name = "vlanList";
            this.vlanList.Size = new System.Drawing.Size(153, 444);
            this.vlanList.TabIndex = 2;
            // 
            // ctxMnuVlanList
            // 
            this.ctxMnuVlanList.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctxMnuItemDelete,
            this.ctxMnuItemUpdate});
            this.ctxMnuVlanList.Name = "ctxMnuVlanList";
            this.ctxMnuVlanList.Size = new System.Drawing.Size(68, 48);
            // 
            // ctxMnuItemDelete
            // 
            this.ctxMnuItemDelete.Name = "ctxMnuItemDelete";
            this.ctxMnuItemDelete.Size = new System.Drawing.Size(67, 22);
            this.ctxMnuItemDelete.Click += new System.EventHandler(this.DeleteVlanToolStripMenuItem_Click);
            // 
            // ctxMnuItemUpdate
            // 
            this.ctxMnuItemUpdate.Name = "ctxMnuItemUpdate";
            this.ctxMnuItemUpdate.Size = new System.Drawing.Size(67, 22);
            this.ctxMnuItemUpdate.Click += new System.EventHandler(this.CtxMnuItemUpdate_Click);
            // 
            // btnAddVlan
            // 
            this.btnAddVlan.Cursor = System.Windows.Forms.Cursors.Hand;
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
            this.tabPage2.Size = new System.Drawing.Size(813, 531);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 591);
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
            this.gbOutput.ResumeLayout(false);
            this.gbScriptOptions.ResumeLayout(false);
            this.gbScriptOptions.PerformLayout();
            this.gbOptions.ResumeLayout(false);
            this.gbOptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spnVlanNumber)).EndInit();
            this.ctxMnuVlanList.ResumeLayout(false);
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
        private System.Windows.Forms.RadioButton rbAddCN;
        private System.Windows.Forms.RadioButton rbAddRN;
        private System.Windows.Forms.RichTextBox txtOutput;
        private System.Windows.Forms.GroupBox gbScriptOptions;
        private System.Windows.Forms.CheckBox chbTelnet;
        private System.Windows.Forms.CheckBox chbSSH;
        private System.Windows.Forms.CheckBox chbHTTP;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.GroupBox gbOutput;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.ContextMenuStrip ctxMnuVlanList;
        private System.Windows.Forms.ToolStripMenuItem ctxMnuItemDelete;
        private System.Windows.Forms.ToolStripMenuItem ctxMnuItemUpdate;
    }
}

