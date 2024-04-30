using BussinesLogic;
using BussinessLogic;
using DataEntity;
using MaterialSkin.Controls;
using Microsoft.Identity.Client;
using Microsoft.SqlServer.Management.Smo;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRS.Forms
{
    public partial class BD_RespaldoUI : Form
    {
        public BD_RespaldoUI()
        {
            InitializeComponent();
            MainUI.Instancia.ResetSessionTimer();
            btnRecuperar.Enabled = false;
        }

        string NODO_SELECCIONADO = Properties.Settings.Default.Nodo_seleccionado;

        /// <summary>
        /// Declaración de variables 
        /// </summary>
        LogActivityE actL = new LogActivityE();
        public static Boolean status = false;

        #region Patron SingleTon
        private static BD_RespaldoUI form = null;

        public static BD_RespaldoUI AbrirForm()
        {
            if (form == null || form.IsDisposed)
            {
                form = new BD_RespaldoUI();
            }
            return form;
        }
        public static void ReiniciarInstancia()
        {
            form = null; // Asignar null a la instancia, permitiendo que se cree una nueva la próxima vez que se llame a AbrirForm()
        }
        #endregion

        private void ActivityLog()
        {
            string modulo = "Respaldo y restauración de BD";
            actL.Modulo = modulo;
            actL.Usuario = LoginUI.usuario_nombre;
            DateTime fecha = DateTime.Now;
            actL.Fecha = Convert.ToDateTime(fecha.ToString("yyyy-MM-dd"));
            actL.Hora = DateTime.Now.ToString("hh:mm:ss tt");
        }


        /// <summary>
        /// método para realizar el respaldo de la base de datos
        /// </summary>  = @"C:\";
        //private void RespaldoBD()
        //{
        //    try
        //    {
        //        SaveFileDialog guardar = new SaveFileDialog();
        //        guardar.InitialDirectory = @"C:\";
        //        guardar.FileName = System.DateTime.Today.Day.ToString() + "-" + System.DateTime.Today.Month.ToString() + "-" + System.DateTime.Today.Year.ToString() + "-" + System.DateTime.Now.Hour.ToString() + "-" + System.DateTime.Now.Minute.ToString() + "-" + System.DateTime.Now.Second.ToString() + NODO_SELECCIONADO;

        //        if (guardar.ShowDialog() == DialogResult.OK)
        //        {
        //            RespaldoBL.RespaldoBD(Convert.ToString(guardar.FileName));
        //            MessageBox.Show("Respaldo exitoso!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //            string action = "Realizó respaldo de BD";
        //            actL.FuncionRealizada = action;
        //            ActivityLog();
        //            status = LogActivityBL.AgregarLogActivity(actL, NODO_SELECCIONADO);

        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        string Mensaje = ex.ToString();
        //        string tipo = "Error";
        //        MessageBox.Show("Ocurrio un problema: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        string action = "Error al Respaldar BD";
        //        actL.FuncionRealizada = action;
        //        ActivityLog();
        //        status = LogActivityBL.AgregarLogActivityEX(actL, NODO_SELECCIONADO, ex);
        //    }
        //}


    private async Task RespaldoBD()
        {
            try
            {
                BarraProgresoUI.Instance.MostrarBarraProgreso(() =>
                {


                });

                await BackUp();

                BarraProgresoUI.Instance.OcultarBarraProgreso();
            }
            catch (Exception ex)
            {
                string Mensaje = ex.ToString();
                MessageBox.Show("Ocurrió un problema: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                string action = "Error al Respaldar BD";
                actL.FuncionRealizada = action;
                ActivityLog();
                status = LogActivityBL.AgregarLogActivityEX(actL, NODO_SELECCIONADO, ex);
            }
        }


        private async Task RecuperacionBD()
        {
            try
            {
                BarraProgresoUI.Instance.MostrarBarraProgreso(() =>
                { 


                });
                // Llamada al método RecuperacionBD

                await Recovery();

                BarraProgresoUI.Instance.OcultarBarraProgreso();
            }
            catch (Exception ex)
            {
                string Mensaje = ex.ToString();
                string tipo = "Error";
                MessageBox.Show("Ocurrió un problema: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                string action = "Error en la recuperación de la base de datos";
                actL.FuncionRealizada = action;
                ActivityLog();
                status = LogActivityBL.AgregarLogActivityEX(actL, NODO_SELECCIONADO, ex);
            }
        }

        private async Task BackUp()
        {
            SaveFileDialog guardar = new SaveFileDialog();
            guardar.InitialDirectory = @"C:\";
            guardar.FileName = $"{DateTime.Today.Day}-{DateTime.Today.Month}-{DateTime.Today.Year}-{DateTime.Now.Hour}-{DateTime.Now.Minute}-{DateTime.Now.Second}-{NODO_SELECCIONADO}";

            if (guardar.ShowDialog() == DialogResult.OK)
            {
                await Task.Run(() => RespaldoBL.RespaldoBD(guardar.FileName));
                MessageBox.Show("Respaldo exitoso!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                string action = "Realizó respaldo de BD";
                actL.FuncionRealizada = action;
                ActivityLog();
                status = LogActivityBL.AgregarLogActivity(actL, NODO_SELECCIONADO);
            }
        }

        private async Task Recovery()
        {
            string Ruta = await ObtenerRuta(txtRuta);

            await Task.Run(() => RespaldoBL.RecuperacionBD(Ruta));
            MessageBox.Show("Recuperación exitosa!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            string action = "Recuperó la base de datos";
            actL.FuncionRealizada = action;
            ActivityLog();
            status = LogActivityBL.AgregarLogActivity(actL, NODO_SELECCIONADO);
        }

        private void BD_RespaldoUI_Load(object sender, EventArgs e)
        {
            //permisos
            materialCard1.Visible = true && LoginUI.TienePermiso("9");

            txtUser.Text = actL.Usuario = LoginUI.usuario_nombre;
        }

        private async void btnRespaldo_Click(object sender, EventArgs e)
        {
            try
            {
                await RespaldoBD();
            }
            catch (Exception ex)

            {
                string Mensaje = ex.ToString();
                string tipo = "Error";
                MessageBox.Show("Ocurrio un problema: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                string action = "Realizo respaldo de la Base de datos";
                actL.FuncionRealizada = action;
                ActivityLog();
                status = LogActivityBL.AgregarLogActivity(actL, NODO_SELECCIONADO);
            }
        }

        private async void btnRecuperar_Click(object sender, EventArgs e)
        {
            try
            {
                await RecuperacionBD();
                btnRecuperar.Enabled = false;
                txtRuta.Clear();

                string action = "Recupero la base de datos";
                actL.FuncionRealizada = action;
                ActivityLog();
                status = LogActivityBL.AgregarLogActivity(actL, NODO_SELECCIONADO);
            }
            catch (Exception ex)
            {
                string Mensaje = ex.ToString();
                string tipo = "Error";
                MessageBox.Show("Ocurrio un problema: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExaminar_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dlg = new OpenFileDialog();
                dlg.InitialDirectory = @"C:\";
                //filtrar archivos .bak
                dlg.Filter = "Backup File(*.bak)|*.bak";
                dlg.Title = "Selecciona archivo para recuperación";
                //Iniciar el directorio en la siguiente dirección
                dlg.RestoreDirectory = true;

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    txtRuta.Text = dlg.FileName;
                    btnRecuperar.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                string Mensaje = ex.ToString();
                string tipo = "Error";
                MessageBox.Show("Ocurrio un problema: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
        }

        private void materialCard1_Paint(object sender, PaintEventArgs e)
        {

        }

        private async Task<string> ObtenerRuta(MaterialTextBox textbox)
        {
            return await Task.FromResult(textbox.Text);
        }
     }
}
