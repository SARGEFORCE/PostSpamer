using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using PostSpamer.library.Linq2SQL;
using PostSpamer.library.Services;
using System.Collections.ObjectModel;
using System.Windows.Input;
using PostSpamer.library.Services.Interfaces;

namespace PostSpamer.ViewModel
{
    public class MainWindowViewModel : ViewModelBase
    {
        private string _WindowTitle = "Спамер мыла 2.17.4.100500";
        private IRecipientsDataProvider _RecipientsProvider;

        public string WindowTitle
        {
            get => _WindowTitle;
            set => Set(ref _WindowTitle, value);
        }

        public ICommand RefrashDataCommand { get; }

        public ICommand SaveChangesCommand { get; }

        public ObservableCollection<Recipient> Recipients { get; } = new ObservableCollection<Recipient>();

        private Recipient _SelectedRecipient;

        public Recipient SelectedRecipient
        {
            get => _SelectedRecipient;
            set => Set(ref _SelectedRecipient, value);
        }
        
        public MainWindowViewModel(IRecipientsDataProvider RecipientsProvider)
        {
            _RecipientsProvider = RecipientsProvider;

            RefrashDataCommand = new RelayCommand(OnRefrashDataCommandExecute, CanRefrashDataCommandExecute());
            SaveChangesCommand = new RelayCommand(OnSaveChangesCommandExecuted);
            //RefrashData();
        }

        private void OnSaveChangesCommandExecuted()
        {
            _RecipientsProvider.SaveChanges();
        }

        private bool CanRefrashDataCommandExecute() => true;

        private void OnRefrashDataCommandExecute() => RefrashData();

        private void RefrashData()
        {
            Recipients.Clear();
            foreach (var recipient in _RecipientsProvider.GetAll())
                Recipients.Add(recipient);
        }
    }
}
