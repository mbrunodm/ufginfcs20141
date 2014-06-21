using System;
using Cadastro_de_horario___Modulo_Desktop.Regra_de_negocio;

namespace Cadastro_de_horario___Modulo_Desktop.Controlador_de_Tela
{
    public class Validador
    {
        /// <summary>
        /// Método de validação do preenchimento dos campos
        /// obrigatórios
        /// </summary>
        /// <param name="horario">Objeto com as informações preenchidas da tela</param>
        /// <returns>Mensagem de erro ou vazia quando não houver erro</returns>
        public static String validaPreenchimentoObrigatorio(Horario horario)
        {
            var erro = String.Empty;
            if (String.IsNullOrWhiteSpace(horario.minutoInicio))
            {
                erro = "Preencha corretamente o horário de início, informe um valor para o campo minuto";
            }
            if (String.IsNullOrWhiteSpace(horario.horaInicio))
            {
                erro = "Preencha corretamente o horário de início, informe um valor para o campo hora";
            }
            if (String.IsNullOrWhiteSpace(horario.horaFim))
            {
                erro = "Preencha corretamente o horário de término, informe um valor para o campo hora.";
            }
            if (String.IsNullOrWhiteSpace(horario.minutoFim))
            {
                erro = "Preencha corretamente o horário de término, informe um valor para o campo minuto.";
            }
            if (horario.diasDaSemana.Count == 0)
            {
                erro = "É preciso informar ao menos um dia da semana para o cadastro de horário";
            }
            return erro;
        }
        /// <summary>
        /// Verifica se o horário informado está disponível 
        /// </summary>
        /// <param name="horario">objeto informado na tela</param>
        /// <returns>true para horário disponível e false para ocupado</returns>
        public static Boolean validaDisponibilidadeDeHorario(Horario horario)
        {
            var mapeador = new MapeadorDeBD();
            return mapeador.horarioDisponivel(horario);
        }
    }
}
