using EncryptionApp.Libs;
using EncryptionApp.UI;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace EncryptionApp
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private bool isEncrypted = false;
        
        public MainWindow()
        {
            InitializeComponent();
            CmbxCurrentEncryption.Items.Add("Замена символов");
            CmbxCurrentEncryption.Items.Add("Шифр цезаря");
        }

        private void ImgReverse_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {

            SpCenterPanel.Children.Clear();

            string buf = TbxFrom.Text;
            TbxFrom.Text = TbxTo.Text; 
            TbxTo.Text = buf;

            if(isEncrypted)
            {
                SpCenterPanel.Children.Add(TblEncryptedText);
                SpCenterPanel.Children.Add(ImgReverse);
                SpCenterPanel.Children.Add(TblOriginalText);
            }
            else 
            {
                SpCenterPanel.Children.Add(TblOriginalText);
                SpCenterPanel.Children.Add(ImgReverse);
                SpCenterPanel.Children.Add(TblEncryptedText);                               
            }

            isEncrypted = !isEncrypted;
        }


        private void CmbxCurrentEncryption_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Encryption.CurrentType = (Encryption.EncryptionType)CmbxCurrentEncryption.SelectedIndex;
            encryptText();
        }

        private void BtnOptions_Click(object sender, RoutedEventArgs e)
        {
            WndOptions wnd = new WndOptions();
            wnd.ShowDialog();
        }

        private void BtnOpenFile_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Открыть файл";
            ofd.ShowDialog();
            if (ofd.FileName == string.Empty)
                return;
            string originalText;
            TbxTo.Text = Encryption.EncryptTextFromFile(out originalText, ofd.FileName);
            TbxFrom.Text = originalText;
        }

        private void BtnSaveToFile_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Title = "Открыть файл";
            sfd.ShowDialog();
            if (sfd.FileName == string.Empty)
                return;
            if (Encryption.SaveToFile(sfd.FileName, TbxTo.Text))
            {
                MessageBox.Show("Текст сохранён!");
            }
            else
            {
                MessageBox.Show("Нахуй пошёл, переделывай");
            }
        }

        private void TbxFrom_TextChanged(object sender, TextChangedEventArgs e)
        {
            encryptText();
        }

        private void encryptText()
        {
            string encryptedText = string.Empty;
            if (isEncrypted)
                encryptedText = Encryption.DecryptText(TbxFrom.Text);
            else
                encryptedText = Encryption.EncryptText(TbxFrom.Text);
            TbxTo.Text = encryptedText;
        }
    }
}
