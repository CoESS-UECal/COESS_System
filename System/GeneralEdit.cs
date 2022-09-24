using System.Windows.Forms;

namespace System
{
    public partial class GeneralEdit : Form
    {

        public static string data;
        public static string col;

        public GeneralEdit()
        {
            InitializeComponent();
            if (MainMenu.isMaster == true)
            {
                MainMenu.Initialize("server=localhost;uid=root;pwd=;database=coess;sslmode=none;");
            }
            else
            {
                MainMenu.Initialize("server=192.168.1.4;uid=access;pwd=;database=coess;sslmode=none;");
            }
        }

        private void GeneralEdit_Load(object sender, EventArgs e)
        {
            tbEdit.Text = data;
            tbEdit.Focus();
        }

        private void tbEdit_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                if (DialogResult.Yes == MessageBox.Show("Would you like to go back?\n\nAll information will be discarded.", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    Close();
                }
            }
            else if (e.KeyCode == Keys.Enter)
            {
                if (DialogResult.Yes == MessageBox.Show("Would you like to save changes?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    Member_List.Updated(col, tbEdit.Text, Member_List.idnumber);
                    MessageBox.Show("Data Updated!", "Update Successful!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                    data = tbEdit.Text;
                }
            }
        }

    }
}
