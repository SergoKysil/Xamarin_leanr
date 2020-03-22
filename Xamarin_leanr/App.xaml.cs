
using Xamarin.Forms;
using Xamarin_leanr.Views;
using Xamarin_leanr.Views.AboutView;
using Xamarin_leanr.Views.ContactViews;



namespace Xamarin_leanr
{
    public partial class App : Application
    {
        public App()
        {

            InitializeComponent();
            MainPage = new MainPage();
           // ((MasterDetailPage)Application.Current.MainPage).Detail.Navigation.PushAsync(new AboutPage());
        }
       
        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
