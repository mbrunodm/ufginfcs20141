using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cadastro_de_horario___Modulo_Desktop.Telas
{
    internal interface ITelaCadastroHorario
    {
        List<String> diasDaSemana { get; set; }
        String horaInicio { get; set; }
        String horaFim { get; set; }
        String minutoInicio { get; set; }
        String minutoFim { get; set; }
        String observacao { get; set; }
        int cboDiaSemana { get; set; }

        void exibaMensagem(String mensagem);
    }
}
