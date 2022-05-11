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
    [Activity(Label = "DetalleFacultadEmpleadoActivity")]
    public class DetalleFacultad_EmpleadoActivity : Activity
    {
        private int id;
        Facultad facultad;
        TextView txt1, cambioTxt1;
        ListView vListaEmpleados;
        LinearLayout btn1;
        ImageButton btn2, cambioTxt2;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_detalleFacultadEmpleado);
            // Create your application here

            //Recuperar el Id de la facultad selecionada en el FacultadActiviy
            id = Intent.GetIntExtra("Id", 0);
            facultad = Global.Facultades.Where(x => x.Id == id).FirstOrDefault();

            txt1 = FindViewById<TextView>(Resource.Id.facultad_detalleEmpleado_TxtTitle);
            txt1.Text = facultad.NombreFacultad;

            //Vincular la variable con el control de la vista
            vListaEmpleados = FindViewById<ListView>(Resource.Id.facultad_detalleEmpleado_ListView1);

            //Vincular los datos con el control haciendo uso del adaptador
            vListaEmpleados.Adapter = new AdapterFacultad_ListaEmpleados(this, Global.Empleados.Where(x => x.FacultadId == facultad.Id).ToList());
            vListaEmpleados.ItemClick += VLista_ItemClick;

            //Btn Estadistica

            //Btn Cambio a Vista_Estadistica
            btn1 = FindViewById<LinearLayout>(Resource.Id.facultad_detalleEmpleado_linearLayout2);
            btn1.Click += Btn1_Click;

            cambioTxt1 = FindViewById<TextView>(Resource.Id.facultad_detalleEmpleado_textView2);
            cambioTxt1.Click += Btn1_Click;

            cambioTxt2 = FindViewById<ImageButton>(Resource.Id.facultad_detalleEmpleado_imageButton2);
            cambioTxt2.Click += Btn1_Click;


            //Btn Regresar
            btn2 = FindViewById<ImageButton>(Resource.Id.facultad_detalleEmpleado_BtnRegresar);
            btn2.Click += Btn2_Click;
        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            Finish();
        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            Intent i = new Intent(this, typeof(DetalleFacultad_EstadisticaActivity));
            i.PutExtra("Id", id);
            StartActivity(i);
        }

        private void VLista_ItemClick(object sender, AdapterView.ItemClickEventArgs e)
        {
            Intent i = new Intent(this, typeof(DetalleFacultad_EmpleadoDetalleActivity));
            Empleado empleado = Global.Empleados[e.Position];
            i.PutExtra("Id", empleado.Id);
            StartActivity(i);
        }
    }
}