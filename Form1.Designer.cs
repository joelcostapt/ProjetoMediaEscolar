namespace ProjetoMediaEscolar
{
    partial class Form1
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
            this.nomeLabelMax = new System.Windows.Forms.Label();
            this.mediaButton = new System.Windows.Forms.Button();
            this.nota1TextBox = new System.Windows.Forms.TextBox();
            this.nota2TextBox = new System.Windows.Forms.TextBox();
            this.nota3TextBox = new System.Windows.Forms.TextBox();
            this.nota4TextBox = new System.Windows.Forms.TextBox();
            this.nota5TextBox = new System.Windows.Forms.TextBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.mediaLabel = new System.Windows.Forms.Label();
            this.mediaTextBox = new System.Windows.Forms.TextBox();
            this.nomeLabel = new System.Windows.Forms.Label();
            this.situacaoButton = new System.Windows.Forms.Button();
            this.labelWriteName = new System.Windows.Forms.Label();
            this.nomeLabelPut = new System.Windows.Forms.Label();
            this.nota5Label = new System.Windows.Forms.Label();
            this.nota4Label = new System.Windows.Forms.Label();
            this.nota3Label = new System.Windows.Forms.Label();
            this.nota2Label = new System.Windows.Forms.Label();
            this.nota1Label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nomeLabelMax
            // 
            this.nomeLabelMax.AutoSize = true;
            this.nomeLabelMax.Location = new System.Drawing.Point(44, 27);
            this.nomeLabelMax.Name = "nomeLabelMax";
            this.nomeLabelMax.Size = new System.Drawing.Size(0, 13);
            this.nomeLabelMax.TabIndex = 0;
            // 
            // mediaButton
            // 
            this.mediaButton.Location = new System.Drawing.Point(79, 232);
            this.mediaButton.Name = "mediaButton";
            this.mediaButton.Size = new System.Drawing.Size(106, 23);
            this.mediaButton.TabIndex = 6;
            this.mediaButton.Text = "Executar média";
            this.mediaButton.UseVisualStyleBackColor = true;
            this.mediaButton.Click += new System.EventHandler(this.mediaButton_Click);
            // 
            // nota1TextBox
            // 
            this.nota1TextBox.Location = new System.Drawing.Point(85, 79);
            this.nota1TextBox.Name = "nota1TextBox";
            this.nota1TextBox.Size = new System.Drawing.Size(100, 20);
            this.nota1TextBox.TabIndex = 7;
            // 
            // nota2TextBox
            // 
            this.nota2TextBox.Location = new System.Drawing.Point(85, 109);
            this.nota2TextBox.Name = "nota2TextBox";
            this.nota2TextBox.Size = new System.Drawing.Size(100, 20);
            this.nota2TextBox.TabIndex = 8;
            // 
            // nota3TextBox
            // 
            this.nota3TextBox.Location = new System.Drawing.Point(85, 137);
            this.nota3TextBox.Name = "nota3TextBox";
            this.nota3TextBox.Size = new System.Drawing.Size(100, 20);
            this.nota3TextBox.TabIndex = 9;
            // 
            // nota4TextBox
            // 
            this.nota4TextBox.Location = new System.Drawing.Point(85, 162);
            this.nota4TextBox.Name = "nota4TextBox";
            this.nota4TextBox.Size = new System.Drawing.Size(100, 20);
            this.nota4TextBox.TabIndex = 10;
            // 
            // nota5TextBox
            // 
            this.nota5TextBox.Location = new System.Drawing.Point(85, 189);
            this.nota5TextBox.Name = "nota5TextBox";
            this.nota5TextBox.Size = new System.Drawing.Size(100, 20);
            this.nota5TextBox.TabIndex = 11;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker.Location = new System.Drawing.Point(324, 27);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(81, 20);
            this.dateTimePicker.TabIndex = 12;
            // 
            // mediaLabel
            // 
            this.mediaLabel.AutoSize = true;
            this.mediaLabel.Location = new System.Drawing.Point(44, 282);
            this.mediaLabel.Name = "mediaLabel";
            this.mediaLabel.Size = new System.Drawing.Size(39, 13);
            this.mediaLabel.TabIndex = 13;
            this.mediaLabel.Text = "Média:";
            // 
            // mediaTextBox
            // 
            this.mediaTextBox.Location = new System.Drawing.Point(85, 279);
            this.mediaTextBox.Name = "mediaTextBox";
            this.mediaTextBox.ReadOnly = true;
            this.mediaTextBox.Size = new System.Drawing.Size(100, 20);
            this.mediaTextBox.TabIndex = 14;
            // 
            // nomeLabel
            // 
            this.nomeLabel.AutoSize = true;
            this.nomeLabel.Location = new System.Drawing.Point(89, 26);
            this.nomeLabel.Name = "nomeLabel";
            this.nomeLabel.Size = new System.Drawing.Size(0, 13);
            this.nomeLabel.TabIndex = 15;
            // 
            // situacaoButton
            // 
            this.situacaoButton.Location = new System.Drawing.Point(244, 231);
            this.situacaoButton.Name = "situacaoButton";
            this.situacaoButton.Size = new System.Drawing.Size(161, 23);
            this.situacaoButton.TabIndex = 16;
            this.situacaoButton.Text = "Situação";
            this.situacaoButton.UseVisualStyleBackColor = true;
            this.situacaoButton.Click += new System.EventHandler(this.situacaoButton_Click);
            // 
            // labelWriteName
            // 
            this.labelWriteName.AutoSize = true;
            this.labelWriteName.Location = new System.Drawing.Point(44, 33);
            this.labelWriteName.Name = "labelWriteName";
            this.labelWriteName.Size = new System.Drawing.Size(38, 13);
            this.labelWriteName.TabIndex = 17;
            this.labelWriteName.Text = "Nome:";
            // 
            // nomeLabelPut
            // 
            this.nomeLabelPut.AutoSize = true;
            this.nomeLabelPut.Location = new System.Drawing.Point(88, 34);
            this.nomeLabelPut.Name = "nomeLabelPut";
            this.nomeLabelPut.Size = new System.Drawing.Size(16, 13);
            this.nomeLabelPut.TabIndex = 18;
            this.nomeLabelPut.Text = "...";
            // 
            // nota5Label
            // 
            this.nota5Label.AutoSize = true;
            this.nota5Label.Location = new System.Drawing.Point(44, 196);
            this.nota5Label.Name = "nota5Label";
            this.nota5Label.Size = new System.Drawing.Size(42, 13);
            this.nota5Label.TabIndex = 19;
            this.nota5Label.Text = "Nota 5:";
            // 
            // nota4Label
            // 
            this.nota4Label.AutoSize = true;
            this.nota4Label.Location = new System.Drawing.Point(44, 169);
            this.nota4Label.Name = "nota4Label";
            this.nota4Label.Size = new System.Drawing.Size(42, 13);
            this.nota4Label.TabIndex = 20;
            this.nota4Label.Text = "Nota 4:";
            // 
            // nota3Label
            // 
            this.nota3Label.AutoSize = true;
            this.nota3Label.Location = new System.Drawing.Point(44, 144);
            this.nota3Label.Name = "nota3Label";
            this.nota3Label.Size = new System.Drawing.Size(42, 13);
            this.nota3Label.TabIndex = 21;
            this.nota3Label.Text = "Nota 3:";
            // 
            // nota2Label
            // 
            this.nota2Label.AutoSize = true;
            this.nota2Label.Location = new System.Drawing.Point(44, 116);
            this.nota2Label.Name = "nota2Label";
            this.nota2Label.Size = new System.Drawing.Size(42, 13);
            this.nota2Label.TabIndex = 22;
            this.nota2Label.Text = "Nota 2:";
            // 
            // nota1Label
            // 
            this.nota1Label.AutoSize = true;
            this.nota1Label.Location = new System.Drawing.Point(44, 86);
            this.nota1Label.Name = "nota1Label";
            this.nota1Label.Size = new System.Drawing.Size(42, 13);
            this.nota1Label.TabIndex = 23;
            this.nota1Label.Text = "Nota 1:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 372);
            this.Controls.Add(this.nota1Label);
            this.Controls.Add(this.nota2Label);
            this.Controls.Add(this.nota3Label);
            this.Controls.Add(this.nota4Label);
            this.Controls.Add(this.nota5Label);
            this.Controls.Add(this.nomeLabelPut);
            this.Controls.Add(this.labelWriteName);
            this.Controls.Add(this.situacaoButton);
            this.Controls.Add(this.nomeLabel);
            this.Controls.Add(this.mediaTextBox);
            this.Controls.Add(this.mediaLabel);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.nota5TextBox);
            this.Controls.Add(this.nota4TextBox);
            this.Controls.Add(this.nota3TextBox);
            this.Controls.Add(this.nota2TextBox);
            this.Controls.Add(this.nota1TextBox);
            this.Controls.Add(this.mediaButton);
            this.Controls.Add(this.nomeLabelMax);
            this.Name = "Form1";
            this.Text = "Média Escolar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nomeLabelMax;
        private System.Windows.Forms.Button mediaButton;
        private System.Windows.Forms.TextBox nota1TextBox;
        private System.Windows.Forms.TextBox nota2TextBox;
        private System.Windows.Forms.TextBox nota3TextBox;
        private System.Windows.Forms.TextBox nota4TextBox;
        private System.Windows.Forms.TextBox nota5TextBox;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label mediaLabel;
        private System.Windows.Forms.TextBox mediaTextBox;
        private System.Windows.Forms.Label nomeLabel;
        private System.Windows.Forms.Button situacaoButton;
        private System.Windows.Forms.Label labelWriteName;
        private System.Windows.Forms.Label nomeLabelPut;
        private System.Windows.Forms.Label nota5Label;
        private System.Windows.Forms.Label nota4Label;
        private System.Windows.Forms.Label nota3Label;
        private System.Windows.Forms.Label nota2Label;
        private System.Windows.Forms.Label nota1Label;
    }
}

