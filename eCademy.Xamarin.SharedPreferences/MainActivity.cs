using Android.App;
using Android.Widget;
using Android.OS;

namespace eCademy.Xamarin.SharedPreferences
{
    [Activity(Label = "eCademy.Xamarin.SharedPreferences", MainLauncher = true)]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
        }
    }
}

