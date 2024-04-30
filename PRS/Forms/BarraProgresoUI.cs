using CircularProgressBar;
using System;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;



namespace PRS.Forms
{
    public partial class BarraProgresoUI : Form
    {
        private static BarraProgresoUI instance; // Instancia única de la ventana de carga
        private Action onClose;

        public static BarraProgresoUI Instance
        {
            get
            {
                if (instance == null || instance.IsDisposed)
                {
                    instance = new BarraProgresoUI();
                }
                return instance;
            }
        }

        public BarraProgresoUI()
        {
            InitializeComponent();
        }

        public void MostrarBarraProgreso(Action onCloseAction)
        {
            onClose = onCloseAction;
            Show();
        }

        public void OcultarBarraProgreso()
        {
            Hide();
            onClose?.Invoke();
        }

        private void BarraProgresoUI_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true; // Cancelar el cierre para ocultar en lugar de cerrar
            OcultarBarraProgreso();
        }

        private void BarraProgresoUI_Load(object sender, EventArgs e)
        {
            // Iniciar la barra de progreso
        }
    }
}


