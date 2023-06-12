using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Text.Json;
using System.Text.Json.Nodes;
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
using System.Windows.Threading;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt";
            saveFileDialog.DefaultExt = ".txt";
            string content = textbox.Text;

            if (saveFileDialog.ShowDialog() == true)
            {
                string filePath = saveFileDialog.FileName;
                Combobox1.Items.Add(filePath);
                File.WriteAllText(filePath, content);
            }
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(textbox.SelectedText))
            {
                Clipboard.SetText(textbox.SelectedText);
                textbox.SelectedText = string.Empty;
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(textbox.SelectedText))
            {
                Clipboard.SetText(textbox.SelectedText);
            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            if (Clipboard.ContainsText())
            {
                string textToPaste = Clipboard.GetText();
                textbox.SelectedText = textToPaste;
            }
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            textbox.SelectAll();
        }

        private void SaveData()
        {
            string dataToSave = textbox.Text;

            File.WriteAllText("C:\\Users\\Ismay_be29\\Desktop", dataToSave);
        }
        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            SaveData();

        }
    }
}
