using System.Windows.Forms;

namespace ahlama
{
    public partial class ConfigForm : Form
    {
        public bool hasChanged = false;
        public ConfigForm()
        {
            InitializeComponent();
        }

        private void ConfigForm_Load(object sender, EventArgs e)
        {
            URLBox.Text = Properties.Settings.Default["URL"].ToString();
        }

        private void URLBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default["URL"] = URLBox.Text;
            Properties.Settings.Default.Save();
            this.Hide();  
            hasChanged = true;
        }
    }
}
