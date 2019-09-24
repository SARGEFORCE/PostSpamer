using System;
using System.Windows;
using System.Windows.Controls;

namespace PostSpamer.controls
{
    public partial class TabSwitcher
    {
        public TabSwitcher()
        {
            InitializeComponent();
        }

        public event EventHandler LeftButtonClick;
        public event EventHandler RightButtonClick;

        public bool LeftButtonVisible
        {
            get => LeftButton.Visibility == Visibility;
            set => LeftButton.Visibility = value ? Visibility.Visible : Visibility.Collapsed;
        }

        public bool RightButtonVisible
        {
            get => RightButton.Visibility == Visibility;
            set => RightButton.Visibility = value ? Visibility.Visible : Visibility.Collapsed;
        }
        private void Button_OnClick(object sender, RoutedEventArgs e)
        {
            if (!(e.Source is Button button)) return;

            switch (button.Name)
            {
                case "LeftButton": //Туда
                    LeftButtonClick?.Invoke(this, EventArgs.Empty);
                    break;
                case "RightButton"://Сюда
                    RightButtonClick?.Invoke(this, EventArgs.Empty);
                    break;
            }
        }
    }
}
