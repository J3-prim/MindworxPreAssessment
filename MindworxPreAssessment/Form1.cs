namespace MindworxPreAssessment
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtAdd.Text))
            {
                lstCollection.Items.Add(txtAdd.Text);
                txtAdd.Text = "";
            }
            else
            {
                MessageBox.Show("Please enter text or word to add");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lstCollection.SelectedIndex == -1)
            {
                MessageBox.Show("Please select word to delete");
            }
            else
            {
                lstCollection.Items.RemoveAt(lstCollection.SelectedIndex);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (lstCollection.SelectedIndex == -1)
            {
                MessageBox.Show("Please select word to edit");
            }
            else
            {
                string replacement = lstCollection.SelectedItem.ToString();
                lstCollection.Items.RemoveAt(lstCollection.SelectedIndex);
                txtAdd.Text = replacement;
                btnAdd.Visible = false;
                btnEdit.Visible = false;
                btnClear.Visible = false;
                btnDelete.Visible = false;
                btnCompleteEdit.Visible = true;

            }

        }

        private void btnCompleteEdit_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtAdd.Text))
            {
                lstCollection.Items.Add(txtAdd.Text);
                btnAdd.Visible = true;
                btnEdit.Visible = true;
                btnClear.Visible = true;
                btnDelete.Visible = true;
                btnCompleteEdit.Visible = false;
                txtAdd.Text = ""; 
            }
            else
            {
                MessageBox.Show("Please enter text or word to add");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lstCollection.Items.Clear();
        }
    }
}