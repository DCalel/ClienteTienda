using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClienteTienda
{
    public partial class FormGameStore : Form
    {
        public FormGameStore()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private int id = 0;
        private void Button1_Click(object sender, EventArgs e)
        {
            tbcPrincipal.SelectedTab = tbGameStore;
            var cliente = new ServiceGameStore.WebService1SoapClient();
            var resultado = cliente.GameStore();
            lbProducto.Text = resultado[id];
            lbPrecio.Text = resultado[id + 1];
            id += 2;
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            lbCompra.Text = "No Comprado";
            id -= 2;
            var cliente = new ServiceGameStore.WebService1SoapClient();
            var resultado = cliente.GameStore();
            if (id <= 0)
            {
                id = resultado.Count - 2;
            }
            lbProducto.Text = resultado[id];
            lbPrecio.Text = resultado[id + 1];
        }

        private void BtnAvanzar_Click(object sender, EventArgs e)
        {
            lbCompra.Text = "No Comprado";
            id += 2;
            var cliente = new ServiceGameStore.WebService1SoapClient();
            var resultado = cliente.GameStore();
            if (id == resultado.Count)
            {
                id = 0;
            }
            lbProducto.Text = resultado[id];
            lbPrecio.Text = resultado[id + 1];
        }

        private void BtnComprar_Click(object sender, EventArgs e)
        {
            lbCompra.Text = "Comprado";
        }
    }
}
