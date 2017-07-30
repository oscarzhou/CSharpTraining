using System;
using System.Windows.Forms;

namespace CSharpTraining
{
    public partial class FrmMain : Form
    {
        public delegate void DlgCount(string msg); //1. Declare the delegate variable

        public DlgCount EvtCount; // 3. Create the object of the delegate variable

        

        public FrmMain()
        {
            InitializeComponent();
            FrmSub frmSub = new FrmSub();
            EvtCount += frmSub.Receiver; // 4. Associate the delegate with the specific method
            frmSub.Show();
        }

        private int counter = 0;

        private void btnPlusOne_Click(object sender, EventArgs e)
        {
            counter++;
            EvtCount(counter.ToString()); // 5. Call the delegate object to pass the message
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            counter = 0;
            EvtCount(counter.ToString()); // 5. Call the delegate object to pass the message
        }
    }
}
