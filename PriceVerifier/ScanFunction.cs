using DataLayer;
using ItemServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PriceVerifier
{
    public class ScanFunction
    {
        private readonly IItemServices itemServices;

        public ScanFunction(IItemServices itemSvc)
        {
            this.itemServices = itemSvc;
        }

        public void scanItem(KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                ItemDTO selectedItem = this.itemServices.GetItem(Program.scanCode);
                if (selectedItem != null)
                {
                    var frmMain = new frmMain(this.itemServices);
                    frmMain.panelItemPicture = selectedItem.PicturePath;
                    frmMain.labelItemScanCode = selectedItem.ScanCode;
                    frmMain.labelItemName = selectedItem.ItemName;
                    frmMain.labelItemPrice = selectedItem.DefaultUnitPrice.ToString();
                    frmMain.labelItemDescription = (selectedItem.ItemDescription == null) ? "No description yet." : selectedItem.ItemDescription;

                    if (frmMain.Visible == false) //!Application.OpenForms.OfType<frmMain>().Any()
                    {
                        frmMain.Show();
                    }
                }
                Program.scanCode = "";
            }
            else
            {
                Program.scanCode += e.KeyChar.ToString();
            }
        }
    }
}
