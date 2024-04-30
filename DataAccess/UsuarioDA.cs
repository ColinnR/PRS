using DataAccess.DataHelper;
using DataEntity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace DataAccess
{
    public class UsuarioDA
    {
        /// <summary>
        /// Método para agregar Usuario
        /// </summary>
        /// <param name="obj_usuario">Recibe un objeto de tipo Usuario</param>
        /// <param name="nombre_nodo">Recibe el nodo de la conexion a conectar</param>
        /// <returns>True si este se guardo correctamente o un false si hubo un error</returns>
        public static bool Usuario_agregar(UsuarioE obj_usuario, string nombre_nodo)
        {
            try
            {
                Database db = DatabaseFactory.CreateDatabase(nombre_nodo);
                //llamado al procedimiento "Usuario_agregar"
                DbCommand cmd = db.GetStoredProcCommand("Usuario_agregar");
                db.AddInParameter(cmd, "Nombre", DbType.String, obj_usuario.Nombre);
                db.AddInParameter(cmd, "Apellido", DbType.String, obj_usuario.Apellido);
                db.AddInParameter(cmd, "Usuario", DbType.String, obj_usuario.Usuario);
                db.AddInParameter(cmd, "Correo", DbType.String, obj_usuario.Correo);
                db.AddInParameter(cmd, "Password", DbType.String, obj_usuario.Password);
                db.AddInParameter(cmd, "Estado", DbType.Boolean, obj_usuario.Estado);
                db.AddInParameter(cmd, "IDTipo", DbType.Int32, obj_usuario.IDTipo);
                return (db.ExecuteNonQuery(cmd) >= 1);
            }
            catch (SqlException ex)
            {
               
                throw ex;
            }
        }

        /// <summary>
        /// Método para Modificar Usuario
        /// </summary>
        /// <param name="obj_usuario">Recibe un objeto de tipo Usuario</param>
        /// <param name="nombre_nodo">Recibe el nodo de la conexion a conectar</param>
        /// <returns>True si este se guardo correctamente o un false si hubo un error</returns>
        public static bool Usuario_modificar(UsuarioE obj_usuario, string nombre_nodo)
        {
            try
            {
                Database db = DatabaseFactory.CreateDatabase(nombre_nodo);
                //llamado al procedimiento "Usuario_modificar"
                DbCommand cmd = db.GetStoredProcCommand("Usuario_modificar");
                db.AddInParameter(cmd, "UsuarioID", DbType.Int32, obj_usuario.UsuarioID);
                db.AddInParameter(cmd, "Nombre", DbType.String, obj_usuario.Nombre);
                db.AddInParameter(cmd, "Apellido", DbType.String, obj_usuario.Apellido);
                db.AddInParameter(cmd, "Usuario", DbType.String, obj_usuario.Usuario);
                db.AddInParameter(cmd, "Correo", DbType.String, obj_usuario.Correo);
                db.AddInParameter(cmd, "Password", DbType.String, obj_usuario.Password);
                db.AddInParameter(cmd, "Estado", DbType.Boolean, obj_usuario.Estado);
                db.AddInParameter(cmd, "IDTipo", DbType.Int32, obj_usuario.IDTipo);
                return (db.ExecuteNonQuery(cmd) >= 1);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Método para eliminar Usuario
        /// </summary>
        /// <param name="obj_usuarioid">Recibe un el identificador unico del usuario</param>
        /// <param name="nombre_nodo">Recibe el nodo de la conexion a conectar</param>
        /// <returns>True si este se guardo correctamente o un false si hubo un error</returns>
        public static bool Usuario_eliminar(int obj_usuarioid, string nombre_nodo)
        {
            try
            {
                Database db = DatabaseFactory.CreateDatabase(nombre_nodo);
                //llamado al procedimiento "Usuario_eliminar"
                DbCommand cmd = db.GetStoredProcCommand("Usuario_eliminar");
                db.AddInParameter(cmd, "UsuarioID", DbType.Int32, obj_usuarioid);
                return (db.ExecuteNonQuery(cmd) >= 1);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Método para obtener todos los usuario
        /// </summary>
        /// <param name="nombre_nodo">Recibe el nodo de la conexion a conectar</param>
        /// <returns>Retorna una lista de objetos de usuario</returns>
        public static List<UsuarioE> Usuario_obtener_todo(string nombre_nodo)
        {
            try
            {
                List<UsuarioE> lista_objeto = new List<UsuarioE>();//creación de lista de usuarios.
                Database db = DatabaseFactory.CreateDatabase(nombre_nodo);
                //llamado al procedimiento "Usuario_obtener_todo"
                DbCommand cmd = db.GetStoredProcCommand("Usuario_obtener_todo");
                using (IDataReader dataReader = db.ExecuteReader(cmd))
                {
                    //Sentencia while que recorre y recopila los datos almacenados.
                    while (dataReader.Read())
                    {
                        UsuarioE obj = new UsuarioE();
                        if (dataReader["UsuarioID"] != DBNull.Value) { obj.UsuarioID = int.Parse(dataReader["UsuarioID"].ToString()); }
                        if (dataReader["Nombre"] != DBNull.Value) { obj.Nombre = (string)dataReader["Nombre"]; }
                        if (dataReader["NombreTipo"] != DBNull.Value) { obj.NombreTipo = (string)dataReader["NombreTipo"]; }
                        if (dataReader["Apellido"] != DBNull.Value) { obj.Apellido = (string)dataReader["Apellido"]; }
                        if (dataReader["Usuario"] != DBNull.Value) { obj.Usuario = (string)dataReader["Usuario"]; }
                        if (dataReader["Correo"] != DBNull.Value) { obj.Correo = (string)dataReader["correo"]; }
                        if (dataReader["Password"] != DBNull.Value) { obj.Password = (string)dataReader["Password"]; }
                        if (dataReader["Estado"] != DBNull.Value) { obj.Estado = (bool)dataReader["Estado"]; }
                        if (dataReader["IDTipo"] != DBNull.Value) { obj.IDTipo = int.Parse(dataReader["IDTipo"].ToString()); }
                        lista_objeto.Add(obj);//Agregan los datos recopilados a la lista_objeto.
                    }
                }
                return lista_objeto;//retorna valores almacenados en lista_objeto.
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Método para loguear usuarios
        /// </summary>
        /// <param name="obj_usuario">Recibe un objeto de tipo Usuario</param>
        /// <param name="nombre_nodo">Recibe el nodo de la conexion a conectar</param>
        /// <returns>True si este se guardo correctamente o un false si hubo un error</returns>
        public DataTable Usuario_logueo(UsuarioE obj_usuario, string nombre_nodo)
        {
            try
            {
                Database db = DatabaseFactory.CreateDatabase(nombre_nodo);
                //llamado al procedimiento "Usuario_logueo"
                DbCommand cmd = db.GetStoredProcCommand("Usuario_logueo");
                cmd.CommandType = CommandType.StoredProcedure;
                db.AddInParameter(cmd, "Usuario", DbType.String, obj_usuario.Usuario);
                db.AddInParameter(cmd, "Password", DbType.String, obj_usuario.Password);
                SqlDataAdapter da = new SqlDataAdapter((SqlCommand)cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static bool Activar (int obj_usuario, string nombre_nodo)
        {
            Database db = DatabaseFactory.CreateDatabase(nombre_nodo);
            DbCommand cmd = db.GetStoredProcCommand("Usuario_activar");
            db.AddInParameter(cmd, "UsuarioID", DbType.Int32, obj_usuario);
            return (db.ExecuteNonQuery(cmd) >= 1);
        }

        public static bool Desactivar(int obj_usuario, string nombre_nodo)
        {
            Database db = DatabaseFactory.CreateDatabase(nombre_nodo);
            DbCommand cmd = db.GetStoredProcCommand("Usuario_desactivar");
            db.AddInParameter(cmd, "UsuarioID", DbType.Int32, obj_usuario);
            return (db.ExecuteNonQuery(cmd) >= 1);
        }
    }
}
