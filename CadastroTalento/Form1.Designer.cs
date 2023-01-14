
namespace CadastroTalento
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.GroupBoxDados = new System.Windows.Forms.GroupBox();
            this.RadioButtonFeminino = new System.Windows.Forms.RadioButton();
            this.RadioButtonMasculino = new System.Windows.Forms.RadioButton();
            this.lblSexo = new System.Windows.Forms.Label();
            this.MaskedTextBoxRg = new System.Windows.Forms.MaskedTextBox();
            this.lblRg = new System.Windows.Forms.Label();
            this.MaskedTextBoxCpf = new System.Windows.Forms.MaskedTextBox();
            this.lblCpf = new System.Windows.Forms.Label();
            this.dateTimePickerNascimento = new System.Windows.Forms.DateTimePicker();
            this.lblDataNascimento = new System.Windows.Forms.Label();
            this.TextBoxNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.GroupBoxInformacao = new System.Windows.Forms.GroupBox();
            this.CheckBoxTodos = new System.Windows.Forms.CheckBox();
            this.CheckBoxItaliano = new System.Windows.Forms.CheckBox();
            this.CheckBoxEspanhol = new System.Windows.Forms.CheckBox();
            this.CheckBoxIngles = new System.Windows.Forms.CheckBox();
            this.checkListBoxInfo = new System.Windows.Forms.CheckedListBox();
            this.lblIdioma = new System.Windows.Forms.Label();
            this.ComboBoxFormacao = new System.Windows.Forms.ComboBox();
            this.lblFormacao = new System.Windows.Forms.Label();
            this.GroupBoxObservacao = new System.Windows.Forms.GroupBox();
            this.TextBoxMesagem = new System.Windows.Forms.TextBox();
            this.lblMensagem = new System.Windows.Forms.Label();
            this.MonthCalendarData = new System.Windows.Forms.MonthCalendar();
            this.lblData = new System.Windows.Forms.Label();
            this.listViewDados = new System.Windows.Forms.ListView();
            this.clNome = new System.Windows.Forms.ColumnHeader();
            this.clData = new System.Windows.Forms.ColumnHeader();
            this.clCpf = new System.Windows.Forms.ColumnHeader();
            this.Rg = new System.Windows.Forms.ColumnHeader();
            this.clSexo = new System.Windows.Forms.ColumnHeader();
            this.clFormacao = new System.Windows.Forms.ColumnHeader();
            this.clIdioma = new System.Windows.Forms.ColumnHeader();
            this.clInformacao = new System.Windows.Forms.ColumnHeader();
            this.BtnGravar = new System.Windows.Forms.Button();
            this.BtnAltera = new System.Windows.Forms.Button();
            this.BtnExcluir = new System.Windows.Forms.Button();
            this.BtnSair = new System.Windows.Forms.Button();
            this.GroupBoxDados.SuspendLayout();
            this.GroupBoxInformacao.SuspendLayout();
            this.GroupBoxObservacao.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.Location = new System.Drawing.Point(256, 27);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(286, 40);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Cadastro de Talentos";
            // 
            // GroupBoxDados
            // 
            this.GroupBoxDados.Controls.Add(this.RadioButtonFeminino);
            this.GroupBoxDados.Controls.Add(this.RadioButtonMasculino);
            this.GroupBoxDados.Controls.Add(this.lblSexo);
            this.GroupBoxDados.Controls.Add(this.MaskedTextBoxRg);
            this.GroupBoxDados.Controls.Add(this.lblRg);
            this.GroupBoxDados.Controls.Add(this.MaskedTextBoxCpf);
            this.GroupBoxDados.Controls.Add(this.lblCpf);
            this.GroupBoxDados.Controls.Add(this.dateTimePickerNascimento);
            this.GroupBoxDados.Controls.Add(this.lblDataNascimento);
            this.GroupBoxDados.Controls.Add(this.TextBoxNome);
            this.GroupBoxDados.Controls.Add(this.lblNome);
            this.GroupBoxDados.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.GroupBoxDados.Location = new System.Drawing.Point(31, 93);
            this.GroupBoxDados.Name = "GroupBoxDados";
            this.GroupBoxDados.Size = new System.Drawing.Size(738, 115);
            this.GroupBoxDados.TabIndex = 1;
            this.GroupBoxDados.TabStop = false;
            this.GroupBoxDados.Text = "Dados Cadastrais:";
            // 
            // RadioButtonFeminino
            // 
            this.RadioButtonFeminino.AutoSize = true;
            this.RadioButtonFeminino.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RadioButtonFeminino.Location = new System.Drawing.Point(637, 83);
            this.RadioButtonFeminino.Name = "RadioButtonFeminino";
            this.RadioButtonFeminino.Size = new System.Drawing.Size(88, 24);
            this.RadioButtonFeminino.TabIndex = 10;
            this.RadioButtonFeminino.TabStop = true;
            this.RadioButtonFeminino.Text = "Feminino";
            this.RadioButtonFeminino.UseVisualStyleBackColor = true;
            this.RadioButtonFeminino.CheckedChanged += new System.EventHandler(this.RadioButtonFeminino_CheckedChanged);
            // 
            // RadioButtonMasculino
            // 
            this.RadioButtonMasculino.AutoSize = true;
            this.RadioButtonMasculino.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RadioButtonMasculino.Location = new System.Drawing.Point(535, 82);
            this.RadioButtonMasculino.Name = "RadioButtonMasculino";
            this.RadioButtonMasculino.Size = new System.Drawing.Size(94, 24);
            this.RadioButtonMasculino.TabIndex = 9;
            this.RadioButtonMasculino.TabStop = true;
            this.RadioButtonMasculino.Text = "Masculino";
            this.RadioButtonMasculino.UseVisualStyleBackColor = true;
            this.RadioButtonMasculino.CheckedChanged += new System.EventHandler(this.RadioButtonMasculino_CheckedChanged);
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSexo.Location = new System.Drawing.Point(485, 83);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(44, 20);
            this.lblSexo.TabIndex = 8;
            this.lblSexo.Text = "Sexo:";
            // 
            // MaskedTextBoxRg
            // 
            this.MaskedTextBoxRg.Location = new System.Drawing.Point(286, 81);
            this.MaskedTextBoxRg.Mask = "00.000.000-0";
            this.MaskedTextBoxRg.Name = "MaskedTextBoxRg";
            this.MaskedTextBoxRg.Size = new System.Drawing.Size(171, 27);
            this.MaskedTextBoxRg.TabIndex = 7;
            // 
            // lblRg
            // 
            this.lblRg.AutoSize = true;
            this.lblRg.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblRg.Location = new System.Drawing.Point(249, 83);
            this.lblRg.Name = "lblRg";
            this.lblRg.Size = new System.Drawing.Size(30, 20);
            this.lblRg.TabIndex = 6;
            this.lblRg.Text = "Rg:";
            // 
            // MaskedTextBoxCpf
            // 
            this.MaskedTextBoxCpf.Location = new System.Drawing.Point(71, 81);
            this.MaskedTextBoxCpf.Mask = "000.000.000-00";
            this.MaskedTextBoxCpf.Name = "MaskedTextBoxCpf";
            this.MaskedTextBoxCpf.Size = new System.Drawing.Size(171, 27);
            this.MaskedTextBoxCpf.TabIndex = 5;
            // 
            // lblCpf
            // 
            this.lblCpf.AutoSize = true;
            this.lblCpf.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCpf.Location = new System.Drawing.Point(30, 83);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(35, 20);
            this.lblCpf.TabIndex = 4;
            this.lblCpf.Text = "Cpf:";
            // 
            // dateTimePickerNascimento
            // 
            this.dateTimePickerNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerNascimento.Location = new System.Drawing.Point(607, 35);
            this.dateTimePickerNascimento.Name = "dateTimePickerNascimento";
            this.dateTimePickerNascimento.Size = new System.Drawing.Size(115, 27);
            this.dateTimePickerNascimento.TabIndex = 3;
            // 
            // lblDataNascimento
            // 
            this.lblDataNascimento.AutoSize = true;
            this.lblDataNascimento.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDataNascimento.Location = new System.Drawing.Point(485, 40);
            this.lblDataNascimento.Name = "lblDataNascimento";
            this.lblDataNascimento.Size = new System.Drawing.Size(109, 20);
            this.lblDataNascimento.TabIndex = 2;
            this.lblDataNascimento.Text = "Data  de Nasci:";
            // 
            // TextBoxNome
            // 
            this.TextBoxNome.Location = new System.Drawing.Point(70, 39);
            this.TextBoxNome.Name = "TextBoxNome";
            this.TextBoxNome.Size = new System.Drawing.Size(387, 27);
            this.TextBoxNome.TabIndex = 1;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNome.Location = new System.Drawing.Point(12, 42);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(53, 20);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome:";
            // 
            // GroupBoxInformacao
            // 
            this.GroupBoxInformacao.Controls.Add(this.CheckBoxTodos);
            this.GroupBoxInformacao.Controls.Add(this.CheckBoxItaliano);
            this.GroupBoxInformacao.Controls.Add(this.CheckBoxEspanhol);
            this.GroupBoxInformacao.Controls.Add(this.CheckBoxIngles);
            this.GroupBoxInformacao.Controls.Add(this.checkListBoxInfo);
            this.GroupBoxInformacao.Controls.Add(this.lblIdioma);
            this.GroupBoxInformacao.Controls.Add(this.ComboBoxFormacao);
            this.GroupBoxInformacao.Controls.Add(this.lblFormacao);
            this.GroupBoxInformacao.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.GroupBoxInformacao.Location = new System.Drawing.Point(31, 211);
            this.GroupBoxInformacao.Name = "GroupBoxInformacao";
            this.GroupBoxInformacao.Size = new System.Drawing.Size(738, 113);
            this.GroupBoxInformacao.TabIndex = 2;
            this.GroupBoxInformacao.TabStop = false;
            this.GroupBoxInformacao.Text = "Informações Acadêmicas:";
            // 
            // CheckBoxTodos
            // 
            this.CheckBoxTodos.AutoSize = true;
            this.CheckBoxTodos.Location = new System.Drawing.Point(605, 12);
            this.CheckBoxTodos.Name = "CheckBoxTodos";
            this.CheckBoxTodos.Size = new System.Drawing.Size(69, 24);
            this.CheckBoxTodos.TabIndex = 10;
            this.CheckBoxTodos.Text = "Todos";
            this.CheckBoxTodos.UseVisualStyleBackColor = true;
            this.CheckBoxTodos.CheckedChanged += new System.EventHandler(this.CheckBoxTodos_CheckedChanged);
            // 
            // CheckBoxItaliano
            // 
            this.CheckBoxItaliano.AutoSize = true;
            this.CheckBoxItaliano.Location = new System.Drawing.Point(386, 85);
            this.CheckBoxItaliano.Name = "CheckBoxItaliano";
            this.CheckBoxItaliano.Size = new System.Drawing.Size(78, 24);
            this.CheckBoxItaliano.TabIndex = 9;
            this.CheckBoxItaliano.Text = "Italiano";
            this.CheckBoxItaliano.UseVisualStyleBackColor = true;
            this.CheckBoxItaliano.CheckedChanged += new System.EventHandler(this.CheckBoxItaliano_CheckedChanged);
            // 
            // CheckBoxEspanhol
            // 
            this.CheckBoxEspanhol.AutoSize = true;
            this.CheckBoxEspanhol.Location = new System.Drawing.Point(386, 52);
            this.CheckBoxEspanhol.Name = "CheckBoxEspanhol";
            this.CheckBoxEspanhol.Size = new System.Drawing.Size(88, 24);
            this.CheckBoxEspanhol.TabIndex = 8;
            this.CheckBoxEspanhol.Text = "Espanhõl";
            this.CheckBoxEspanhol.UseVisualStyleBackColor = true;
            this.CheckBoxEspanhol.CheckedChanged += new System.EventHandler(this.CheckBoxEspanhol_CheckedChanged);
            // 
            // CheckBoxIngles
            // 
            this.CheckBoxIngles.AutoSize = true;
            this.CheckBoxIngles.Location = new System.Drawing.Point(386, 25);
            this.CheckBoxIngles.Name = "CheckBoxIngles";
            this.CheckBoxIngles.Size = new System.Drawing.Size(67, 24);
            this.CheckBoxIngles.TabIndex = 7;
            this.CheckBoxIngles.Text = "Inglês";
            this.CheckBoxIngles.UseVisualStyleBackColor = true;
            this.CheckBoxIngles.CheckedChanged += new System.EventHandler(this.CheckBoxIngles_CheckedChanged);
            // 
            // checkListBoxInfo
            // 
            this.checkListBoxInfo.FormattingEnabled = true;
            this.checkListBoxInfo.Items.AddRange(new object[] {
            "Windows",
            "SqlServer",
            "C#",
            "Java",
            "JavaScript",
            "Hmtl5",
            "Css",
            "Analise de Sistema",
            "Manutenção de Micros",
            "Redes",
            "Infra-estrutura",
            "Android"});
            this.checkListBoxInfo.Location = new System.Drawing.Point(605, 39);
            this.checkListBoxInfo.Name = "checkListBoxInfo";
            this.checkListBoxInfo.Size = new System.Drawing.Size(120, 70);
            this.checkListBoxInfo.TabIndex = 6;
            // 
            // lblIdioma
            // 
            this.lblIdioma.AutoSize = true;
            this.lblIdioma.Location = new System.Drawing.Point(289, 56);
            this.lblIdioma.Name = "lblIdioma";
            this.lblIdioma.Size = new System.Drawing.Size(59, 20);
            this.lblIdioma.TabIndex = 2;
            this.lblIdioma.Text = "Idioma:";
            // 
            // ComboBoxFormacao
            // 
            this.ComboBoxFormacao.FormattingEnabled = true;
            this.ComboBoxFormacao.Items.AddRange(new object[] {
            "Ensino Médio",
            "Médio Técnico",
            "Ensino Técnico",
            "Gradução ",
            "Pós-Gradução",
            "Doutorado",
            "Mestrado"});
            this.ComboBoxFormacao.Location = new System.Drawing.Point(109, 53);
            this.ComboBoxFormacao.Name = "ComboBoxFormacao";
            this.ComboBoxFormacao.Size = new System.Drawing.Size(174, 28);
            this.ComboBoxFormacao.TabIndex = 1;
            // 
            // lblFormacao
            // 
            this.lblFormacao.AutoSize = true;
            this.lblFormacao.Location = new System.Drawing.Point(14, 56);
            this.lblFormacao.Name = "lblFormacao";
            this.lblFormacao.Size = new System.Drawing.Size(78, 20);
            this.lblFormacao.TabIndex = 0;
            this.lblFormacao.Text = "Formação:";
            // 
            // GroupBoxObservacao
            // 
            this.GroupBoxObservacao.Controls.Add(this.TextBoxMesagem);
            this.GroupBoxObservacao.Controls.Add(this.lblMensagem);
            this.GroupBoxObservacao.Controls.Add(this.MonthCalendarData);
            this.GroupBoxObservacao.Controls.Add(this.lblData);
            this.GroupBoxObservacao.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.GroupBoxObservacao.Location = new System.Drawing.Point(31, 324);
            this.GroupBoxObservacao.Name = "GroupBoxObservacao";
            this.GroupBoxObservacao.Size = new System.Drawing.Size(738, 196);
            this.GroupBoxObservacao.TabIndex = 3;
            this.GroupBoxObservacao.TabStop = false;
            this.GroupBoxObservacao.Text = "Observações:";
            // 
            // TextBoxMesagem
            // 
            this.TextBoxMesagem.Location = new System.Drawing.Point(503, 29);
            this.TextBoxMesagem.Multiline = true;
            this.TextBoxMesagem.Name = "TextBoxMesagem";
            this.TextBoxMesagem.Size = new System.Drawing.Size(227, 155);
            this.TextBoxMesagem.TabIndex = 3;
            // 
            // lblMensagem
            // 
            this.lblMensagem.AutoSize = true;
            this.lblMensagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMensagem.Location = new System.Drawing.Point(399, 85);
            this.lblMensagem.Name = "lblMensagem";
            this.lblMensagem.Size = new System.Drawing.Size(86, 18);
            this.lblMensagem.TabIndex = 2;
            this.lblMensagem.Text = "Mensagem:";
            // 
            // MonthCalendarData
            // 
            this.MonthCalendarData.Location = new System.Drawing.Point(158, 22);
            this.MonthCalendarData.Name = "MonthCalendarData";
            this.MonthCalendarData.TabIndex = 1;
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblData.Location = new System.Drawing.Point(11, 86);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(141, 18);
            this.lblData.TabIndex = 0;
            this.lblData.Text = "Data da Messagem:";
            // 
            // listViewDados
            // 
            this.listViewDados.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clNome,
            this.clData,
            this.clCpf,
            this.Rg,
            this.clSexo,
            this.clFormacao,
            this.clIdioma,
            this.clInformacao});
            this.listViewDados.FullRowSelect = true;
            this.listViewDados.GridLines = true;
            this.listViewDados.HideSelection = false;
            this.listViewDados.Location = new System.Drawing.Point(31, 523);
            this.listViewDados.Name = "listViewDados";
            this.listViewDados.Size = new System.Drawing.Size(738, 97);
            this.listViewDados.TabIndex = 4;
            this.listViewDados.UseCompatibleStateImageBehavior = false;
            this.listViewDados.View = System.Windows.Forms.View.Details;
            this.listViewDados.SelectedIndexChanged += new System.EventHandler(this.listViewDados_SelectedIndexChanged);
            // 
            // clNome
            // 
            this.clNome.Text = "Nome";
            this.clNome.Width = 170;
            // 
            // clData
            // 
            this.clData.Text = "Data";
            this.clData.Width = 80;
            // 
            // clCpf
            // 
            this.clCpf.Text = "Cpf";
            this.clCpf.Width = 90;
            // 
            // Rg
            // 
            this.Rg.Text = "Rg";
            this.Rg.Width = 90;
            // 
            // clSexo
            // 
            this.clSexo.Text = "Sexo";
            this.clSexo.Width = 50;
            // 
            // clFormacao
            // 
            this.clFormacao.Text = "Formação";
            this.clFormacao.Width = 110;
            // 
            // clIdioma
            // 
            this.clIdioma.Text = "Idioma";
            // 
            // clInformacao
            // 
            this.clInformacao.Text = "Informática";
            this.clInformacao.Width = 82;
            // 
            // BtnGravar
            // 
            this.BtnGravar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnGravar.Location = new System.Drawing.Point(80, 635);
            this.BtnGravar.Name = "BtnGravar";
            this.BtnGravar.Size = new System.Drawing.Size(121, 32);
            this.BtnGravar.TabIndex = 5;
            this.BtnGravar.Text = "Gravar";
            this.BtnGravar.UseVisualStyleBackColor = true;
            this.BtnGravar.Click += new System.EventHandler(this.BtnGravar_Click);
            // 
            // BtnAltera
            // 
            this.BtnAltera.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnAltera.Location = new System.Drawing.Point(258, 634);
            this.BtnAltera.Name = "BtnAltera";
            this.BtnAltera.Size = new System.Drawing.Size(121, 32);
            this.BtnAltera.TabIndex = 6;
            this.BtnAltera.Text = "Alterar";
            this.BtnAltera.UseVisualStyleBackColor = true;
            this.BtnAltera.Click += new System.EventHandler(this.BtnAltera_Click);
            // 
            // BtnExcluir
            // 
            this.BtnExcluir.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnExcluir.Location = new System.Drawing.Point(421, 634);
            this.BtnExcluir.Name = "BtnExcluir";
            this.BtnExcluir.Size = new System.Drawing.Size(121, 32);
            this.BtnExcluir.TabIndex = 7;
            this.BtnExcluir.Text = "Excluir";
            this.BtnExcluir.UseVisualStyleBackColor = true;
            this.BtnExcluir.Click += new System.EventHandler(this.BtnExcluir_Click);
            // 
            // BtnSair
            // 
            this.BtnSair.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnSair.Location = new System.Drawing.Point(584, 635);
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.Size = new System.Drawing.Size(121, 32);
            this.BtnSair.TabIndex = 8;
            this.BtnSair.Text = "Sair";
            this.BtnSair.UseVisualStyleBackColor = true;
            this.BtnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(800, 680);
            this.Controls.Add(this.BtnSair);
            this.Controls.Add(this.BtnExcluir);
            this.Controls.Add(this.BtnAltera);
            this.Controls.Add(this.BtnGravar);
            this.Controls.Add(this.listViewDados);
            this.Controls.Add(this.GroupBoxObservacao);
            this.Controls.Add(this.GroupBoxInformacao);
            this.Controls.Add(this.GroupBoxDados);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Talentos";
            this.GroupBoxDados.ResumeLayout(false);
            this.GroupBoxDados.PerformLayout();
            this.GroupBoxInformacao.ResumeLayout(false);
            this.GroupBoxInformacao.PerformLayout();
            this.GroupBoxObservacao.ResumeLayout(false);
            this.GroupBoxObservacao.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.GroupBox GroupBoxDados;
        private System.Windows.Forms.RadioButton RadioButtonFeminino;
        private System.Windows.Forms.RadioButton RadioButtonMasculino;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.MaskedTextBox MaskedTextBoxRg;
        private System.Windows.Forms.Label lblRg;
        private System.Windows.Forms.MaskedTextBox MaskedTextBoxCpf;
        private System.Windows.Forms.Label lblCpf;
        private System.Windows.Forms.DateTimePicker dateTimePickerNascimento;
        private System.Windows.Forms.Label lblDataNascimento;
        private System.Windows.Forms.TextBox TextBoxNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.GroupBox GroupBoxInformacao;
        private System.Windows.Forms.CheckBox CheckBoxItaliano;
        private System.Windows.Forms.CheckBox CheckBoxEspanhol;
        private System.Windows.Forms.CheckBox CheckBoxIngles;
        private System.Windows.Forms.CheckedListBox checkListBoxInfo;
        private System.Windows.Forms.Label lblIdioma;
        private System.Windows.Forms.ComboBox ComboBoxFormacao;
        private System.Windows.Forms.Label lblFormacao;
        private System.Windows.Forms.CheckBox CheckBoxTodos;
        private System.Windows.Forms.GroupBox GroupBoxObservacao;
        private System.Windows.Forms.Label lblMensagem;
        private System.Windows.Forms.MonthCalendar MonthCalendarData;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.TextBox TextBoxMesagem;
        private System.Windows.Forms.ListView listViewDados;
        private System.Windows.Forms.ColumnHeader clNome;
        private System.Windows.Forms.ColumnHeader clData;
        private System.Windows.Forms.ColumnHeader clCpf;
        private System.Windows.Forms.ColumnHeader Rg;
        private System.Windows.Forms.ColumnHeader clSexo;
        private System.Windows.Forms.ColumnHeader clFormacao;
        private System.Windows.Forms.ColumnHeader clIdioma;
        private System.Windows.Forms.ColumnHeader clInformacao;
        private System.Windows.Forms.Button BtnGravar;
        private System.Windows.Forms.Button BtnAltera;
        private System.Windows.Forms.Button BtnExcluir;
        private System.Windows.Forms.Button BtnSair;
    }
}

