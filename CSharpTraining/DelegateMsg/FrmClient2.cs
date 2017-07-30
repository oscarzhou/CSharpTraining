using System;
using System.Windows.Forms;

namespace CSharpTraining.DelegateMsg
{
    public partial class FrmClient2 : Form
    {
        public FrmClient2()
        {
            InitializeComponent();
        }
        public delegate void DlgSendMsg(string content);//step 1


        public DlgSendMsg EvtSendMsg;//step 3
        private void btnSend_Click(object sender, EventArgs e)
        {
            EvtSendMsg("Client2: " + tbClient.Text.Trim()+"\r\n");//step 5
        }
    }
}
