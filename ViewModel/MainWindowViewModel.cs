﻿using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using PostSpamer.library.Linq2SQL;
using PostSpamer.library.Services;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace PostSpamer.ViewModel
{
    public class MainWindowViewModel : ViewModelBase
    {
        private string _WindowTitle = "Спамер мыла 2.17.4.100500";
        private RecipientsDataProvider _RecipientsProvider;

        public string WindowTitle
        {
            get => _WindowTitle;
            set => Set(ref _WindowTitle, value);
        }

        public ICommand RefrashDataCommand { get; }

        public ObservableCollection<Recipients> Recipients { get; } = new ObservableCollection<Recipients>();

        private Recipients _SelectedRecipient;

        public Recipients SelectedRecipient
        {
            get => _SelectedRecipient;
            set => Set(ref _SelectedRecipient, value);
        }

        public MainWindowViewModel(RecipientsDataProvider RecipientsProvider)
        {
            _RecipientsProvider = RecipientsProvider;

            RefrashDataCommand = new RelayCommand(OnRefrashDataCommandExecute, CanRefrashDataCommandExecute());
            //RefrashData();
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
