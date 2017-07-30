using System.Windows.Forms;

namespace CSharpTraining.DelegateMsg
{
    public partial class FrmServer : Form
    {


        public FrmServer()
        {
            InitializeComponent();

            FrmClient1 frmClient1 = new FrmClient1();
            frmClient1.EvtSendMsg += this.Receiver;//step 4
            frmClient1.Show();

            FrmClient2 frmClient2 = new FrmClient2();
            frmClient2.EvtSendMsg += this.Receiver;
            frmClient2.Show();
        }


        public void Receiver(string content)
        {
            tbServer.AppendText(content);//step 2
            
        }

    }
}
