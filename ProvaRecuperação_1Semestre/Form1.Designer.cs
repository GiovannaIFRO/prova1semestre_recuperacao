namespace ProvaRecuperação_1Semestre
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tx_datanasc = new System.Windows.Forms.TextBox();
            this.tx_data_profissao = new System.Windows.Forms.TextBox();
            this.tx_nome = new System.Windows.Forms.TextBox();
            this.cm_profissao = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.mask_cpf = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cm_sexo = new System.Windows.Forms.ComboBox();
            this.lb_pontos = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(21, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(22, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "idade:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(25, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "cpf:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(21, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(349, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "tempo de exercício da profissão(anos):";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(22, 280);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "profissão:";
            // 
            // tx_datanasc
            // 
            this.tx_datanasc.Location = new System.Drawing.Point(113, 90);
            this.tx_datanasc.Name = "tx_datanasc";
            this.tx_datanasc.Size = new System.Drawing.Size(125, 27);
            this.tx_datanasc.TabIndex = 5;
            // 
            // tx_data_profissao
            // 
            this.tx_data_profissao.Location = new System.Drawing.Point(376, 217);
            this.tx_data_profissao.Name = "tx_data_profissao";
            this.tx_data_profissao.Size = new System.Drawing.Size(125, 27);
            this.tx_data_profissao.TabIndex = 6;
            // 
            // tx_nome
            // 
            this.tx_nome.Location = new System.Drawing.Point(113, 30);
            this.tx_nome.Name = "tx_nome";
            this.tx_nome.Size = new System.Drawing.Size(617, 27);
            this.tx_nome.TabIndex = 8;
            // 
            // cm_profissao
            // 
            this.cm_profissao.FormattingEnabled = true;
            this.cm_profissao.Items.AddRange(new object[] {
            "saúde",
            "professor",
            "agente de segurança",
            "demais serviços"});
            this.cm_profissao.Location = new System.Drawing.Point(125, 280);
            this.cm_profissao.Name = "cm_profissao";
            this.cm_profissao.Size = new System.Drawing.Size(151, 28);
            this.cm_profissao.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(488, 363);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 36);
            this.button1.TabIndex = 10;
            this.button1.Text = "verificar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(658, 363);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(98, 36);
            this.button2.TabIndex = 11;
            this.button2.Text = "cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // mask_cpf
            // 
            this.mask_cpf.Location = new System.Drawing.Point(113, 154);
            this.mask_cpf.Mask = "000,000,000-00";
            this.mask_cpf.Name = "mask_cpf";
            this.mask_cpf.Size = new System.Drawing.Size(125, 27);
            this.mask_cpf.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(21, 341);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 25);
            this.label6.TabIndex = 13;
            this.label6.Text = "sexo:";
            // 
            // cm_sexo
            // 
            this.cm_sexo.FormattingEnabled = true;
            this.cm_sexo.Items.AddRange(new object[] {
            "feminino",
            "masculino"});
            this.cm_sexo.Location = new System.Drawing.Point(125, 338);
            this.cm_sexo.Name = "cm_sexo";
            this.cm_sexo.Size = new System.Drawing.Size(151, 28);
            this.cm_sexo.TabIndex = 14;
            // 
            // lb_pontos
            // 
            this.lb_pontos.AutoSize = true;
            this.lb_pontos.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_pontos.Location = new System.Drawing.Point(376, 317);
            this.lb_pontos.Name = "lb_pontos";
            this.lb_pontos.Size = new System.Drawing.Size(68, 23);
            this.lb_pontos.TabIndex = 15;
            this.lb_pontos.Text = " pontos";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lb_pontos);
            this.Controls.Add(this.cm_sexo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.mask_cpf);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cm_profissao);
            this.Controls.Add(this.tx_nome);
            this.Controls.Add(this.tx_data_profissao);
            this.Controls.Add(this.tx_datanasc);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Consultar Aposentadoria";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox tx_datanasc;
        private TextBox tx_data_profissao;
        private TextBox tx_nome;
        private ComboBox cm_profissao;
        private Button button1;
        private Button button2;
        private MaskedTextBox mask_cpf;
        private Label label6;
        private ComboBox cm_sexo;
        private Label lb_pontos;
    }
}