using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Cadastro_de_horario___Modulo_Desktop.Controlador_de_Tela;

namespace Cadastro_de_horario___Modulo_Desktop.Telas
{
    public partial class Form1 : Form,ITelaCadastroHorario
    {
        ControladorDeTela ctrl;
        public Form1()
        {
            InitializeComponent();
            ctrl = new ControladorDeTela(this);
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (cboDiaSemana.SelectedIndex > 0)
            {
                if (!ltbHorario.Items.Contains(cboDiaSemana.Text))
                {
                    ltbHorario.Items.Add(cboDiaSemana.Text);
                }
                else
                {
                    MessageBox.Show(@"Este dia da semana já foi adicionado.", @"Atenção", MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                }
                
            }
            else
            {
                MessageBox.Show(@"É preciso selecionar um dia da semana.", @"Atenção", MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
            }
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (ltbHorario.SelectedItems.Count > 0)
            {
                ltbHorario.Items.Remove(ltbHorario.SelectedItem);
            }
        }

        public System.Collections.Generic.List<string> diasDaSemana
        {
            get { return ltbHorario.Items.Cast<string>().ToList(); }
            set { ltbHorario.Items.Add(value); }
        }

        public string horaInicio
        {
            get { return cboHInicio.Text; }
            set { cboHInicio.Text = value; }
        }

        public string horaFim
        {
            get { return cboHFim.Text; }
            set { cboHFim.Text = value; }
        }

        public string minutoInicio
        {
            get { return cboMInicio.Text; }
            set { cboMFim.Text = value; }
        }

        public string minutoFim
        {
            get { return cboMFim.Text; }
            set { cboMFim.Text = value; }
        }

        public string observacao
        {
            get { return rtbObservacoes.Text; }
            set { rtbObservacoes.Text = value; }
        }

        public bool horarioOcupado
        {
            get { return chbStatus.Checked; }
            set { chbStatus.Checked = value; }
        }
        /// <summary>
        /// Exibe uma caixa de diálogo.
        /// </summary>
        /// <param name="mensagem">Mensagem a ser exibida.</param>
        public void exibaMensagem(string mensagem)
        {
            MessageBox.Show(mensagem, @"Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            ctrl.gravarHorario();
            ctrl.limpaTela();

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            ctrl.limpaTela();
        }

        private void visualizarDadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new frmVisualizarHorario();
            frm.ShowDialog();
        }
    }
}
