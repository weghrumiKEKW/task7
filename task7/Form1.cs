namespace task7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string flowertype = txtType.Text;
            string flowerprice = txtPrice.Text;
            string flowerquantity = txtQuantity.Text;
            if (string.IsNullOrEmpty(flowertype) || string.IsNullOrEmpty(flowerprice) || string.IsNullOrEmpty(flowerquantity))
            {
                MessageBox.Show("fill in the blanks", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!double.TryParse(flowerprice, out double price) || price <= 0)
            {
                    MessageBox.Show("it must be greater than 0", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!double.TryParse(flowerquantity, out double quantity) || quantity <= 0)
            {
                MessageBox.Show("it must be greater than 0", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            double totalprice = quantity * price;

                dataGridView1.Rows.Add(flowertype,flowerprice,flowerquantity,totalprice);

            double total = 0;

            foreach (DataGridViewRow row in dataGridView1.Rows)
                {

                    if (row.Cells["totalamount"].Value != null)
                    {
                        total += Convert.ToDouble((row.Cells["totalamount"].Value));
                    }
                }
                lblIncome.Text = total.ToString("F2");
                txtType.Text = "";
                txtQuantity.Text = "";
                txtPrice.Text = "";
            }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("do you want exit?","Notification",MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Close();
            }
        }
    }
}
