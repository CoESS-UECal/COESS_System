using System.Windows.Forms;

namespace System
{
    public partial class NameEdit : Form
    {
        public NameEdit()
        {
            InitializeComponent();
        }
        private void NameEdit_Load(object sender, EventArgs e)
        {
            tbEditFN.Text = Member_List.firstname;
            tbEditMI.Text = Member_List.mi;
            tbEditLN.Text = Member_List.lastname;
            tbEditFN.Focus();
        }

        private void tbEditFN_KeyDown(object sender, KeyEventArgs e)
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
                    Member_List.Updated("FN", tbEditFN.Text, Member_List.idnumber);
                    Member_List.Updated("MI", tbEditMI.Text, Member_List.idnumber);
                    Member_List.Updated("LN", tbEditLN.Text, Member_List.idnumber);
                    MessageBox.Show("Data Updated!", "Update Successful!");
                    Member_List.fullname = tbEditFN.Text + " " + tbEditMI.Text + " " + tbEditLN.Text;
                    Close();
                }
            }
        }

        private void tbEditLN_KeyDown(object sender, KeyEventArgs e)
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
                    Member_List.Updated("FN", tbEditFN.Text, Member_List.idnumber);
                    Member_List.Updated("MI", tbEditMI.Text, Member_List.idnumber);
                    Member_List.Updated("LN", tbEditLN.Text, Member_List.idnumber);
                    MessageBox.Show("Data Updated!", "Update Successful!");
                    Member_List.fullname = tbEditFN.Text + " " + tbEditMI.Text + " " + tbEditLN.Text;
                    Close();
                }
            }
        }

        private void tbEditMI_KeyDown(object sender, KeyEventArgs e)
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
                    Member_List.Updated("FN", tbEditFN.Text, Member_List.idnumber);
                    Member_List.Updated("MI", tbEditMI.Text, Member_List.idnumber);
                    Member_List.Updated("LN", tbEditLN.Text, Member_List.idnumber);
                    MessageBox.Show("Data Updated!", "Update Successful!");
                    Member_List.fullname = tbEditFN.Text + " " + tbEditMI.Text + " " + tbEditLN.Text;
                    Close();
                }
            }
        }
    }
}
