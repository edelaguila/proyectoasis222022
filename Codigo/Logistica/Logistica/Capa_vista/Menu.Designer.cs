
namespace Capa_vista
{
    partial class Menu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.iNICIOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iNVENTARIOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tRANSPORTEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aUDITORIAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tRASLADOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cIERREToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rEPORTESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mUESTREOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iNICIOToolStripMenuItem,
            this.iNVENTARIOSToolStripMenuItem,
            this.tRANSPORTEToolStripMenuItem,
            this.aUDITORIAToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // iNICIOToolStripMenuItem
            // 
            this.iNICIOToolStripMenuItem.Name = "iNICIOToolStripMenuItem";
            this.iNICIOToolStripMenuItem.Size = new System.Drawing.Size(66, 24);
            this.iNICIOToolStripMenuItem.Text = "INICIO";
            // 
            // iNVENTARIOSToolStripMenuItem
            // 
            this.iNVENTARIOSToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cIERREToolStripMenuItem,
            this.rEPORTESToolStripMenuItem});
            this.iNVENTARIOSToolStripMenuItem.Name = "iNVENTARIOSToolStripMenuItem";
            this.iNVENTARIOSToolStripMenuItem.Size = new System.Drawing.Size(115, 24);
            this.iNVENTARIOSToolStripMenuItem.Text = "INVENTARIOS";
            // 
            // tRANSPORTEToolStripMenuItem
            // 
            this.tRANSPORTEToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tRASLADOSToolStripMenuItem});
            this.tRANSPORTEToolStripMenuItem.Name = "tRANSPORTEToolStripMenuItem";
            this.tRANSPORTEToolStripMenuItem.Size = new System.Drawing.Size(112, 24);
            this.tRANSPORTEToolStripMenuItem.Text = "TRANSPORTE";
            // 
            // aUDITORIAToolStripMenuItem
            // 
            this.aUDITORIAToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mUESTREOToolStripMenuItem});
            this.aUDITORIAToolStripMenuItem.Name = "aUDITORIAToolStripMenuItem";
            this.aUDITORIAToolStripMenuItem.Size = new System.Drawing.Size(99, 24);
            this.aUDITORIAToolStripMenuItem.Text = "AUDITORIA";
            // 
            // tRASLADOSToolStripMenuItem
            // 
            this.tRASLADOSToolStripMenuItem.Name = "tRASLADOSToolStripMenuItem";
            this.tRASLADOSToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.tRASLADOSToolStripMenuItem.Text = "TRASLADOS";
            // 
            // cIERREToolStripMenuItem
            // 
            this.cIERREToolStripMenuItem.Name = "cIERREToolStripMenuItem";
            this.cIERREToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.cIERREToolStripMenuItem.Text = "CIERRE";
            // 
            // rEPORTESToolStripMenuItem
            // 
            this.rEPORTESToolStripMenuItem.Name = "rEPORTESToolStripMenuItem";
            this.rEPORTESToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.rEPORTESToolStripMenuItem.Text = "REPORTES";
            // 
            // mUESTREOToolStripMenuItem
            // 
            this.mUESTREOToolStripMenuItem.Name = "mUESTREOToolStripMenuItem";
            this.mUESTREOToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.mUESTREOToolStripMenuItem.Text = "MUESTREO";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Menu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem iNICIOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iNVENTARIOSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cIERREToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rEPORTESToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tRANSPORTEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tRASLADOSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aUDITORIAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mUESTREOToolStripMenuItem;
    }
}