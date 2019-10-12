using GalaSoft.MvvmLight;
using System.Collections.ObjectModel;
using TestEFDB.Data.Entities;
using TestEFDB.Data.Interfaces;

namespace TestEFDB.ViewModel
{
    /// <summary>
    /// This class contains properties that the main View can data bind to.
    /// <para>
    /// Use the <strong>mvvminpc</strong> snippet to add bindable properties to this ViewModel.
    /// </para>
    /// <para>
    /// You can also use Blend to data bind with the tool's support.
    /// </para>
    /// <para>
    /// See http://www.galasoft.ch/mvvm
    /// </para>
    /// </summary>
    public class MainViewModel : ViewModelBase
    {
        private string _WindowTitle = "Тест базы данных EF";

        IHumansDataProvider _HumansProvider;
        public string WindowTitle
        {
            get => _WindowTitle;
            set => Set(ref _WindowTitle, value);
        }

        public ObservableCollection<Human> Recipients { get; } = new ObservableCollection<Human>();

        private Human _SelectedHuman;

        public Human SelectedHuman
        {
            get => _SelectedHuman;
            set => Set(ref _SelectedHuman, value);
        }

        private void OnSaveChangesCommandExecuted()
        {
            _HumansProvider.SaveChanges();
        }

        private bool CanRefrashDataCommandExecute() => true;

        private void OnRefrashDataCommandExecute() => RefrashData();

        private void RefrashData()
        {
            Recipients.Clear();
            foreach (var recipient in _HumansProvider.GetAll())
                Recipients.Add(recipient);
        }
        public MainViewModel()
        {
            ////if (IsInDesignMode)
            ////{
            ////    // Code runs in Blend --> create design time data.
            ////}
            ////else
            ////{
            ////    // Code runs "for real"
            ////}
        }
    }
}