using RelatorioAPS.Telas_Relatorios;
using System;
using System.Data;
using System.Text;
using System.Windows.Forms;
using static RelatorioAPS.Dados;

namespace RelatorioAPS
{
    public partial class RelPrincipal : Form
    {
        Banco Bancos = new Banco();
        DataTable dados;
        DataTable dadosAux;

        public RelPrincipal()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            var aux = new StringBuilder();
            DataTable dt = new DataTable();

            if (rdbTotconsultas.Checked)
                dgRelPrincipal.DataSource = Bancos.TotalConsulta(Convert.ToDateTime(dtInicio.Value.ToShortDateString()), Convert.ToDateTime(dtFim.Value.ToShortDateString()));

            if (rdbTotSint.Checked)
                dgRelPrincipal.DataSource = Bancos.TotalConsultaSintetico(Convert.ToDateTime(dtInicio.Value.ToShortDateString()), Convert.ToDateTime(dtFim.Value.ToShortDateString()));

            if (rdbhmglicada.Checked)
                dgRelPrincipal.DataSource = Bancos.hemoglobinaGlicada(Convert.ToDateTime(dtInicio.Value.ToShortDateString()), Convert.ToDateTime(dtFim.Value.ToShortDateString()));

            if (rdbabsenteismo.Checked)
            {
                dgRelPrincipal.DataSource = Bancos.Faltas(Convert.ToDateTime(dtInicio.Value.ToShortDateString()), Convert.ToDateTime(dtFim.Value.ToShortDateString()));
                txtTotPaciente.Text = (dgRelPrincipal.Rows.Count - 1).ToString();
            }
            if (rdbRiscoExtratificado.Checked)
            {
                
                
                dgRelPrincipal.DataSource = Bancos.Extratificados(Convert.ToDateTime(dtInicio.Value.ToShortDateString()), Convert.ToDateTime(dtFim.Value.ToShortDateString()));

                int count = 0;
                txtTotPaciente.Text = (dgRelPrincipal.Rows.Count - 1).ToString();


                foreach (DataGridViewRow row in dgRelPrincipal.Rows)

                {
                    if (row.Cells[3].Value != null)
                    if (row.Cells[3].Value.ToString() == "SIM")
                    {
                        count = count+1; 
                    }

                    txtTotExtratificados.Text = count.ToString();
                }

            }

            if (rdvIvcf.Checked)
            {
                dgRelPrincipal.DataSource = Bancos.Ivcf(Convert.ToDateTime(dtInicio.Value.ToShortDateString()), Convert.ToDateTime(dtFim.Value.ToShortDateString()));

                int count = 0;
                txtTotPaciente.Text = (dgRelPrincipal.Rows.Count - 1).ToString();
                lblTotEstratificados.Text = "Total de Idosos avaliados ";
               


                foreach (DataGridViewRow row in dgRelPrincipal.Rows)

                {
                    if (row.Cells[2].Value != null)
                        if (row.Cells[2].Value.ToString() == "SIM")
                        {
                            count = count + 1;
                        }

                    txtTotExtratificados.Text = count.ToString();
                }


            }
            if (rdbEncaminhamento.Checked)
                dgRelPrincipal.DataSource = Bancos.Encaminhamentos(Convert.ToDateTime(dtInicio.Value.ToShortDateString()), Convert.ToDateTime(dtFim.Value.ToShortDateString()));

            if (rdbTempoatendimento.Checked)
                dgRelPrincipal.DataSource = Bancos.TempoEspera(Convert.ToDateTime(dtInicio.Value.ToShortDateString()), Convert.ToDateTime(dtFim.Value.ToShortDateString()));

            if (rdbRastreiocolo.Checked)
            {
                dgRelPrincipal.DataSource = Bancos.RastreioColo(Convert.ToDateTime(dtInicio.Value.ToShortDateString()), Convert.ToDateTime(dtFim.Value.ToShortDateString()));
                int count = 0;
                txtTotPaciente.Text = (dgRelPrincipal.Rows.Count - 1).ToString();
                lblTotEstratificados.Text = "Rastreios realizados ";


                foreach (DataGridViewRow row in dgRelPrincipal.Rows)

                {
                    if (row.Cells[1].Value != null)
                        if (row.Cells[1].Value.ToString() == "S")
                        {
                            count = count + 1;
                        }

                    txtTotExtratificados.Text = count.ToString();
                }

            }
        
            if (rdbAgendamento72.Checked)
                dgRelPrincipal.DataSource = Bancos.Agendamento72(Convert.ToDateTime(dtInicio.Value.ToShortDateString()), Convert.ToDateTime(dtFim.Value.ToShortDateString()));

            if (rdbEqupe.Checked)
                dgRelPrincipal.DataSource = Bancos.Equipe(Convert.ToDateTime(dtInicio.Value.ToShortDateString()), Convert.ToDateTime(dtFim.Value.ToShortDateString()));

            if (rdbAgendaDisponibilizada.Checked)
                dgRelPrincipal.DataSource = Bancos.AgendaDisponibilizada(Convert.ToDateTime(dtInicio.Value.ToShortDateString()), Convert.ToDateTime(dtFim.Value.ToShortDateString()));


            dt = (DataTable)dgRelPrincipal.DataSource;
           // MontaRelatorio(dt);
        }

        private void quantidadeConsultasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            relConsultas rel = new relConsultas();
            rel.ShowDialog();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
