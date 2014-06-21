using System;
using System.Collections.Generic;
using Cadastro_de_horario___Modulo_Desktop.Regra_de_negocio;
using Cadastro_de_horario___Modulo_Desktop.Telas;

namespace Cadastro_de_horario___Modulo_Desktop.Controlador_de_Tela
{
    class ControladorDeTela
    {
        private ITelaCadastroHorario _tela;
        private MapeadorDeBD mapeador = new MapeadorDeBD();
        public ControladorDeTela(ITelaCadastroHorario tela)
        {
            _tela = tela;
        }
        /// <summary>
        /// Testa a validade do cadastro comparando os ítens obrigatórios e a 
        /// disponibilidade do horário e envia os dados para o mapeador efetuar
        /// a gravação na Base de Dados.
        /// </summary>
        public void gravarHorario()
        {
            var horario = obtemObjTela();
            var erro = Validador.validaPreenchimentoObrigatorio(horario);
            if (!string.IsNullOrWhiteSpace(erro))
            {
                _tela.exibaMensagem(erro);
            }
            else
            {
                if (Validador.validaDisponibilidadeDeHorario(horario))
                {
                    mapeador.GravarHorario(horario);
                }
                else
                {
                    _tela.exibaMensagem("Horário indisponível, houve um choque de horários, favor tente novamente.");
                }
                
            }

        }
        /// <summary>
        /// Obtém os valores informados na tela e monta o objeto horário.
        /// </summary>
        /// <returns>Objeto horário com todas as informações da tela.</returns>
        private Horario obtemObjTela()
        {
            var horario = new Horario
                {
                    diasDaSemana = _tela.diasDaSemana,
                    horaFim = _tela.horaFim,
                    horaInicio = _tela.horaInicio,
                    horarioOcupado = _tela.horarioOcupado,
                    minutoFim = _tela.minutoFim,
                    minutoInicio = _tela.minutoInicio,
                    observacao = _tela.observacao
                };
            return horario;
        }
        /// <summary>
        /// Limpa os valores dos campos na tela substituíndo - os pelos
        /// valores padrões.
        /// </summary>
        public void limpaTela()
        {
            _tela.diasDaSemana = new List<string>();
            _tela.horaFim = String.Empty;
            _tela.horaInicio = String.Empty;
            _tela.horarioOcupado = false;
            _tela.minutoFim = String.Empty;
            _tela.minutoInicio = String.Empty;
            _tela.observacao = String.Empty;
        }
    }
}
