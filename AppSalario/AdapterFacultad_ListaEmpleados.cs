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
    internal class AdapterFacultad_ListaEmpleados : BaseAdapter
    {
        Activity context;
        List<Empleado> vLista;

        public AdapterFacultad_ListaEmpleados(Activity context, List<Empleado> vLista)
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
                view = context.LayoutInflater.Inflate(Android.Resource.Layout.SimpleListItem1, null);
            view.FindViewById<TextView>(Android.Resource.Id.Text1).Text = item.Nombre + " " + item.Apellido;
            return view;
        }
    }
}