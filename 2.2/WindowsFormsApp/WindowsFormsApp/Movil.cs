using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace WindowsFormsApp
{
    public class Movil : IcalculoIds<Movil>
    {
		public Movil(string patente) {
		Patente = patente;
		}
		private string _patente;
		public  string Patente
		{
			get { return _patente; }
			set { _patente = value; }
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
    }
}