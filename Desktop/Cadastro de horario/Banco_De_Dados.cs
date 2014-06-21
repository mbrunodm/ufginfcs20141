using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Cadastro_de_horario___Modulo_Desktop.Regra_de_negocio;

namespace Cadastro_de_horario___Modulo_Desktop
{
    public class Banco_De_Dados
    {
        static List<Horario> horarios = new List<Horario>(); 
        public static void inicializa()
        {
            var horario = new Horario
                {
                    diasDaSemana = new List<string> {"Segunda-Feira,Terça-Feira,Sabado"},
                    horaFim = "20",
                    horaInicio = "18",
                    minutoFim = "20",
                    minutoInicio = "50",
                    observacao = "Nenhuma"
                };
            horarios.Add(horario);
            horario = new Horario
            {
                diasDaSemana = new List<string> { "Quarta-Feira,Sexta-Feira" },
                horaFim = "22",
                horaInicio = "21",
                minutoFim = "00",
                minutoInicio = "30",
                observacao = "Nenhuma"
            };
            horarios.Add(horario);
            horario = new Horario
            {
                diasDaSemana = new List<string> { "Quinta-Feira" },
                horaFim = "18",
                horaInicio = "16",
                minutoFim = "00",
                minutoInicio = "00",
                observacao = "Nenhuma"
            };
            horarios.Add(horario);
        }

        public static void inserir(Horario horario)
        {
            horarios.Add(horario);
        }

        public static void excluir(Horario horario)
        {
            horarios.Remove(horario);
        }

        public static List<Horario> obtemTodos()
        {
            return horarios;
        }
    }
}
