using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.OleDb;
using System.Threading;

namespace pryTorresIEFIPL2_LAB2
{
    internal class clsCliente
    {
        //Creacion de objetos
        //Nos permite conectar a la base de datos
        private OleDbConnection conexionBd = new OleDbConnection();
        //Con este objeto enviamos una orden a la BD
        private OleDbCommand comandoBd = new OleDbCommand();
        //Nos sirve para adaptar los datos de la BD a datos reconocidos por .NET
        private OleDbDataAdapter AdaptadorDeDatosBd = new OleDbDataAdapter();
        //Ruta de la base de datos
        string varRutaAccesoBD = "Provider = Microsoft.ACE.OLEDB.12.0;Data Source=" + "BD_Clientes.accdb";
        private string varTabla = "Clientes";
        //Declaracion de campos
        private Int32 varCantidadClientes;
        private Decimal varPromedioSaldos;
        private Decimal varTotalSaldos;
        private string varNombreCliente;
        private string varApellidoCliente;
        private Int32 varDniCliente;
        private Int32 varBarrioCliente;
        private string varDireccionCliente;
        private Int32 varActividadCliente;
        private Decimal varSaldoCliente;



        //Declaracion de propiedades
        //Get retorna el valor
        //Set setea el valor

        public string varNombreDelCliente
        {
            get { return varNombreCliente; }
            set { varNombreCliente= value; }
        }
        public string varApellidoDelCliente
        {
            get { return varApellidoCliente; }
            set { varApellidoCliente = value; }
        }
        public Int32 varDniDelCliente
        {
            get { return varDniCliente; }
            set { varDniCliente = value; }
        }
        public Int32 varBarrioDelCliente
        {
            get { return varBarrioCliente; }
            set { varBarrioCliente = value; }
        }
        public string varDireccionDelCliente
        {
            get { return varDireccionCliente; }
            set { varDireccionCliente = value;}

        }
        public Int32 varActividadDelCliente
        {
            get { return varActividadCliente; }
            set { varActividadCliente = value; }
        }

        public Decimal varSaldoDelCliente
        {
            get { return varSaldoCliente; }
            set { varSaldoCliente = value; }
        }

        public Int32 varCantidadDeClientes
        {
            get { return varCantidadClientes; }
        }
        public Decimal varPromedioSaldosDeClientes
        {
            get { return varPromedioSaldos; }
        }
        public Decimal varTotalSaldosDeClientes
        {
            get { return varTotalSaldos; }
        }



        public void ListarClientes(DataGridView dgvClientes)
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
                AdaptadorDeDatosBd.Fill(LectorDataSet);
                //DataSource sirve para tomar el contenido de un DataSet
                dgvClientes.DataSource = LectorDataSet.Tables[0];
                conexionBd.Close();
            }
            catch (Exception mensaje)
            {

                MessageBox.Show(mensaje.Message);
            }
          
        }


        public void Agregar()
        {
            try
            {
                string sql = "INSERT INTO" + " CLIENTES ([NOMBRE], [APELLIDO], [DNI], [BARRIO],[DIRECCION], [ACTIVIDAD], [SALDO])" + " VALUES ('" + varNombreCliente + "','" + varApellidoCliente + "','" + varDniCliente.ToString() + "','"
                    + varBarrioCliente.ToString() + "','" + varDireccionCliente + "','" + varActividadCliente.ToString() + "','" + varSaldoCliente.ToString() + "')";
                conexionBd = new OleDbConnection(varRutaAccesoBD);
                conexionBd.Open();

                comandoBd.Connection = conexionBd;
                comandoBd.CommandType = CommandType.Text;
                comandoBd.CommandText = sql;
                //ejecuta el comando
                comandoBd.ExecuteNonQuery();
                MessageBox.Show("Cliente Cargado");
            }
            catch (Exception mensaje)
            {

                MessageBox.Show(mensaje.Message);
            }
            conexionBd.Close();



        }


        public void Listar(DataGridView dgvGrilla)
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
                //Creacion del objeto datareader que toma lo del comando una vez ejecutado el comando
                //Es una tabla virtual que esta en la ram
                OleDbDataReader DR = comandoBd.ExecuteReader();
                dgvGrilla.Rows.Clear();
                varCantidadClientes = 0;
                varTotalSaldos = 0;
                varPromedioSaldos = 0;
                //Si hay filas en el DataReader entra el if
                if (DR.HasRows)
                {
                    //Mientras hayan datos para leer en el Datareader
                    while (DR.Read())
                    {
                        //Añade filas a la grilla tomando las posiciones de los campos de la tabla clientes
                        dgvGrilla.Rows.Add(DR.GetInt32(2), DR.GetString(0), DR.GetString(1), DR.GetDecimal(6));
                        varCantidadClientes++;
                        varTotalSaldos = varTotalSaldos + DR.GetDecimal(6);
                    }
                    varPromedioSaldos = varTotalSaldos / varCantidadClientes;
                }
                conexionBd.Close();
               

            }
            catch (Exception mensaje)
            {
                MessageBox.Show(mensaje.Message);
                
            }
          

        }


        public void BusquedaCliente(Int32 variableCliente)
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
                //Creacion del objeto datareader que toma lo del comando una vez ejecutado el comando
                //Es una tabla virtual que esta en la ram
                OleDbDataReader DR = comandoBd.ExecuteReader();
                //Si hay filas en el DataReader entra el if
                if (DR.HasRows)
                {
                    //Mientras hayan datos para leer en el Datareader
                    while (DR.Read())
                    {
                        if (DR.GetInt32(2) == variableCliente)
                        {
                            varNombreCliente = DR.GetString(0);
                            varApellidoCliente = DR.GetString(1);
                            varDniCliente = DR.GetInt32(2);                            
                            varBarrioCliente = DR.GetInt32(3);
                            varDireccionCliente = DR.GetString(4);
                            varActividadCliente = DR.GetInt32(5);
                            varSaldoCliente = DR.GetDecimal(6);                                                                                   
                        }
                    }
                }
                conexionBd.Close();
            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message);
            }

        }

        public void Modificar(Int32 Dni)
        {
            //Instruccion sql
            string Sql = "UPDATE CLIENTES SET [BARRIO] = " + varBarrioCliente + ", [DIRECCION] = '" + varDireccionCliente + "', [ACTIVIDAD] = " + varActividadCliente + ", [SALDO] = " + varSaldoCliente + "  WHERE [DNI] = " + Dni + "";
            //Recibe la ruta de la BD para conectarse
            conexionBd.ConnectionString = varRutaAccesoBD;
            //Se conecta a la BD
            conexionBd.Open();

            //El comando toma la conexion
            comandoBd.Connection = conexionBd;
            //Se indica el tipo de comando el text es para instrucciones sql
            comandoBd.CommandType = CommandType.Text;
            //Se pasa la instruccion sql al comando
            comandoBd.CommandText = Sql;
            //ejecuta el comando
            comandoBd.ExecuteNonQuery();
            conexionBd.Close();
            MessageBox.Show("Cambios Guardados");
        }


    }
}
