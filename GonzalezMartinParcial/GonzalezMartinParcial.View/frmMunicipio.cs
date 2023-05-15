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
    public partial class frmMunicipio : Form
    {
        private List<Municipio> _listado;

        public frmMunicipio()
        {
            InitializeComponent();
        }

        private void frmMunicipio_Load(object sender, EventArgs e)
        {
            Updategrid();

        }

        private void Updategrid()
        {
            _listado = MunicipioBL.Instance.SellecALL();
            var query = from x in _listado
                        select new
                        {
                            Id = x.DepartamentoId,
                            Nombre = x.Nombre,
                            Departamento = x.Departamentos.Nombre

                        };
            dataGridView1.DataSource = query.ToList();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmaAgregarMunicipio frm = new frmaAgregarMunicipio();
            frm.ShowDialog();
            Updategrid();
        }

    
    }
}
