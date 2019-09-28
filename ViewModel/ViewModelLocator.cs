using GalaSoft.MvvmLight.Ioc;
using CommonServiceLocator;
using PostSpamer.library.Linq2SQL;
using PostSpamer.library.Services;

namespace PostSpamer.ViewModel
{
    public class ViewModelLocator
    {
        public ViewModelLocator()
        {
            var services = SimpleIoc.Default;
            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);

            services.Register<MainWindowViewModel>();
            services.Register<RecipientsDataProvider>();
            services.Register(() => new PostSpamerDBDataContext());
        }

        public MainWindowViewModel MainVindowModel => ServiceLocator.Current.GetInstance<MainWindowViewModel>();

        public static void Cleanup()
        {
            // TODO Clear the ViewModels
        }
    }
}