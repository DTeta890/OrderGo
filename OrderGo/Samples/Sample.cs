using OrderGo.Database;
using System.Windows.Forms;

namespace OrderGo
{
    public partial class Sample : Form
    {
        public Sample()
        {
            InitializeComponent();
        }

        private void Sample_Load(object sender, System.EventArgs e)
        {
            userLabel.Text = Retreival.USER;
        }
    }
}
