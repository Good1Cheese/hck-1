
namespace HackatonProject.ViewModels
{
    public class NavigationBarViewModel
    {
        public NavigationCommand HomeViewCommand { get; set; }
        public NavigationCommand OrganizationViewCommand { get; set; }
        public NavigationCommand EventViewCommand { get; set; }
        public NavigationCommand SignAndLogViewCommand { get; set; }
        public NavigationCommand SignInViewCommand { get; set; }
        public NavigationCommand LogInViewCommand { get; set; }
        public NavigationCommand ProfileViewCommand { get; set; }

        public NavigationBarViewModel(NavigationStore navigationStore)
        {
            HomeViewModel homeViewModel = new(this);
            SignAndLogViewModel signAndLogViewModel = new(this);

            HomeViewCommand = new NavigationCommand(navigationStore, homeViewModel);
            SignInViewCommand = new NavigationCommand(navigationStore, new SignInViewModel(this));
            LogInViewCommand = new NavigationCommand(navigationStore, new LogInViewModel(this));
            EventViewCommand = new NavigationCommand(navigationStore, new EventViewModel(this));
            OrganizationViewCommand = new NavigationCommand(navigationStore, new OrganizationViewModel(this));
            SignAndLogViewCommand = new NavigationCommand(navigationStore, signAndLogViewModel);

            navigationStore.CurrentViewModel = homeViewModel;
        }
    }
}