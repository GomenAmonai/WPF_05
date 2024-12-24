using System.Windows;

namespace WaterMeterApp
{
    public partial class MainWindow : Window
    {
        private WaterMeter _currentWaterMeter;

        public MainWindow()
        {
            InitializeComponent();

            _currentWaterMeter = new WaterMeter
            {
                Manufacturer = "Default Manufacturer",
                Model = "Model A",
                SerialNumber = "SN123456",
                LastVerificationDate = DateTime.Now.AddYears(-1),
                IsForHotWater = false
            };
        }

        private void EditButton_Click(object sender, RoutedEventArgs e)
        {
            var meterClone = (WaterMeter)_currentWaterMeter.Clone();
            var dialog = new EditWaterMeterDialog
            {
                DataContext = meterClone
            };

            if (dialog.ShowDialog() == true)
            {
                _currentWaterMeter = meterClone;
            }
        }
    }
}
