using System;
using CardIOSample.Models;
using Xamarin.Forms;

namespace CardIOSample.Pages
{
    public class CreditCardEntryPage : ContentPage
    {
        public delegate void ScanSucceededEventHandler(object sender, CreditCard_PCL ccPCL);

        public event ScanSucceededEventHandler ScanSucceeded;
        public event EventHandler ScanCancelled;

        public CardIOConfig cardIOConfig;

        public CreditCardEntryPage(CardIOConfig config)
        {
            cardIOConfig = config;
        }

        public void OnScanSucceeded(CreditCard_PCL ccPCL)
        {
            if (ScanSucceeded != null) {
                ScanSucceeded(this, ccPCL);
            }
        }

        public void OnScanCancelled()
        {
            if (ScanCancelled != null) {
                ScanCancelled(this, EventArgs.Empty);
            }
        }
    }
}


