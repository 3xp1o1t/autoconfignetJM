﻿namespace AutoConfigNetJM
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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.mnuMain.SuspendLayout();
            this.tbcTabs.SuspendLayout();
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
            this.sMnuQuit.Size = new System.Drawing.Size(180, 22);
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
            this.sMnuClean.Size = new System.Drawing.Size(180, 22);
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
            this.sMnuHelp.Size = new System.Drawing.Size(180, 22);
            // 
            // sMnuCompany
            // 
            this.sMnuCompany.Name = "sMnuCompany";
            this.sMnuCompany.Size = new System.Drawing.Size(180, 22);
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
            this.tbcVlanGen.Location = new System.Drawing.Point(4, 32);
            this.tbcVlanGen.Name = "tbcVlanGen";
            this.tbcVlanGen.Padding = new System.Windows.Forms.Padding(3);
            this.tbcVlanGen.Size = new System.Drawing.Size(813, 546);
            this.tbcVlanGen.TabIndex = 0;
            this.tbcVlanGen.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 32);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(813, 542);
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
    }
}

