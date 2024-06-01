
namespace Recuperação
{
    partial class IMCform
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
            this.rdbHomem = new System.Windows.Forms.RadioButton();
            this.rdbMulher = new System.Windows.Forms.RadioButton();
            this.lblAltura = new System.Windows.Forms.Label();
            this.lblPeso = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // rdbHomem
            // 
            this.rdbHomem.AutoSize = true;
            this.rdbHomem.Location = new System.Drawing.Point(151, 13);
            this.rdbHomem.Name = "rdbHomem";
            this.rdbHomem.Size = new System.Drawing.Size(61, 17);
            this.rdbHomem.TabIndex = 0;
            this.rdbHomem.TabStop = true;
            this.rdbHomem.Text = "Homem";
            this.rdbHomem.UseVisualStyleBackColor = true;
            // 
            // rdbMulher
            // 
            this.rdbMulher.AutoSize = true;
            this.rdbMulher.Location = new System.Drawing.Point(556, 24);
            this.rdbMulher.Name = "rdbMulher";
            this.rdbMulher.Size = new System.Drawing.Size(57, 17);
            this.rdbMulher.TabIndex = 1;
            this.rdbMulher.TabStop = true;
            this.rdbMulher.Text = "Mulher";
            this.rdbMulher.UseVisualStyleBackColor = true;
            // 
            // lblAltura
            // 
            this.lblAltura.AutoSize = true;
            this.lblAltura.Location = new System.Drawing.Point(81, 71);
            this.lblAltura.Name = "lblAltura";
            this.lblAltura.Size = new System.Drawing.Size(34, 13);
            this.lblAltura.TabIndex = 2;
            this.lblAltura.Text = "Altura";
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.Location = new System.Drawing.Point(81, 113);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(31, 13);
            this.lblPeso.TabIndex = 3;
            this.lblPeso.Text = "Peso";
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(553, 363);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(58, 13);
            this.lblResultado.TabIndex = 4;
            this.lblResultado.Text = "Resultado:";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(151, 352);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 5;
            this.btnCalcular.Text = "Calcula IMC";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // txtAltura
            // 
            this.txtAltura.Location = new System.Drawing.Point(151, 71);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(100, 20);
            this.txtAltura.TabIndex = 6;
            // 
            // txtPeso
            // 
            this.txtPeso.Location = new System.Drawing.Point(151, 106);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(100, 20);
            this.txtPeso.TabIndex = 7;
            // 
            // IMCform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtPeso);
            this.Controls.Add(this.txtAltura);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.lblPeso);
            this.Controls.Add(this.lblAltura);
            this.Controls.Add(this.rdbMulher);
            this.Controls.Add(this.rdbHomem);
            this.Name = "IMCform";
            this.Text = "IMCform";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdbHomem;
        private System.Windows.Forms.RadioButton rdbMulher;
        private System.Windows.Forms.Label lblAltura;
        private System.Windows.Forms.Label lblPeso;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox txtAltura;
        private System.Windows.Forms.TextBox txtPeso;
    }
}