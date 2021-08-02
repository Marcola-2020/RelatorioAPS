
namespace RelatorioAPS
{
    partial class RelPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.DataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lbsRelIndicadores = new System.Windows.Forms.Label();
            this.dtInicio = new System.Windows.Forms.DateTimePicker();
            this.dtFim = new System.Windows.Forms.DateTimePicker();
            this.dgRelPrincipal = new System.Windows.Forms.DataGridView();
            this.btBuscar = new System.Windows.Forms.Button();
            this.rdbTotconsultas = new System.Windows.Forms.RadioButton();
            this.pnelMenu = new System.Windows.Forms.Panel();
            this.rdbAgendaDisponibilizada = new System.Windows.Forms.RadioButton();
            this.rdbEqupe = new System.Windows.Forms.RadioButton();
            this.rdbAgendamento72 = new System.Windows.Forms.RadioButton();
            this.rdbRastreiocolo = new System.Windows.Forms.RadioButton();
            this.rdbTempoatendimento = new System.Windows.Forms.RadioButton();
            this.rdbEncaminhamento = new System.Windows.Forms.RadioButton();
            this.rdvIvcf = new System.Windows.Forms.RadioButton();
            this.rdbRiscoExtratificado = new System.Windows.Forms.RadioButton();
            this.rdbabsenteismo = new System.Windows.Forms.RadioButton();
            this.rdbhmglicada = new System.Windows.Forms.RadioButton();
            this.rdbTotSint = new System.Windows.Forms.RadioButton();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgRelPrincipal)).BeginInit();
            this.pnelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // DataSet1BindingSource
            // 
            this.DataSet1BindingSource.DataMember = "DataTable1";
            this.DataSet1BindingSource.CurrentChanged += new System.EventHandler(this.DataSet1BindingSource_CurrentChanged);
            // 
            // lbsRelIndicadores
            // 
            this.lbsRelIndicadores.AutoSize = true;
            this.lbsRelIndicadores.Location = new System.Drawing.Point(958, 25);
            this.lbsRelIndicadores.Name = "lbsRelIndicadores";
            this.lbsRelIndicadores.Size = new System.Drawing.Size(185, 17);
            this.lbsRelIndicadores.TabIndex = 0;
            this.lbsRelIndicadores.Text = "RELATORIO INDICADORES";
            this.lbsRelIndicadores.Click += new System.EventHandler(this.label1_Click);
            // 
            // dtInicio
            // 
            this.dtInicio.Location = new System.Drawing.Point(822, 104);
            this.dtInicio.Name = "dtInicio";
            this.dtInicio.Size = new System.Drawing.Size(200, 22);
            this.dtInicio.TabIndex = 1;
            this.dtInicio.Value = new System.DateTime(2021, 7, 28, 0, 0, 0, 0);
            // 
            // dtFim
            // 
            this.dtFim.Location = new System.Drawing.Point(1086, 104);
            this.dtFim.Name = "dtFim";
            this.dtFim.Size = new System.Drawing.Size(200, 22);
            this.dtFim.TabIndex = 2;
            this.dtFim.Value = new System.DateTime(2021, 7, 28, 0, 0, 0, 0);
            // 
            // dgRelPrincipal
            // 
            this.dgRelPrincipal.AllowUserToOrderColumns = true;
            this.dgRelPrincipal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgRelPrincipal.Location = new System.Drawing.Point(12, 240);
            this.dgRelPrincipal.Name = "dgRelPrincipal";
            this.dgRelPrincipal.RowHeadersWidth = 51;
            this.dgRelPrincipal.RowTemplate.Height = 24;
            this.dgRelPrincipal.Size = new System.Drawing.Size(1454, 479);
            this.dgRelPrincipal.TabIndex = 3;
            this.dgRelPrincipal.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgRelPrincipal_CellContentClick);
            // 
            // btBuscar
            // 
            this.btBuscar.Location = new System.Drawing.Point(1008, 151);
            this.btBuscar.Name = "btBuscar";
            this.btBuscar.Size = new System.Drawing.Size(92, 35);
            this.btBuscar.TabIndex = 4;
            this.btBuscar.Text = "Pesquisar";
            this.btBuscar.UseVisualStyleBackColor = true;
            this.btBuscar.Click += new System.EventHandler(this.btBuscar_Click);
            // 
            // rdbTotconsultas
            // 
            this.rdbTotconsultas.AutoSize = true;
            this.rdbTotconsultas.Location = new System.Drawing.Point(3, 15);
            this.rdbTotconsultas.Name = "rdbTotconsultas";
            this.rdbTotconsultas.Size = new System.Drawing.Size(221, 21);
            this.rdbTotconsultas.TabIndex = 5;
            this.rdbTotconsultas.TabStop = true;
            this.rdbTotconsultas.Text = "Total de Consultas detalhadas";
            this.rdbTotconsultas.UseVisualStyleBackColor = true;
            this.rdbTotconsultas.CheckedChanged += new System.EventHandler(this.rdbTotconsultas_CheckedChanged);
            // 
            // pnelMenu
            // 
            this.pnelMenu.Controls.Add(this.rdbAgendaDisponibilizada);
            this.pnelMenu.Controls.Add(this.rdbEqupe);
            this.pnelMenu.Controls.Add(this.rdbAgendamento72);
            this.pnelMenu.Controls.Add(this.rdbRastreiocolo);
            this.pnelMenu.Controls.Add(this.rdbTempoatendimento);
            this.pnelMenu.Controls.Add(this.rdbEncaminhamento);
            this.pnelMenu.Controls.Add(this.rdvIvcf);
            this.pnelMenu.Controls.Add(this.rdbRiscoExtratificado);
            this.pnelMenu.Controls.Add(this.rdbabsenteismo);
            this.pnelMenu.Controls.Add(this.rdbhmglicada);
            this.pnelMenu.Controls.Add(this.rdbTotSint);
            this.pnelMenu.Controls.Add(this.rdbTotconsultas);
            this.pnelMenu.Location = new System.Drawing.Point(21, 25);
            this.pnelMenu.Name = "pnelMenu";
            this.pnelMenu.Size = new System.Drawing.Size(795, 209);
            this.pnelMenu.TabIndex = 6;
            // 
            // rdbAgendaDisponibilizada
            // 
            this.rdbAgendaDisponibilizada.AutoSize = true;
            this.rdbAgendaDisponibilizada.Location = new System.Drawing.Point(511, 140);
            this.rdbAgendaDisponibilizada.Name = "rdbAgendaDisponibilizada";
            this.rdbAgendaDisponibilizada.Size = new System.Drawing.Size(230, 21);
            this.rdbAgendaDisponibilizada.TabIndex = 16;
            this.rdbAgendaDisponibilizada.TabStop = true;
            this.rdbAgendaDisponibilizada.Text = "Horários disponiveis do médico ";
            this.rdbAgendaDisponibilizada.UseVisualStyleBackColor = true;
            this.rdbAgendaDisponibilizada.CheckedChanged += new System.EventHandler(this.rdbAgendaDisponibilizada_CheckedChanged);
            // 
            // rdbEqupe
            // 
            this.rdbEqupe.AutoSize = true;
            this.rdbEqupe.Location = new System.Drawing.Point(278, 140);
            this.rdbEqupe.Name = "rdbEqupe";
            this.rdbEqupe.Size = new System.Drawing.Size(204, 21);
            this.rdbEqupe.TabIndex = 15;
            this.rdbEqupe.TabStop = true;
            this.rdbEqupe.Text = "Total de pacientes x Equipe";
            this.rdbEqupe.UseVisualStyleBackColor = true;
            // 
            // rdbAgendamento72
            // 
            this.rdbAgendamento72.AutoSize = true;
            this.rdbAgendamento72.Location = new System.Drawing.Point(3, 140);
            this.rdbAgendamento72.Name = "rdbAgendamento72";
            this.rdbAgendamento72.Size = new System.Drawing.Size(192, 21);
            this.rdbAgendamento72.TabIndex = 14;
            this.rdbAgendamento72.TabStop = true;
            this.rdbAgendamento72.Text = "Agendamento em ate 72h";
            this.rdbAgendamento72.UseVisualStyleBackColor = true;
            // 
            // rdbRastreiocolo
            // 
            this.rdbRastreiocolo.AutoSize = true;
            this.rdbRastreiocolo.Location = new System.Drawing.Point(511, 94);
            this.rdbRastreiocolo.Name = "rdbRastreiocolo";
            this.rdbRastreiocolo.Size = new System.Drawing.Size(114, 21);
            this.rdbRastreiocolo.TabIndex = 13;
            this.rdbRastreiocolo.TabStop = true;
            this.rdbRastreiocolo.Text = "Rastreio Colo";
            this.rdbRastreiocolo.UseVisualStyleBackColor = true;
            // 
            // rdbTempoatendimento
            // 
            this.rdbTempoatendimento.AutoSize = true;
            this.rdbTempoatendimento.Location = new System.Drawing.Point(511, 52);
            this.rdbTempoatendimento.Name = "rdbTempoatendimento";
            this.rdbTempoatendimento.Size = new System.Drawing.Size(121, 21);
            this.rdbTempoatendimento.TabIndex = 12;
            this.rdbTempoatendimento.TabStop = true;
            this.rdbTempoatendimento.Text = "Tempo espera";
            this.rdbTempoatendimento.UseVisualStyleBackColor = true;
            // 
            // rdbEncaminhamento
            // 
            this.rdbEncaminhamento.AutoSize = true;
            this.rdbEncaminhamento.Location = new System.Drawing.Point(511, 15);
            this.rdbEncaminhamento.Name = "rdbEncaminhamento";
            this.rdbEncaminhamento.Size = new System.Drawing.Size(138, 21);
            this.rdbEncaminhamento.TabIndex = 11;
            this.rdbEncaminhamento.TabStop = true;
            this.rdbEncaminhamento.Text = "Encaminhamento";
            this.rdbEncaminhamento.UseVisualStyleBackColor = true;
            // 
            // rdvIvcf
            // 
            this.rdvIvcf.AutoSize = true;
            this.rdvIvcf.Location = new System.Drawing.Point(278, 94);
            this.rdvIvcf.Name = "rdvIvcf";
            this.rdvIvcf.Size = new System.Drawing.Size(108, 21);
            this.rdvIvcf.TabIndex = 10;
            this.rdvIvcf.TabStop = true;
            this.rdvIvcf.Text = "Ivcf Avaliado";
            this.rdvIvcf.UseVisualStyleBackColor = true;
            // 
            // rdbRiscoExtratificado
            // 
            this.rdbRiscoExtratificado.AutoSize = true;
            this.rdbRiscoExtratificado.Location = new System.Drawing.Point(278, 52);
            this.rdbRiscoExtratificado.Name = "rdbRiscoExtratificado";
            this.rdbRiscoExtratificado.Size = new System.Drawing.Size(179, 21);
            this.rdbRiscoExtratificado.TabIndex = 9;
            this.rdbRiscoExtratificado.TabStop = true;
            this.rdbRiscoExtratificado.Text = "Pacientes Extratificados";
            this.rdbRiscoExtratificado.UseVisualStyleBackColor = true;
            // 
            // rdbabsenteismo
            // 
            this.rdbabsenteismo.AutoSize = true;
            this.rdbabsenteismo.Location = new System.Drawing.Point(278, 17);
            this.rdbabsenteismo.Name = "rdbabsenteismo";
            this.rdbabsenteismo.Size = new System.Drawing.Size(67, 21);
            this.rdbabsenteismo.TabIndex = 8;
            this.rdbabsenteismo.TabStop = true;
            this.rdbabsenteismo.Text = "Faltas";
            this.rdbabsenteismo.UseVisualStyleBackColor = true;
            // 
            // rdbhmglicada
            // 
            this.rdbhmglicada.AutoSize = true;
            this.rdbhmglicada.Location = new System.Drawing.Point(3, 94);
            this.rdbhmglicada.Name = "rdbhmglicada";
            this.rdbhmglicada.Size = new System.Drawing.Size(164, 21);
            this.rdbhmglicada.TabIndex = 7;
            this.rdbhmglicada.TabStop = true;
            this.rdbhmglicada.Text = "Hemoglobina Glicada";
            this.rdbhmglicada.UseVisualStyleBackColor = true;
            // 
            // rdbTotSint
            // 
            this.rdbTotSint.AutoSize = true;
            this.rdbTotSint.Location = new System.Drawing.Point(3, 52);
            this.rdbTotSint.Name = "rdbTotSint";
            this.rdbTotSint.Size = new System.Drawing.Size(203, 21);
            this.rdbTotSint.TabIndex = 6;
            this.rdbTotSint.TabStop = true;
            this.rdbTotSint.Text = "Total de consultas Sintetico";
            this.rdbTotSint.UseVisualStyleBackColor = true;
            // 
            // reportViewer1
            // 
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "RelatorioAPS.Relatorios.RelQtdAtendimentos.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(822, 240);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(644, 479);
            this.reportViewer1.TabIndex = 7;
            // 
            // RelPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1478, 731);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.pnelMenu);
            this.Controls.Add(this.btBuscar);
            this.Controls.Add(this.dgRelPrincipal);
            this.Controls.Add(this.dtFim);
            this.Controls.Add(this.dtInicio);
            this.Controls.Add(this.lbsRelIndicadores);
            this.Name = "RelPrincipal";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.RelPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgRelPrincipal)).EndInit();
            this.pnelMenu.ResumeLayout(false);
            this.pnelMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbsRelIndicadores;
        private System.Windows.Forms.DateTimePicker dtInicio;
        private System.Windows.Forms.DateTimePicker dtFim;
        private System.Windows.Forms.DataGridView dgRelPrincipal;
        private System.Windows.Forms.Button btBuscar;
        private System.Windows.Forms.RadioButton rdbTotconsultas;
        private System.Windows.Forms.Panel pnelMenu;
        private System.Windows.Forms.RadioButton rdbhmglicada;
        private System.Windows.Forms.RadioButton rdbTotSint;
        private System.Windows.Forms.RadioButton rdbabsenteismo;
        private System.Windows.Forms.RadioButton rdbRiscoExtratificado;
        private System.Windows.Forms.RadioButton rdvIvcf;
        private System.Windows.Forms.RadioButton rdbEncaminhamento;
        private System.Windows.Forms.RadioButton rdbTempoatendimento;
        private System.Windows.Forms.RadioButton rdbRastreiocolo;
        private System.Windows.Forms.RadioButton rdbAgendamento72;
        private System.Windows.Forms.RadioButton rdbEqupe;
        private System.Windows.Forms.RadioButton rdbAgendaDisponibilizada;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource DataSet1BindingSource;
    }
}

