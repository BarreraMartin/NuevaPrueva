using GonzalezMartinParcial.BussinnessLogic;
using GonzalezMartinParcial.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GonzalezMartinParcial.View
{
    public partial class frmaAgregarMunicipio : Form
    {
        public frmaAgregarMunicipio()
        {
            InitializeComponent();
        }

        private void frmaAgregarMunicipio_Load(object sender, EventArgs e)
        {
            UpdateCombo();
        }

        private void UpdateCombo()
        {
            comboBox1.DisplayMember = "Nombre";
            comboBox1.ValueMember = "DepartamentoId";
            comboBox1.DataSource = DepartamentoBL.Instance.SellecALL();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Municipio entity = new Municipio()
            {
                Nombre = textBox1.Text.Trim(),
                DepartamentoId = (int)comboBox1.SelectedValue

            };

            if (MunicipioBL.Instance.Insert(entity))
            {
                MessageBox.Show("Se Agrego Con Exito", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            this.Close();
        }
    }
}
