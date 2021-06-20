using DataLayer;
using ItemServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PriceVerifier
{
    public partial class frmMain : Form
    {
        private readonly IItemServices itemServices;

        int idleTime = 0;
        int maxIdleTime = 5;

        public frmMain(IItemServices itemSvc)
        {
            InitializeComponent();
            this.itemServices = itemSvc;
            timerIdle.Enabled = true;
        }

        public string panelItemPicture
        {
            get { return ""; }
            set { panelItemImage.BackgroundImage = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "/" + value); }
        }
        public string labelItemScanCode
        {
            get { return lblScanCode.Text; }
            set { lblScanCode.Text = value; }
        }
        public string labelItemName
        {
            get { return lblItemName.Text; }
            set { lblItemName.Text = value; }
        }
        public string labelItemPrice
        {
            get { return lblItemDefaultPrice.Text; }
            set { lblItemDefaultPrice.Text = value; }
        }
        public string labelItemDescription
        {
            get { return lblItemDescription.Text; }
            set { lblItemDescription.Text = value; }
        }

        private void frmMain_KeyPress(object sender, KeyPressEventArgs e)
        {
            var ScanFunction = new ScanFunction(this.itemServices);
            ScanFunction.scanItem(e);
            idleTime = 0;
        }

        private void timerIdle_Tick(object sender, EventArgs e)
        {
            if (idleTime == maxIdleTime)
            {
                this.Hide();
            } else
            {
                idleTime++;
            }
        }
    }
}
