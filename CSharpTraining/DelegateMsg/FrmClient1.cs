using System;
using System.Windows.Forms;

namespace CSharpTraining.DelegateMsg
{
    public partial class FrmClient1 : Form
    {
        public FrmClient1()
        {
            InitializeComponent();
        }

        
        public delegate void DlgSendMsg(string content);//step 1


        public DlgSendMsg EvtSendMsg;



        private void btnSend_Click(object sender, EventArgs e)
        {
            EvtSendMsg("Client1: " + tbClient.Text.Trim() + "\r\n");//step 5
        }
    }
}
