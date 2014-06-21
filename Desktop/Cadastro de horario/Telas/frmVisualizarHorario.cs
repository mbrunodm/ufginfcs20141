using System;
using System.Windows.Forms;

namespace Cadastro_de_horario___Modulo_Desktop.Telas
{
    public partial class frmVisualizarHorario : Form
    {
        public frmVisualizarHorario()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            MessageBox.Show(@"É preciso selecionar um horário, antes de continuar.", @"Atenção", MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
        }

        private void frmVisualizarHorario_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Banco_De_Dados.obtemTodos();
        }
    }
}
