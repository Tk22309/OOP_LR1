using System;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace lr10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void buttonStart_Click(object sender, EventArgs e)
        {
            await Task.WhenAll(
                Task.Run(() => KHAFRE()),
                Task.Run(() => MD3()),
                Task.Run(() => ONG_SCHNORRSHAMIR())
            );
        }

        private void KHAFRE()
        {
            try
            {
                string plainText = "This is a secret message.";
                string key = "ThisIsASecretKey";

                using (Aes aes = Aes.Create())
                {
                    aes.Key = Encoding.UTF8.GetBytes(key);
                    aes.IV = new byte[16]; // IV is typically 16 bytes for AES

                    // Encrypt the data
                    ICryptoTransform encryptor = aes.CreateEncryptor(aes.Key, aes.IV);
                    byte[] encryptedData = encryptor.TransformFinalBlock(Encoding.UTF8.GetBytes(plainText), 0, plainText.Length);

                    // Decrypt the data
                    ICryptoTransform decryptor = aes.CreateDecryptor(aes.Key, aes.IV);
                    byte[] decryptedData = decryptor.TransformFinalBlock(encryptedData, 0, encryptedData.Length);

                    string decryptedText = Encoding.UTF8.GetString(decryptedData);
                    richTextBox1.Invoke((MethodInvoker)delegate { richTextBox1.AppendText($"KHAFRE: {decryptedText}\n"); });
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error in KHAFRE: {ex.Message}");
            }
        }

        private void MD3()
        {
            try
            {
                string plainText = "This is another secret message.";

                // Compute hash
                using (MD5 md5 = MD5.Create())
                {
                    byte[] hashBytes = md5.ComputeHash(Encoding.UTF8.GetBytes(plainText));
                    string hashString = BitConverter.ToString(hashBytes).Replace("-", "").ToLower();

                    richTextBox1.Invoke((MethodInvoker)delegate { richTextBox1.AppendText($"MD3: {hashString}\n"); });
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error in MD3: {ex.Message}");
            }
        }

        private void ONG_SCHNORRSHAMIR()
        {
            try
            {
                // Your implementation of ONG-SCHNORRSHAMIR algorithm here

                richTextBox1.Invoke((MethodInvoker)delegate { richTextBox1.AppendText("ONG-SCHNORRSHAMIR: Not implemented yet\n"); });
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error in ONG-SCHNORRSHAMIR: {ex.Message}");
            }
        }
    }
}
