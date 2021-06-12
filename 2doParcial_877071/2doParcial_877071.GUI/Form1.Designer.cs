
namespace _2doParcial_877071.GUI
{
    partial class Form1
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
            this.lstPlazoFijo = new System.Windows.Forms.ListBox();
            this.tbMontoTotal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbComiTotal = new System.Windows.Forms.TextBox();
            this.cbTipoPlazoFijo = new System.Windows.Forms.ComboBox();
            this.tbTasaInt = new System.Windows.Forms.TextBox();
            this.tbCapAInvert = new System.Windows.Forms.TextBox();
            this.tbDias = new System.Windows.Forms.TextBox();
            this.tbIntARecib = new System.Windows.Forms.TextBox();
            this.tbMontoFinal = new System.Windows.Forms.TextBox();
            this.btnSimular = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnAtlta = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstPlazoFijo
            // 
            this.lstPlazoFijo.FormattingEnabled = true;
            this.lstPlazoFijo.Location = new System.Drawing.Point(465, 59);
            this.lstPlazoFijo.Name = "lstPlazoFijo";
            this.lstPlazoFijo.Size = new System.Drawing.Size(274, 225);
            this.lstPlazoFijo.TabIndex = 0;
            // 
            // tbMontoTotal
            // 
            this.tbMontoTotal.Enabled = false;
            this.tbMontoTotal.Location = new System.Drawing.Point(559, 312);
            this.tbMontoTotal.Name = "tbMontoTotal";
            this.tbMontoTotal.Size = new System.Drawing.Size(100, 20);
            this.tbMontoTotal.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(489, 312);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Monto total";
            // 
            // tbComiTotal
            // 
            this.tbComiTotal.Enabled = false;
            this.tbComiTotal.Location = new System.Drawing.Point(559, 353);
            this.tbComiTotal.Name = "tbComiTotal";
            this.tbComiTotal.Size = new System.Drawing.Size(100, 20);
            this.tbComiTotal.TabIndex = 3;
            // 
            // cbTipoPlazoFijo
            // 
            this.cbTipoPlazoFijo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoPlazoFijo.FormattingEnabled = true;
            this.cbTipoPlazoFijo.Location = new System.Drawing.Point(170, 43);
            this.cbTipoPlazoFijo.Name = "cbTipoPlazoFijo";
            this.cbTipoPlazoFijo.Size = new System.Drawing.Size(121, 21);
            this.cbTipoPlazoFijo.TabIndex = 4;
            this.cbTipoPlazoFijo.SelectedIndexChanged += new System.EventHandler(this.cbTipoPlazoFijo_SelectedIndexChanged);
            // 
            // tbTasaInt
            // 
            this.tbTasaInt.Enabled = false;
            this.tbTasaInt.Location = new System.Drawing.Point(170, 80);
            this.tbTasaInt.Name = "tbTasaInt";
            this.tbTasaInt.Size = new System.Drawing.Size(100, 20);
            this.tbTasaInt.TabIndex = 5;
            // 
            // tbCapAInvert
            // 
            this.tbCapAInvert.Location = new System.Drawing.Point(170, 117);
            this.tbCapAInvert.Name = "tbCapAInvert";
            this.tbCapAInvert.Size = new System.Drawing.Size(100, 20);
            this.tbCapAInvert.TabIndex = 6;
            // 
            // tbDias
            // 
            this.tbDias.Location = new System.Drawing.Point(170, 152);
            this.tbDias.Name = "tbDias";
            this.tbDias.Size = new System.Drawing.Size(100, 20);
            this.tbDias.TabIndex = 7;
            // 
            // tbIntARecib
            // 
            this.tbIntARecib.Enabled = false;
            this.tbIntARecib.Location = new System.Drawing.Point(170, 188);
            this.tbIntARecib.Name = "tbIntARecib";
            this.tbIntARecib.Size = new System.Drawing.Size(100, 20);
            this.tbIntARecib.TabIndex = 8;
            // 
            // tbMontoFinal
            // 
            this.tbMontoFinal.Enabled = false;
            this.tbMontoFinal.Location = new System.Drawing.Point(170, 223);
            this.tbMontoFinal.Name = "tbMontoFinal";
            this.tbMontoFinal.Size = new System.Drawing.Size(100, 20);
            this.tbMontoFinal.TabIndex = 9;
            // 
            // btnSimular
            // 
            this.btnSimular.Location = new System.Drawing.Point(79, 298);
            this.btnSimular.Name = "btnSimular";
            this.btnSimular.Size = new System.Drawing.Size(75, 23);
            this.btnSimular.TabIndex = 10;
            this.btnSimular.Text = "Simular";
            this.btnSimular.UseVisualStyleBackColor = true;
            this.btnSimular.Click += new System.EventHandler(this.btnSimular_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(195, 257);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 11;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnAtlta
            // 
            this.btnAtlta.Location = new System.Drawing.Point(79, 339);
            this.btnAtlta.Name = "btnAtlta";
            this.btnAtlta.Size = new System.Drawing.Size(176, 23);
            this.btnAtlta.TabIndex = 12;
            this.btnAtlta.Text = "Alta";
            this.btnAtlta.UseVisualStyleBackColor = true;
            this.btnAtlta.Click += new System.EventHandler(this.btnAtlta_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbMontoFinal);
            this.groupBox1.Controls.Add(this.btnLimpiar);
            this.groupBox1.Controls.Add(this.cbTipoPlazoFijo);
            this.groupBox1.Controls.Add(this.tbTasaInt);
            this.groupBox1.Controls.Add(this.tbCapAInvert);
            this.groupBox1.Controls.Add(this.tbIntARecib);
            this.groupBox1.Controls.Add(this.tbDias);
            this.groupBox1.Location = new System.Drawing.Point(47, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(308, 347);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Simulador";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(446, 41);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(308, 347);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Plazos fijos dados de alta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Tipo Plazo Fijo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Tasa interés";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(66, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Capital a invertir";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(66, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Dias";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(66, 191);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Interés a recibir";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(69, 223);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Monto final";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(43, 315);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Comisión";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAtlta);
            this.Controls.Add(this.btnSimular);
            this.Controls.Add(this.tbComiTotal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbMontoTotal);
            this.Controls.Add(this.lstPlazoFijo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstPlazoFijo;
        private System.Windows.Forms.TextBox tbMontoTotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbComiTotal;
        private System.Windows.Forms.ComboBox cbTipoPlazoFijo;
        private System.Windows.Forms.TextBox tbTasaInt;
        private System.Windows.Forms.TextBox tbCapAInvert;
        private System.Windows.Forms.TextBox tbDias;
        private System.Windows.Forms.TextBox tbIntARecib;
        private System.Windows.Forms.TextBox tbMontoFinal;
        private System.Windows.Forms.Button btnSimular;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnAtlta;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
    }
}

