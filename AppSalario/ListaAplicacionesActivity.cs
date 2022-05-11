using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AppSalario
{
    [Activity(Label = "ListaAplicacionesActivity")]
    public class ListaAplicacionesActivity : Activity
    {
        Button btn1;
        ImageButton btn2;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.activity_listaAplicaciones);
            //Vinculando botones
            btn1 = FindViewById<Button>(Resource.Id.btnFacultades);
            btn1.Click += Btn1_Click;

            //Btn Regresar
            btn2 = FindViewById<ImageButton>(Resource.Id.listaApp_BtnRegresar);
            btn2.Click += Btn2_Click;
        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            Finish();
        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            Intent i = new Intent(this, typeof(FacultadesActivity));
            StartActivity(i);
        }
    }
}