namespace ejercicioTelegrama
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCalcularPrecioEMM2425 = new System.Windows.Forms.Button();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTelegrama = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rBtnOrdinario = new System.Windows.Forms.RadioButton();
            this.rBtnUrgente = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // btnCalcularPrecioEMM2425
            // 
            this.btnCalcularPrecioEMM2425.Location = new System.Drawing.Point(244, 202);
            this.btnCalcularPrecioEMM2425.Name = "btnCalcularPrecioEMM2425";
            this.btnCalcularPrecioEMM2425.Size = new System.Drawing.Size(131, 56);
            this.btnCalcularPrecioEMM2425.TabIndex = 12;
            this.btnCalcularPrecioEMM2425.Text = "Calcular";
            this.btnCalcularPrecioEMM2425.UseVisualStyleBackColor = true;
            this.btnCalcularPrecioEMM2425.Click += new System.EventHandler(this.btnCalcularPrecioEMM2425_Click);
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(90, 220);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(100, 20);
            this.txtPrecio.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 224);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Coste:";
            // 
            // txtTelegrama
            // 
            this.txtTelegrama.Location = new System.Drawing.Point(36, 48);
            this.txtTelegrama.Multiline = true;
            this.txtTelegrama.Name = "txtTelegrama";
            this.txtTelegrama.Size = new System.Drawing.Size(339, 118);
            this.txtTelegrama.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Texto";
            // 
            // rBtnOrdinario
            // 
            this.rBtnOrdinario.AutoSize = true;
            this.rBtnOrdinario.Checked = true;
            this.rBtnOrdinario.Location = new System.Drawing.Point(36, 186);
            this.rBtnOrdinario.Name = "rBtnOrdinario";
            this.rBtnOrdinario.Size = new System.Drawing.Size(67, 17);
            this.rBtnOrdinario.TabIndex = 13;
            this.rBtnOrdinario.TabStop = true;
            this.rBtnOrdinario.Text = "Ordinario";
            this.rBtnOrdinario.UseVisualStyleBackColor = true;
            // 
            // rBtnUrgente
            // 
            this.rBtnUrgente.AutoSize = true;
            this.rBtnUrgente.Location = new System.Drawing.Point(109, 186);
            this.rBtnUrgente.Name = "rBtnUrgente";
            this.rBtnUrgente.Size = new System.Drawing.Size(63, 17);
            this.rBtnUrgente.TabIndex = 14;
            this.rBtnUrgente.TabStop = true;
            this.rBtnUrgente.Text = "Urgente";
            this.rBtnUrgente.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 325);
            this.Controls.Add(this.rBtnUrgente);
            this.Controls.Add(this.rBtnOrdinario);
            this.Controls.Add(this.btnCalcularPrecioEMM2425);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTelegrama);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Práctica Telegrama EMM2425";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalcularPrecioEMM2425;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTelegrama;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rBtnOrdinario;
        private System.Windows.Forms.RadioButton rBtnUrgente;
    }
}

