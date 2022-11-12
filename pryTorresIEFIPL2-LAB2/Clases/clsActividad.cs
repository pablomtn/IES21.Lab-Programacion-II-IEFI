using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.OleDb;

namespace pryTorresIEFIPL2_LAB2
{
    internal class clsActividad
    {
        //Creacion de objetos
        //Nos permite conectar a la base de datos
        private OleDbConnection conexionBd = new OleDbConnection();
        //Con este objeto enviamos una orden a la BD
        private OleDbCommand comandoBd = new OleDbCommand();
        //Nos sirve para adaptar los datos de la BD a datos reconocidos por .NET
        private OleDbDataAdapter AdaptadorDeDatosBd = new OleDbDataAdapter();
        //variable para indicar la ruta de la BD
        private string varRutaAccesoBD = "Provider = Microsoft.ACE.OLEDB.12.0;Data Source=" + "BD_Clientes.accdb";
        //Variable que contiene el nombre de una tabla
        private string varTabla = "Cod_Actividad";

        public void LlenarListaDesplegable(ComboBox lstClientes)
        {
            try
            {
                //Recibe la ruta de la BD para conectarse
                conexionBd.ConnectionString = varRutaAccesoBD;
                //Abre la conexion de la BD, es un canal
                conexionBd.Open();
                //Necesitamos mndar una orden para que nos traiga datos de la BD 
                //usamos el objeto comando
                //Indicamos la conexion que tiene que utilizar
                comandoBd.Connection = conexionBd;
                //Indicamos el tipo de comando
                //Trae una tabla el comando
                comandoBd.CommandType = CommandType.TableDirect;
                comandoBd.CommandText = varTabla;
                //El adaptador recibe los datos de la BD(lectura)
                AdaptadorDeDatosBd = new OleDbDataAdapter(comandoBd);
                //objeto que contiene lo que tiene la tabla, es una tabla virtual
                DataSet LectorDataSet = new DataSet();
                //Adaptamos los datos al data set
                AdaptadorDeDatosBd.Fill(LectorDataSet, varTabla);
                //Enviamos los datos del DataSet a la grilla, es 0 porque es la unica tabla
                //que trajo el dataset
                //DataSource sirve para tomar el contenido de un DataSet
                lstClientes.DataSource = LectorDataSet.Tables[varTabla];
                lstClientes.DisplayMember = "Detalle";
                lstClientes.ValueMember = "Codigo_Actividad";

                conexionBd.Close();
            }
            catch (Exception mensaje)
            {

                MessageBox.Show(mensaje.Message);
            }

        }



        //Creacion de una funcion
        // una funcion retorna un valor
        public string Buscar(Int32 CodigoActividad)
        {
            try
            {
                conexionBd.ConnectionString = varRutaAccesoBD;
                conexionBd.Open();
                comandoBd.Connection = conexionBd;
                comandoBd.CommandType = CommandType.TableDirect;
                comandoBd.CommandText = varTabla;
                OleDbDataReader Lector = comandoBd.ExecuteReader();
                string varDetalleActividiad = "";
                if (Lector.HasRows)
                {
                    while (Lector.Read())
                    {
                        if (Lector.GetInt32(0) == CodigoActividad)
                        {
                            varDetalleActividiad = Lector.GetString(1);
                        }
                    }
                }
                conexionBd.Close();
                return varDetalleActividiad;
            }
            catch (Exception e)
            {
                return e.ToString();
            }
        }






    }













}
