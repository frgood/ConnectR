using Microsoft.Data.SqlClient;

namespace DBDialog
{
    public partial class DBConnector : Form
    {
        //private string? provider;
        //private string? servername;
        //private bool authentication;
        ////private string? username;
        //private string? password;
        //private string? databasename;
        //private bool encrypt;
        //private bool trustcertificate;
        //private string? connectionstring;
        private readonly SqlConnectionStringBuilder bldr = new();

        private string? filepath;
        private string? columndelimiter;
        private string? columntextqualifier;

        private bool connectiontestresult = false;


        public DBConnector()
        {
            InitializeComponent();
        }

        public DBConnector(string connectionstring)
        {
            this.ConnectionString = connectionstring ?? throw new ArgumentNullException(nameof(connectionstring));
            InitializeComponent();
            bldr.ConnectionString = this.ConnectionString;
        }

        /*--------------------------------------------------------*/
        public string? DataSource { get => TxtServerName.Text; set => TxtServerName.Text = value; }
        public string? InitialCatalog { get => TxtDatabase.Text; set => TxtDatabase.Text = value; }
        public bool WindowsAuthentication { get => CbxWindowsAuthentication.Checked; set => CbxWindowsAuthentication.Checked = value; }
        public string? Username { get => TxTUsername.Text; set => TxTUsername.Text = value; }
        public string? Password { get => TxtPassword.Text; set => TxtPassword.Text = value; }

        public bool TrustServerCertificate { get => CbxTrustServerCertificate.Checked; set => CbxTrustServerCertificate.Checked = value; }
        public bool Encrypt { get => CbxEncrypt.Checked; set => CbxEncrypt.Checked = value; }

        public string ConnectionString { get => bldr.ConnectionString; set => bldr.ConnectionString = value; }
        /*--------------------------------------------------------*/

        public string? Filepath { get => filepath; set => filepath = value; }
        public string? Columndelimiter { get => columndelimiter; set => columndelimiter = value; }
        public string? Columntextqualifier { get => columntextqualifier; set => columntextqualifier = value; }
        public bool Connectiontestresult { get => connectiontestresult; set => connectiontestresult = value; }

        private void BtnTest_Click(object sender, EventArgs e)
        {
            BtnSave.Enabled = TestConnection();
        }

        private bool TestConnection()
        {
            if (string.IsNullOrWhiteSpace(ConnectionString)) return false;
            string msg = string.Empty;
            using (SqlConnection cnx = new(ConnectionString))
            {
                try
                {
                    cnx.Open();
                    Connectiontestresult = true;
                    msg = "Connection Successful";
                }
                catch (SqlException e)
                {
                    Connectiontestresult = false;
                    msg = "Connection failed - " + e.Message;
                }
            }
            string caption = "SQL Server connection test result";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            MessageBox.Show(msg, caption, buttons);

            return connectiontestresult;
        }

        private void FormTextChanged(object sender, EventArgs e)
        {
            bldr.DataSource = TxtServerName.Text;
            bldr.InitialCatalog = TxtDatabase.Text;
            bldr.IntegratedSecurity = CbxWindowsAuthentication.Checked;
            if (CbxWindowsAuthentication.Checked)
            {
                TxTUsername.Text = ""; TxTUsername.Enabled = false;
                TxtPassword.Text = ""; TxtPassword.Enabled = false;
            }
            else
            {
                bldr.UserID = TxTUsername.Text; TxTUsername.Enabled = false;
                bldr.Password = TxtPassword.Text; TxtPassword.Enabled = false;
            }
            bldr.Encrypt = CbxEncrypt.Checked;
            bldr.TrustServerCertificate = CbxTrustServerCertificate.Checked;
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
