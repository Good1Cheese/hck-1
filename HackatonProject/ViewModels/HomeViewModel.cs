namespace HackatonProject.ViewModels
{
    public class HomeViewModel : ViewModelBase
    {
        public int[] Organizations { get; set; } = new int[] { 1, 2, 3, 4, 5 };

        public HomeViewModel(NavigationBarViewModel navigationBarViewModel)
            : base(navigationBarViewModel)
        {
        }
    }
}