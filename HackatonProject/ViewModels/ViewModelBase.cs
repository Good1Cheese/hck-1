namespace HackatonProject.ViewModels
{
    public class ViewModelBase
    {
        public NavigationBarViewModel NavigationBarViewModel { get; set; }

        public ViewModelBase(NavigationBarViewModel navigationBarViewModel)
        {
            NavigationBarViewModel = navigationBarViewModel;
        }
    }
}