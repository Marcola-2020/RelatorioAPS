
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.relatoriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quantidadeConsultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.lblTotPacientes = new System.Windows.Forms.Label();
            this.lblTotEstratificados = new System.Windows.Forms.Label();
            this.txtTotPaciente = new System.Windows.Forms.TextBox();
            this.txtTotExtratificados = new System.Windows.Forms.TextBox();
            this.lblDtIni = new System.Windows.Forms.Label();
            this.lblDtFim = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgRelPrincipal)).BeginInit();
            this.pnelMenu.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1BindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbsRelIndicadores
            // 
            this.lbsRelIndicadores.AutoSize = true;
            this.lbsRelIndicadores.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbsRelIndicadores.Location = new System.Drawing.Point(540, 0);
            this.lbsRelIndicadores.Name = "lbsRelIndicadores";
            this.lbsRelIndicadores.Size = new System.Drawing.Size(370, 31);
            this.lbsRelIndicadores.TabIndex = 0;
            this.lbsRelIndicadores.Text = "RELATORIO INDICADORES";
            this.lbsRelIndicadores.Click += new System.EventHandler(this.label1_Click);
            // 
            // dtInicio
            // 
            this.dtInicio.Location = new System.Drawing.Point(154, 26);
            this.dtInicio.Name = "dtInicio";
            this.dtInicio.Size = new System.Drawing.Size(200, 22);
            this.dtInicio.TabIndex = 1;
            this.dtInicio.Value = new System.DateTime(2021, 7, 28, 0, 0, 0, 0);
            // 
            // dtFim
            // 
            this.dtFim.Location = new System.Drawing.Point(564, 26);
            this.dtFim.Name = "dtFim";
            this.dtFim.Size = new System.Drawing.Size(200, 22);
            this.dtFim.TabIndex = 2;
            this.dtFim.Value = new System.DateTime(2021, 7, 28, 0, 0, 0, 0);
            // 
            // dgRelPrincipal
            // 
            this.dgRelPrincipal.AllowUserToOrderColumns = true;
            this.dgRelPrincipal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgRelPrincipal.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgRelPrincipal.Location = new System.Drawing.Point(0, 252);
            this.dgRelPrincipal.Name = "dgRelPrincipal";
            this.dgRelPrincipal.RowHeadersWidth = 51;
            this.dgRelPrincipal.RowTemplate.Height = 24;
            this.dgRelPrincipal.Size = new System.Drawing.Size(1478, 479);
            this.dgRelPrincipal.TabIndex = 3;
            // 
            // btBuscar
            // 
            this.btBuscar.Location = new System.Drawing.Point(1275, 13);
            this.btBuscar.Name = "btBuscar";
            this.btBuscar.Size = new System.Drawing.Size(167, 35);
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
            // 
            // pnelMenu
            // 
            this.pnelMenu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
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
            this.pnelMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnelMenu.Location = new System.Drawing.Point(0, 30);
            this.pnelMenu.Name = "pnelMenu";
            this.pnelMenu.Size = new System.Drawing.Size(1478, 91);
            this.pnelMenu.TabIndex = 6;
            // 
            // rdbAgendaDisponibilizada
            // 
            this.rdbAgendaDisponibilizada.AutoSize = true;
            this.rdbAgendaDisponibilizada.Location = new System.Drawing.Point(934, 52);
            this.rdbAgendaDisponibilizada.Name = "rdbAgendaDisponibilizada";
            this.rdbAgendaDisponibilizada.Size = new System.Drawing.Size(230, 21);
            this.rdbAgendaDisponibilizada.TabIndex = 16;
            this.rdbAgendaDisponibilizada.TabStop = true;
            this.rdbAgendaDisponibilizada.Text = "Horários disponiveis do médico ";
            this.rdbAgendaDisponibilizada.UseVisualStyleBackColor = true;
            // 
            // rdbEqupe
            // 
            this.rdbEqupe.AutoSize = true;
            this.rdbEqupe.Location = new System.Drawing.Point(717, 52);
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
            this.rdbAgendamento72.Location = new System.Drawing.Point(1240, 17);
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
            this.rdbRastreiocolo.Location = new System.Drawing.Point(1100, 17);
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
            this.rdvIvcf.Location = new System.Drawing.Point(934, 17);
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
            this.rdbRiscoExtratificado.Size = new System.Drawing.Size(180, 21);
            this.rdbRiscoExtratificado.TabIndex = 9;
            this.rdbRiscoExtratificado.TabStop = true;
            this.rdbRiscoExtratificado.Text = "Pacientes Estratificados";
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
            this.rdbhmglicada.Location = new System.Drawing.Point(717, 17);
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
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.relatoriosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1478, 30);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // relatoriosToolStripMenuItem
            // 
            this.relatoriosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quantidadeConsultasToolStripMenuItem});
            this.relatoriosToolStripMenuItem.Name = "relatoriosToolStripMenuItem";
            this.relatoriosToolStripMenuItem.Size = new System.Drawing.Size(94, 24);
            this.relatoriosToolStripMenuItem.Text = "Relatorios ";
            this.relatoriosToolStripMenuItem.Visible = false;
            // 
            // quantidadeConsultasToolStripMenuItem
            // 
            this.quantidadeConsultasToolStripMenuItem.Name = "quantidadeConsultasToolStripMenuItem";
            this.quantidadeConsultasToolStripMenuItem.Size = new System.Drawing.Size(237, 26);
            this.quantidadeConsultasToolStripMenuItem.Text = "Quantidade Consultas";
            this.quantidadeConsultasToolStripMenuItem.Click += new System.EventHandler(this.quantidadeConsultasToolStripMenuItem_Click);
            // 
            // DataSet1BindingSource
            // 
            this.DataSet1BindingSource.DataMember = "DataTable1";
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 121);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 131);
            this.splitter1.TabIndex = 9;
            this.splitter1.TabStop = false;
            // 
            // lblTotPacientes
            // 
            this.lblTotPacientes.AutoSize = true;
            this.lblTotPacientes.Location = new System.Drawing.Point(275, 70);
            this.lblTotPacientes.Name = "lblTotPacientes";
            this.lblTotPacientes.Size = new System.Drawing.Size(130, 17);
            this.lblTotPacientes.TabIndex = 10;
            this.lblTotPacientes.Text = "Total de Pacientes ";
            // 
            // lblTotEstratificados
            // 
            this.lblTotEstratificados.AutoSize = true;
            this.lblTotEstratificados.Location = new System.Drawing.Point(841, 68);
            this.lblTotEstratificados.Name = "lblTotEstratificados";
            this.lblTotEstratificados.Size = new System.Drawing.Size(149, 17);
            this.lblTotEstratificados.TabIndex = 11;
            this.lblTotEstratificados.Text = "Total de Estratificados";
            // 
            // txtTotPaciente
            // 
            this.txtTotPaciente.Location = new System.Drawing.Point(471, 73);
            this.txtTotPaciente.Name = "txtTotPaciente";
            this.txtTotPaciente.Size = new System.Drawing.Size(100, 22);
            this.txtTotPaciente.TabIndex = 12;
            // 
            // txtTotExtratificados
            // 
            this.txtTotExtratificados.Location = new System.Drawing.Point(1042, 70);
            this.txtTotExtratificados.Name = "txtTotExtratificados";
            this.txtTotExtratificados.Size = new System.Drawing.Size(100, 22);
            this.txtTotExtratificados.TabIndex = 13;
            this.txtTotExtratificados.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // lblDtIni
            // 
            this.lblDtIni.AutoSize = true;
            this.lblDtIni.Location = new System.Drawing.Point(0, 31);
            this.lblDtIni.Name = "lblDtIni";
            this.lblDtIni.Size = new System.Drawing.Size(77, 17);
            this.lblDtIni.TabIndex = 14;
            this.lblDtIni.Text = "Data Inicial";
            // 
            // lblDtFim
            // 
            this.lblDtFim.AutoSize = true;
            this.lblDtFim.Location = new System.Drawing.Point(433, 31);
            this.lblDtFim.Name = "lblDtFim";
            this.lblDtFim.Size = new System.Drawing.Size(72, 17);
            this.lblDtFim.TabIndex = 15;
            this.lblDtFim.Text = "Data Final";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btBuscar);
            this.panel1.Controls.Add(this.lblDtFim);
            this.panel1.Controls.Add(this.dtInicio);
            this.panel1.Controls.Add(this.lblDtIni);
            this.panel1.Controls.Add(this.dtFim);
            this.panel1.Controls.Add(this.txtTotExtratificados);
            this.panel1.Controls.Add(this.lblTotPacientes);
            this.panel1.Controls.Add(this.txtTotPaciente);
            this.panel1.Controls.Add(this.lblTotEstratificados);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 121);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1475, 100);
            this.panel1.TabIndex = 16;
            // 
            // RelPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1478, 731);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.pnelMenu);
            this.Controls.Add(this.dgRelPrincipal);
            this.Controls.Add(this.lbsRelIndicadores);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "RelPrincipal";
            this.Text = "Relatorio Conexao Saude";
            ((System.ComponentModel.ISupportInitialize)(this.dgRelPrincipal)).EndInit();
            this.pnelMenu.ResumeLayout(false);
            this.pnelMenu.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1BindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.BindingSource DataSet1BindingSource;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem relatoriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quantidadeConsultasToolStripMenuItem;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Label lblTotPacientes;
        private System.Windows.Forms.Label lblTotEstratificados;
        private System.Windows.Forms.TextBox txtTotPaciente;
        private System.Windows.Forms.TextBox txtTotExtratificados;
        private System.Windows.Forms.Label lblDtIni;
        private System.Windows.Forms.Label lblDtFim;
        private System.Windows.Forms.Panel panel1;
    }
}

