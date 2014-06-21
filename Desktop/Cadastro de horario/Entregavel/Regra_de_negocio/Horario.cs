using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cadastro_de_horario___Modulo_Desktop.Regra_de_negocio
{
    public class Horario
    {
        public List<String> diasDaSemana { get; set; }
        public String horaInicio { get; set;  }
        public String horaFim { get; set; }
        public String minutoInicio { get; set; }
        public String minutoFim { get; set; }
        public String observacao { get; set; }
        public Boolean horarioOcupado { get; set; }
    }
}
