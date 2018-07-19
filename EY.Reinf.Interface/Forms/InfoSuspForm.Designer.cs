namespace EY.Reinf.Interface
{
    partial class InfoSuspForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.infoSusp_groupBox = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.label29 = new System.Windows.Forms.Label();
            this.indDeposito_checkbox = new System.Windows.Forms.ComboBox();
            this.label30 = new System.Windows.Forms.Label();
            this.dtDecisao_dtp = new System.Windows.Forms.DateTimePicker();
            this.label31 = new System.Windows.Forms.Label();
            this.indSusp_comboBox = new System.Windows.Forms.ComboBox();
            this.label32 = new System.Windows.Forms.Label();
            this.codSusp_textBox = new System.Windows.Forms.TextBox();
            this.infoSusp_groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(262, 203);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(130, 30);
            this.btnCancelar.TabIndex = 19;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(126, 203);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(130, 30);
            this.btnSalvar.TabIndex = 18;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // infoSusp_groupBox
            // 
            this.infoSusp_groupBox.Controls.Add(this.tableLayoutPanel5);
            this.infoSusp_groupBox.Controls.Add(this.label29);
            this.infoSusp_groupBox.Controls.Add(this.indDeposito_checkbox);
            this.infoSusp_groupBox.Controls.Add(this.label30);
            this.infoSusp_groupBox.Controls.Add(this.dtDecisao_dtp);
            this.infoSusp_groupBox.Controls.Add(this.label31);
            this.infoSusp_groupBox.Controls.Add(this.indSusp_comboBox);
            this.infoSusp_groupBox.Controls.Add(this.label32);
            this.infoSusp_groupBox.Controls.Add(this.codSusp_textBox);
            this.infoSusp_groupBox.Location = new System.Drawing.Point(12, 12);
            this.infoSusp_groupBox.Name = "infoSusp_groupBox";
            this.infoSusp_groupBox.Size = new System.Drawing.Size(492, 177);
            this.infoSusp_groupBox.TabIndex = 17;
            this.infoSusp_groupBox.TabStop = false;
            this.infoSusp_groupBox.Text = "Informações de Suspensão de Exibilidade de Tributos";
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 3;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel5.Location = new System.Drawing.Point(333, 191);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(200, 100);
            this.tableLayoutPanel5.TabIndex = 0;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(10, 144);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(153, 13);
            this.label29.TabIndex = 14;
            this.label29.Text = "Depósito do Montante Integral:";
            // 
            // indDeposito_checkbox
            // 
            this.indDeposito_checkbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.indDeposito_checkbox.FormattingEnabled = true;
            this.indDeposito_checkbox.Items.AddRange(new object[] {
            "S - Sim",
            "N - Não"});
            this.indDeposito_checkbox.Location = new System.Drawing.Point(166, 141);
            this.indDeposito_checkbox.Name = "indDeposito_checkbox";
            this.indDeposito_checkbox.Size = new System.Drawing.Size(92, 21);
            this.indDeposito_checkbox.TabIndex = 13;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(10, 112);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(88, 13);
            this.label30.TabIndex = 12;
            this.label30.Text = "Data da decisão:";
            // 
            // dtDecisao_dtp
            // 
            this.dtDecisao_dtp.CustomFormat = "MMMM yyyy";
            this.dtDecisao_dtp.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDecisao_dtp.Location = new System.Drawing.Point(166, 106);
            this.dtDecisao_dtp.Name = "dtDecisao_dtp";
            this.dtDecisao_dtp.Size = new System.Drawing.Size(92, 20);
            this.dtDecisao_dtp.TabIndex = 11;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(10, 74);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(125, 13);
            this.label31.TabIndex = 10;
            this.label31.Text = "Indicativo de suspensão:";
            // 
            // indSusp_comboBox
            // 
            this.indSusp_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.indSusp_comboBox.FormattingEnabled = true;
            this.indSusp_comboBox.Items.AddRange(new object[] {
            "01 - Liminar em Mandado de Segurança",
            "02 - Depósito Judicial do Montante Integral",
            "03 - Depósito Administrativo do Montante Integral",
            "04 - Antecipação de Tutela",
            "05 - Liminar em Medida Cautelar",
            "08 - Sentença em Mandado de Segurança Favorável ao Contribuinte",
            "09 - Sentença em Ação Ordinária Favorável ao Contribuinte e Confirmada pelo TRF",
            "10 - Acórdão do TRF Favorável ao Contribuinte",
            "11 - Acórdão do STJ em Recurso Especial Favorável ao Contribuinte",
            "12 - Acórdão do STF em Recurso Extraordinário Favorável ao Contribuinte",
            "13 - Sentença 1ª instância não transitada em julgado com efeito suspensivo",
            "90 - Decisão Definitiva a favor do contribuinte",
            "92 - Sem suspensão da exigibilidade"});
            this.indSusp_comboBox.Location = new System.Drawing.Point(166, 71);
            this.indSusp_comboBox.Name = "indSusp_comboBox";
            this.indSusp_comboBox.Size = new System.Drawing.Size(296, 21);
            this.indSusp_comboBox.TabIndex = 9;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(10, 36);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(114, 13);
            this.label32.TabIndex = 8;
            this.label32.Text = "Código da Suspensão:";
            // 
            // codSusp_textBox
            // 
            this.codSusp_textBox.Location = new System.Drawing.Point(166, 33);
            this.codSusp_textBox.MaxLength = 20;
            this.codSusp_textBox.Name = "codSusp_textBox";
            this.codSusp_textBox.Size = new System.Drawing.Size(135, 20);
            this.codSusp_textBox.TabIndex = 7;
            // 
            // InfoSuspForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(516, 245);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.infoSusp_groupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "InfoSuspForm";
            this.Text = "Informações de Suspensão";
            this.infoSusp_groupBox.ResumeLayout(false);
            this.infoSusp_groupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.GroupBox infoSusp_groupBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.ComboBox indDeposito_checkbox;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.DateTimePicker dtDecisao_dtp;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.ComboBox indSusp_comboBox;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.TextBox codSusp_textBox;
    }
}