namespace Calculadora.WinForms
{
    partial class FormCaluladora
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
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel1 = new Panel();
            lblPrimeiroNumerador = new Label();
            txtPrimeiroNumerador = new TextBox();
            panel2 = new Panel();
            lblSegundoNumerador = new Label();
            txtSegundoNumerador = new TextBox();
            groupBox1 = new GroupBox();
            flowLayoutPanel2 = new FlowLayoutPanel();
            rdbAdicao = new RadioButton();
            rdbSubtracao = new RadioButton();
            rdbMultiplicacao = new RadioButton();
            rdbDivisao = new RadioButton();
            btnCalcular = new Button();
            btnLimpar = new Button();
            listBoxResultados = new ListBox();
            flowLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            groupBox1.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(panel1);
            flowLayoutPanel1.Controls.Add(panel2);
            flowLayoutPanel1.Controls.Add(groupBox1);
            flowLayoutPanel1.Controls.Add(btnCalcular);
            flowLayoutPanel1.Controls.Add(btnLimpar);
            flowLayoutPanel1.Controls.Add(listBoxResultados);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(335, 438);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(lblPrimeiroNumerador);
            panel1.Controls.Add(txtPrimeiroNumerador);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(326, 36);
            panel1.TabIndex = 2;
            // 
            // lblPrimeiroNumerador
            // 
            lblPrimeiroNumerador.AutoSize = true;
            lblPrimeiroNumerador.Location = new Point(15, 12);
            lblPrimeiroNumerador.Name = "lblPrimeiroNumerador";
            lblPrimeiroNumerador.Size = new Size(117, 15);
            lblPrimeiroNumerador.TabIndex = 0;
            lblPrimeiroNumerador.Text = "Primeiro númerador:";
            // 
            // txtPrimeiroNumerador
            // 
            txtPrimeiroNumerador.Location = new Point(157, 9);
            txtPrimeiroNumerador.Name = "txtPrimeiroNumerador";
            txtPrimeiroNumerador.Size = new Size(140, 23);
            txtPrimeiroNumerador.TabIndex = 1;
            txtPrimeiroNumerador.TextChanged += txtPrimeiroNumerador_TextChanged;
            // 
            // panel2
            // 
            panel2.Controls.Add(lblSegundoNumerador);
            panel2.Controls.Add(txtSegundoNumerador);
            panel2.Location = new Point(3, 45);
            panel2.Name = "panel2";
            panel2.Size = new Size(326, 33);
            panel2.TabIndex = 3;
            // 
            // lblSegundoNumerador
            // 
            lblSegundoNumerador.AutoSize = true;
            lblSegundoNumerador.Location = new Point(15, 6);
            lblSegundoNumerador.Name = "lblSegundoNumerador";
            lblSegundoNumerador.Size = new Size(119, 15);
            lblSegundoNumerador.TabIndex = 0;
            lblSegundoNumerador.Text = "Segundo númerador:";
            // 
            // txtSegundoNumerador
            // 
            txtSegundoNumerador.Location = new Point(157, 3);
            txtSegundoNumerador.Name = "txtSegundoNumerador";
            txtSegundoNumerador.Size = new Size(140, 23);
            txtSegundoNumerador.TabIndex = 1;
            txtSegundoNumerador.TextChanged += txtSegundoNumerador_TextChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(flowLayoutPanel2);
            groupBox1.Location = new Point(3, 84);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(326, 129);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Selecione a operação";
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(rdbAdicao);
            flowLayoutPanel2.Controls.Add(rdbSubtracao);
            flowLayoutPanel2.Controls.Add(rdbMultiplicacao);
            flowLayoutPanel2.Controls.Add(rdbDivisao);
            flowLayoutPanel2.Dock = DockStyle.Fill;
            flowLayoutPanel2.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel2.Location = new Point(3, 19);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(320, 107);
            flowLayoutPanel2.TabIndex = 0;
            // 
            // rdbdicaçõ
            // 
            rdbAdicao.AutoSize = true;
            rdbAdicao.Dock = DockStyle.Fill;
            rdbAdicao.Location = new Point(3, 3);
            rdbAdicao.Name = "rdbdicaçõ";
            rdbAdicao.Size = new Size(97, 19);
            rdbAdicao.TabIndex = 0;
            rdbAdicao.Text = "Adição";
            rdbAdicao.UseVisualStyleBackColor = true;
            rdbAdicao.CheckedChanged += rdbOperacao;
            // 
            // rdbSubtracao
            // 
            rdbSubtracao.AutoSize = true;
            rdbSubtracao.Dock = DockStyle.Fill;
            rdbSubtracao.Location = new Point(3, 28);
            rdbSubtracao.Name = "rdbSubtracao";
            rdbSubtracao.Size = new Size(97, 19);
            rdbSubtracao.TabIndex = 1;
            rdbSubtracao.Text = "Subtracao";
            rdbSubtracao.UseVisualStyleBackColor = true;
            rdbSubtracao.CheckedChanged += rdbOperacao;
            // 
            // rdbMultiplicacao
            // 
            rdbMultiplicacao.AutoSize = true;
            rdbMultiplicacao.Dock = DockStyle.Fill;
            rdbMultiplicacao.Location = new Point(3, 53);
            rdbMultiplicacao.Name = "rdbMultiplicacao";
            rdbMultiplicacao.Size = new Size(97, 19);
            rdbMultiplicacao.TabIndex = 2;
            rdbMultiplicacao.Text = "Multiplicação";
            rdbMultiplicacao.UseVisualStyleBackColor = true;
            rdbMultiplicacao.CheckedChanged += rdbOperacao;
            // 
            // rdbDivisao
            // 
            rdbDivisao.AutoSize = true;
            rdbDivisao.Dock = DockStyle.Fill;
            rdbDivisao.Location = new Point(3, 78);
            rdbDivisao.Name = "rdbDivisao";
            rdbDivisao.Size = new Size(97, 19);
            rdbDivisao.TabIndex = 3;
            rdbDivisao.Text = "Divisão";
            rdbDivisao.UseVisualStyleBackColor = true;
            rdbDivisao.CheckedChanged += rdbOperacao;
            // 
            // btnCalcular
            // 
            btnCalcular.Enabled = false;
            btnCalcular.Location = new Point(3, 219);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(323, 23);
            btnCalcular.TabIndex = 5;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // btnLimpar
            // 
            btnLimpar.Location = new Point(3, 248);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(323, 23);
            btnLimpar.TabIndex = 6;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = true;
            // 
            // listBoxResultados
            // 
            listBoxResultados.FormattingEnabled = true;
            listBoxResultados.ItemHeight = 15;
            listBoxResultados.Location = new Point(3, 277);
            listBoxResultados.Name = "listBoxResultados";
            listBoxResultados.Size = new Size(323, 154);
            listBoxResultados.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(335, 438);
            Controls.Add(flowLayoutPanel1);
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculadora Academia";
            flowLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            groupBox1.ResumeLayout(false);
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Label lblPrimeiroNumerador;
        private TextBox txtPrimeiroNumerador;
        private Panel panel1;
        private Panel panel2;
        private Label lblSegundoNumerador;
        private TextBox txtSegundoNumerador;
        private GroupBox groupBox1;
        private FlowLayoutPanel flowLayoutPanel2;
        private RadioButton rdbAdicao;
        private RadioButton rdbSubtracao;
        private RadioButton rdbMultiplicacao;
        private RadioButton rdbDivisao;
        private Button btnCalcular;
        private Button btnLimpar;
        private ListBox listBoxResultados;
    }
}
