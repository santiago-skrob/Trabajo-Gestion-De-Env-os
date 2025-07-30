using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.ComponentModel;

namespace WindowsFormsApp
{
    public class Paquete : IcalculoIds<Paquete>
    {
        public Paquete(int id, string descripcion, Cliente cliente, Repartidor repartidor, Proveedor proveedor, DateTime fechaEnvio, Movil movil,
            double costo,string lugarSalida,string lugarDestino,string entregado)
        {
            _id = id;
            _descripcion = descripcion;
            _id = id;
            Cliente = cliente;
            Repartidor = repartidor;
            Proveedor = proveedor;
            _fecha_salida = fechaEnvio;
            Movil = movil;
            Costo = costo;
            Salida = lugarSalida;
            Destino = lugarDestino;
            Entregado = entregado;
        }
        public Paquete() { }

        private List<Producto> _listaProductos = new List<Producto>();
		public List<Producto> ListaProductos
		{
			get { return _listaProductos; }
			set { _listaProductos = value; }
		}

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

        private Cliente _cliente;
        public Cliente Cliente
        {
            get { return _cliente; }
            set { _cliente = value; }
        }

        private Proveedor _proveedor;
        public Proveedor Proveedor
        {
            get { return _proveedor; }
            set { _proveedor = value; }
        }

        private Movil _movil;
        public Movil Movil
        {
            get { return _movil; }
            set { _movil = value; }
        }

        private Repartidor _repartidor;
        public Repartidor Repartidor
        {
            get { return _repartidor; }
            set { _repartidor = value; }
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
        public  double Costo
        {
            get { return _costo; }
            set { _costo = value; }
        }

        private string _entregado;

        public string Entregado
        {
            get { return _entregado; }
            set { _entregado = value; }
        }


        public int calcularID(string ruta)
        {
            int id = -1;
            FileStream fs = new FileStream(ruta, FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            string linea = "";
            string[] vector = new string[0];
            linea = sr.ReadLine();
            linea = sr.ReadLine();
            while (linea != null)
            {
                vector = linea.Split(';');
                linea = sr.ReadLine();
            }
            if (vector.Length > 0 && int.TryParse(vector[0], out int ultimoID))
            {
                id = ultimoID + 1;
            }
            else
            {
                id = 1; // si no hay datos validos, arranca en 1
            }
            sr.Close();
            fs.Close();
            return id;
        }

        public static Paquete EncontrarPaqueteEnLista (BindingList<Paquete> lista, int idPaquete)
        {
            foreach (Paquete p in lista)
            {
                if (p.ID == idPaquete)
                {
                    return p;
                }
            }
            return null;
        }

        public static void  agregarPaquetesALista(BindingList<Paquete> listaPaquetes)
        {
            Archivos archivos = new Archivos();
            int cantPaquetes = archivos.Contar_archivo("paquetes.csv");
            for (int i = 1; i <= cantPaquetes; i++)
            {
                string descripcion = archivos.Buscar_archivo("paquetes.csv", 0, 1, i.ToString());
                int idCliente = Convert.ToInt32(archivos.Buscar_archivo("paquetes.csv", 0, 2, i.ToString()));
                int idRepartidor = Convert.ToInt32(archivos.Buscar_archivo("paquetes.csv", 0, 3, i.ToString()));
                int idProveedor = Convert.ToInt32(archivos.Buscar_archivo("paquetes.csv", 0, 4, i.ToString()));
                DateTime fechaEnvio = Convert.ToDateTime(archivos.Buscar_archivo("paquetes.csv", 0, 5, i.ToString()));
                string patenteMovil = archivos.Buscar_archivo("paquetes.csv", 0, 7, i.ToString());
                double costo = Convert.ToDouble(archivos.Buscar_archivo("paquetes.csv", 0, 8, i.ToString()));
                string lugarSalida = archivos.Buscar_archivo("paquetes.csv", 0, 10, i.ToString());
                string lugarDestino = archivos.Buscar_archivo("paquetes.csv", 0, 11, i.ToString());
                string entregado = archivos.Buscar_archivo("paquetes.csv", 0, 12, i.ToString());
                Cliente cliente = new Cliente(idCliente);
                Repartidor repartidor = new Repartidor(idRepartidor);
                Proveedor proveedor = new Proveedor(idProveedor);
                Movil movil = new Movil(patenteMovil);
                Paquete paquete = new Paquete(i, descripcion, cliente, repartidor, proveedor, fechaEnvio, movil, costo, lugarSalida, lugarDestino, entregado);
                listaPaquetes.Add(paquete);
            }
        }
    }

}