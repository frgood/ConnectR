using DBDialog;

namespace Test.Dialog
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            // Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=master;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False
            DBConnector dbd = new();
            DialogResult =  dbd.ShowDialog();
            ReturnedValue.Text = dbd.DialogResult.ToString() + " " + dbd.ConnectionString;

        }
    }
}
