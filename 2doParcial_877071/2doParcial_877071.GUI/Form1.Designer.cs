
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
            this.cbTipoPlazoFijo.FormattingEnabled = true;
            this.cbTipoPlazoFijo.Location = new System.Drawing.Point(79, 69);
            this.cbTipoPlazoFijo.Name = "cbTipoPlazoFijo";
            this.cbTipoPlazoFijo.Size = new System.Drawing.Size(121, 21);
            this.cbTipoPlazoFijo.TabIndex = 4;
            // 
            // tbTasaInt
            // 
            this.tbTasaInt.Location = new System.Drawing.Point(79, 106);
            this.tbTasaInt.Name = "tbTasaInt";
            this.tbTasaInt.Size = new System.Drawing.Size(100, 20);
            this.tbTasaInt.TabIndex = 5;
            // 
            // tbCapAInvert
            // 
            this.tbCapAInvert.Location = new System.Drawing.Point(79, 143);
            this.tbCapAInvert.Name = "tbCapAInvert";
            this.tbCapAInvert.Size = new System.Drawing.Size(100, 20);
            this.tbCapAInvert.TabIndex = 6;
            // 
            // tbDias
            // 
            this.tbDias.Location = new System.Drawing.Point(79, 178);
            this.tbDias.Name = "tbDias";
            this.tbDias.Size = new System.Drawing.Size(100, 20);
            this.tbDias.TabIndex = 7;
            // 
            // tbIntARecib
            // 
            this.tbIntARecib.Location = new System.Drawing.Point(79, 214);
            this.tbIntARecib.Name = "tbIntARecib";
            this.tbIntARecib.Size = new System.Drawing.Size(100, 20);
            this.tbIntARecib.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbIntARecib);
            this.Controls.Add(this.tbDias);
            this.Controls.Add(this.tbCapAInvert);
            this.Controls.Add(this.tbTasaInt);
            this.Controls.Add(this.cbTipoPlazoFijo);
            this.Controls.Add(this.tbComiTotal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbMontoTotal);
            this.Controls.Add(this.lstPlazoFijo);
            this.Name = "Form1";
            this.Text = "Form1";
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
    }
}

