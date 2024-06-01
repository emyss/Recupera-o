
namespace Recuperação
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
            this.btnIMC = new System.Windows.Forms.Button();
            this.btnFormas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnIMC
            // 
            this.btnIMC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnIMC.Font = new System.Drawing.Font("Sitka Small", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIMC.Location = new System.Drawing.Point(119, 204);
            this.btnIMC.Name = "btnIMC";
            this.btnIMC.Size = new System.Drawing.Size(125, 77);
            this.btnIMC.TabIndex = 0;
            this.btnIMC.Text = "Calcular IMC";
            this.btnIMC.UseVisualStyleBackColor = false;
            this.btnIMC.Click += new System.EventHandler(this.btnIMC_Click);
            // 
            // btnFormas
            // 
            this.btnFormas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnFormas.Font = new System.Drawing.Font("Sitka Small", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFormas.Location = new System.Drawing.Point(510, 204);
            this.btnFormas.Name = "btnFormas";
            this.btnFormas.Size = new System.Drawing.Size(127, 77);
            this.btnFormas.TabIndex = 1;
            this.btnFormas.Text = "Formas Geométricas";
            this.btnFormas.UseVisualStyleBackColor = false;
            this.btnFormas.Click += new System.EventHandler(this.btnFormas_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnFormas);
            this.Controls.Add(this.btnIMC);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnIMC;
        private System.Windows.Forms.Button btnFormas;
    }
}

