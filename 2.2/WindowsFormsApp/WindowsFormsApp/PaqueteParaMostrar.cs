using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp
{
    public class PaqueteParaMostrar
    {
        public PaqueteParaMostrar(int id, string descripcion, int idCliente, int idRepartidor, int idProveedor, DateTime fechaEnvio, string patenteMovil, double costo)
        {
            _id = id;
            _descripcion = descripcion;
            _id = id;
            IdCliente = idCliente;
            IdRepartidor = idRepartidor;
            IdProveedor = idProveedor;
            _fecha_salida = fechaEnvio;
            PatenteMovil = patenteMovil;
            Costo = costo;
        }
        public PaqueteParaMostrar() { }



        private int _id;
        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }

        private string _descripcion;

        public string Descripcion
        {
            get { return _descripcion; }
            set { _descripcion = value; }
        }


        private DateTime _fecha_salida;

        public DateTime FechaSalida
        {
            get { return _fecha_salida; }
            set { _fecha_salida = value; }
        }

        public DateTime FechaDestino
        {

            get { return _fecha_salida.AddDays(3); }
        }

        private int _idProveedor;

        public int IdProveedor
        {
            get { return _idProveedor; }
            set { _idProveedor = value; }
        }

        private int _idCliente;
        public int IdCliente
        {
            get { return _idCliente; }
            set { _idCliente = value; }
        }

        private int _idRepartidor;
        public int IdRepartidor
        {
            get { return _idRepartidor; }
            set { _idRepartidor = value; }
        }

        private string _patenteMovil;
        public string PatenteMovil
        {
            get { return _patenteMovil; }
            set { _patenteMovil = value; }
        }


        private string _destino;
        public string Destino
        {
            get { return _destino; }
            set { _destino = value; }
        }
        private string _salida;
        public string Salida
        {
            get { return _salida; }
            set { _salida = value; }
        }
        private double _costo;
        public double Costo
        {
            get { return _costo; }
            set { _costo = value; }
        }

        private string _idProductos;
        public string IdProductos
        {
            get { return _idProductos; }
            set { _idProductos = value; }
        }

        private string _entregado;
        public string Entregado
        {
            get { return _entregado; }
            set { _entregado = value; }
        }

        public static BindingList<PaqueteParaMostrar> ConvertirListaParaMostrar(BindingList<Paquete> listaPaquete)
        {
            Archivos archivos = new Archivos();
            BindingList<PaqueteParaMostrar> listaParaMostrar = new BindingList<PaqueteParaMostrar>();
            foreach (var paq in listaPaquete)
            {
                PaqueteParaMostrar paqAMostrar = new PaqueteParaMostrar();
                paqAMostrar.Costo = paq.Costo;
                paqAMostrar.Salida = paq.Salida;
                paqAMostrar.FechaSalida = paq.FechaSalida;
                paqAMostrar.Descripcion = paq.Descripcion;
                paqAMostrar.Destino = paq.Destino;
                paqAMostrar.ID = paq.ID;
                paqAMostrar.IdCliente = paq.Cliente.ID_Usuario;
                paqAMostrar.IdProveedor = paq.Proveedor.ID_Usuario;
                paqAMostrar.IdRepartidor = paq.Repartidor.ID_Usuario;
                paqAMostrar.PatenteMovil = paq.Movil.Patente;
                paqAMostrar.IdProductos = archivos.obtenerIDproductosPorPaquete("productos.csv", paqAMostrar.ID);
                paqAMostrar.Entregado = paq.Entregado;
                listaParaMostrar.Add(paqAMostrar);
            }
            return listaParaMostrar;
        }

    }
}

