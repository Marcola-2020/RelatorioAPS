using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RelatorioAPS
{
    class Dados

    {
        public class Banco
        {
            DataSet dsDados = new DataSet();
            private string _strConexao;
            private SqlConnection _conn;
            private SqlCommand _comandoSQL;

            public SqlCommand ComandoSQL
            {
                get { return _comandoSQL; }
                set { _comandoSQL = value; }
            }

            public Banco()
            {
                _strConexao = @"Data Source=10.42.0.223,9024;Initial Catalog=clinicaFamilia;User ID=sa;Password=AgoRa@2016";
                _conn = new SqlConnection(_strConexao);
                _comandoSQL = new SqlCommand();
                _comandoSQL.Connection = _conn;
            }

            protected bool AbreConexao()
            {
                try
                {
                    _conn.Open();
                    return true;
                }
                catch
                {
                    return false;
                }
            }

            protected bool FechaConexao()
            {
                try
                {
                    if (_conn.State == ConnectionState.Open)
                        _conn.Close();
                    return true;
                }
                catch
                {
                    return false;
                }
            }

            public int ExecutarComando()
            {
                int retorno;
                AbreConexao();
                try
                {
                    retorno = _comandoSQL.ExecuteNonQuery();
                }
                catch
                {
                    retorno = -1;
                }
                finally
                {
                    FechaConexao();
                }
                return retorno;
            }

            public DataTable TotalConsulta(DateTime dtIni, DateTime dtFim)
            {
                AbreConexao();
                DataTable dt = new DataTable();

                try
                {
                    ComandoSQL.CommandText = @"	SELECT PA.CodigoOperadora,PA.CodigoPaciente, NomePaciente, DataNascimento,  DATEDIFF(hour, DataNascimento, getdate()) / 8766 as IDADE, DescricaoProcedimento, DataAgenda, HoraAtendimento, Comparecimento, AG.CodigoProfissional, NomeProfissional  from Agenda ag 
                                            INNER JOIN Paciente pa on pa.CodigoPaciente = ag.CodigoPaciente
                                            INNER JOIN Procedimento pr on pr.CodigoProcedimento = ag.CodigoProcedimento
											INNER JOIN Profissional PF ON PF.CodigoProfissional = AG.CodigoProfissional
                                                 where  Comparecimento = 'S' AND AG.CodigoOperadora = 1 AND DataAgenda >= '" + dtIni + "' and DataAgenda <= '" + dtFim + "' GROUP BY NomePaciente, DescricaoProcedimento, DataAgenda, HoraAtendimento, Comparecimento, AG.CodigoProfissional, PA.CodigoPaciente, PA.DataNascimento, PA.CodigoOperadora,  PF.NomeProfissional ORDER BY DescricaoProcedimento";

                                
                                            


                    dt.Load(_comandoSQL.ExecuteReader());

                    return dt;
                }
                catch
                {
                    dt = null;
                }
                finally
                {
                    FechaConexao();
                }
                return dt;
            }
            public DataTable TotalConsultaSintetico(DateTime dtIni, DateTime dtFim)
            {
                AbreConexao();
                DataTable dt = new DataTable();

                try
                {
                        ComandoSQL.CommandText = @"select  DescricaoProcedimento, COUNT(DescricaoProcedimento), ag.CodigoProfissional, PF.NomeProfissional from Agenda ag 
                                                inner join Paciente pa on pa.CodigoPaciente = ag.CodigoPaciente
                                                inner join Procedimento pr on pr.CodigoProcedimento = ag.CodigoProcedimento
                                                INNER JOIN Profissional PF ON PF.CodigoProfissional = AG.CodigoProfissional
                                             where  Comparecimento = 'S' AND AG.CodigoOperadora = 1 AND DataAgenda >= '" + dtIni + "' and DataAgenda <= '" + dtFim + "' " +
                                             "GROUP BY  DescricaoProcedimento, ag.CodigoProfissional, PF.NomeProfissional ORDER BY NomeProfissional";


                                            


                    dt.Load(_comandoSQL.ExecuteReader());

                    return dt;
                }
                catch
                {
                    dt = null;
                }
                finally
                {
                    FechaConexao();
                }
                return dt;
            }
            public DataTable hemoglobinaGlicada(DateTime dtIni, DateTime dtFim)
            {
                AbreConexao();
                DataTable dt = new DataTable();

                try
                {
                    ComandoSQL.CommandText = @"select PA.CodigoOperadora, PA.CodigoPaciente, PA.DataNascimento, PA.NomePaciente, Hemoglobina, DataDigitacao, DataNascimento, DATEDIFF(hour, DataNascimento, getdate()) / 8766 as IDADE, Diabetes from paciente pa 
                                                    INNER JOIN PacienteClassificacaoEstratificacao PX ON PX.CodigoPaciente =PA.CodigoPaciente
                                                 where  DataDigitacao >= '" + dtIni + "' and DataDigitacao <= '" + dtFim + "' order by NomePaciente";


                    dt.Load(_comandoSQL.ExecuteReader());

                    return dt;
                }
                catch
                {
                    dt = null;
                }
                finally
                {
                    FechaConexao();
                }
                return dt;
            }
            public DataTable Faltas(DateTime dtIni, DateTime dtFim)
            {
                AbreConexao();
                DataTable dt = new DataTable();

                try
                {
                    ComandoSQL.CommandText = @"select PA.CodigoOperadora, NomePaciente, DescricaoProcedimento, Comparecimento from Agenda ag                                     
                                                    inner join Paciente pa on pa.CodigoPaciente = ag.CodigoPaciente
                                                    inner join Procedimento pr on pr.CodigoProcedimento = ag.CodigoProcedimento
                                                    inner join Usuario usu on usu.CodigoUsuario = pa.CodigoUsuario
                                                where  Comparecimento ='n' and DataAgenda >= '" + dtIni + "' and DataAgenda <= '" + dtFim + "' order by NomePaciente";


                    dt.Load(_comandoSQL.ExecuteReader());

                    return dt;
                }
                catch
                {
                    dt = null;
                }
                finally
                {
                    FechaConexao();
                }
                return dt;
            }
            public DataTable Extratificados(DateTime dtIni, DateTime dtFim)
            {
                AbreConexao();
                DataTable dt = new DataTable();

                try
                {
                    ComandoSQL.CommandText = @"SELECT  pa.CodigoOperadora, pa.CodigoPaciente, 
                                                         NomePaciente,
                                                           CASE 
 		                                                    WHEN exists ( SELECT 1 FROM Paciente PAS 
								                                                INNER JOIN PacienteClassificacaoEstratificacao CLA ON CLA.CodigoPaciente = PAS.CodigoPaciente
								                                                LEFT JOIN TipoClassificacaoRiscoHip RHIP ON RHIP.CodigoClassificacaoHip = CLA.CodigoClassificacaoHip
							                                               WHERE pa.CodigoPaciente = PAS.CodigoPaciente)
								                             THEN 'SIM' ELSE 'NAO ' END AS ESTRATIFICADO
			                                    FROM Agenda ag 
                                                            INNER JOIN Paciente pa on pa.CodigoPaciente = ag.CodigoPaciente
                                                            INNER JOIN Procedimento pr on pr.CodigoProcedimento = ag.CodigoProcedimento
									                        INNER JOIN Profissional pf on pf.CodigoProfissional = ag.CodigoProfissional
                                                 WHERE  Comparecimento = 'S' 
                                                        AND AG.CodigoOperadora = 1
                                                        AND DataAgenda >= '" + dtIni + "' " +
                                                       "AND DataAgenda <= '" + dtFim + "' " +
                                                "GROUP BY NomePaciente, PA.CodigoPaciente, pa.CodigoOperadora";

                    dt.Load(_comandoSQL.ExecuteReader());

                    return dt;
                }
                catch
                {
                    dt = null;
                }
                finally
                {
                    FechaConexao();
                }
                return dt;
            }
            public DataTable Ivcf(DateTime dtIni, DateTime dtFim)
            {
                AbreConexao();
                DataTable dt = new DataTable();

                try
                {
                    ComandoSQL.CommandText = @"SELECT  PA.CodigoOperadora, pa.CodigoPaciente, NomePaciente, iv.DataAvaliacao,
		                                                CASE 
 		                                                    WHEN exists ( select pas.NomePaciente, ivc.DescricaoClassificacao, DataAvaliacao  from Paciente pas 
																			inner join IVCF iv on iv.CodigoPaciente = pas.CodigoPaciente
																			inner join IVCFClassificacao ivc on ivc.CodigoClassificacao = iv.CodigoClassificacao
																			where pas.CodigoPaciente = pa.CodigoPaciente )
                                                                THEN 'SIM' ELSE ' ' END AS IVCF_IDOSO
			                                    FROM Agenda ag 
                                                        INNER join Paciente pa on pa.CodigoPaciente = ag.CodigoPaciente
                                                        INNER join Procedimento pr on pr.CodigoProcedimento = ag.CodigoProcedimento
														INNER JOIN Profissional PF ON PF.CodigoProfissional = AG.CodigoProfissional
                                                        INNER JOIN IVCF IV ON IV.CodigoPaciente = AG.CodigoPaciente
                                                WHERE DataNascimento <='01-01-1960' and  Comparecimento = 'S' 
                                                        AND AG.CodigoOperadora = 1 
                                                        AND DataAgenda >= '" + dtIni + "' " +
                                                        "AND DataAgenda <= '" + dtFim + "' " +
                                                "GROUP BY pa.CodigoPaciente, NomePaciente,  iv.DataAvaliacao, PA.CodigoOperadora ";

                    dt.Load(_comandoSQL.ExecuteReader());

                    return dt;
                }
                catch
                {
                    dt = null;
                }
                finally
                {
                    FechaConexao();
                }
                return dt;
            }
            public DataTable Encaminhamentos(DateTime dtIni, DateTime dtFim)
            {
                AbreConexao();
                DataTable dt = new DataTable();

                try
                {
                    ComandoSQL.CommandText = @"select PA.CodigoOperadora, NomePaciente, tenc.DescricaoEncaminhamento, DataMovimento from Paciente pa 
                                                    inner join FichaAtendimentoIndividualEncaminhamento fenc on fenc.CodigoPaciente = pa.CodigoPaciente
                                                    inner join TipoEncaminhamento tenc on  tenc.CodigoEncaminhamento = fenc.CodigoEncaminhamento
                                                where DataMovimento >= '" + dtIni + "' and DataMovimento <= '" + dtFim + "' order by NomePaciente";





                    dt.Load(_comandoSQL.ExecuteReader());

                    return dt;
                }
                catch
                {
                    dt = null;
                }
                finally
                {
                    FechaConexao();
                }
                return dt;
            }
            public DataTable TempoEspera(DateTime dtIni, DateTime dtFim)
            {
                AbreConexao();
                DataTable dt = new DataTable();

                try
                {
                    ComandoSQL.CommandText = @"select PA.CodigoOperadora, NomePaciente, DataProcesso, TempoProcesso, HoraProcessoInicial, HoraProcessoFinal, TempoMinutos from FichaTempo ft 
                                                    inner join Paciente pa on pa.CodigoPaciente = ft.CodigoPaciente
                                                where DataProcesso >= '" + dtIni + "' and DataProcesso <= '" + dtFim + "' order by NomePaciente";


                    dt.Load(_comandoSQL.ExecuteReader());

                    return dt;
                }
                catch
                {
                    dt = null;
                }
                finally
                {
                    FechaConexao();
                }
                return dt;
            }
            public DataTable RastreioColo(DateTime dtIni, DateTime dtFim)
            {
                AbreConexao();
                DataTable dt = new DataTable();

                try
                {
                    ComandoSQL.CommandText = @"select PA.CodigoOperadora, NomePaciente, RastreamentoColorretal, DataMovimento from Paciente pa 
                                                inner join ESUSFichaAtendimentoIndividual esu on esu.CodigoPaciente = pa.CodigoPaciente
                                                where DataNascimento <= '01/01/1961' and  Sexo ='m' and DataMovimento >= '" + dtIni + "' and DataMovimento <= '" + dtFim + "' group by NomePaciente,RastreamentoColorretal, DataMovimento, PA.CodigoOperadora  order by DataMovimento";


                    dt.Load(_comandoSQL.ExecuteReader());

                    return dt;
                }
                catch
                {
                    dt = null;
                }
                finally
                {
                    FechaConexao();
                }
                return dt;
            }
            public DataTable Agendamento72(DateTime dtIni, DateTime dtFim)
            {
                AbreConexao();
                DataTable dt = new DataTable();

                try
                {
                    ComandoSQL.CommandText = @"SELECT [Referencia]
                                                      ,[Ate72horas] as Depois72h
                                                      ,[TotalAgendamentos]
                                                      ,[Porcentagem]
                                                  FROM [ClinicaFamilia].[dbo].[BiAgendamento72Cemig]";


                    dt.Load(_comandoSQL.ExecuteReader());

                    return dt;
                }
                catch
                {
                    dt = null;
                }
                finally
                {
                    FechaConexao();
                }
                return dt;
            }
            public DataTable Equipe(DateTime dtIni, DateTime dtFim)
            {
                AbreConexao();
                DataTable dt = new DataTable();

                try
                {
                    ComandoSQL.CommandText = @"select * from Equipe";


                    dt.Load(_comandoSQL.ExecuteReader());

                    return dt;
                }
                catch
                {
                    dt = null;
                }
                finally
                {
                    FechaConexao();
                }
                return dt;
            }
            public DataTable AgendaDisponibilizada(DateTime dtIni, DateTime dtFim)
            {
                AbreConexao();
                DataTable dt = new DataTable();

                try
                {
                    ComandoSQL.CommandText = @"SELECT NomeProfissional, COUNT(NomeProfissional) from NumeroConsultaData nc 
	                                                INNER JOIN Profissional po on po.CodigoProfissional = nc.CodigoProfissional
                                               where DataAgenda >= '" + dtIni + "' and DataAgenda <= '" + dtFim + "'  group by NomeProfissional";

                    dt.Load(_comandoSQL.ExecuteReader());

                    return dt;
                }
                catch
                {
                    dt = null;
                }
                finally
                {
                    FechaConexao();
                }
                return dt;
            }
        }
    }
}
