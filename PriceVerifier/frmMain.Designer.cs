
namespace PriceVerifier
{
    partial class frmMain
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
            this.panelItemImage = new System.Windows.Forms.Panel();
            this.panelItemDetail = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblItemDescription = new System.Windows.Forms.Label();
            this.lblScanCode = new System.Windows.Forms.Label();
            this.lblItemDefaultPrice = new System.Windows.Forms.Label();
            this.lblItemName = new System.Windows.Forms.Label();
            this.timerIdle = new System.Windows.Forms.Timer(this.components);
            this.panelItemDetail.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelItemImage
            // 
            this.panelItemImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelItemImage.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelItemImage.Location = new System.Drawing.Point(0, 0);
            this.panelItemImage.Name = "panelItemImage";
            this.panelItemImage.Size = new System.Drawing.Size(498, 768);
            this.panelItemImage.TabIndex = 0;
            // 
            // panelItemDetail
            // 
            this.panelItemDetail.Controls.Add(this.label3);
            this.panelItemDetail.Controls.Add(this.label2);
            this.panelItemDetail.Controls.Add(this.label1);
            this.panelItemDetail.Controls.Add(this.groupBox1);
            this.panelItemDetail.Controls.Add(this.lblScanCode);
            this.panelItemDetail.Controls.Add(this.lblItemDefaultPrice);
            this.panelItemDetail.Controls.Add(this.lblItemName);
            this.panelItemDetail.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelItemDetail.Location = new System.Drawing.Point(504, 0);
            this.panelItemDetail.Name = "panelItemDetail";
            this.panelItemDetail.Size = new System.Drawing.Size(862, 768);
            this.panelItemDetail.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 264);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(309, 56);
            this.label3.TabIndex = 8;
            this.label3.Text = "Price:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(309, 56);
            this.label2.TabIndex = 7;
            this.label2.Text = "Name:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(309, 56);
            this.label1.TabIndex = 6;
            this.label1.Text = "Barcode:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.lblItemDescription);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(32, 362);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(795, 271);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Description";
            // 
            // lblItemDescription
            // 
            this.lblItemDescription.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemDescription.Location = new System.Drawing.Point(6, 27);
            this.lblItemDescription.Name = "lblItemDescription";
            this.lblItemDescription.Size = new System.Drawing.Size(490, 56);
            this.lblItemDescription.TabIndex = 2;
            this.lblItemDescription.Text = "ItemDescription";
            this.lblItemDescription.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblScanCode
            // 
            this.lblScanCode.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScanCode.Location = new System.Drawing.Point(337, 86);
            this.lblScanCode.Name = "lblScanCode";
            this.lblScanCode.Size = new System.Drawing.Size(490, 56);
            this.lblScanCode.TabIndex = 3;
            this.lblScanCode.Text = "ScanCode";
            this.lblScanCode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblItemDefaultPrice
            // 
            this.lblItemDefaultPrice.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemDefaultPrice.Location = new System.Drawing.Point(337, 264);
            this.lblItemDefaultPrice.Name = "lblItemDefaultPrice";
            this.lblItemDefaultPrice.Size = new System.Drawing.Size(490, 56);
            this.lblItemDefaultPrice.TabIndex = 1;
            this.lblItemDefaultPrice.Text = "ItemPrice";
            this.lblItemDefaultPrice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblItemName
            // 
            this.lblItemName.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemName.Location = new System.Drawing.Point(337, 172);
            this.lblItemName.Name = "lblItemName";
            this.lblItemName.Size = new System.Drawing.Size(490, 56);
            this.lblItemName.TabIndex = 0;
            this.lblItemName.Text = "ItemName";
            this.lblItemName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // timerIdle
            // 
            this.timerIdle.Interval = 1000;
            this.timerIdle.Tick += new System.EventHandler(this.timerIdle_Tick);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.panelItemDetail);
            this.Controls.Add(this.panelItemImage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMain";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmMain_KeyPress);
            this.panelItemDetail.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelItemImage;
        private System.Windows.Forms.Panel panelItemDetail;
        private System.Windows.Forms.Label lblItemDefaultPrice;
        private System.Windows.Forms.Label lblItemName;
        private System.Windows.Forms.Label lblItemDescription;
        private System.Windows.Forms.Timer timerIdle;
        private System.Windows.Forms.Label lblScanCode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}