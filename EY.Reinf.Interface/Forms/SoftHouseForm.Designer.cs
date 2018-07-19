namespace EY.Reinf.Interface
{
    partial class SoftHouseForm
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
            if(disposing && (components != null))
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
            this.inf_softhouse_groupBox = new System.Windows.Forms.GroupBox();
            this.softCttCNPJ_textbox = new System.Windows.Forms.MaskedTextBox();
            this.softCttTelFixo_textbox = new System.Windows.Forms.MaskedTextBox();
            this.softCttRazaoSocial_textbox = new System.Windows.Forms.TextBox();
            this.label162 = new System.Windows.Forms.Label();
            this.label156 = new System.Windows.Forms.Label();
            this.softCttNome_textbox = new System.Windows.Forms.TextBox();
            this.softCttEmail_textbox = new System.Windows.Forms.TextBox();
            this.label161 = new System.Windows.Forms.Label();
            this.label158 = new System.Windows.Forms.Label();
            this.label160 = new System.Windows.Forms.Label();
            this.inf_softhouse_groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(276, 213);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(130, 30);
            this.btnCancelar.TabIndex = 13;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(140, 213);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(130, 30);
            this.btnSalvar.TabIndex = 12;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // inf_softhouse_groupBox
            // 
            this.inf_softhouse_groupBox.Controls.Add(this.softCttCNPJ_textbox);
            this.inf_softhouse_groupBox.Controls.Add(this.softCttTelFixo_textbox);
            this.inf_softhouse_groupBox.Controls.Add(this.softCttRazaoSocial_textbox);
            this.inf_softhouse_groupBox.Controls.Add(this.label162);
            this.inf_softhouse_groupBox.Controls.Add(this.label156);
            this.inf_softhouse_groupBox.Controls.Add(this.softCttNome_textbox);
            this.inf_softhouse_groupBox.Controls.Add(this.softCttEmail_textbox);
            this.inf_softhouse_groupBox.Controls.Add(this.label161);
            this.inf_softhouse_groupBox.Controls.Add(this.label158);
            this.inf_softhouse_groupBox.Controls.Add(this.label160);
            this.inf_softhouse_groupBox.Location = new System.Drawing.Point(12, 12);
            this.inf_softhouse_groupBox.Name = "inf_softhouse_groupBox";
            this.inf_softhouse_groupBox.Size = new System.Drawing.Size(526, 186);
            this.inf_softhouse_groupBox.TabIndex = 11;
            this.inf_softhouse_groupBox.TabStop = false;
            this.inf_softhouse_groupBox.Text = "Informações da SoftHouse";
            // 
            // softCttCNPJ_textbox
            // 
            this.softCttCNPJ_textbox.Location = new System.Drawing.Point(159, 95);
            this.softCttCNPJ_textbox.Mask = "00.000.000-0000.00";
            this.softCttCNPJ_textbox.Name = "softCttCNPJ_textbox";
            this.softCttCNPJ_textbox.Size = new System.Drawing.Size(132, 20);
            this.softCttCNPJ_textbox.TabIndex = 13;
            // 
            // softCttTelFixo_textbox
            // 
            this.softCttTelFixo_textbox.Location = new System.Drawing.Point(159, 126);
            this.softCttTelFixo_textbox.Mask = "(00) 0000-0000";
            this.softCttTelFixo_textbox.Name = "softCttTelFixo_textbox";
            this.softCttTelFixo_textbox.Size = new System.Drawing.Size(132, 20);
            this.softCttTelFixo_textbox.TabIndex = 15;
            // 
            // softCttRazaoSocial_textbox
            // 
            this.softCttRazaoSocial_textbox.Location = new System.Drawing.Point(159, 62);
            this.softCttRazaoSocial_textbox.MaximumSize = new System.Drawing.Size(311, 20);
            this.softCttRazaoSocial_textbox.MinimumSize = new System.Drawing.Size(266, 20);
            this.softCttRazaoSocial_textbox.Name = "softCttRazaoSocial_textbox";
            this.softCttRazaoSocial_textbox.Size = new System.Drawing.Size(266, 20);
            this.softCttRazaoSocial_textbox.TabIndex = 23;
            // 
            // label162
            // 
            this.label162.AutoSize = true;
            this.label162.Location = new System.Drawing.Point(34, 30);
            this.label162.Name = "label162";
            this.label162.Size = new System.Drawing.Size(92, 13);
            this.label162.TabIndex = 12;
            this.label162.Text = "Nome do contato:";
            // 
            // label156
            // 
            this.label156.AutoSize = true;
            this.label156.Location = new System.Drawing.Point(35, 65);
            this.label156.Name = "label156";
            this.label156.Size = new System.Drawing.Size(70, 13);
            this.label156.TabIndex = 22;
            this.label156.Text = "Razão Social";
            // 
            // softCttNome_textbox
            // 
            this.softCttNome_textbox.Location = new System.Drawing.Point(159, 30);
            this.softCttNome_textbox.MaximumSize = new System.Drawing.Size(311, 20);
            this.softCttNome_textbox.MinimumSize = new System.Drawing.Size(266, 20);
            this.softCttNome_textbox.Name = "softCttNome_textbox";
            this.softCttNome_textbox.Size = new System.Drawing.Size(266, 20);
            this.softCttNome_textbox.TabIndex = 13;
            // 
            // softCttEmail_textbox
            // 
            this.softCttEmail_textbox.Location = new System.Drawing.Point(159, 153);
            this.softCttEmail_textbox.MaximumSize = new System.Drawing.Size(300, 20);
            this.softCttEmail_textbox.MinimumSize = new System.Drawing.Size(266, 20);
            this.softCttEmail_textbox.Name = "softCttEmail_textbox";
            this.softCttEmail_textbox.Size = new System.Drawing.Size(266, 20);
            this.softCttEmail_textbox.TabIndex = 21;
            // 
            // label161
            // 
            this.label161.AutoSize = true;
            this.label161.Location = new System.Drawing.Point(34, 98);
            this.label161.Name = "label161";
            this.label161.Size = new System.Drawing.Size(91, 13);
            this.label161.TabIndex = 14;
            this.label161.Text = "CNPJ do contato:";
            // 
            // label158
            // 
            this.label158.AutoSize = true;
            this.label158.Location = new System.Drawing.Point(35, 156);
            this.label158.Name = "label158";
            this.label158.Size = new System.Drawing.Size(35, 13);
            this.label158.TabIndex = 20;
            this.label158.Text = "Email:";
            // 
            // label160
            // 
            this.label160.AutoSize = true;
            this.label160.Location = new System.Drawing.Point(34, 129);
            this.label160.Name = "label160";
            this.label160.Size = new System.Drawing.Size(74, 13);
            this.label160.TabIndex = 16;
            this.label160.Text = "Telefone Fixo:";
            // 
            // SoftHouseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(550, 257);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.inf_softhouse_groupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SoftHouseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SoftHouseForm";
            this.inf_softhouse_groupBox.ResumeLayout(false);
            this.inf_softhouse_groupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.GroupBox inf_softhouse_groupBox;
        private System.Windows.Forms.MaskedTextBox softCttCNPJ_textbox;
        private System.Windows.Forms.MaskedTextBox softCttTelFixo_textbox;
        private System.Windows.Forms.TextBox softCttRazaoSocial_textbox;
        private System.Windows.Forms.Label label162;
        private System.Windows.Forms.Label label156;
        private System.Windows.Forms.TextBox softCttNome_textbox;
        private System.Windows.Forms.TextBox softCttEmail_textbox;
        private System.Windows.Forms.Label label161;
        private System.Windows.Forms.Label label158;
        private System.Windows.Forms.Label label160;
    }
}