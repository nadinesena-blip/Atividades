namespace Dolar
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
            label2 = new Label();
            label3 = new Label();
            txtCotacao = new TextBox();
            txtDolares = new TextBox();
            btnConverter = new Button();
            txtResultado = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 37);
            label1.Name = "label1";
            label1.Size = new Size(122, 15);
            label1.TabIndex = 0;
            label1.Text = "Cotação do dólar(R$):";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(292, 37);
            label2.Name = "label2";
            label2.Size = new Size(161, 15);
            label2.TabIndex = 1;
            label2.Text = "Quantidade em dólares(US$):";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(163, 131);
            label3.Name = "label3";
            label3.Size = new Size(62, 15);
            label3.TabIndex = 2;
            label3.Text = "Resultado:";
            // 
            // txtCotacao
            // 
            txtCotacao.Location = new Point(156, 29);
            txtCotacao.Name = "txtCotacao";
            txtCotacao.Size = new Size(100, 23);
            txtCotacao.TabIndex = 3;
            // 
            // txtDolares
            // 
            txtDolares.Location = new Point(459, 29);
            txtDolares.Name = "txtDolares";
            txtDolares.Size = new Size(100, 23);
            txtDolares.TabIndex = 4;
            // 
            // btnConverter
            // 
            btnConverter.Location = new Point(249, 76);
            btnConverter.Name = "btnConverter";
            btnConverter.Size = new Size(75, 23);
            btnConverter.TabIndex = 5;
            btnConverter.Text = "Converter";
            btnConverter.UseVisualStyleBackColor = true;
            btnConverter.Click += btnConverter_Click;
            // 
            // txtResultado
            // 
            txtResultado.Location = new Point(249, 131);
            txtResultado.Name = "txtResultado";
            txtResultado.Size = new Size(100, 23);
            txtResultado.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(576, 450);
            Controls.Add(txtResultado);
            Controls.Add(btnConverter);
            Controls.Add(txtDolares);
            Controls.Add(txtCotacao);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtCotacao;
        private TextBox txtDolares;
        private Button btnConverter;
        private TextBox txtResultado;
    }
}
