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
    internal class AdapterFacultad_ListaEstadisticas : BaseAdapter
    {
        Activity context;
        List<Estadistica> vLista;

        public AdapterFacultad_ListaEstadisticas(Activity context, List<Estadistica> vLista)
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
                view = context.LayoutInflater.Inflate(Resource.Layout.ListEstadistica, null);
            view.FindViewById<TextView>(Resource.Id.facultad_detalleEstadistica_TxtTitleEstadis).Text = item.titulo;
            view.FindViewById<TextView>(Resource.Id.facultad_detalleEstadistica_TxtSubEstadis).Text = item.subtitulo;
            return view;
        }
    }
}