using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using MySql.Data.MySqlClient;

namespace Cadastro_de_horario___Modulo_Desktop.Regra_de_negocio
{
    public class MapeadorDeBD
    {
        private MySqlConnection bdConn; //MySQL
        private MySqlDataAdapter bdAdapter;
        //private DataSet bdDataSet;
        /// <summary>
        /// Grava o horário na base de dados.
        /// </summary>
        /// <param name="horario">horário obtido da tela.</param>
        public void GravarHorario(Horario horario)
        {
            var horaInicio = String.Format("{0}:{1}", horario.horaInicio, horario.minutoInicio);
            var horaFim = String.Format("{0}:{1}", horario.horaFim, horario.minutoFim);
            //bdDataSet = new DataSet();
            //TODO: Alterar String de conexão.
            bdConn = new MySqlConnection("Persist Security  Info=False;server=localhost;database=rfidapp;uid=root;server=localhost;database=rfidapp;uid=root;pwd=''");
            //Abre conecção
            try{
 	            bdConn.Open();
            }
            catch
            {
                bdConn.Close();
            }
            //Verifica se a conexão está aberta
            if (bdConn.State == ConnectionState.Open)
            {
                var strSqlCmd = new StringBuilder();
                strSqlCmd.AppendLine(
                    "INSERT INTO cadastro_Horario_Aula(Id_Horario_Aula,Dia_Semana,Horario_Inicio,Horario_Termino,Obs,Status)");
                strSqlCmd.AppendFormat("values('{0}','{1}','{2}','{3}','{4}','{5}')", ObtemProximoCodigo(), horario.diasDaSemana, horaInicio, horaFim,
                                       horario.observacao, horario.horarioOcupado);
	            //Se estiver aberta insere os dados na BD
                var commS = new MySqlCommand(strSqlCmd.ToString(), bdConn);
                commS.BeginExecuteNonQuery();
            }
        }
        /// <summary>
        /// obtém o próximo código livre na base de dados, para cadastrar
        /// um horário com código incrementativo.
        /// </summary>
        /// <returns>código livre para cadastrar horário</returns>
        private int ObtemProximoCodigo()
        {
            const string strSqlcmd = "SELECT MAX(Id_Horario_Aula) + 1 proxcod FROM Cadastro_Horario_Aula;";
            int retorno;
            //bdDataSet = new DataSet();
            //TODO: Alterar String de conexão.
            bdConn = new MySqlConnection("server=www.leonardoalves.info:3306;database=leonar11_projetos;uid=leonar11_bdaula;pwd=aulabd");
            //Abre conecção
            try
            {
                bdConn.Open();

                if (bdConn.State == ConnectionState.Open)
                {
                    var commS = new MySqlCommand(strSqlcmd, bdConn);
                    var leitor = commS.ExecuteReader();
                    if (leitor.HasRows)
                    {
                        if (leitor.NextResult())
                        {
                            return Convert.ToInt32(leitor["proxcod"]);
                        }
                    }
                }
            }
            catch
            {
                return 1;
            }
            return 0;
        }
        /// <summary>
        /// Testa se o horário informado está disponível para 
        /// ser inserdo.
        /// </summary>
        /// <param name="horario">Horário informado para cadastro</param>
        /// <returns>Status do horário</returns>
        public Boolean horarioDisponivel(Horario horario)
        {
            var strSql = new StringBuilder();
            strSql.AppendLine("SELECT Horario_Inicio,Horario_Termino FROM CADASTRO_HORARIO_AULA");
            strSql.AppendFormat("WHERE status = 'ocupado' AND Dia_Semana = '{0}'",horario.diasDaSemana);
            //TODO: Atualizar string de conexão com banco de dados. Mysql
            bdConn = new MySqlConnection("server=www.leandroalves.info:3306;database=leonar11_projetos;uid=leonar11_bdaula;pwd=aulabd");
            bdConn.Open();

            if (bdConn.State == ConnectionState.Open)
            {
                var commS = new MySqlCommand(strSql.ToString(), bdConn);
                var leitor = commS.ExecuteReader();
                if (leitor.HasRows)
                {
                    while(leitor.NextResult())
                    {
                        var horarioInicio = (String) leitor["Horario_Inicio"];
                        var horarioFim = (String) leitor["Horario_Termino"]; 
                        var h = new Horario
                            {
                                horaInicio = horarioInicio.Split(':')[0],
                                minutoInicio = horarioInicio.Split(':')[1],
                                horaFim = horarioFim.Split(':')[0],
                                minutoFim = horarioFim.Split(':')[1]
                            };
                        if (ehHorarioLivre(horario, h) == false)
                        {
                            return false;
                        }
                    }
                }
            }
            return true;
        }
        /// <summary>
        /// Método auxiliar do teste de horário, este compara 
        /// os valores dos horários vindos do banco e da tela.
        /// </summary>
        /// <param name="hTela">Horário informado na tela</param>
        /// <param name="hBanco">Horário vindo do banco de dados</param>
        /// <returns>Disponibilidade destes horários.</returns>
        private Boolean ehHorarioLivre(Horario hTela, Horario hBanco)
        {
            //Retorna se a hora de início informado na tela está entre o horário de início e de término vindo do banco.
            return Convert.ToInt32(hTela.horaInicio) <= Convert.ToInt32(hBanco.horaInicio) || Convert.ToInt32(hTela.horaInicio) >= Convert.ToInt32(hBanco.horaFim);
        }
    }
}
