
namespace PriceVerifier
{
    partial class frmIdle
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
            this.components = new System.ComponentModel.Container();
            this.panelInstruction = new System.Windows.Forms.Panel();
            this.panelAds = new System.Windows.Forms.Panel();
            this.timerAds = new System.Windows.Forms.Timer(this.components);
            this.lblScanHere = new System.Windows.Forms.Label();
            this.pangelDownArrow = new System.Windows.Forms.Panel();
            this.panelInstruction.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelInstruction
            // 
            this.panelInstruction.BackColor = System.Drawing.Color.Transparent;
            this.panelInstruction.Controls.Add(this.pangelDownArrow);
            this.panelInstruction.Controls.Add(this.lblScanHere);
            this.panelInstruction.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelInstruction.Location = new System.Drawing.Point(0, 0);
            this.panelInstruction.Name = "panelInstruction";
            this.panelInstruction.Size = new System.Drawing.Size(456, 768);
            this.panelInstruction.TabIndex = 0;
            // 
            // panelAds
            // 
            this.panelAds.BackColor = System.Drawing.Color.Transparent;
            this.panelAds.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelAds.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelAds.Location = new System.Drawing.Point(462, 0);
            this.panelAds.Name = "panelAds";
            this.panelAds.Size = new System.Drawing.Size(904, 768);
            this.panelAds.TabIndex = 1;
            // 
            // timerAds
            // 
            this.timerAds.Interval = 1000;
            this.timerAds.Tick += new System.EventHandler(this.timerAds_Tick);
            // 
            // lblScanHere
            // 
            this.lblScanHere.AutoSize = true;
            this.lblScanHere.Font = new System.Drawing.Font("Century Gothic", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScanHere.Location = new System.Drawing.Point(31, 80);
            this.lblScanHere.Name = "lblScanHere";
            this.lblScanHere.Size = new System.Drawing.Size(395, 224);
            this.lblScanHere.TabIndex = 0;
            this.lblScanHere.Text = "S C A N\r\nH E R E";
            this.lblScanHere.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pangelDownArrow
            // 
            this.pangelDownArrow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pangelDownArrow.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pangelDownArrow.Location = new System.Drawing.Point(0, 375);
            this.pangelDownArrow.Name = "pangelDownArrow";
            this.pangelDownArrow.Size = new System.Drawing.Size(456, 393);
            this.pangelDownArrow.TabIndex = 1;
            // 
            // frmIdle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.ControlBox = false;
            this.Controls.Add(this.panelAds);
            this.Controls.Add(this.panelInstruction);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmIdle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmIdle";
            this.Load += new System.EventHandler(this.frmIdle_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmIdle_KeyPress);
            this.panelInstruction.ResumeLayout(false);
            this.panelInstruction.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelInstruction;
        private System.Windows.Forms.Panel panelAds;
        private System.Windows.Forms.Timer timerAds;
        private System.Windows.Forms.Panel pangelDownArrow;
        private System.Windows.Forms.Label lblScanHere;
    }
}