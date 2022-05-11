using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AppSalario
{
    [Activity(Label = "FacultadesActivity")]
    public class FacultadesActivity : Activity
    {
        ListView vLista;
        ImageButton btn1;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_facultades);
            // Create your application here

            vLista = FindViewById<ListView>(Resource.Id.facultadListView1);

            //Vincular los datos con el control haciendo uso del adaptador
            vLista.Adapter = new AdapterFacultad_ListaFacultades(this, Global.Facultades);
            vLista.ItemClick += VLista_ItemClick;

            //Btn Cerrar
            btn1 = FindViewById<ImageButton>(Resource.Id.facultades_BtnRegresar);
            btn1.Click += Btn1_Click;
        }

        private void Btn1_Click(object sender, System.EventArgs e)
        {
            Finish();
        }

        private void VLista_ItemClick(object sender, AdapterView.ItemClickEventArgs e)
        {
            Intent i = new Intent(this, typeof(DetalleFacultad_EmpleadoActivity));
            Facultad facultad = Global.Facultades[e.Position];
            i.PutExtra("Id", facultad.Id);
            StartActivity(i);
        }
    }
}