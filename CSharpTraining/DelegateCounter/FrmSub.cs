using System.Windows.Forms;

namespace CSharpTraining
{
    public partial class FrmSub : Form
    {
        public FrmSub()
        {
            InitializeComponent();
        }

        // 2. Define the method according to the delegate
        public void Receiver(string msg)
        {
            lbCounter.Text = msg;
        }
    }
}
