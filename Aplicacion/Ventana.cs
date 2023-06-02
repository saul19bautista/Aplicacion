using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocios;


namespace Aplicacion
{
    public partial class Ventana : Form
    {
        ConexionSQLN cn = new ConexionSQLN();

        public Ventana()
        {
            InitializeComponent();
            dataGridView1.DataSource = cn.ConsultaDTV();
        }

        private void Ventana_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            cn.InsertarVenta(txt_producto.Text, txt_cantidad.Text, txt_precio.Text, txt_codigo.Text);
            dataGridView1.DataSource = cn.ConsultaDTV();
        }

        private void inventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Inventario v2 = new Inventario();
            this.Hide();
            v2.ShowDialog();
            this.Show();
        }
    }
}
