using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TxtFileEditor
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public bool IsAutoSaveEnabled { get; set; }
        public MainWindow()
        {
            InitializeComponent();

            directionLbl.Content = "Select File!";
        }

        private void autoSaveBtn_Checked(object sender, RoutedEventArgs e)
        {
            #region UI
            autoSaveBg.Background = Brushes.Green;
            autoSaveBtn.Background = Brushes.Transparent;
            autoSaveEllipse.ClearValue(Canvas.LeftProperty);
            Canvas.SetRight(autoSaveEllipse, 2);
            #endregion
            IsAutoSaveEnabled = true;
            textArea.Focus();
        }

        private void autoSaveBtn_Unchecked(object sender, RoutedEventArgs e)
        {
            #region UI
            autoSaveBg.Background = Brushes.Red;
            autoSaveBtn.Background = Brushes.Transparent;
            autoSaveEllipse.ClearValue(Canvas.RightProperty);
            Canvas.SetLeft(autoSaveEllipse, 1);
            #endregion
            IsAutoSaveEnabled= false;
            textArea.Focus();
        }

        private void changeDirectionBtn_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = FileManager.FilePath;
            openFileDialog.Filter = "TXT files|*.txt";
            var result = openFileDialog.ShowDialog();

            if (result == true)
            {
                FileManager.FilePath = openFileDialog.FileName;
                textArea.IsEnabled = true;
                textArea.Text = FileManager.ReadFile();
            }
        }

        private void textArea_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (IsAutoSaveEnabled) FileManager.WriteFile(textArea.Text);
        }

        private void saveBtn_Click(object sender, RoutedEventArgs e)
        {
            FileManager.WriteFile(textArea.Text);
            textArea.Focus();
        }

        private void cutBtn_Click(object sender, RoutedEventArgs e)
        {
            if (!isAnyTextSelected()) return;

            var textBox = textArea as TextBox;
            if(textBox.SelectedText != null)
            {
                int selectionStart = textBox.SelectionStart;
                int selectionLength = textBox.SelectionLength;
                string currentText = textBox.Text;

                Clipboard.SetText(currentText.Substring(selectionStart, selectionLength));

                textBox.Text = currentText.Remove(textBox.SelectionStart, textBox.SelectionLength);
                textBox.CaretIndex = selectionStart;
            }
            textArea.Focus();
        }

        private void copyBtn_Click(object sender, RoutedEventArgs e)
        {
            if (!isAnyTextSelected()) return;

            var textBox = textArea as TextBox;
            int selectionStart = textBox.SelectionStart;
            int selectionLength = textBox.SelectionLength;

            if (textBox.SelectedText != null) Clipboard.SetText(textBox.Text.Substring(selectionStart, selectionLength));

            textBox.CaretIndex = selectionStart;
            textArea.Focus();
        }

        private void pasteBtn_Click(object sender, RoutedEventArgs e)
        {
            var textBox = textArea as TextBox;
            int caretIndex = textBox.CaretIndex;
            textBox.Text = textBox.Text.Insert(caretIndex, Clipboard.GetText());
            textBox.CaretIndex = caretIndex += Clipboard.GetText().Length;
            textArea.Focus();
        }

        private void selectAllBtn_Click(object sender, RoutedEventArgs e)
        {
            textArea.SelectAll();
            textArea.Focus();
        }

        private bool isAnyTextSelected() => textArea.SelectedText.Length > 0;

    }
}
