using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Security.Cryptography;

namespace WindowsFormsApp
{
    public class Archivos : IcalculoIds<Archivos>
    {
        public int Iniciar_sesion(string usuario, string contra)
        {
            //string usuario_cod = Convert.ToBase64String(Encoding.UTF8.GetBytes(usuario));
            //string contra_cod = Convert.ToBase64String(Encoding.UTF8.GetBytes(contra));

            FileStream cuentas = new FileStream("cuentas.csv", FileMode.OpenOrCreate, FileAccess.Read);
            StreamReader sr = new StreamReader(cuentas);

            bool inicio = false;
            int id_usuario = 0;

            string linea = "";
            string[] vector = new string[0];
            linea = sr.ReadLine();
            linea = sr.ReadLine();
            while (linea != null)
            {
                vector = linea.Split(';');
                if (usuario == vector[1])
                {
                    if (contra == vector[2])
                    {
                        inicio = true;
                        id_usuario = Convert.ToInt32(vector[0]);
                        //MessageBox.Show("Iniciado secion con exito" + "\n\r" + "Id de cuenta: " + vector[0]);
                    }
                }
                linea = sr.ReadLine();
            }

            if (inicio == false)
            {
                //Usuario o contraseña invalidos
            }
            sr.Close();
            cuentas.Close();
            return id_usuario;
        }

        public int Registarse(string usuario, string contra, string contra2)
        {
            FileStream cuentas = new FileStream("cuentas.csv", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            StreamReader sr = new StreamReader(cuentas);
            StreamWriter sw = new StreamWriter(cuentas);

            //string usuario_cod = Convert.ToBase64String(Encoding.UTF8.GetBytes(usuario));
            //string contra_cod = Convert.ToBase64String(Encoding.UTF8.GetBytes(contra));

            int inicio = 0;
            int contador = 0;

            string linea = "";
            string[] vector = new string[0];
            linea = sr.ReadLine();
            linea = sr.ReadLine();
            while (linea != null)
            {
                vector = linea.Split(';');
                contador = Convert.ToInt32(vector[0]);
                if (usuario == vector[1])
                {
                    inicio = 1;
                    //Usuario ya existente;
                }
                linea = sr.ReadLine();
            }

            if (inicio == 0)
            {
                if (contra == contra2)
                {
                    linea = sr.ReadLine();
                    sw.WriteLine((contador + 1).ToString() + ";" + usuario + ";" + contra + ";1;1");
                    //Usuario registado con exito
                    inicio = 3;
                }
                else
                {
                    inicio = 2;
                    //Las contraseñas no coinciden
                }
            }

            sw.Close();
            sr.Close();
            cuentas.Close();
            return inicio;
        }

        public string Buscar_archivo(string ruta, int vector_buscado, int vector_obtenido, string referencia)
        {
            FileStream archivo = new FileStream(ruta, FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(archivo);

            bool encontrado = false;
            string resultado = "";

            string linea = "";
            string[] vector = new string[0];
            linea = sr.ReadLine();
            linea = sr.ReadLine();
            while (linea != null && encontrado == false)
            {
                vector = linea.Split(';');
                if (referencia == vector[vector_buscado])
                {
                    resultado = vector[vector_obtenido];
                    encontrado = true;
                }
                linea = sr.ReadLine();
            }

            if (encontrado == false)
            {
                //usuario o contraseña invalidos
            }
            sr.Close();
            archivo.Close();
            return resultado;
        }

        public int Contar_archivo(string ruta)
        {
            FileStream archivo = new FileStream(ruta, FileMode.Open, FileAccess.ReadWrite);
            StreamReader sr = new StreamReader(archivo);

            int contador = 0;

            string linea = "";
            linea = sr.ReadLine();
            linea = sr.ReadLine();
            while (linea != null)
            {
                contador++;
                linea = sr.ReadLine();
            }

            sr.Close();
            archivo.Close();
            return contador;
        }


        public bool Agregar_archivo(string ruta, int vector_buscado, string referencia, string texto)
        {
            bool encontrado = false;

            // leer todo el archivo
            string[] lineas = File.ReadAllLines(ruta);

            foreach (string linea in lineas.Skip(1)) // saltar encabezado
            {
                string[] vector = linea.Split(';');
                if (vector_buscado < vector.Length && vector[vector_buscado] == referencia)
                {
                    encontrado = true;
                    break;
                }
            }

            // si no se encontro, agregar al final
            if (!encontrado)
            {
                using (StreamWriter sw = new StreamWriter(ruta, append: true))
                {
                    sw.WriteLine(texto);
                }
            }

            return encontrado;
        } //!


        public bool Editar_archivo(string ruta, int fila, int columna, string referencia)
        {
            int fila_actual = fila + 1; //saltar encabezado

            string[] lineas = File.ReadAllLines(ruta);
            if (fila_actual >= lineas.Length){ 
                return false;
            }
            string[] columnas = lineas[fila_actual].Split(';');
            if (columna >= columnas.Length){
                return false;
            }

            columnas[columna] = referencia;
            lineas[fila_actual] = string.Join(";", columnas);

            File.WriteAllLines(ruta, lineas); // sobreescribe el archivo completo
            return true;
        } //!

        public bool Editar_archivo(string ruta, int id, string referencia)
        {
            string[] lineas = File.ReadAllLines(ruta);
            int i = 1;
            int iMax = lineas.Length;
            int filaAModificar = -1;
            while(i != iMax)
            {
                string linea = lineas[i];
                string[] vl = linea.Split(';');
                if (Convert.ToInt32(vl[0]) == id)
                {
                    filaAModificar = i;
                }
                i++;
            }
            lineas[filaAModificar] = referencia; 
            File.WriteAllLines (ruta, lineas);
            if (filaAModificar != -1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Eliminar_linea(string ruta, int id)
        {
            string[] lineas = File.ReadAllLines(ruta);
            int i = 1;
            int iMax = lineas.Length;
            int filaAEliminar = -1;
            while (i != iMax)
            {
                string linea = lineas[i];
                string[] vl = linea.Split(';');
                if (Convert.ToInt32(vl[0]) == id)
                {
                    filaAEliminar = i;
                }
                i++;
            }
            if (filaAEliminar != -1)
            {
                List<string> lista = lineas.ToList();
                lista.RemoveAt(filaAEliminar);
                lineas = lista.ToArray();
                File.WriteAllLines(ruta, lineas);
                return true;
            }
            else
            {
                return false;
            }
        }


        public int calcularID(string ruta) {
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

        public string obtenerIDproductosPorPaquete(string ruta, int idPaqueteBuscado)
        {
            FileStream fs = new FileStream (ruta, FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            List<string> listaIds = new List<string>();
            string linea = sr.ReadLine();
            linea = sr.ReadLine();
            while (linea != null)
            {
                string[] vector = linea.Split(';');
                if (vector.Length > 4 && int.TryParse(vector[4], out int idPaqActual))
                {
                    if (idPaqActual == idPaqueteBuscado) {
                        listaIds.Add(vector[0]);
                    }

                }
                linea = sr.ReadLine();
            }
            sr.Close ();
            fs.Close();

            return string.Join(",", listaIds);
        }

        public void Mantener_sesion(int activado, int id, string cuenta, string contra, int tipo, int activo)
        {
            FileStream sesion = new FileStream("sesionactual.csv", FileMode.Open, FileAccess.Write);
            StreamWriter sw = new StreamWriter(sesion);

            string a = Convert.ToBase64String(Encoding.UTF8.GetBytes(activado.ToString()));
            string b = Convert.ToBase64String(Encoding.UTF8.GetBytes(id.ToString()));
            string c = Convert.ToBase64String(Encoding.UTF8.GetBytes(cuenta));
            string d = Convert.ToBase64String(Encoding.UTF8.GetBytes(contra));
            string e = Convert.ToBase64String(Encoding.UTF8.GetBytes(tipo.ToString()));
            string f = Convert.ToBase64String(Encoding.UTF8.GetBytes(activo.ToString()));

            sw.WriteLine(a + ";" + b + ";" + c + ";" + d + ";" + e + ";" + f);
            sw.Close();
            sesion.Close();
        }

        public string[] Reiniciar_sesion()
        {
            FileStream sesion = new FileStream("sesionactual.csv", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(sesion);

            string linea = sr.ReadLine();
            string[] vector = linea.Split(';');
            string a = Encoding.UTF8.GetString(Convert.FromBase64String(vector[0]));
            string b = Encoding.UTF8.GetString(Convert.FromBase64String(vector[1]));
            string c = Encoding.UTF8.GetString(Convert.FromBase64String(vector[2]));
            string d = Encoding.UTF8.GetString(Convert.FromBase64String(vector[3]));
            string e = Encoding.UTF8.GetString(Convert.FromBase64String(vector[4]));
            string f = Encoding.UTF8.GetString(Convert.FromBase64String(vector[5]));

            string[] nuevo_vector = { a, b, c, d, e, f };

            sr.Close();
            sesion.Close();
            return nuevo_vector;
        }
    }
}