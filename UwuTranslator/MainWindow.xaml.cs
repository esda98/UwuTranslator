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
using System.Windows.Navigation;
using System.Windows.Shapes;
using UwuTranslator.Framework;

namespace UwuTranslator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>

    public partial class MainWindow : Window
    {
        public const string uwuPlaceHolder = "Your Uwu Output will be presented here!";
        public const string inputPlaceholder = "Type your string to translate here!";
        public MainWindow()
        {
            InitializeComponent();
            txtInput.Text = inputPlaceholder;
            tblkUwuOutput.Text = uwuPlaceHolder;
        }
        
        #region Input Placeholder
        
        private void TxtInput_OnGotFocus(object sender, RoutedEventArgs e)
        {
            if (txtInput.Text == inputPlaceholder)
            {
                txtInput.Text = "";
            }
        }

        private void TxtInput_OnLostFocus(object sender, RoutedEventArgs e)
        {
            if (txtInput.Text == "")
            {
                txtInput.Text = inputPlaceholder;
            }
        }
        
        #endregion


        private void TxtInput_OnTextChanged(object sender, TextChangedEventArgs e)
        {
            //when no text is entered into the text box, show the placeholder in the label
            if (txtInput is null || string.IsNullOrWhiteSpace(txtInput.Text))
            {
                tblkUwuOutput.Text = uwuPlaceHolder;
                return;
            }
            tblkUwuOutput.Text = UwuTranslatorenator.translate(txtInput.Text);
        }
    }
}