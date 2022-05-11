using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Widget;
using AndroidX.AppCompat.App;

namespace AppSalario
{
    [Activity(Label = "@string/app_name", Theme = "@style/mee", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        ImageButton btn1;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);
            btn1 = FindViewById<ImageButton>(Resource.Id.mainBtn1);
            btn1.Click += Btn1_Click;

        }

        private void Btn1_Click(object sender, System.EventArgs e)
        {
            Intent i = new Intent(this, typeof(ListaAplicacionesActivity));
            StartActivity(i);
        }

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}