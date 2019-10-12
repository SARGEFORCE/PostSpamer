using Microsoft.Win32;
using System.Windows;

namespace TestEFDB
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static string FileName;
        public OpenFileDialog openFileDialog = new OpenFileDialog();
        public SaveFileDialog saveFileDialog = new SaveFileDialog();
        public MainWindow()
        {
            InitializeComponent();
            openFileDialog.Filter = "CSV files(*.csv)|*.csv|All files(*.*)|*.*";
            saveFileDialog.Filter = "CSV files(*.csv)|*.csv|All files(*.*)|*.*";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            openFileDialog.ShowDialog();
            // получаем выбранный файл
            string filename = openFileDialog.FileName;
            // читаем файл
            //MessageBox.Show("Файл загружен в базу данных");
        }
    }
}
