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
    [Activity(Label = "DetalleFacultadEstadisticaActivity")]
    public class DetalleFacultad_EstadisticaActivity : Activity
    {
        private int id;
        Facultad facultad;
        TextView txt1, cambioTxt1;
        ListView vLista;
        LinearLayout btn1;
        ImageButton btn2, cambioTxt2;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_detalleFacultadEstadistica);
            // Create your application here

            //Recuperar el Id de la facultad selecionada en el FacultadActiviy
            id = Intent.GetIntExtra("Id", 0);
            facultad = Global.Facultades.Where(x => x.Id == id).FirstOrDefault();

            txt1 = FindViewById<TextView>(Resource.Id.facultad_detalleEstadistica_TxtTitle);
            txt1.Text = facultad.NombreFacultad;

            List<Estadistica> estadisticas = new List<Estadistica>
            {
                new Estadistica(1, Convert.ToString(GetSalarioPromedio(id)), "Promedio de Salarios"),
                new Estadistica(2, Convert.ToString(GetCantidadEmpleado(id)), "Empleados"),
            };
           

            vLista = FindViewById<ListView>(Resource.Id.facultad_detalleEstadistica_listView1);
            vLista.Adapter = new AdapterFacultad_ListaEstadisticas(this, estadisticas);

            //Btn Cambio a Vista_Empleado
            btn1 = FindViewById<LinearLayout>(Resource.Id.facultad_detalleEstadistica_linearLayout1);
            btn1.Click += Btn1_Click;

            cambioTxt1 = FindViewById<TextView>(Resource.Id.facultad_detalleEstadistica_textView1);
            cambioTxt1.Click += Btn1_Click;

            cambioTxt2 = FindViewById<ImageButton>(Resource.Id.facultad_detalleEstadistica_imageButton1);
            cambioTxt2.Click += Btn1_Click;


            //Btn Regresar
            btn2 = FindViewById<ImageButton>(Resource.Id.facultad_detalleEstadistica_BtnRegresar);
            btn2.Click += Btn2_Click;

        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            Finish();
        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            Finish();
        }

        protected static double GetSalarioPromedio(int id)
        {
            List<double> salariosEmpleados = Global.Empleados.Where(x => x.FacultadId == id).Select(e => e.Salario).ToList();
            return salariosEmpleados.Sum()/salariosEmpleados.Count;
        }
        protected static int GetCantidadEmpleado(int id)
        {
            return Global.Empleados.Where(x => x.FacultadId == id).Count();
        }
    }
}