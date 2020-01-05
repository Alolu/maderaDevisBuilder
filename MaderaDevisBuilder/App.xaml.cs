using Xamarin.Forms;
using MaderaDevisBuilder.ViewModels;
using MaderaDevisBuilder.Navigation;

namespace MaderaDevisBuilder
{
    public partial class App : Application
    {
        public static NavigationPage NavigationPage { get; private set; }
        public static Masterpage Masterpage;
        public static bool MenuIsPresented
        {
            get
            {
                return Masterpage.IsPresented;
            }
            set
            {
                Masterpage.IsPresented = value;
            }
        }

        public App()
        {
            InitializeComponent();
            CallMain();
        }

        private void CallMain()
        {
            NavigationPage = new NavigationPage(new MenuPage());
            Masterpage = new Masterpage();
            Masterpage.MasterBehavior = MasterBehavior.Popover;
            Masterpage.Detail = NavigationPage;
            MainPage = Masterpage;
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
