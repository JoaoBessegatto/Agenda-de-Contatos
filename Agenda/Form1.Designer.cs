namespace Agenda
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            button1 = new Button();
            btnRestaurar = new Button();
            btnNovo = new Button();
            button4 = new Button();
            lstAgenda = new ListBox();
            btnExportar = new Button();
            btnLimparContatos = new Button();
            btnImportar = new Button();
            cmbSexo = new ComboBox();
            txtNome = new TextBox();
            txtFone = new TextBox();
            btnmin = new Button();
            btnclose = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = SystemColors.ActiveCaption;
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(717, 85);
            label1.TabIndex = 0;
            label1.Text = "Agenda 2024";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(18, 102);
            label5.Name = "label5";
            label5.Size = new Size(40, 15);
            label5.TabIndex = 4;
            label5.Text = "Nome";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(18, 158);
            label6.Name = "label6";
            label6.Size = new Size(33, 15);
            label6.TabIndex = 5;
            label6.Text = "Fone";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(18, 202);
            label7.Name = "label7";
            label7.Size = new Size(32, 15);
            label7.TabIndex = 6;
            label7.Text = "Sexo";
            // 
            // button1
            // 
            button1.Location = new Point(18, 273);
            button1.Name = "button1";
            button1.Size = new Size(142, 65);
            button1.TabIndex = 3;
            button1.Text = "Adicionar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnRestaurar
            // 
            btnRestaurar.Location = new Point(166, 273);
            btnRestaurar.Name = "btnRestaurar";
            btnRestaurar.Size = new Size(142, 65);
            btnRestaurar.TabIndex = 4;
            btnRestaurar.Text = "Restaurar";
            btnRestaurar.UseVisualStyleBackColor = true;
            btnRestaurar.Click += btnRestaurar_Click;
            // 
            // btnNovo
            // 
            btnNovo.Location = new Point(18, 344);
            btnNovo.Name = "btnNovo";
            btnNovo.Size = new Size(142, 65);
            btnNovo.TabIndex = 5;
            btnNovo.Text = "Novo";
            btnNovo.UseVisualStyleBackColor = true;
            btnNovo.Click += btnNovo_Click;
            // 
            // button4
            // 
            button4.Location = new Point(166, 344);
            button4.Name = "button4";
            button4.Size = new Size(142, 65);
            button4.TabIndex = 6;
            button4.Text = "Excluir";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // lstAgenda
            // 
            lstAgenda.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lstAgenda.FormattingEnabled = true;
            lstAgenda.ItemHeight = 17;
            lstAgenda.Location = new Point(385, 94);
            lstAgenda.Name = "lstAgenda";
            lstAgenda.Size = new Size(333, 242);
            lstAgenda.TabIndex = 10;
            // 
            // btnExportar
            // 
            btnExportar.Location = new Point(438, 344);
            btnExportar.Name = "btnExportar";
            btnExportar.Size = new Size(136, 64);
            btnExportar.TabIndex = 8;
            btnExportar.Text = "Exportar";
            btnExportar.UseVisualStyleBackColor = true;
            btnExportar.Click += btnExportar_Click;
            // 
            // btnLimparContatos
            // 
            btnLimparContatos.Location = new Point(580, 343);
            btnLimparContatos.Name = "btnLimparContatos";
            btnLimparContatos.Size = new Size(137, 65);
            btnLimparContatos.TabIndex = 9;
            btnLimparContatos.Text = "Limpar Contatos";
            btnLimparContatos.UseVisualStyleBackColor = true;
            btnLimparContatos.Click += btnLimparContatos_Click;
            // 
            // btnImportar
            // 
            btnImportar.Location = new Point(314, 344);
            btnImportar.Name = "btnImportar";
            btnImportar.Size = new Size(118, 65);
            btnImportar.TabIndex = 7;
            btnImportar.Text = "Importar";
            btnImportar.UseVisualStyleBackColor = true;
            btnImportar.Click += btnImportar_Click;
            // 
            // cmbSexo
            // 
            cmbSexo.FormattingEnabled = true;
            cmbSexo.Items.AddRange(new object[] { "", "Masculino", "Feminino", "Outro" });
            cmbSexo.Location = new Point(21, 220);
            cmbSexo.Name = "cmbSexo";
            cmbSexo.Size = new Size(358, 23);
            cmbSexo.TabIndex = 2;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(18, 125);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(361, 23);
            txtNome.TabIndex = 0;
            // 
            // txtFone
            // 
            txtFone.Location = new Point(21, 176);
            txtFone.Name = "txtFone";
            txtFone.Size = new Size(358, 23);
            txtFone.TabIndex = 1;
            // 
            // btnmin
            // 
            btnmin.BackColor = Color.NavajoWhite;
            btnmin.Location = new Point(0, 62);
            btnmin.Name = "btnmin";
            btnmin.Size = new Size(75, 23);
            btnmin.TabIndex = 11;
            btnmin.Text = "Minimizar";
            btnmin.UseVisualStyleBackColor = false;
            btnmin.Click += btnmin_Click;
            // 
            // btnclose
            // 
            btnclose.BackColor = Color.IndianRed;
            btnclose.Location = new Point(85, 62);
            btnclose.Name = "btnclose";
            btnclose.Size = new Size(75, 23);
            btnclose.TabIndex = 12;
            btnclose.Text = "Fechar";
            btnclose.UseVisualStyleBackColor = false;
            btnclose.Click += btnclose_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(717, 420);
            Controls.Add(btnclose);
            Controls.Add(btnmin);
            Controls.Add(txtFone);
            Controls.Add(txtNome);
            Controls.Add(cmbSexo);
            Controls.Add(btnImportar);
            Controls.Add(btnLimparContatos);
            Controls.Add(btnExportar);
            Controls.Add(lstAgenda);
            Controls.Add(button4);
            Controls.Add(btnNovo);
            Controls.Add(btnRestaurar);
            Controls.Add(button1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button button1;
        private Button btnRestaurar;
        private Button btnNovo;
        private Button button4;
        private ListBox lstAgenda;
        private Button btnExportar;
        private Button btnLimparContatos;
        private Button btnImportar;
        private ComboBox cmbSexo;
        private TextBox txtNome;
        private TextBox txtFone;
        private Button btnmin;
        private Button btnclose;
    }
}