using System.Windows.Controls;

namespace PostSpamer.View
{
    /// <summary>
    /// Логика взаимодействия для RecipientsEditor.xaml
    /// </summary>
    public partial class RecipientsEditor : UserControl
    {
        public RecipientsEditor()
        {
            InitializeComponent();
        }

        //private void OnDataValidationError(object sender, ValidationErrorEventArgs e)
        //{
        //    if (!(e.Source is Control control)) return;

        //    if (e.Action == ValidationErrorEventAction.Added)
        //        control.ToolTip = e.Error.ErrorContent.ToString();
        //    else
        //        control.ClearValue(ToolTipProperty);
        //}
    }
}
