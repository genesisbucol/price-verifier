using AdvertisementServices;
using DataLayer;
using ItemServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unity;

namespace PriceVerifier
{
    static class Program
    {
        public static int globalDisplayIndex = 0;

        public static String scanCode = "";

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var container = BuildContainer();
            //UnityConfig.RegisterComponents();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(container.Resolve<frmIdle>());
        }

        public static IUnityContainer BuildContainer()
        {
            var currentContainer = new UnityContainer();
            currentContainer.RegisterType<IAdvertisementService, AdvertisementService>();
            currentContainer.RegisterType<IAdvertisementDL, AdvertisementEFDL>();

            currentContainer.RegisterType<IItemServices, ItemService>();
            currentContainer.RegisterType<IItemDL, ItemEFDL>();

            return currentContainer;
        }

        
    }
}
