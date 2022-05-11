using Android.App;
using Android.Content;
using Android.Content.Res;
using Android.Graphics.Drawables;
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
    internal class AdapterFacultad_ListaFacultades : BaseAdapter
    {
        Activity context;
        List<Facultad> vLista;

        public AdapterFacultad_ListaFacultades(Activity context, List<Facultad> vLista)
        {
            this.context = context;
            this.vLista = vLista;
        }

        public override int Count => vLista.Count;

        public override Java.Lang.Object GetItem(int position)
        {
            throw new NotImplementedException();
        }

        public override long GetItemId(int position)
        {
            return position;
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            var item = vLista[position];
            View view = convertView;
            if (view == null)
                view = context.LayoutInflater.Inflate(Resource.Layout.ListICon, null);
            //view = context.LayoutInflater.Inflate(Android.Resource.Layout.SimpleListItem1, null);

            view.FindViewById<ImageView>(Resource.Id.listIconImage).SetImageResource(Resource.Drawable.facultad);
            //usar setimageURL cuando se guarde en bd la imagen
//            view.FindViewById<ImageView>(Resource.Id.listIconImage).SetImageURI(Android.Net.Uri.Parse(System.Convert.ToString(Resource.Drawable.facultad)));
            view.FindViewById<TextView>(Resource.Id.listIconTxtTitle).Text = item.NombreFacultad;
            view.FindViewById<TextView>(Resource.Id.listIconTxtSub).Text = "Empleados: " + Global.Empleados.Where(e => e.FacultadId == vLista[position].Id).Count();
            return view;
        }
    }
}