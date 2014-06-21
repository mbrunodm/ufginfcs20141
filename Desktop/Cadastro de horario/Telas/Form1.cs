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

        public List<string> diasDaSemana
        {
            get { return ltbHorario.Items.Cast<string>().ToList(); }
            set
            {
                if (value.Count == 0)
                {
                    ltbHorario.Items.Clear();
                }
                else
                {
                    foreach (var item in value.Where(item => !ltbHorario.Items.Contains(item)))
                    {
                        ltbHorario.Items.Add(item);
                    }
                }
                
            }
        }

        public string horaInicio
        {
            get
            {
                return cboHInicio.Text;
            }
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    cboHInicio.SelectedIndex = 0;
                }
                else
                {
                    cboHInicio.SelectedItem = value;
                }
            }
        }

        public string horaFim
        {
            get { return cboHFim.Text; }
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    cboHFim.SelectedIndex = 0;
                }
                else
                {
                    cboHFim.SelectedItem = value;
                }
            }
        }

        public string minutoInicio
        {
            get { return cboMInicio.Text; }
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    cboMInicio.SelectedIndex = 0;
                }
                else
                {
                    cboMInicio.SelectedItem = value;
                }
            }
        }

        public string minutoFim
        {
            get { return cboMFim.Text; }
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    cboMFim.SelectedIndex = 0;
                }
                else
                {
                    cboMFim.SelectedItem = value;
                }
            }
        }

        public string observacao
        {
            get { return rtbObservacoes.Text; }
            set { rtbObservacoes.Text = value; }
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
            //ctrl.gravarHorario();
            //ctrl.limpaTela();
            MessageBox.Show(ctrl.conetado() ? "Conexão Efetuada com sucesso." : "Erro ao estabelecer conexao.");
            MessageBox.Show("Erro: " + Regra_de_negocio.MapeadorDeBD.erroExcessao);
            rtbObservacoes.Text = Regra_de_negocio.MapeadorDeBD.erroExcessao;
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


        int ITelaCadastroHorario.cboDiaSemana
        {
            get { return cboDiaSemana.SelectedIndex; }
            set { cboDiaSemana.SelectedIndex = value; }
        }
    }
}
