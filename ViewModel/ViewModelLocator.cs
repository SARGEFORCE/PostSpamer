using GalaSoft.MvvmLight.Ioc;
using CommonServiceLocator;
using PostSpamer.library.Services.InMemory;
using PostSpamer.library.Services.Interfaces;
using PostSpamer.library.Linq2SQL;
using PostSpamer.library.Services;
using PostSpamer.library.EF;

namespace PostSpamer.ViewModel
{
    public class ViewModelLocator
    {
        public ViewModelLocator()
        {
            var services = SimpleIoc.Default;
            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);
            /*
            services //память компа
                .TryRegister<MainWindowViewModel>()
                .TryRegister<IRecipientsDataProvider, InMemoryRecipientsDataProvider>()
                .TryRegister<ISendersDataProvider, InMemorySendersDataProvider>()
                .TryRegister<ISpamDataProvider, InMemorySpamDataProvider>();
            */

            services //база данных
                .TryRegister<MainWindowViewModel>()
                .TryRegister(() => new PostSpamerDBDataContext())
                .TryRegister<IRecipientsDataProvider, Linq2SQLRecipientsDataProvider>()
                .TryRegister(() => new PostSpamerDB());
            
        }

        public MainWindowViewModel MainVindowModel => ServiceLocator.Current.GetInstance<MainWindowViewModel>();

        public static void Cleanup()
        {
            // TODO Clear the ViewModels
        }
    }
}