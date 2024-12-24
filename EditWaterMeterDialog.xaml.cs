using System.Windows;

namespace WaterMeterApp
{
    public partial class EditWaterMeterDialog : Window
    {
        public EditWaterMeterDialog()
        {
            InitializeComponent();
        }

        private void OkButton_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
            Close();
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
            Close();
        }
    }
}
