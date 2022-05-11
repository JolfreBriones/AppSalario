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
    [Activity(Label = "DetalleFacultad_EmpleadoDetalleActivity")]
    public class DetalleFacultad_EmpleadoDetalleActivity : Activity
    {
        TextView txt1, txt2, txt3, txtTitle;
        int id;
        Empleado empleado;
        ImageButton btn1;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_detalleFacultadDetalleEmpl);
            // Create your application here

            //Recuperar Id
            id = Intent.GetIntExtra("Id", 0);
            empleado = Global.Empleados.Where(x => x.Id == id).FirstOrDefault();


            txtTitle = FindViewById<TextView>(Resource.Id.facultad_detalleEmpleadoDetalle_TxtTitle);
            txtTitle.Text = empleado.Nombre + " " + empleado.Apellido;

            //Textos Detalle Empleado
            txt1 = FindViewById<TextView>(Resource.Id.facultad_detalleEmpleadoDetalle_TxtTitleEstadis1);
            txt1.Text = Convert.ToString(empleado.Salario);

            txt2 = FindViewById<TextView>(Resource.Id.facultad_detalleEmpleadoDetalle_TxtTitleEstadis2);
            txt2.Text = empleado.FechaNacimiento.ToString("yyyy/MM/dd");

            txt3 = FindViewById<TextView>(Resource.Id.facultad_detalleEmpleadoDetalle_TxtTitleEstadis3);
            txt3.Text = empleado.FechaComienzo.ToString("yyyy/MM/dd");

            btn1 = FindViewById<ImageButton>(Resource.Id.facultad_detalleEmpleadoDetalle_BtnRegresar);
            btn1.Click += Btn1_Click;
        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            Finish();
        }
    }
}