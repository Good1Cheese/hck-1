namespace HackatonProject.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        public NavigationStore NavigationStore { get; set; }

        public MainViewModel(NavigationBarViewModel navigationBarViewModel, NavigationStore navigationStore)
            : base(navigationBarViewModel)
        {
            NavigationBarViewModel = navigationBarViewModel;
            NavigationStore = navigationStore;
        }
    }
}