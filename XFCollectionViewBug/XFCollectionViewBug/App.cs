
namespace XFCollectionViewBug
{
    public class App : Xamarin.Forms.Application
    {
        public static double ScreenWidth;
        public static double ScreenHeight;

        public App()
        {
            MainPage = new MainPage();
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
