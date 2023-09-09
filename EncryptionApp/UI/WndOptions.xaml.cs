using EncryptionApp.Libs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using EncryptionApp.Properties;

namespace EncryptionApp.UI
{
    /// <summary>
    /// Логика взаимодействия для WndOptions.xaml
    /// </summary>
    public partial class WndOptions : Window
    {
        private bool changesSaved = false;
        public WndOptions()
        {
            InitializeComponent();
            TbCeusarShift.Text = Encryption.CEUSAR_SHIFT.ToString();
        }

        private void BtnOk_Click(object sender, RoutedEventArgs e)
        {
            bool hasErrors = false;
            StringBuilder stringBuilder= new StringBuilder();

            uint ceusarShift = 0;
            uint currentCharReplaceTable = 0;
            if(!UInt32.TryParse(TbCeusarShift.Text, out ceusarShift))
                stringBuilder.AppendLine($"Укажите положительное целое число в поле {TblCeusarShift.Text}!");

            if (!UInt32.TryParse(TbCharReplace.Text, out currentCharReplaceTable))
                stringBuilder.AppendLine($"Укажите положительное целое число в поле {TblCharReplace.Text}!");

            if (currentCharReplaceTable > Settings.Default.CHAR_REPLACE_TABLES_COUNT)
                stringBuilder.AppendLine("Таблицы с таким номером не существует!");

            if (stringBuilder.Length != 0)
            {
                MessageBox.Show(stringBuilder.ToString(), "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            Settings.Default.CEUSAR_SHIFT = ceusarShift;
            Settings.Default.Save();
            MessageBox.Show("Настройки сохранены!", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);
            changesSaved = true;
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if(changesSaved == true)
                return;
            if (MessageBox.Show("В случае закрытия окна все несохранённые данные будут утеряны! Вы уверены?",
                    "Внимание",
                    MessageBoxButton.OKCancel,
                    MessageBoxImage.Warning) == MessageBoxResult.OK)
            {
                e.Cancel = false;
            }
            else
                e.Cancel = true;
        }

        private void TbCeusarShift_TextChanged(object sender, TextChangedEventArgs e)
        {
            changesSaved = false;
        }
    }
}
