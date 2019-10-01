using GalaSoft.MvvmLight.Ioc;
using CommonServiceLocator;
using PostSpamer.library.Services;
using PostSpamer.library.Linq2SQL;
using PostSpamer.library.Services.InMemory;
using PostSpamer.library.Services.Interfaces;

namespace PostSpamer.ViewModel
{
    public class ViewModelLocator
    {
        public ViewModelLocator()
        {
            var services = SimpleIoc.Default;
            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);

            services
                .TryRegister<IRecipientsDataProvider, InMemoryRecipientsDataProvider>()
                .TryRegister<ISendersDataProvider, InMemorySendersDataProvider>()
                .TryRegister<ISpamDataProvider, InMemorySpamDataProvider>();
                
                /*
                Register<MainWindowViewModel>();
          //services.Register<IRecipientsDataProvider, InMemoryRecipientsDataProvider>(); //строка подключения провайдера для хранения списка реципиентов в памяти
            services.Register<IRecipientsDataProvider, Linq2SQLRecipientsDataProvider>();
            services.Register(() => new PostSpamerDBDataContext());*/
        }

        public MainWindowViewModel MainVindowModel => ServiceLocator.Current.GetInstance<MainWindowViewModel>();

        public static void Cleanup()
        {
            // TODO Clear the ViewModels
        }
    }
}