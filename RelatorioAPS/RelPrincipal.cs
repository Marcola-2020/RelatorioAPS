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
                dgRelPrincipal.DataSource = Bancos.Faltas(Convert.ToDateTime(dtInicio.Value.ToShortDateString()), Convert.ToDateTime(dtFim.Value.ToShortDateString()));

            if (rdbRiscoExtratificado.Checked)
                dgRelPrincipal.DataSource = Bancos.Extratificados(Convert.ToDateTime(dtInicio.Value.ToShortDateString()), Convert.ToDateTime(dtFim.Value.ToShortDateString()));

            if (rdvIvcf.Checked)
                dgRelPrincipal.DataSource = Bancos.Ivcf(Convert.ToDateTime(dtInicio.Value.ToShortDateString()), Convert.ToDateTime(dtFim.Value.ToShortDateString()));

            if (rdbEncaminhamento.Checked)
                dgRelPrincipal.DataSource = Bancos.Encaminhamentos(Convert.ToDateTime(dtInicio.Value.ToShortDateString()), Convert.ToDateTime(dtFim.Value.ToShortDateString()));

            if (rdbTempoatendimento.Checked)
                dgRelPrincipal.DataSource = Bancos.TempoEspera(Convert.ToDateTime(dtInicio.Value.ToShortDateString()), Convert.ToDateTime(dtFim.Value.ToShortDateString()));

            if (rdbRastreiocolo.Checked)
                dgRelPrincipal.DataSource = Bancos.RastreioColo(Convert.ToDateTime(dtInicio.Value.ToShortDateString()), Convert.ToDateTime(dtFim.Value.ToShortDateString()));

            if (rdbAgendamento72.Checked)
                dgRelPrincipal.DataSource = Bancos.Agendamento72(Convert.ToDateTime(dtInicio.Value.ToShortDateString()), Convert.ToDateTime(dtFim.Value.ToShortDateString()));

            if (rdbEqupe.Checked)
                dgRelPrincipal.DataSource = Bancos.Equipe(Convert.ToDateTime(dtInicio.Value.ToShortDateString()), Convert.ToDateTime(dtFim.Value.ToShortDateString()));

            if (rdbAgendaDisponibilizada.Checked)
                dgRelPrincipal.DataSource = Bancos.AgendaDisponibilizada(Convert.ToDateTime(dtInicio.Value.ToShortDateString()), Convert.ToDateTime(dtFim.Value.ToShortDateString()));


            dt = (DataTable)dgRelPrincipal.DataSource;
            MontaRelatorio(dt);
        }
        private void MontaRelatorio(DataTable dtaux)
        {

            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DsRelqtdAtendimento", dtaux));

            this.reportViewer1.RefreshReport();



        }

        private void rdbTotconsultas_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdbAgendaDisponibilizada_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dgRelPrincipal_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void RelPrincipal_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        private void DataSet1BindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }


    }
}
