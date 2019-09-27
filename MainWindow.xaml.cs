using System;
using System.Windows;

namespace PostSpamer
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();            
        }

        private void ExitMenuItem_OnClick(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void AboutMenuItem_OnClick(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("This program cannot be run in DOS mode!", "ATTENTION!");
        }

        private void TabSwitcher_OnLeftButtonClick(object sender, EventArgs e)
        {
            if (!(sender is controls.TabSwitcher switcher)) return;
            if (MainTabControl.SelectedIndex < MainTabControl.Items.Count - 1) switcher.RightButtonVisible = true;
            if (MainTabControl.SelectedIndex == 0)
            {
                switcher.LeftButtonVisible = false;
                return;
            }
            MainTabControl.SelectedIndex--;
            if (MainTabControl.SelectedIndex < MainTabControl.Items.Count - 1) switcher.RightButtonVisible = true;
            if (MainTabControl.SelectedIndex == 0) switcher.LeftButtonVisible = false;
        }

        private void TabSwitcher_OnRightButtonClick(object sender, EventArgs e)
        {
            if (!(sender is controls.TabSwitcher switcher)) return;
            if (MainTabControl.SelectedIndex > 0) switcher.LeftButtonVisible = true;
            if (MainTabControl.SelectedIndex == MainTabControl.Items.Count -1)
            {                
                switcher.RightButtonVisible = false;
                return;
            }
            MainTabControl.SelectedIndex++;
            if (MainTabControl.SelectedIndex > 0) switcher.LeftButtonVisible = true;
            if (MainTabControl.SelectedIndex == MainTabControl.Items.Count - 1) switcher.RightButtonVisible = false;
        }

        private void PlannerButton_Click(object sender, RoutedEventArgs e)
        {
            MainTabControl.SelectedIndex = 1;
        }
    }
}
