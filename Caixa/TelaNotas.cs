using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dados;


namespace Caixa
{
    public partial class TelaNotas : Form
    {
        Caixa_EletronicoEntities data = new Caixa_EletronicoEntities();

        public TelaNotas()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void TelaNotas_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = data.Cedulas.ToList();
        }
    }
    }
