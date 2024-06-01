
namespace Recuperação
{
    partial class FormasForm
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
            this.cbxForma = new System.Windows.Forms.ComboBox();
            this.lblP1 = new System.Windows.Forms.Label();
            this.lblP2 = new System.Windows.Forms.Label();
            this.lblP3 = new System.Windows.Forms.Label();
            this.lblP4 = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txtP1 = new System.Windows.Forms.TextBox();
            this.txtP2 = new System.Windows.Forms.TextBox();
            this.txtP3 = new System.Windows.Forms.TextBox();
            this.txtP4 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cbxForma
            // 
            this.cbxForma.FormattingEnabled = true;
            this.cbxForma.Location = new System.Drawing.Point(484, 12);
            this.cbxForma.Name = "cbxForma";
            this.cbxForma.Size = new System.Drawing.Size(304, 21);
            this.cbxForma.TabIndex = 0;
            // 
            // lblP1
            // 
            this.lblP1.AutoSize = true;
            this.lblP1.Location = new System.Drawing.Point(67, 77);
            this.lblP1.Name = "lblP1";
            this.lblP1.Size = new System.Drawing.Size(64, 13);
            this.lblP1.TabIndex = 1;
            this.lblP1.Text = "Parâmetro 1";
            // 
            // lblP2
            // 
            this.lblP2.AutoSize = true;
            this.lblP2.Location = new System.Drawing.Point(67, 116);
            this.lblP2.Name = "lblP2";
            this.lblP2.Size = new System.Drawing.Size(64, 13);
            this.lblP2.TabIndex = 2;
            this.lblP2.Text = "Parâmetro 2";
            // 
            // lblP3
            // 
            this.lblP3.AutoSize = true;
            this.lblP3.Location = new System.Drawing.Point(67, 162);
            this.lblP3.Name = "lblP3";
            this.lblP3.Size = new System.Drawing.Size(64, 13);
            this.lblP3.TabIndex = 3;
            this.lblP3.Text = "Parâmetro 3";
            // 
            // lblP4
            // 
            this.lblP4.AutoSize = true;
            this.lblP4.Location = new System.Drawing.Point(67, 200);
            this.lblP4.Name = "lblP4";
            this.lblP4.Size = new System.Drawing.Size(64, 13);
            this.lblP4.TabIndex = 4;
            this.lblP4.Text = "Parâmetro 4";
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(467, 349);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(76, 16);
            this.lblResultado.TabIndex = 5;
            this.lblResultado.Text = "Resultado:";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(333, 254);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(95, 42);
            this.btnCalcular.TabIndex = 6;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            // 
            // txtP1
            // 
            this.txtP1.Location = new System.Drawing.Point(172, 77);
            this.txtP1.Name = "txtP1";
            this.txtP1.Size = new System.Drawing.Size(100, 20);
            this.txtP1.TabIndex = 7;
            // 
            // txtP2
            // 
            this.txtP2.Location = new System.Drawing.Point(172, 116);
            this.txtP2.Name = "txtP2";
            this.txtP2.Size = new System.Drawing.Size(100, 20);
            this.txtP2.TabIndex = 8;
            // 
            // txtP3
            // 
            this.txtP3.Location = new System.Drawing.Point(172, 162);
            this.txtP3.Name = "txtP3";
            this.txtP3.Size = new System.Drawing.Size(100, 20);
            this.txtP3.TabIndex = 9;
            // 
            // txtP4
            // 
            this.txtP4.Location = new System.Drawing.Point(172, 200);
            this.txtP4.Name = "txtP4";
            this.txtP4.Size = new System.Drawing.Size(100, 20);
            this.txtP4.TabIndex = 10;
            // 
            // FormasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtP4);
            this.Controls.Add(this.txtP3);
            this.Controls.Add(this.txtP2);
            this.Controls.Add(this.txtP1);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.lblP4);
            this.Controls.Add(this.lblP3);
            this.Controls.Add(this.lblP2);
            this.Controls.Add(this.lblP1);
            this.Controls.Add(this.cbxForma);
            this.Name = "FormasForm";
            this.Text = "FormasForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxForma;
        private System.Windows.Forms.Label lblP1;
        private System.Windows.Forms.Label lblP2;
        private System.Windows.Forms.Label lblP3;
        private System.Windows.Forms.Label lblP4;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox txtP1;
        private System.Windows.Forms.TextBox txtP2;
        private System.Windows.Forms.TextBox txtP3;
        private System.Windows.Forms.TextBox txtP4;
    }
}