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
    public partial class Form1 : Form
    {
        private List<Departamento> _listado;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateGrid();
        }

        private void UpdateGrid()
        {
            _listado = DepartamentoBL.Instance.SellecALL();
            var query = from x in _listado
                        select new
                        {
                            Id = x.DepartamentoId,
                            Nombre = x.Nombre
            
                        };
            dataGridView1.DataSource = query.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmAgregarDepartamento frm = new frmAgregarDepartamento();
            frm.ShowDialog();
            UpdateGrid();
        }
    }
}
