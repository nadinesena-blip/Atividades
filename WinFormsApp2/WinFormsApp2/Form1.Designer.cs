namespace WinFormsApp2
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
            txtNumero = new TextBox();
            Gerar = new Button();
            Tabuada = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(44, 38);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 0;
            label1.Text = "Número:";
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(114, 30);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(100, 23);
            txtNumero.TabIndex = 1;
            txtNumero.TextChanged += txtNumero_TextChanged;
            // 
            // Gerar
            // 
            Gerar.Location = new Point(128, 80);
            Gerar.Name = "Gerar";
            Gerar.Size = new Size(75, 23);
            Gerar.TabIndex = 2;
            Gerar.Text = "Gerar";
            Gerar.UseVisualStyleBackColor = true;
            Gerar.Click += Gerar_Click;
            // 
            // Tabuada
            // 
            Tabuada.FormattingEnabled = true;
            Tabuada.ItemHeight = 15;
            Tabuada.Location = new Point(44, 126);
            Tabuada.Name = "Tabuada";
            Tabuada.Size = new Size(202, 154);
            Tabuada.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(398, 450);
            Controls.Add(Tabuada);
            Controls.Add(Gerar);
            Controls.Add(txtNumero);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNumero;
        private Button Gerar;
        private ListBox Tabuada;
    }
}
