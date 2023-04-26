using System.Diagnostics;

namespace AuthenticationServer.RSAKeyGenerator.UI
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void selectPrivateKeyPathButton_Click(object sender, EventArgs e)
        {
            privateKeyPathTextBox.Text = OpenSaveFileDialog();

        }

        private void selectPublicKeyPathButton_Click(object sender, EventArgs e)
        {
            publicKeyPathTextBox.Text = OpenSaveFileDialog();
        }

        private string OpenSaveFileDialog()
        {
            using (var saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "pem|*.pem";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    return saveFileDialog.FileName;
                }

                return string.Empty;
            }
        }

        private void openPrivateKeyPathButton_Click(object sender, EventArgs e)
        {
            OpenDir(privateKeyPathTextBox.Text);
        }

        private void openPublicKeyPathButton_Click(object sender, EventArgs e)
        {
            OpenDir(publicKeyPathTextBox.Text);
        }

        private void OpenDir(string path)
        {
            if (CheckFilePath(path, out var dirPath))
            {
                Process.Start("explorer", dirPath);
            }
        }

        private void generatorButton_Click(object sender, EventArgs e)
        {
            var key = KeyGenerator.Generate();
            publicKeyTextBox.Text = key.PublicKey;
            privateKeyTextBox.Text = key.PrivateKey;

            if (CheckFilePath(publicKeyPathTextBox.Text, out var _))
            {
                File.WriteAllText(publicKeyPathTextBox.Text, key.PublicKey);
            }

            if (CheckFilePath(privateKeyPathTextBox.Text, out var _))
            {
                File.WriteAllText(privateKeyPathTextBox.Text, key.PrivateKey);
            }
        }

        private bool CheckFilePath(string path, out string dirPath)
        {
            dirPath = string.Empty;
            if (!string.IsNullOrWhiteSpace(path))
            {
                var dir = Path.GetDirectoryName(path);
                if (Directory.Exists(dir))
                {
                    dirPath = dir;
                    return true;
                }
            }

            return false;
        }
    }
}