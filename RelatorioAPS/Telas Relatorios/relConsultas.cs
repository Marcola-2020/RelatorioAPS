using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static RelatorioAPS.Dados;

namespace RelatorioAPS.Telas_Relatorios
{
    public partial class relConsultas : Form
    {
        public relConsultas()
        {
            InitializeComponent();
        }

        private void relConsultas_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
           
                var aux = new StringBuilder();
                DataTable dt = new DataTable();
                Banco conect = new Banco();

                dt = conect.TotalConsulta(Convert.ToDateTime(dtIni.Value.ToShortDateString()), Convert.ToDateTime(dtFim.Value.ToShortDateString()));

                this.reportViewer1.LocalReport.DataSources.Clear();
                this.reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", dt));

                this.reportViewer1.RefreshReport();

            
        }
    }
}
