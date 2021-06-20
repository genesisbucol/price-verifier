using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using System.Windows.Forms;
using AdvertisementServices;
using DataLayer;
using ItemServices;

namespace PriceVerifier
{
    public partial class frmIdle : Form
    {
        private readonly IAdvertisementService advertisementService;
        private readonly IItemServices itemServices;

        IEnumerable<AdvertisementDTO> listAds;
        String adName = "";
        int adStartInterval = 0;
        int adEndInterval = 0;
        int adMaxIndex = 0;

        public frmIdle(IAdvertisementService advertisementSvc, IItemServices itemSvc)
        {
            InitializeComponent();
            this.advertisementService = advertisementSvc;
            this.itemServices = itemSvc;
        }

        private void frmIdle_Load(object sender, EventArgs e)
        {
            listAds = this.advertisementService.List();
            timerAds.Enabled = true;
            Program.globalDisplayIndex = 0;
            adMaxIndex = listAds.Count();
            pangelDownArrow.BackgroundImage = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "/Images/Others/down-arrow.png");

            // condition if no ads.
            // insert code here
        }

        private void timerAds_Tick(object sender, EventArgs e)
        {
            try
            {
                timerAds.Enabled = false;
                if (adStartInterval == adEndInterval)
                {
                    if (Program.globalDisplayIndex == adMaxIndex)
                    {
                        Program.globalDisplayIndex = 0;
                    }

                    var selectedAd = listAds.ElementAt(Program.globalDisplayIndex);
                    panelAds.BackgroundImage = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "/" + selectedAd.FilePath);

                    adStartInterval = 0;
                    adEndInterval = int.Parse(selectedAd.Interval);
                    Program.globalDisplayIndex++;
                } else
                {
                    adStartInterval++;
                }
                timerAds.Enabled = true;
            }
            catch (Exception ex)
            {

            }
        }

        private void frmIdle_KeyPress(object sender, KeyPressEventArgs e)
        {

            //Program.scanItem(e);
            var ScanFunction = new ScanFunction(this.itemServices);
            ScanFunction.scanItem(e);

            //if (e.KeyChar == (char)Keys.Return)
            //{
            //    IEnumerable<ItemDTO> selectedItem = this.itemServices.list(Program.scanCode);
            //    if (selectedItem.Count() > 0)
            //    {
            //        var frmMain = new frmMain();
            //        frmMain.panelItemPicture = selectedItem.ElementAt(0).PicturePath;
            //        frmMain.labelItemScanCode = selectedItem.ElementAt(0).ScanCode;
            //        frmMain.labelItemName = selectedItem.ElementAt(0).ItemName;
            //        frmMain.labelItemPrice = selectedItem.ElementAt(0).DefaultUnitPrice.ToString();
            //        frmMain.labelItemDescription = selectedItem.ElementAt(0).ItemDescription;

            //        if (frmMain.Visible == false)
            //        {
            //            frmMain.Show();
            //        }


            //        //MessageBox.Show(selectedItem.ElementAt(0).ItemName);
            //    }
            //    Program.scanCode = "";
            //} else
            //{
            //    Program.scanCode += e.KeyChar.ToString();
            //}
        }
    }
}
